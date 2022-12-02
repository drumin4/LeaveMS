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
    public partial class Employees_Form : Form
    {
        Functions Connection;
        int Key = 0;
        int KeyCount = 0;

        public Employees_Form()
        {
            InitializeComponent();
            Connection = new Functions();
            ShowEmployees();
        }

        private void ShowEmployees()
        {
            string Query = "select * from dbo.EmployeeTable";
            listEmployees.DataSource = Connection.GetData(Query);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(textBoxEmployeeAddress.Text == "" || textBoxEmployeeName.Text == "" || textBoxEmployeePassword.Text == "" || textBoxEmployeePhoneNumber.Text == "" || comboBoxEmployeeGender.Text == "")
            {
                MessageBox.Show("Missing Information!", "Warning");
            }
            else
            {
                try
                {
                    string Name = textBoxEmployeeName.Text;
                    string Gender = comboBoxEmployeeGender.Text;
                    string PhoneNumber = textBoxEmployeePhoneNumber.Text;
                    string Password = textBoxEmployeePassword.Text;
                    string Address = textBoxEmployeeAddress.Text;
                    KeyCount++;
                    for(int i = 0; i < listEmployees.RowCount - 1; i++)
                    {
                        if (listEmployees.Rows[0].Cells[0].Value == null)
                        {
                            break;
                        }
                        else if (listEmployees.Rows[i].Cells[0].Value.ToString() == KeyCount.ToString()) 
                        {
                            KeyCount++;
                        }
                    }

                    string Query = $"insert into EmployeeTable values({KeyCount}, '{Name}', '{Gender}', '{PhoneNumber}', '{Password}', '{Address}')";
                    Connection.SetData(Query);
                    MessageBox.Show("Employee Saved Successfully!", "Info");
                    SetToDefault();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void listEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxEmployeeName.Text = listEmployees.SelectedRows[0].Cells[1].Value.ToString();
            comboBoxEmployeeGender.Text = listEmployees.SelectedRows[0].Cells[2].Value.ToString();
            textBoxEmployeePhoneNumber.Text = listEmployees.SelectedRows[0].Cells[3].Value.ToString();
            textBoxEmployeePassword.Text = listEmployees.SelectedRows[0].Cells[4].Value.ToString();
            textBoxEmployeeAddress.Text = listEmployees.SelectedRows[0].Cells[5].Value.ToString();

            if(textBoxEmployeeName.Text == "" || comboBoxEmployeeGender.Text == "" || textBoxEmployeePhoneNumber.Text == "" || textBoxEmployeePassword.Text == "" || textBoxEmployeeAddress.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(listEmployees.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxEmployeeAddress.Text == "" || textBoxEmployeeName.Text == "" || textBoxEmployeePassword.Text == "" || textBoxEmployeePhoneNumber.Text == "" || comboBoxEmployeeGender.Text == "")
            {
                MessageBox.Show("Missing Information!", "Warning");
            }
            else
            {
                try
                {
                    string Name = textBoxEmployeeName.Text;
                    string Gender = comboBoxEmployeeGender.Text;
                    string PhoneNumber = textBoxEmployeePhoneNumber.Text;
                    string Password = textBoxEmployeePassword.Text;
                    string Address = textBoxEmployeeAddress.Text;

                    string Query = $"Update dbo.EmployeeTable set EmployeeName = '{Name}', EmployeeGender = '{Gender}', EmployeePhone = '{PhoneNumber}', EmployeePassword = '{Password}', EmployeeAddress = '{Address}' where EmployeeId = {Key}";
                    Connection.SetData(Query);
                    MessageBox.Show("Employee Updated Successfully!", "Info");
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
            ShowEmployees();
            textBoxEmployeeName.Text = "";
            comboBoxEmployeeGender.Text = "";
            textBoxEmployeePhoneNumber.Text = "";
            textBoxEmployeePassword.Text = "";
            textBoxEmployeeAddress.Text = "";
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
                    string Query = $"delete from dbo.EmployeeTable where EmployeeId = {Key}";
                    Connection.SetData(Query);
                    MessageBox.Show("Employee Deleted Successfully!", "Info");
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
            for (int i = Key; i < listEmployees.RowCount - 1; i++)
            {
                string ReorderQuery = $"Update dbo.EmployeeTable set EmployeeId = {i} where EmployeeId = {i + 1}";
                Connection.SetData(ReorderQuery);
            }
        }

        private void labelLeavesAccess_Click(object sender, EventArgs e)
        {
            Leaves_Form leaves = new Leaves_Form();
            leaves.Show();
            this.Hide();
        }

        private void pictureBoxLeavesAccess_Click(object sender, EventArgs e)
        {
            Leaves_Form leaves = new Leaves_Form();
            leaves.Show();
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
