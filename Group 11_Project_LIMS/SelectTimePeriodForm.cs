using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_11_Project_LIMS
{
    public partial class SelectTimePeriodForm : Form
    {
        public SelectTimePeriodForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (inputIsValid())
            {
                if (DateTime.Parse(cmbStartDate.SelectedItem.ToString()) < DateTime.Parse(cmbStartEnd.SelectedItem.ToString()))
                {
                    WorkRequestsPerTime workRequestsPerTimeForm = new WorkRequestsPerTime(DateTime.Parse(cmbStartDate.SelectedItem.ToString()), DateTime.Parse(cmbStartEnd.SelectedItem.ToString()));
                    this.Hide();
                    workRequestsPerTimeForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("The end date cannot be before the start date, please select again", "Input Error");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool inputIsValid()
        {
            bool inputValid = false;

            if (cmbStartDate.SelectedIndex != -1)
            {
                if (cmbStartEnd.SelectedIndex != -1)
                {
                    inputValid = true;
                }
                else
                {
                    MessageBox.Show("Please select an end date from the list", "Input Error");
                    cmbStartEnd.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please select a start date from the list", "Input Error");
                cmbStartDate.Focus();
            }

            return inputValid;
        }
    }
}
