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
    public partial class Leaves_Form : Form
    {
        Functions Connection;
        int KeyCount = 0;
        int Key = 0;

        public Leaves_Form()
        {
            InitializeComponent();
            Connection = new Functions();
            GetEmployees();
            GetCategories();
            SetToDefault();
            
        }

        private void ShowLeaves()
        {
            string Query = "select * from dbo.LeaveTable";
            listLeaves.DataSource = Connection.GetData(Query);
        }

        private void FilterLeaves()
        {
            string Query = $"select * from dbo.LeaveTable where Status = '{comboBoxLeaves.SelectedItem.ToString()}'";
            listLeaves.DataSource = Connection.GetData(Query);
        }

        private void GetEmployees()
        {
            string Query = "select * from dbo.EmployeeTable";
            comboBoxEmployees.DataSource = Connection.GetData(Query);
            comboBoxEmployees.DisplayMember = Connection.GetData(Query).Columns["EmployeeName"].ToString();
            comboBoxEmployees.ValueMember = Connection.GetData(Query).Columns["EmployeeId"].ToString();

        }

        private void GetCategories()
        {
            string Query = "select * from dbo.CategoryTable";
            comboBoxCategories.DisplayMember = Connection.GetData(Query).Columns["CategoryName"].ToString();
            comboBoxCategories.ValueMember = Connection.GetData(Query).Columns["CategoryId"].ToString();
            comboBoxCategories.DataSource = Connection.GetData(Query);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployees.SelectedIndex == -1 || comboBoxCategories.SelectedIndex == -1 || comboBoxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information!", "Warning");
            }
            else
            {
                try
                {
                    int EmployeeId = Convert.ToInt32(comboBoxEmployees.SelectedValue.ToString());
                    int CategoryId = Convert.ToInt32(comboBoxCategories.SelectedValue.ToString());
                    string DateStart = dateStart.Value.Date.ToString();
                    string DateEnd = dateEnd.Value.Date.ToString();
                    string DateApplied = DateTime.Today.Date.ToString();
                    string Status = comboBoxStatus.SelectedItem.ToString(); 


                    KeyCount++;

                    for (int i = 0; i < listLeaves.RowCount - 1; i++)
                    {
                        if (listLeaves.Rows[0].Cells[0].Value == null)
                        {
                            break;
                        }
                        else if (listLeaves.Rows[i].Cells[0].Value.ToString() == KeyCount.ToString())
                        {
                            KeyCount++;
                        }
                    }

                    string Query = $"insert into dbo.LeaveTable values ({KeyCount}, {EmployeeId}, {CategoryId}, '{DateStart}', '{DateEnd}', '{DateApplied}', '{Status}')";
                    Connection.SetData(Query);
                    MessageBox.Show("Leave Saved Successfully!", "Info");
                    SetToDefault();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void AddRequestedLeave(int EmployeeId, int CategoryId, string DateStart, string DateEnd, string Status)
        {

            comboBoxEmployees.SelectedIndex = EmployeeId;
            comboBoxCategories.SelectedIndex = CategoryId;
            dateStart.Text = DateStart;
            dateEnd.Text = DateEnd;
            comboBoxStatus.Text = Status;
            if (comboBoxStatus.Text == "Pending")
            {
                comboBoxStatus.SelectedIndex = 0;
            }
            if (comboBoxStatus.Text == "Approved")
            {
                comboBoxStatus.SelectedIndex = 1;
            }
            if (comboBoxStatus.Text == "Rejected")
            {
                comboBoxStatus.SelectedIndex = 2;
            }

            
            if (comboBoxEmployees.SelectedIndex == -1 || comboBoxCategories.SelectedIndex == -1 || comboBoxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information!", "Warning");
            }
            else
            {
                try
                {
                    string DateApplied = DateTime.Today.Date.ToString();
                    
                    KeyCount++;

                    for (int i = 0; i < listLeaves.RowCount - 1; i++)
                    {
                        if (listLeaves.Rows[0].Cells[0].Value == null)
                        {
                            break;
                        }
                        else if (listLeaves.Rows[i].Cells[0].Value.ToString() == KeyCount.ToString())
                        {
                            KeyCount++;
                        }
                    }

                    string Query = $"insert into dbo.LeaveTable values ({KeyCount}, {comboBoxEmployees.SelectedIndex}, {comboBoxCategories.SelectedIndex}, '{DateStart}', '{DateEnd}', '{DateApplied}', '{Status}')";
                    Connection.SetData(Query);
                    MessageBox.Show("Leave Saved Successfully!", "Info");
                    SetToDefault();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void SetToDefault()
        {
            Key = 0;
            ShowLeaves();
            comboBoxEmployees.SelectedIndex = -1;
            comboBoxCategories.SelectedIndex = -1;
            comboBoxStatus.SelectedIndex = -1;
        }

        private void listLeaves_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxEmployees.SelectedIndex = Convert.ToInt32(listLeaves.SelectedRows[0].Cells[1].Value.ToString()) - 1;
            comboBoxCategories.SelectedIndex = Convert.ToInt32(listLeaves.SelectedRows[0].Cells[2].Value.ToString()) - 1;
            dateStart.Text = listLeaves.SelectedRows[0].Cells[3].Value.ToString();
            dateEnd.Text = listLeaves.SelectedRows[0].Cells[4].Value.ToString();
            comboBoxStatus.Text = listLeaves.SelectedRows[0].Cells[6].Value.ToString();
            if(comboBoxStatus.Text == "Pending")
            {
                comboBoxStatus.SelectedIndex = 0;
            }
            if(comboBoxStatus.Text == "Approved")
            {
                comboBoxStatus.SelectedIndex = 1;
            }
            if(comboBoxStatus.Text == "Rejected")
            {
                comboBoxStatus.SelectedIndex = 2;
            }

            if (comboBoxEmployees.SelectedIndex == -1)
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(listLeaves.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployees.SelectedIndex == -1 || comboBoxCategories.SelectedIndex == -1 || comboBoxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information!", "Warning");
            }
            else
            {
                try
                {
                    int EmployeeId = Convert.ToInt32(comboBoxEmployees.SelectedValue.ToString());
                    //string Employee = Connection.GetData($"select EmployeeName from dbo.EmployeeTable where EmployeeId = {EmployeeId}").ToString();
                    int CategoryId = Convert.ToInt32(comboBoxCategories.SelectedValue.ToString());
                    //string Category = Connection.GetData($"select CategoryName from dbo.CategoryTable where CategoryId = {CategoryId}").ToString();
                    string DateStart = dateStart.Value.Date.ToString();
                    string DateEnd = dateEnd.Value.Date.ToString();
                    string DateApplied = DateTime.Today.Date.ToString();
                    string Status = comboBoxStatus.SelectedItem.ToString();

                    string Query = $"Update dbo.LeaveTable set EmployeeId = {EmployeeId}, CategoryId = {CategoryId}, DateStart = '{DateStart}', DateEnd = '{DateEnd}', DateApplied = '{DateApplied}', Status = '{Status}' where LeaveId = {Key}";
                    Connection.SetData(Query);
                    MessageBox.Show("Leave Updated Successfully!", "Info");
                    SetToDefault();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("No Row Selected!", "Warning");
            }
            else
            {
                try
                {
                    string Query = $"delete from dbo.LeaveTable where LeaveId = {Key}";
                    Connection.SetData(Query);
                    MessageBox.Show("Leave Deleted Successfully!", "Info");
                    UpdateKeys();
                    SetToDefault();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateKeys()
        {
            for (int i = Key; i < listLeaves.RowCount - 1; i++)
            {
                string ReorderQuery = $"Update dbo.LeaveTable set LeaveId = {i} where LeaveId = {i + 1}";
                Connection.SetData(ReorderQuery);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ShowLeaves();
        }

        private void comboBoxLeaves_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterLeaves();
        }

        private void labelEmployeesAccess_Click(object sender, EventArgs e)
        {
            Employees_Form employees = new Employees_Form();
            employees.Show();
            this.Hide();
        }

        private void pictureBoxEmployeesAccess_Click(object sender, EventArgs e)
        {
            Employees_Form employees = new Employees_Form();
            employees.Show();
            this.Hide();
        }

        private void labelCategoriesAccess_Click(object sender, EventArgs e)
        {
            Categories_Form categories = new Categories_Form();
            categories.Show();
            this.Hide();
        }

        private void pictureBoxCategoriesAccess_Click(object sender, EventArgs e)
        {
            Categories_Form categories = new Categories_Form();
            categories.Show();
            this.Hide();
        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            Login_Form login = new Login_Form();
            login.Show();
            this.Hide();
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            Login_Form login = new Login_Form();
            login.Show();
            this.Hide();
        }
    }
}
