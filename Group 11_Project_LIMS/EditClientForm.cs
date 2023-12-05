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
using System.Xml;

namespace Group_11_Project_LIMS
{
    public partial class EditClientForm : Form
    {
        SqlConnection myConn;
        string connString = @"Data Source=DESKTOP-CN8D1TK;Initial Catalog=DB_LIMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlCommand myCommand;
        SqlDataReader myReader;
        SqlDataAdapter myAdapter;

        int selectedID;

        public EditClientForm()
        {
            InitializeComponent();
        }

        public EditClientForm(int selectedID)
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

                    myCommand = new SqlCommand("EXECUTE UpdateClient @Client_ID, @Client_first_name, @Client_last_name, @Client_contact_number, @Client_email_address, @Billing_address_number, @Billing_address_street_name, @Billing_addres_city_ID", myConn);

                    myCommand.Parameters.Add("@Client_ID", SqlDbType.Int).Value = selectedID;
                    myCommand.Parameters.Add("@Client_first_name", SqlDbType.NVarChar, 30).Value = txtFirstName.Text.Trim();
                    myCommand.Parameters.Add("@Client_last_name", SqlDbType.NVarChar, 30).Value = txtLastName.Text.Trim();
                    myCommand.Parameters.Add("@Client_contact_number", SqlDbType.NVarChar, 20).Value = txtContactNo.Text.Trim();
                    myCommand.Parameters.Add("@Client_email_address", SqlDbType.NVarChar, 30).Value = txtEmail.Text.Trim();
                    myCommand.Parameters.Add("@Billing_address_number", SqlDbType.NVarChar, 10).Value = txtAddressNo.Text.Trim();
                    myCommand.Parameters.Add("@Billing_address_street_name", SqlDbType.NVarChar, 50).Value = txtAddressStreet.Text.Trim();
                    myCommand.Parameters.Add("@Billing_addres_city_ID", SqlDbType.NVarChar, 30).Value = txtAddressCity.Text.Trim();

                    myCommand.ExecuteNonQuery();

                    myConn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Client successfully updated", "Task Successful");
                this.Close();
            }
        }

        private void EditClientForm_Load(object sender, EventArgs e)
        {
            try
            {
                myConn = new SqlConnection(connString);

                myConn.Open();
                
                myCommand = new SqlCommand("EXECUTE SelectSingleClient @Client_ID", myConn);
                
                myCommand.Parameters.Add("@Client_ID", SqlDbType.Int).Value = selectedID;

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    lblClientNoDisplay.Text = myReader.GetValue(0).ToString();
                    txtFirstName.Text = myReader.GetValue(1).ToString();
                    txtLastName.Text = myReader.GetValue(2).ToString();
                    txtContactNo.Text = myReader.GetValue(3).ToString();
                    txtEmail.Text = myReader.GetValue(4).ToString();
                    txtAddressNo.Text = myReader.GetValue(5).ToString();
                    txtAddressStreet.Text = myReader.GetValue(6).ToString();
                    txtAddressCity.Text = myReader.GetValue(7).ToString();
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
                    if (string.IsNullOrEmpty(txtContactNo.Text) == false)
                    {
                        if (string.IsNullOrEmpty(txtEmail.Text) == false && txtEmail.Text.Contains('@'))
                        {
                            if (string.IsNullOrEmpty(txtAddressNo.Text) == false)
                            {
                                if (string.IsNullOrEmpty(txtAddressStreet.Text) == false)
                                {
                                    if (string.IsNullOrEmpty(txtAddressCity.Text) == false)
                                    {
                                        if (int.TryParse(txtContactNo.Text, out int test))
                                        {
                                            inputValid = true;
                                        }
                                        else MessageBox.Show("The contact number should only contain digits");
                                    }
                                    else MessageBox.Show("Please enter City");
                                }
                                else MessageBox.Show("Please enter street");
                            }
                            else MessageBox.Show("Please enter an address number");
                        }
                        else MessageBox.Show("Please enter a valid Email");
                    }
                    else MessageBox.Show("Please enter contact number");
                }
                else MessageBox.Show("Please enter Last name");
            }
            else MessageBox.Show("Please enter First name");

            return inputValid;
        }

        private void tsHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To edit the existing client, enter all the required information of the client and click the \"Apply Changes\" button." +
                "          \nOtherwise, to go back without making any changes, click on the \"Cancel\" button", "Help");
        }
    }
}
