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
    public partial class EditEmployeeForm : Form
    {
        SqlConnection myConn;
        string connString = @"Data Source=DESKTOP-CN8D1TK;Initial Catalog=DB_LIMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlCommand myCommand;
        SqlDataReader myReader;
        SqlDataAdapter myAdapter;

        int selectedID;

        public EditEmployeeForm()
        {
            InitializeComponent();
        }

        public EditEmployeeForm(int selectedID)
        {
            InitializeComponent();

            this.selectedID = selectedID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (inputIsValid())
            {
                try
                {
                    myConn.Open();

                    myCommand = new SqlCommand("EXECUTE UpdateEmployee @Employee_ID, @Employee_first_name, @Employee_last_name, @Employee_ID_number, @Employee_contact_number", myConn);

                    myCommand.Parameters.Add("@Employee_ID", SqlDbType.Int).Value = selectedID;
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

                MessageBox.Show("Employee successfully updated", "Task Successful");
                this.Close();
            }
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
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
                    txtFirstName.Text = myReader.GetValue(1).ToString();
                    txtLastName.Text = myReader.GetValue(2).ToString();
                    txtIDNumber.Text = myReader.GetValue(3).ToString();
                    txtContactNumber.Text = myReader.GetValue(4).ToString();
                }

                myConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            MessageBox.Show("To edit the existing employee, enter all the required information of the employee and click the \"Apply Changes\" button." +
                "          \nOtherwise, to go back without making any changes, click on the \"Cancel\" button", "Help");
        }
    }
}
