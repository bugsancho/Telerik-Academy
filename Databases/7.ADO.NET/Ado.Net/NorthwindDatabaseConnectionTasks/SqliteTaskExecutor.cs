namespace NorthwindDatabaseConnectionTasks
{
    using System;
    using System.Data.SQLite;

    public class SqliteTaskExecutor
    {
        private SQLiteConnection DbConnection { get; set; }

        public SqliteTaskExecutor(): this(new SQLiteConnection("Data Source=../../BooksDatabase/Books.sqlite;Version=3;"))
        {
        }

        public SqliteTaskExecutor(SQLiteConnection dbConnection)
        {
            this.DbConnection = dbConnection;
        }
        
        public void GetBooks()
        {
            this.DbConnection.Open();
            using (this.DbConnection)
            {
                var command = new SQLiteCommand("SELECT * FROM Books", this.DbConnection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string bookTitle = (string)reader["title"];
                    string isbn = (string)reader["isbn"];

                    Console.WriteLine("Title: {0} ISBN: {1}.", bookTitle, isbn);
                }
            }
        }
    }
}