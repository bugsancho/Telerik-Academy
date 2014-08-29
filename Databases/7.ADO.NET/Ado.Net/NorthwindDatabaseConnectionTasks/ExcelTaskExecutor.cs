namespace NorthwindDatabaseConnectionTasks
{
    using System;
    using System.Data.OleDb;

    public class ExcelTaskExecutor
    {
        private OleDbConnection DbConnection { get; set; }


        public ExcelTaskExecutor(): this(new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='../../Scores.xls';Extended Properties=Excel 8.0;"))
        {
        }

        public ExcelTaskExecutor(OleDbConnection dbConnection)
        {
            this.DbConnection = dbConnection;
        }

        // Task 6.Write a program that reads your MS Excel file through the OLE DB data provider and displays the name and score row by row.
        public void PrintScores()
        {            
            this.DbConnection.Open();
            using (this.DbConnection)
            {
                var command = new OleDbCommand("SELECT * FROM [Sheet1$]", this.DbConnection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string contestantName = (string)reader["Name"];
                    double score = (double)reader["Score"];

                    Console.WriteLine("{0} has earned {1} points.",contestantName,score);
                }
            }
        }

        // Task 7.Implement appending new rows to the Excel file.
        public void InsertScores(string name, decimal score)
        {
            this.DbConnection.Open();
            using (this.DbConnection)
            {
                var command = new OleDbCommand("INSERT INTO [Sheet1$](Name,Score) VALUES (@Name,@Score)", this.DbConnection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Score", score);
                command.ExecuteNonQuery();
            }
        }
    }
}