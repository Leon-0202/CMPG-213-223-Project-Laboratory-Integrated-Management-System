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
    public partial class DeleteClientForm : Form
    {
        SqlConnection myConn;
        string connString = @"Data Source=DESKTOP-CN8D1TK;Initial Catalog=DB_LIMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlCommand myCommand;
        SqlDataReader myReader;

        int selectedID;

        public DeleteClientForm()
        {
            InitializeComponent();
        }

        public DeleteClientForm(int selectedID)
        {
            InitializeComponent();

            this.selectedID = selectedID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                myConn.Open();

                myCommand = new SqlCommand("EXECUTE DeleteClient @Client_ID", myConn);

                myCommand.Parameters.Add("@Client_ID", SqlDbType.Int).Value = selectedID;

                myCommand.ExecuteNonQuery();

                myConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Client successfully deleted", "Task Successful");
            this.Close();
        }

        private void DeleteClientForm_Load(object sender, EventArgs e)
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
                    lblFirstNameDisplay.Text = myReader.GetValue(1).ToString();
                    lblLastNameDisplay.Text = myReader.GetValue(2).ToString();
                    lblContactNoDisplay.Text = myReader.GetValue(3).ToString();
                    lblEmailDisplay.Text = myReader.GetValue(4).ToString();
                    lblAddressNoDisplay.Text = myReader.GetValue(5).ToString();
                    lblAddressStreetDisplay.Text = myReader.GetValue(6).ToString();
                    lblAddressCityDisplay.Text = myReader.GetValue(7).ToString();
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
