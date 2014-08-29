namespace NorthwindDatabaseConnectionTasks
{
    using MySql.Data;
    using MySql.Data.MySqlClient;
    using System;

    public class MySqlTaskExecutor
    {
        private MySqlConnection DbConnection { get; set; }

        public MySqlTaskExecutor() : this(new MySqlConnection("server=localhost;user=root;database=books;port=3306;password=blabla;"))
        {
        }

        public MySqlTaskExecutor(MySqlConnection dbConnection)
        {
            this.DbConnection = dbConnection;
        }

        public void GetBooks()
        {
            this.DbConnection.Open();
            using (this.DbConnection)
            {
                var command = new MySqlCommand("SELECT * FROM Books", this.DbConnection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string bookTitle = (string)reader["title"];
                    string isbn = (string)reader["isbn"];

                    Console.WriteLine("Title: {0} ISBN: {1}.", bookTitle, isbn);
                }
            }
        }

        public void InsertBook(string title, DateTime publishDate, string isbn, int authorId)
        {
            this.DbConnection.Open();
            using (this.DbConnection)
            {
                var command = new MySqlCommand("INSERT INTO Books(Title,PublishDate,isbn,AuthorID) VALUES (@Title,@PublishDate,@Isbn,@AuthorId)", this.DbConnection);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@PublishDate", publishDate);
                command.Parameters.AddWithValue("@Isbn", isbn);
                command.Parameters.AddWithValue("@AuthorId", authorId);
                command.ExecuteNonQuery();
            }
        }
         public void InsertAuthor(string name)
        {
            this.DbConnection.Open();
            using (this.DbConnection)
            {
                var command = new MySqlCommand("INSERT INTO Authors(Name) VALUES (@Name)", this.DbConnection);
                command.Parameters.AddWithValue("@Name", name);
                command.ExecuteNonQuery();
            }
        }
    }
}