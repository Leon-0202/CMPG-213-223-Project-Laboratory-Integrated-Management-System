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
    public partial class AddEmployeeForm : Form
    {
        SqlConnection myConn;
        string connString = @"Data Source=DESKTOP-CN8D1TK;Initial Catalog=DB_LIMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlCommand myCommand;

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (inputIsValid())
            {
                try
                {
                    myConn = new SqlConnection(connString);

                    myConn.Open();

                    myCommand = new SqlCommand("EXECUTE AddEmployee @Employee_first_name, @Employee_last_name, @Employee_ID_number, @Employee_contact_number", myConn);

                    myCommand.Parameters.Add("@Employee_first_name", SqlDbType.NVarChar, 30).Value = txtFirstName.Text.Trim();
                    myCommand.Parameters.Add("@Employee_last_name", SqlDbType.NVarChar, 30).Value = txtLastName.Text.Trim();
                    myCommand.Parameters.Add("@Employee_ID_number", SqlDbType.Char, 13).Value = txtIDNumber.Text.Trim();
                    myCommand.Parameters.Add("@Employee_contact_number", SqlDbType.NVarChar, 20).Value = txtContactNumber.Text.Trim();

                    myCommand.ExecuteNonQuery();

                    myConn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Employee successfully added", "Task Successful");
                this.Close();
            }
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private bool inputIsValid()
        {
            bool inputValid = false;

            if (string.IsNullOrEmpty(txtFirstName.Text) == false)
            {
                if (string.IsNullOrEmpty(txtLastName.Text) == false)
                {
                    if (string.IsNullOrEmpty(txtIDNumber.Text) == false && txtIDNumber.Text.Length == 13)
                    {
                        if (string.IsNullOrEmpty(txtContactNumber.Text) == false)
                        {
                            if (int.TryParse(txtContactNumber.Text, out int test))
                            {
                                if (long.TryParse(txtIDNumber.Text, out long test2))
                                {
                                    inputValid = true;
                                }
                                else MessageBox.Show("The ID number should only contain digits");
                            }
                            else MessageBox.Show("The contact number should only contain digits");
                        }
                        else MessageBox.Show("Please enter valid contact number");
                    }
                    else MessageBox.Show("Please enter valid ID number");
                }
                else MessageBox.Show("Please enter valid Last name");
            }
            else MessageBox.Show("Please enter valid First name");

            return inputValid;
        }

        private void tsHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To add a new employee, enter all the required information of the new employee and click the \"Add\" button." +
                "          \nOtherwise, to go back without making any changes, click on the \"Cancel\" button", "Help");
        }
    }
}
