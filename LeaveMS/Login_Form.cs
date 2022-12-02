using System.Data;

namespace LeaveMS
{
    public partial class Login_Form : Form
    {
        Functions Connection;
        public static int EmployeeId;
        public static string EmployeeName = "";

        public Login_Form()
        {
            InitializeComponent();
            Connection = new Functions();
            textBoxPasswordLogin.PasswordChar = '*';
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textBoxUsernameLogin.Text == "" || textBoxPasswordLogin.Text == "")
            {
                MessageBox.Show("Missing Information!", "Warning");
            }
            else if(textBoxUsernameLogin.Text == "Admin" && textBoxPasswordLogin.Text == "adminpassword")
            {
                Employees_Form employee = new Employees_Form();
                employee.Show();
                this.Hide();
            }
            else
            {
                try
                {
                    string Query = $"select * from dbo.EmployeeTable where EmployeeName = '{textBoxUsernameLogin.Text}' and EmployeePassword = '{textBoxPasswordLogin.Text}'";
                    DataTable dataTable = Connection.GetData(Query);
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Invalid username or password", "Warning");
                        textBoxPasswordLogin.Text = "";
                    }
                    else
                    {
                        EmployeeId = Convert.ToInt32(dataTable.Rows[0][0].ToString());
                        EmployeeName = dataTable.Rows[0][1].ToString();
                        ViewLeave_Form viewLeave = new ViewLeave_Form();
                        viewLeave.Show();
                        this.Hide();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        

        private void textBoxPasswordLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                buttonLogin_Click(sender, e);
            }
        }

        private void textBoxUsernameLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                buttonLogin_Click(sender, e);
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}