namespace NorthwindDatabaseConnectionTasks
{
    using System;

    class Program
    {
        static void Main()
        {
            NorthwindDatabaseTaskExecutor nortwindTaskExecutor = new NorthwindDatabaseTaskExecutor();
            ExcelTaskExecutor excelTastExecutor = new ExcelTaskExecutor();
            MySqlTaskExecutor mysqlTaskExecutor = new MySqlTaskExecutor();
            SqliteTaskExecutor sqliteTaskExecutor = new SqliteTaskExecutor();

            sqliteTaskExecutor.GetBooks();

           // mysqlTaskExecutor.InsertBook("Booky", DateTime.Now, "0-4323-233-222-1", 2);
          //  mysqlTaskExecutor.InsertAuthor("Author");
            //mysqlTaskExecutor.GetBooks();
            //nortwindTaskExecutor.InsertProduct("t%33'4x", 4, 2.55m);
            //nortwindTaskExecutor.SaveImagesFromDatabase();
            // nortwindTaskExecutor.PrintProductsByNameSubstring("lager"); 
            //excelTastExecutor.InsertScores("Pesho", 25);
        }
    }
}