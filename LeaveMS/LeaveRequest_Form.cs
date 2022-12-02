using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeaveMS
{
    public partial class LeaveRequest_Form : Form
    {
        Functions Connection;
        public static int EmployeeId;

        public LeaveRequest_Form()
        {
            InitializeComponent();
            Connection = new Functions();
            GetCategories();
        }

        private void GetCategories()
        {
            string Query = "Select * from dbo.CategoryTable";
            comboBoxCategories.DisplayMember = Connection.GetData(Query).Columns["CategoryName"].ToString();
            comboBoxCategories.ValueMember = Connection.GetData(Query).Columns["CategoryId"].ToString();
            comboBoxCategories.DataSource = Connection.GetData(Query);
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void EmployeeRequesting(string labelEmployeeName)
        {
            EmployeeId = Convert.ToInt32(labelEmployeeName);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (comboBoxCategories.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information!", "Warning");
            }
            else
            {
                try
                {
                    int CategoryId = comboBoxCategories.SelectedIndex;
                    string DateStart = dateStart.Value.Date.ToString();
                    string DateEnd = dateEnd.Value.Date.ToString();
                    string Status = "Pending";
                    Leaves_Form leaves = new Leaves_Form();
                    leaves.AddRequestedLeave(EmployeeId, CategoryId, DateStart, DateEnd, Status);
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
                this.Close();
            }
        }
    }
}
