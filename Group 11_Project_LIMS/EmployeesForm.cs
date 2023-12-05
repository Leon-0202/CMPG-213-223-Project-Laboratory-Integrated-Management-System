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
    public partial class EmployeesForm : Form
    {
        SqlConnection myConn;
        string connString = @"Data Source=DESKTOP-CN8D1TK;Initial Catalog=DB_LIMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlCommand myCommand;
        SqlDataReader myReader;

        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.ShowDialog();
            updateList();
            txtSearch.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedID = acquireSelectedID();

            if (selectedID != 0)
            {
                EditEmployeeForm editEmployeeForm = new EditEmployeeForm(selectedID);
                editEmployeeForm.ShowDialog();
                updateList();
                txtSearch.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedID = acquireSelectedID();

            if (selectedID != 0)
            {
                DeleteEmployeeForm deleteEmployeeForm = new DeleteEmployeeForm(selectedID);
                deleteEmployeeForm.ShowDialog();
                updateList();
                txtSearch.Clear();
            }
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            updateList();
        }

        private void updateList()
        {
            try
            {
                myConn = new SqlConnection(connString);

                myConn.Open();
                
                myCommand = new SqlCommand("EXECUTE SelectAllEmployees", myConn);
                
                myReader = myCommand.ExecuteReader();

                lstEmployees.Items.Clear();
                string heading = String.Format("{0, -12} {1, -23} {2, -23} {3, -18} {4, -23}", "Employee ID", "Employee Name", "Employee Surname", "ID Number", "Contact Number");
                lstEmployees.Items.Add(heading);
                lstEmployees.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                while (myReader.Read())
                {
                    string nextEntry = String.Format("{0, -12} {1, -23} {2, -23} {3, -18} {4, -23}", myReader.GetValue(0), myReader.GetValue(1), myReader.GetValue(2), myReader.GetValue(3), myReader.GetValue(4));
                    lstEmployees.Items.Add(nextEntry);
                }

                myConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                myConn = new SqlConnection(connString);

                myConn.Open();

                myCommand = new SqlCommand("EXECUTE SelectSearchEmployee @Employee_search_value", myConn);

                myCommand.Parameters.Add("@Employee_search_value", SqlDbType.NVarChar, 30).Value = txtSearch.Text.Trim();

                myReader = myCommand.ExecuteReader();

                lstEmployees.Items.Clear();
                string heading = String.Format("{0, -12} {1, -23} {2, -23} {3, -18} {4, -23}", "Employee ID", "Employee Name", "Employee Surname", "ID Number", "Contact Number");
                lstEmployees.Items.Add(heading);
                lstEmployees.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                while (myReader.Read())
                {
                    string nextEntry = String.Format("{0, -12} {1, -23} {2, -23} {3, -18} {4, -23}", myReader.GetValue(0), myReader.GetValue(1), myReader.GetValue(2), myReader.GetValue(3), myReader.GetValue(4));
                    lstEmployees.Items.Add(nextEntry);
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

            if (lstEmployees.SelectedIndex != -1)
            {
                String selectedItem = lstEmployees.SelectedItem.ToString();
                String[] splitValues = selectedItem.Split(' ');
                selectedID = int.Parse(splitValues[0]);
            }
            else
            {
                MessageBox.Show("Please select an employee from the list");
                return selectedID;
            }

            return selectedID;
        }

        private void tsHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All the existing employees are displayed in the list.  To search for a specific employee, enter either the employee name, surname or both" +
                         " into the search field." +
                         "\nTo add a new employee, click on the \"Add Employee\" button." +
                         "\nTo edit the details of an existing employee, select the employee from the list, and click on the \"Edit Employee\" button." +
                         "\nTo delete an existing employee, select the employee from the list, and click on the \"Delete Employee\" button." +
                         "\nOtherwise, to go back, click on the \"Back\" button", "Help");
        }
    }
}
