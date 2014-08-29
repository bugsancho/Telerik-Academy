namespace Northwind.Data
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using Northwind.Models;
    using System;
    using System.Linq;
    using System.Data.SqlClient;
    using System.Data.Entity.Infrastructure;

    public static class NorthwindDataPersister
    {
        private static NorthwindEntities DbContext = new NorthwindEntities();

        public static void AddCustomer(string customerId, string companyName, string contactName, string address,
            string city = null, string country = null, string phone = null, string region = null, string postalCode = null)
        {
            var customer = new Customer
            {
                CustomerID = customerId,
                CompanyName = companyName,
                ContactName = contactName,
                Address = address,
            };

            NorthwindDataPersister.AddCustomer(customer);
        }

        public static void AddCustomer(Customer customer)
        {
            DbContext.Customers.Add(customer);
            DbContext.SaveChanges();
        }

        public static void UpdateCustomer(Customer oldCustomerInfo, Customer newCustomerInfo)
        {
            if (oldCustomerInfo.CustomerID != newCustomerInfo.CustomerID)
            {
                throw new ArgumentException("Cannot change customerId property!");
            }

            NorthwindDataPersister.RemoveCustomer(oldCustomerInfo);
            DbContext.Customers.Add(newCustomerInfo);

            DbContext.SaveChanges();
        }

        public static void RemoveCustomer(Customer customer)
        {
            if (!DbContext.Customers.Contains(customer))
            {
                throw new ArgumentException("Customer could not be found in database!");
            }

            DbContext.Customers.Remove(customer);  
            DbContext.SaveChanges();
        }

        public static ICollection<Customer> GetCustomersByShippmentCountryAndYear(string country, DateTime yearOfOrder)
        {
            var customers = DbContext.Customers.Where(x => x.Orders.Any(o => o.ShipCountry == country &&
                                                                             o.OrderDate.Value.Year == yearOfOrder.Year));
            return customers.ToList();
        }

        public static ICollection<Customer> NativeQueryGetCustomersCountryAndYearOfOrder(string country, int yearOfOrder)
        {
            var countryParameter = new SqlParameter("@Country",country);
            var yearParameter = new SqlParameter("@YearOfOrder",yearOfOrder);
            var queryParameters = new[] { countryParameter, yearParameter };

            var customers = DbContext.Customers.SqlQuery(@"SELECT * FROM Customers c
	                                                            JOIN Orders o
	                                                            	ON o.CustomerID = c.CustomerID
	                                                            WHERE
	                                                            	o.ShipCountry = @Country
	                                                            	AND DATEPART(YEAR, o.OrderDate) = @YearOfOrder", queryParameters);
            return customers.ToList();
        }

        public static ICollection<Order> GetOrdersByRegionAndPeriod(string region, DateTime startPeriod, DateTime endPeriod)
        {
            var orders = DbContext.Orders.Where(o => o.ShipRegion == region &&
                                                     o.OrderDate >= startPeriod &&
                                                     o.OrderDate <= endPeriod);

            return orders.ToList();
        }

        public static void CreateCloneDB()
        {
            string importDatabaseSchemaScript = (DbContext as IObjectContextAdapter).ObjectContext.CreateDatabaseScript();
            string createDatabaseScript = "CREATE DATABASE NorthwindTwin";
            SqlConnection createDbConnection = new SqlConnection(@"Server=.; 
                                                                    Database=master; 
                                                                    Integrated Security=true");
            createDbConnection.Open();
            using (createDbConnection)
            {
                SqlCommand createDbCommand = new SqlCommand(createDatabaseScript, createDbConnection);
                createDbCommand.ExecuteNonQuery();
            }

            //Console.WriteLine(importDatabaseSchemaScript);
            SqlConnection importDbSchemaConnection = new SqlConnection(@"Server=.; 
                                                                    Database=NorthwindTwin; 
                                                                    Integrated Security=true"); 
            importDbSchemaConnection.Open();
            using (importDbSchemaConnection)
            {
                SqlCommand importDbSchemaCommand = new SqlCommand(importDatabaseSchemaScript, importDbSchemaConnection);
                importDbSchemaCommand.ExecuteNonQuery();
            }
        }

        public static void PerformConcurrentChanges()
        {
            var additionalContext = new NorthwindEntities();

           // DbContext.Customers.First(x => x.CustomerID == "ABCDE").ContactName = "John";
            additionalContext.Customers.First(x => x.CustomerID == "ABCDE").ContactName = "Maria";
            
            additionalContext.SaveChanges();
            DbContext.SaveChanges();

            DbContext.Customers.First(x => x.CustomerID == "ABCDE").ContactName = "Peter";
            additionalContext.Customers.First(x => x.CustomerID == "ABCDE");
        }
    }
}