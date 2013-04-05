using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Coursework3
{
    public class DBConnector
    {
        //Properties
        //connection object
        private System.Data.SqlClient.SqlConnection Conn;

        //dataset object
        private StudentsDataSet Ds1;
        //dataadapter object
        private System.Data.SqlClient.SqlDataAdapter Da;

        //constructors
        public DBConnector()
        {
            //call initialisation
            init();
        }

        //Methods
        //initialisation method
        public void init()
        {
            //create the memory space for the connection object
            Conn = new System.Data.SqlClient.SqlConnection();
            //create the memory space for the dataset
            Ds1 = new StudentsDataSet();

            //set the connection string to the location of our database file
            Conn.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Students.mdf;Integrated Security=True;User Instance=True";

            //open the conenction
            Conn.Open();

            //create a query to get all the records from the table
            string query = "SELECT * from Studentstbl";
            //create the data adapter for the database
            Da = new System.Data.SqlClient.SqlDataAdapter(query, Conn);
            //use it to fill the dataset as the first parameter the second is a name for the table we use later on
            Da.Fill(Ds1, "Students");


            //close the connection
            Conn.Close();
            System.Windows.Forms.MessageBox.Show("Database connection Open", "Success");
        }

        public StudentsDataSet DBDataSet
        {
            get
            {
                return Ds1;
            }
        }

        //update method

        public void UpdateDB(DataSet ds, string table)
        {
            //create a command builder to reconnect to the database
            System.Data.SqlClient.SqlCommandBuilder cb;
            //set the comamnd builder to be our existing dataadapter
            cb = new System.Data.SqlClient.SqlCommandBuilder(Da);
            Da.Update(ds, table);
        }



    }
}
   
