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
    public partial class ViewLeave_Form : Form
    {
        Functions Connection;
        public ViewLeave_Form()
        {
            InitializeComponent();
            Connection = new Functions();
            labelEmployeeId.Text = Login_Form.EmployeeId.ToString();
            labelEmployeeName.Text = Login_Form.EmployeeName.ToString();
            ShowLeaves();
        }

        private void ShowLeaves()
        {
            string Query = $"select * from dbo.LeaveTable where EmployeeId = {labelEmployeeId.Text}";
            listEmployeeLeaves.DataSource = Connection.GetData(Query);
        }

        private void pictureBoxLeavesAccess_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeaveRequest_Form leaveRequest = new LeaveRequest_Form();
            leaveRequest.EmployeeRequesting(labelEmployeeId.Text);
            
            leaveRequest.ShowDialog();
            if(leaveRequest.Visible == false)
            {
                this.Show();
                ShowLeaves();
                
            }
            
        }

        private void labelRequestLeave_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeaveRequest_Form leaveRequest = new LeaveRequest_Form();
            leaveRequest.EmployeeRequesting(labelEmployeeId.Text);

            leaveRequest.ShowDialog();
            if (leaveRequest.Visible == false)
            {
                this.Show();
                ShowLeaves();

            }
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            Login_Form login = new Login_Form();
            login.Show();
            this.Hide();
        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            Login_Form login = new Login_Form();
            login.Show();
            this.Hide();
        }

        
    }
}
