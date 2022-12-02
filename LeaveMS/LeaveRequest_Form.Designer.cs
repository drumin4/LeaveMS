namespace LeaveMS
{
    partial class LeaveRequest_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveRequest_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 102);
            this.panel1.TabIndex = 1;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(443, 7);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(33, 33);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 8;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lemon", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(88, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "Leave Request";
            // 
            // dateStart
            // 
            this.dateStart.Checked = true;
            this.dateStart.FillColor = System.Drawing.Color.MediumPurple;
            this.dateStart.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateStart.ForeColor = System.Drawing.Color.Lavender;
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateStart.Location = new System.Drawing.Point(56, 274);
            this.dateStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(306, 33);
            this.dateStart.TabIndex = 47;
            this.dateStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateStart.Value = new System.DateTime(2022, 11, 18, 5, 48, 33, 701);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(47, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 41);
            this.label5.TabIndex = 45;
            this.label5.Text = "Date Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(47, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 41);
            this.label4.TabIndex = 44;
            this.label4.Text = "Leaving Reason";
            // 
            // dateEnd
            // 
            this.dateEnd.Checked = true;
            this.dateEnd.FillColor = System.Drawing.Color.MediumPurple;
            this.dateEnd.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateEnd.ForeColor = System.Drawing.Color.Lavender;
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateEnd.Location = new System.Drawing.Point(56, 383);
            this.dateEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateEnd.MinDate = new System.DateTime(2022, 11, 18, 0, 0, 0, 0);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(306, 33);
            this.dateEnd.TabIndex = 49;
            this.dateEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateEnd.Value = new System.DateTime(2022, 11, 18, 5, 48, 33, 701);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(47, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 41);
            this.label6.TabIndex = 48;
            this.label6.Text = "Date End";
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Items.AddRange(new object[] {
            "Woman",
            "Man",
            "Transgender",
            "Non-binary/non-conforming",
            "Prefer not to respond"});
            this.comboBoxCategories.Location = new System.Drawing.Point(56, 167);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(306, 31);
            this.comboBoxCategories.TabIndex = 50;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCancel.FlatAppearance.BorderSize = 3;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(56, 494);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(155, 53);
            this.buttonCancel.TabIndex = 51;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubmit.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSubmit.FlatAppearance.BorderSize = 3;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(271, 492);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(155, 53);
            this.buttonSubmit.TabIndex = 52;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // LeaveRequest_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 574);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LeaveRequest_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RequestLeave_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxClose;
        private Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateStart;
        private Label label5;
        private Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateEnd;
        private Label label6;
        private ComboBox comboBoxCategories;
        private Button buttonCancel;
        private Button buttonSubmit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}