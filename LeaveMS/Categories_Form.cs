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

namespace LeaveMS
{
    public partial class Categories_Form : Form
    {
        int KeyCount = 0;
        int Key = 0;
        Functions Connection;

        public Categories_Form()
        {
            InitializeComponent();
            Connection = new Functions();
            ShowCategories();
        }

        private void ShowCategories()
        {
            string Query = "select * from CategoryTable";
            listCategories.DataSource = Connection.GetData(Query);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxCategoryName.Text == "")
                {
                    MessageBox.Show("Missing Information!", "Warning");
                }
                else
                {
                    KeyCount++;
                    for (int i = 0; i < listCategories.RowCount - 1; i++)
                    {
                        if(listCategories.Rows[0].Cells[0].Value == null)
                        {
                            break;
                        }
                        else if (listCategories.Rows[i].Cells[0].Value.ToString() == KeyCount.ToString())
                        {
                            KeyCount++;
                        }

                    }
                    string Category = textBoxCategoryName.Text;
                    string Query = "insert into CategoryTable (CategoryId, CategoryName) values({0},'{1}')";
                    Query = string.Format(Query, KeyCount, Category);
                    Connection.SetData(Query);
                    MessageBox.Show("Category Saved Successfully!", "Info");
                    ShowCategories();
                    textBoxCategoryName.Text = "";
                    KeyCount = 0;
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxCategoryName.Text = listCategories.SelectedRows[0].Cells[1].Value.ToString();
            if(textBoxCategoryName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(listCategories.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxCategoryName.Text == "")
                {
                    MessageBox.Show("Missing Information!", "Warning");
                }
                else
                {
                    string Category = textBoxCategoryName.Text;
                    string Query = "update CategoryTable set CategoryName = '{0}' where CategoryId = {1}";
                    Query = string.Format(Query, Category, Key);
                    Connection.SetData(Query);
                    MessageBox.Show("Category Updated Successfully!", "Info");
                    ShowCategories();
                    textBoxCategoryName.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(Key == 0)
                {
                    MessageBox.Show("No Row Selected!", "Warning");
                }
                else
                {
                    string Query = $"delete from CategoryTable where CategoryId = {Key}";
                    Connection.SetData(Query);
                    MessageBox.Show("Category Deleted Successfully!", "Info");
                    UpdateKeys();
                    ShowCategories();
                    textBoxCategoryName.Text = "";
                    Key = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateKeys()
        {
            for (int i = Key; i < listCategories.RowCount - 1; i++) 
            {
                string Query = $"update CategoryTable set CategoryId = {i} where CategoryId = {i+1}";
                Connection.SetData(Query);
                
            }
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
