namespace NorthwindDatabaseConnectionTasks
{
    using System;
    using System.Data.SqlClient;
    using System.IO;
    using System.Drawing;
    using System.Linq;

    public class NorthwindDatabaseTaskExecutor
    {
        private SqlConnection DbConnection { get; set; }

        public NorthwindDatabaseTaskExecutor() : this(new SqlConnection(
            "Server=.;Database=Northwind;Integrated Security=true"))
        {
        }

        public NorthwindDatabaseTaskExecutor(SqlConnection dbConnection)
        {
            this.DbConnection = dbConnection;
        }

        // Task 1.Write a program that retrieves from the Northwind sample database in MS SQL Server the number of  rows in the Categories table.
        public void PrintNumberOfCategories()
        {
            string commandMsg = "SELECT COUNT(*) FROM Categories";
            this.DbConnection.Open();

            using (this.DbConnection)
            {
                SqlCommand command = new SqlCommand(commandMsg, this.DbConnection);
                int categoriesCount = (int)command.ExecuteScalar();

                Console.WriteLine("Categories count: {0} ", categoriesCount);
            }
        }

        // Task 2.Write a program that retrieves the name and description of all categories in the Northwind DB.
        public void PrintCategoriesInfo()
        {
            var commandMsg = "SELECT CategoryName, Description FROM Categories";
            this.DbConnection.Open();

            using (this.DbConnection)
            {
                SqlCommand command = new SqlCommand(
                    commandMsg, this.DbConnection);

                var reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        string categoryName = (string)reader["CategoryName"];
                        string categoryDescription = (string)reader["Description"];

                        Console.WriteLine("Category: {0} - {1}", categoryName, categoryDescription);
                    }
                }
            }
        }

        // Task 3. Write a program that retrieves from the Northwind database all product categories and the names of the products in each category. 
        public void PrintProductsByCategory()
        {
            var commandMsg = "SELECT CategoryName, ProductName FROM Categories c JOIN Products p ON c.CategoryID = p.CategoryID ORDER BY CategoryName";
            this.DbConnection.Open();

            using (this.DbConnection)
            {
                SqlCommand command = new SqlCommand(
                    commandMsg, this.DbConnection);

                var reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        string categoryName = (string)reader["CategoryName"];
                        string productName = (string)reader["ProductName"];

                        Console.WriteLine("Category: {0} - Product: {1}", categoryName, productName);
                    }
                }
            }
        }

        // Task 4. Write a method that adds a new product in the products table in the Northwind database. Use a parameterized SQL command.
        public void InsertProduct(string productName, int categoryID, decimal unitPrice)
        {
            string commandMsg = @"INSERT INTO Products(ProductName,CategoryID, UnitPrice) 
                                    VALUES
                                        (@ProductName,@CategoryID,@UnitPrice)";
            this.DbConnection.Open();

            using (this.DbConnection)
            {
                SqlCommand command = new SqlCommand(commandMsg, this.DbConnection);
                command.Parameters.AddWithValue("@ProductName", productName);
                command.Parameters.AddWithValue("@CategoryID", categoryID);
                command.Parameters.AddWithValue("@UnitPrice", unitPrice);
                Console.WriteLine(command.ExecuteNonQuery());
            }
        }

        // Task 5.Write a program that retrieves the images for all categories in the Northwind database and stores them as JPG files in the file system.
        public void SaveImagesFromDatabase()
        {
            this.DbConnection.Open();
            using (this.DbConnection)
            {
                SqlCommand cmd = new SqlCommand("SELECT CategoryName, Picture FROM Categories", this.DbConnection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string imageName = (string)reader["CategoryName"];
                        byte[] imageBinary = (byte[])reader["Picture"];

                        // Escape invalid file name chars
                        imageName = String.Join("", imageName.Split(Path.GetInvalidFileNameChars()));
                        // Skip image metadata
                        imageBinary = imageBinary.Skip(78).ToArray();

                        if (imageBinary != null)
                        {
                            using (Stream stream = new MemoryStream(imageBinary))
                            {
                                Bitmap image = new Bitmap(stream);
                                image.Save("../../Images/" + imageName + ".jpg");
                            }
                        }
                    }
                }
            }
        }
        
        // Task 8.Write a program that reads a string from the console and finds all products that contain this string. Ensure you handle correctly characters like ', %, ", \ and _.
        public void PrintProductsByNameSubstring(string nameSubstring)
        {
            var commandMsg = "SELECT ProductName FROM Products WHERE ProductName LIKE '%'+@Substring+'%'";
            this.DbConnection.Open();

            using (this.DbConnection)
            {
                SqlCommand command = new SqlCommand(commandMsg, this.DbConnection);
                // Command parametrization ensures no sql injection is possible.
                command.Parameters.AddWithValue("@Substring", nameSubstring);

                var reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        string productName = (string)reader["ProductName"];

                        Console.WriteLine("Product: {0}", productName);
                    }
                }
            }
        }
    }
}