using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_11_Project_LIMS
{
    public partial class DeleteEmployeeForm : Form
    {
        SqlConnection myConn;
        string connString = @"Data Source=DESKTOP-CN8D1TK;Initial Catalog=DB_LIMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlCommand myCommand;
        SqlDataReader myReader;

        int selectedID;

        public DeleteEmployeeForm()
        {
            InitializeComponent();
        }

        public DeleteEmployeeForm(int selectedID)
        {
            InitializeComponent();

            this.selectedID = selectedID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                myConn.Open();

                myCommand = new SqlCommand("EXECUTE DeleteEmployee @Employee_ID", myConn);

                myCommand.Parameters.Add("@Employee_ID", SqlDbType.Int).Value = selectedID;

                myCommand.ExecuteNonQuery();

                myConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Employee successfully deleted", "Task Successful");
            this.Close();
        }

        private void DeleteEmployeeForm_Load(object sender, EventArgs e)
        {
            try
            {
                myConn = new SqlConnection(connString);

                myConn.Open();

                myCommand = new SqlCommand("EXECUTE SelectSingleEmployee @Employee_ID", myConn);

                myCommand.Parameters.Add("@Employee_ID", SqlDbType.Int).Value = selectedID;

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    lblEmployeeNoDisplay.Text = myReader.GetValue(0).ToString();
                    lblFirstNameDisplay.Text = myReader.GetValue(1).ToString();
                    lblLastNameDisplay.Text = myReader.GetValue(2).ToString();
                    lblIDNoDisplay.Text = myReader.GetValue(3).ToString();
                    lblContactNoDisplay.Text = myReader.GetValue(4).ToString();
                }

                myConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
