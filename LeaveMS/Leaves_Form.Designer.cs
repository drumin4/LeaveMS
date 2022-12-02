namespace LeaveMS
{
    partial class Leaves_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leaves_Form));
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEmployees = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.dateStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.listLeaves = new Guna.UI2.WinForms.Guna2DataGridView();
            this.comboBoxLeaves = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLogout = new System.Windows.Forms.Label();
            this.pictureBoxLogout = new System.Windows.Forms.PictureBox();
            this.labelCategoriesAccess = new System.Windows.Forms.Label();
            this.pictureBoxCategoriesAccess = new System.Windows.Forms.PictureBox();
            this.labelLeavesAccess = new System.Windows.Forms.Label();
            this.pictureBoxLeavesAccess = new System.Windows.Forms.PictureBox();
            this.labelEmployeesAccess = new System.Windows.Forms.Label();
            this.pictureBoxEmployeesAccess = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listLeaves)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategoriesAccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeavesAccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployeesAccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.comboBoxCategories.Location = new System.Drawing.Point(485, 153);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(225, 31);
            this.comboBoxCategories.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label13.Location = new System.Drawing.Point(644, 361);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 37);
            this.label13.TabIndex = 39;
            this.label13.Text = "Leaves List";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumPurple;
            this.panel3.Location = new System.Drawing.Point(185, 326);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1092, 15);
            this.panel3.TabIndex = 37;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Plum;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(1040, 255);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(174, 44);
            this.buttonDelete.TabIndex = 36;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(1040, 195);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(174, 44);
            this.buttonSave.TabIndex = 35;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(1040, 139);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(174, 44);
            this.buttonEdit.TabIndex = 34;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(667, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 28);
            this.label7.TabIndex = 32;
            this.label7.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(364, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 28);
            this.label6.TabIndex = 30;
            this.label6.Text = "Date End";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(744, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 28);
            this.label5.TabIndex = 28;
            this.label5.Text = "Date Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(479, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "Categories";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(213, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "Employees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(629, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Manage Leaves";
            // 
            // comboBoxEmployees
            // 
            this.comboBoxEmployees.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxEmployees.FormattingEnabled = true;
            this.comboBoxEmployees.Items.AddRange(new object[] {
            "Woman",
            "Man",
            "Transgender",
            "Non-binary/non-conforming",
            "Prefer not to respond"});
            this.comboBoxEmployees.Location = new System.Drawing.Point(219, 153);
            this.comboBoxEmployees.Name = "comboBoxEmployees";
            this.comboBoxEmployees.Size = new System.Drawing.Size(225, 31);
            this.comboBoxEmployees.TabIndex = 41;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Rejected"});
            this.comboBoxStatus.Location = new System.Drawing.Point(673, 252);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(225, 31);
            this.comboBoxStatus.TabIndex = 42;
            // 
            // dateStart
            // 
            this.dateStart.Checked = true;
            this.dateStart.FillColor = System.Drawing.Color.MediumPurple;
            this.dateStart.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateStart.ForeColor = System.Drawing.Color.Lavender;
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateStart.Location = new System.Drawing.Point(751, 153);
            this.dateStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(257, 33);
            this.dateStart.TabIndex = 43;
            this.dateStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateStart.Value = new System.DateTime(2022, 11, 18, 5, 48, 33, 701);
            // 
            // dateEnd
            // 
            this.dateEnd.Checked = true;
            this.dateEnd.FillColor = System.Drawing.Color.MediumPurple;
            this.dateEnd.Font = new System.Drawing.Font("Segoe UI Semibold", 8.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateEnd.ForeColor = System.Drawing.Color.Lavender;
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateEnd.Location = new System.Drawing.Point(370, 252);
            this.dateEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateEnd.MinDate = new System.DateTime(2022, 11, 18, 0, 0, 0, 0);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(257, 33);
            this.dateEnd.TabIndex = 44;
            this.dateEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateEnd.Value = new System.DateTime(2022, 11, 18, 5, 48, 33, 701);
            // 
            // listLeaves
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.listLeaves.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listLeaves.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listLeaves.ColumnHeadersHeight = 30;
            this.listLeaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listLeaves.DefaultCellStyle = dataGridViewCellStyle3;
            this.listLeaves.GridColor = System.Drawing.Color.Lavender;
            this.listLeaves.Location = new System.Drawing.Point(227, 447);
            this.listLeaves.Name = "listLeaves";
            this.listLeaves.ReadOnly = true;
            this.listLeaves.RowHeadersVisible = false;
            this.listLeaves.RowHeadersWidth = 51;
            this.listLeaves.RowTemplate.Height = 29;
            this.listLeaves.Size = new System.Drawing.Size(1009, 417);
            this.listLeaves.TabIndex = 45;
            this.listLeaves.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.MediumPurple;
            this.listLeaves.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.listLeaves.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.listLeaves.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.listLeaves.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.listLeaves.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.listLeaves.ThemeStyle.GridColor = System.Drawing.Color.Lavender;
            this.listLeaves.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.listLeaves.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listLeaves.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listLeaves.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.listLeaves.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.listLeaves.ThemeStyle.HeaderStyle.Height = 30;
            this.listLeaves.ThemeStyle.ReadOnly = true;
            this.listLeaves.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.listLeaves.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listLeaves.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listLeaves.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listLeaves.ThemeStyle.RowsStyle.Height = 29;
            this.listLeaves.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listLeaves.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listLeaves.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listLeaves_CellContentClick);
            // 
            // comboBoxLeaves
            // 
            this.comboBoxLeaves.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxLeaves.FormattingEnabled = true;
            this.comboBoxLeaves.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Rejected"});
            this.comboBoxLeaves.Location = new System.Drawing.Point(608, 401);
            this.comboBoxLeaves.Name = "comboBoxLeaves";
            this.comboBoxLeaves.Size = new System.Drawing.Size(225, 31);
            this.comboBoxLeaves.TabIndex = 46;
            this.comboBoxLeaves.SelectedIndexChanged += new System.EventHandler(this.comboBoxLeaves_SelectedIndexChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Location = new System.Drawing.Point(850, 394);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(174, 44);
            this.buttonRefresh.TabIndex = 47;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.labelLogout);
            this.panel1.Controls.Add(this.pictureBoxLogout);
            this.panel1.Controls.Add(this.labelCategoriesAccess);
            this.panel1.Controls.Add(this.pictureBoxCategoriesAccess);
            this.panel1.Controls.Add(this.labelLeavesAccess);
            this.panel1.Controls.Add(this.pictureBoxLeavesAccess);
            this.panel1.Controls.Add(this.labelEmployeesAccess);
            this.panel1.Controls.Add(this.pictureBoxEmployeesAccess);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 877);
            this.panel1.TabIndex = 48;
            // 
            // labelLogout
            // 
            this.labelLogout.AutoSize = true;
            this.labelLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLogout.ForeColor = System.Drawing.Color.Lavender;
            this.labelLogout.Location = new System.Drawing.Point(77, 809);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(78, 28);
            this.labelLogout.TabIndex = 14;
            this.labelLogout.Text = "Logout";
            this.labelLogout.Click += new System.EventHandler(this.labelLogout_Click);
            // 
            // pictureBoxLogout
            // 
            this.pictureBoxLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogout.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogout.Image")));
            this.pictureBoxLogout.Location = new System.Drawing.Point(5, 790);
            this.pictureBoxLogout.Name = "pictureBoxLogout";
            this.pictureBoxLogout.Size = new System.Drawing.Size(73, 73);
            this.pictureBoxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogout.TabIndex = 13;
            this.pictureBoxLogout.TabStop = false;
            this.pictureBoxLogout.Click += new System.EventHandler(this.pictureBoxLogout_Click);
            // 
            // labelCategoriesAccess
            // 
            this.labelCategoriesAccess.AutoSize = true;
            this.labelCategoriesAccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCategoriesAccess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCategoriesAccess.ForeColor = System.Drawing.Color.Lavender;
            this.labelCategoriesAccess.Location = new System.Drawing.Point(56, 510);
            this.labelCategoriesAccess.Name = "labelCategoriesAccess";
            this.labelCategoriesAccess.Size = new System.Drawing.Size(112, 28);
            this.labelCategoriesAccess.TabIndex = 12;
            this.labelCategoriesAccess.Text = "Categories";
            this.labelCategoriesAccess.Click += new System.EventHandler(this.labelCategoriesAccess_Click);
            // 
            // pictureBoxCategoriesAccess
            // 
            this.pictureBoxCategoriesAccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCategoriesAccess.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCategoriesAccess.Image")));
            this.pictureBoxCategoriesAccess.Location = new System.Drawing.Point(-3, 502);
            this.pictureBoxCategoriesAccess.Name = "pictureBoxCategoriesAccess";
            this.pictureBoxCategoriesAccess.Size = new System.Drawing.Size(63, 51);
            this.pictureBoxCategoriesAccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCategoriesAccess.TabIndex = 11;
            this.pictureBoxCategoriesAccess.TabStop = false;
            this.pictureBoxCategoriesAccess.Click += new System.EventHandler(this.pictureBoxCategoriesAccess_Click);
            // 
            // labelLeavesAccess
            // 
            this.labelLeavesAccess.AutoSize = true;
            this.labelLeavesAccess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLeavesAccess.ForeColor = System.Drawing.Color.Lavender;
            this.labelLeavesAccess.Location = new System.Drawing.Point(56, 424);
            this.labelLeavesAccess.Name = "labelLeavesAccess";
            this.labelLeavesAccess.Size = new System.Drawing.Size(75, 28);
            this.labelLeavesAccess.TabIndex = 10;
            this.labelLeavesAccess.Text = "Leaves";
            // 
            // pictureBoxLeavesAccess
            // 
            this.pictureBoxLeavesAccess.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLeavesAccess.Image")));
            this.pictureBoxLeavesAccess.Location = new System.Drawing.Point(-3, 416);
            this.pictureBoxLeavesAccess.Name = "pictureBoxLeavesAccess";
            this.pictureBoxLeavesAccess.Size = new System.Drawing.Size(63, 45);
            this.pictureBoxLeavesAccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLeavesAccess.TabIndex = 9;
            this.pictureBoxLeavesAccess.TabStop = false;
            // 
            // labelEmployeesAccess
            // 
            this.labelEmployeesAccess.AutoSize = true;
            this.labelEmployeesAccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEmployeesAccess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmployeesAccess.ForeColor = System.Drawing.Color.Lavender;
            this.labelEmployeesAccess.Location = new System.Drawing.Point(56, 337);
            this.labelEmployeesAccess.Name = "labelEmployeesAccess";
            this.labelEmployeesAccess.Size = new System.Drawing.Size(113, 28);
            this.labelEmployeesAccess.TabIndex = 8;
            this.labelEmployeesAccess.Text = "Employees";
            this.labelEmployeesAccess.Click += new System.EventHandler(this.labelEmployeesAccess_Click);
            // 
            // pictureBoxEmployeesAccess
            // 
            this.pictureBoxEmployeesAccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEmployeesAccess.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEmployeesAccess.Image")));
            this.pictureBoxEmployeesAccess.Location = new System.Drawing.Point(-3, 329);
            this.pictureBoxEmployeesAccess.Name = "pictureBoxEmployeesAccess";
            this.pictureBoxEmployeesAccess.Size = new System.Drawing.Size(63, 45);
            this.pictureBoxEmployeesAccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEmployeesAccess.TabIndex = 7;
            this.pictureBoxEmployeesAccess.TabStop = false;
            this.pictureBoxEmployeesAccess.Click += new System.EventHandler(this.pictureBoxEmployeesAccess_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Lavender;
            this.label8.Location = new System.Drawing.Point(31, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 28);
            this.label8.TabIndex = 6;
            this.label8.Text = "Leave M.S";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(185, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1092, 35);
            this.panel2.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(369, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management System Version 1.0";
            // 
            // Leaves_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1277, 877);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.comboBoxLeaves);
            this.Controls.Add(this.listLeaves);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxEmployees);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Leaves_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leaves_Form";
            ((System.ComponentModel.ISupportInitialize)(this.listLeaves)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCategoriesAccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeavesAccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployeesAccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxCategories;
        private Label label13;
        private Panel panel3;
        private Button buttonDelete;
        private Button buttonSave;
        private Button buttonEdit;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxEmployees;
        private ComboBox comboBoxStatus;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateEnd;
        private Guna.UI2.WinForms.Guna2DataGridView listLeaves;
        private Button buttonRefresh;
        private ComboBox comboBoxLeaves;
        private Panel panel1;
        private Label labelLogout;
        private PictureBox pictureBoxLogout;
        private Label labelCategoriesAccess;
        private PictureBox pictureBoxCategoriesAccess;
        private Label labelLeavesAccess;
        private PictureBox pictureBoxLeavesAccess;
        private Label labelEmployeesAccess;
        private PictureBox pictureBoxEmployeesAccess;
        private Label label8;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
    }
}