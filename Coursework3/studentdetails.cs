using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coursework3
{
    public partial class studentdetails : Form
    {
        DataSet StudentDataSet;
        //set variables for limit
        int Limit = 0;
        int current = 0;

        public studentdetails()
        {
            InitializeComponent();
        }

        public studentdetails(DataSet ds)
            : this()
        {
            StudentDataSet = ds;
            //set the limit of records we can navigate
            Limit = StudentDataSet.Tables["Students"].Rows.Count;

            NavigateRecords();
        }
        

       public studentdetails(DBConnector db)
            : this()
        {
           
        }

        public studentdetails(DBConnector db, int sRow)
            : this(db)
        {
            current = sRow;
            NavigateRecords();
            //turn on editing
            plEdit.Visible = true;
            //set our local dataset object to point to the passed in one
            DBConnection = db;
            StudentDataSet = db.DBDataSet;
            Limit = StudentDataSet.Tables["Students"].Rows.Count;
            NavigateRecords();
        }


        //navigate records function to move through the records
        public void NavigateRecords()
        {   //create a datarow object and set it to be the first row in the dataset
            DataRow dRow = StudentDataSet.Tables["Students"].Rows[current];
            //set the form text to add the current record number
            this.Text += " for record " + dRow.ItemArray.GetValue(0).ToString();
            //fill the text boxes with the database values
            txtFirstName.Text = dRow.ItemArray.GetValue(1).ToString();
            txtMiddleName.Text = dRow.ItemArray.GetValue(2).ToString();
            txtLastName.Text = dRow.ItemArray.GetValue(3).ToString();
            txtDOB.Text = dRow.ItemArray.GetValue(4).ToString();
            txtgender.Text = dRow.ItemArray.GetValue(5).ToString();

        }

        //update the label for the dtatbase
        private void UpdateCount()
        {
            txtCount.Text = (current + 1).ToString() + " of " + Limit.ToString();

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (current != Limit - 1)
            {
                current++;
                NavigateRecords();
            }
            else
            {
                MessageBox.Show("Last Record", "Information", 0, MessageBoxIcon.Information);
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (current > 0)
            {
                current--;
                NavigateRecords();
            }
            else
            {
                MessageBox.Show("First Record", "Information", 0, MessageBoxIcon.Information);
            }
        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            if (current != Limit - 1)
            {
                current = Limit - 1;
                NavigateRecords();
            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            if (current != 0)
            {
                current = 0;
                NavigateRecords();
            }
        }

        public DBConnector DBConnection { get; set; }

        private void btn_save_Click(object sender, EventArgs e)
        {
            {
                //create a new datarow 
                DataRow dRow = StudentDataSet.Tables["Students"].NewRow();

                //set the data to be the values from the text boxes
                dRow[1] = txtFirstName.Text;
                dRow[2] = txtMiddleName.Text;
                dRow[3] = txtLastName.Text;
                dRow[4] = txtDOB.Text;
                dRow[5] = txtgender.Text;


                //add the row to our dataset
                StudentDataSet.Tables["Studentstbl"].Rows.Add(dRow);

                //increase the limit as we have a new record
                Limit++;
                //move to the newly entered Student
                current = Limit - 1;
                DBConnection.UpdateDB(StudentDataSet, "Students");
                MessageBox.Show("Record Saved", "Information", 0, MessageBoxIcon.Information);
                NavigateRecords();
            }



        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            {   //get the current row
                DataRow dRow = StudentDataSet.Tables["Students"].Rows[current];
                //set the dataset values to those in the textboxes
                dRow[1] = txtFirstName.Text;
                dRow[2] = txtMiddleName.Text;
                dRow[3] = txtLastName.Text;
                dRow[4] = txtDOB.Text;
                dRow[5] = txtgender.Text;

                //call the update method in our DB connector class
                DBConnection.UpdateDB(StudentDataSet, "Studentstbl");
                //display a message box
                MessageBox.Show("Record updated", "Information", 0, MessageBoxIcon.Information);

                NavigateRecords();
            }

        }





            
    }
}
