namespace Northwind.Console
{
    using System;
    using Northwind.Models;
    using Northwind.Data;

    class NorthwindConsoleClient
    {
        static void Main()
        {
            //NorthwindDataPersister.AddCustomer("ABdDE", "Company", "Peter", "Address");
            //var customers = NorthwindDataPersister.NativeQueryGetCustomersCountryAndYearOfOrder("Brazil", 1996);
            //foreach (var customer in customers)
            //{
            //    Console.WriteLine(customer.CompanyName);
            //}
            //NorthwindDataPersister.CreateCloneDB();
            NorthwindDataPersister.PerformConcurrentChanges();
        }
    }
}