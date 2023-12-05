using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Group_11_Project_LIMS
{
    public partial class ClientsForm : Form
    {
        SqlConnection myConn;
        string connString = @"Data Source=DESKTOP-CN8D1TK;Initial Catalog=DB_LIMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlCommand myCommand;
        SqlDataReader myReader;

        public ClientsForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();
            addClientForm.ShowDialog();
            updateList();
            txtSearch.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedID = acquireSelectedID();

            if (selectedID != 0)
            {
                EditClientForm editClientForm = new EditClientForm(selectedID);
                editClientForm.ShowDialog();
                updateList();
                txtSearch.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedID = acquireSelectedID();

            if (selectedID != 0)
            {
                DeleteClientForm deleteClientForm = new DeleteClientForm(selectedID);
                deleteClientForm.ShowDialog();
                updateList();
                txtSearch.Clear();
            }
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            updateList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                myConn = new SqlConnection(connString);

                myConn.Open();

                myCommand = new SqlCommand("EXECUTE SelectSearchClient @Client_search_value", myConn);

                myCommand.Parameters.Add("@Client_search_value", SqlDbType.NVarChar, 30).Value = txtSearch.Text.Trim();

                myReader = myCommand.ExecuteReader();

                lstClients.Items.Clear();
                string heading = String.Format("{0, -10} {1, -23} {2, -23} {3, -18} {4, -23} {5, -5}", "Client ID", "Client Name", "Client Surname", "Contact Number", "Email", "Address");
                lstClients.Items.Add(heading);
                lstClients.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                while (myReader.Read())
                {
                    string nextEntry = String.Format("{0, -10} {1, -23} {2, -23} {3, -18} {4, -23} {5, -5} {6, -25} {7, -25}", myReader.GetValue(0), myReader.GetValue(1), myReader.GetValue(2), myReader.GetValue(3), myReader.GetValue(4), myReader.GetValue(5), myReader.GetValue(6), myReader.GetValue(7));
                    lstClients.Items.Add(nextEntry);
                }

                myConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int acquireSelectedID()
        {
            int selectedID = 0;

            if (lstClients.SelectedIndex != -1)
            {
                String selectedItem = lstClients.SelectedItem.ToString();
                String[] splitValues = selectedItem.Split(' ');
                selectedID = int.Parse(splitValues[0]);
            }
            else
            {
                MessageBox.Show("Please select a client from the list");
                return selectedID;
            }

            return selectedID;
        }

        private void updateList()
        {
            try
            {
                myConn = new SqlConnection(connString);

                myConn.Open();

                myCommand = new SqlCommand("EXECUTE SelectAllClients", myConn);

                myReader = myCommand.ExecuteReader();

                lstClients.Items.Clear();
                string heading = String.Format("{0, -10} {1, -23} {2, -23} {3, -18} {4, -23} {5, -5}", "Client ID", "Client Name", "Client Surname", "Contact Number", "Email", "Address");
                lstClients.Items.Add(heading);
                lstClients.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                while (myReader.Read())
                {
                    string nextEntry = String.Format("{0, -10} {1, -23} {2, -23} {3, -18} {4, -23} {5, -5} {6, -25} {7, -25}", myReader.GetValue(0), myReader.GetValue(1), myReader.GetValue(2), myReader.GetValue(3), myReader.GetValue(4), myReader.GetValue(5), myReader.GetValue(6), myReader.GetValue(7));
                    lstClients.Items.Add(nextEntry);
                }

                myConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All the existing clients are displayed in the list.  To search for a specific client, enter either the client name, surname or both" +
                         " into the search field." +
                         "\nTo add a new client, click on the \"Add New Client\" button." +
                         "\nTo edit the details of an existing client, select the client from the list, and click on the \"Edit Client\" button." +
                         "\nTo delete an existing client, select the client from the list, and click on the \"Delete Client\" button." +
                         "\nOtherwise, to go back, click on the \"Back\" button", "Help");
        }
    }
}
