namespace PRN211
{
    partial class Management
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
            dgvStudent = new DataGridView();
            btnClose = new Button();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnNew1 = new Button();
            txtName = new TextBox();
            txtID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSearch = new TextBox();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtAccType = new TextBox();
            txtBranchName = new TextBox();
            dtpOpenDate = new DateTimePicker();
            btnSearch = new Button();
            cbbTypeID = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // dgvStudent
            // 
            dgvStudent.AllowUserToAddRows = false;
            dgvStudent.AllowUserToDeleteRows = false;
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(56, 58);
            dgvStudent.Margin = new Padding(3, 2, 3, 2);
            dgvStudent.MultiSelect = false;
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 82;
            dgvStudent.RowTemplate.Height = 41;
            dgvStudent.Size = new Size(1211, 235);
            dgvStudent.TabIndex = 0;
            dgvStudent.CellDoubleClick += dgvStudent_CellDoubleClick;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1151, 550);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(116, 37);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(1151, 308);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(116, 37);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Delete Student";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(56, 495);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(116, 37);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnCancel_Click;
            // 
            // btnNew1
            // 
            btnNew1.Location = new Point(626, 495);
            btnNew1.Margin = new Padding(3, 2, 3, 2);
            btnNew1.Name = "btnNew1";
            btnNew1.Size = new Size(116, 37);
            btnNew1.TabIndex = 16;
            btnNew1.Text = "Create";
            btnNew1.UseVisualStyleBackColor = true;
            btnNew1.Click += btnNew1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(187, 382);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(297, 31);
            txtName.TabIndex = 15;
            // 
            // txtID
            // 
            txtID.Location = new Point(187, 343);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(297, 31);
            txtID.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 417);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 12;
            label3.Text = "Open Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 382);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 11;
            label2.Text = "Account Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 343);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 10;
            label1.Text = "Account ID";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(57, 13);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(1090, 31);
            txtSearch.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(553, 417);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 21;
            label4.Text = "Account Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(553, 382);
            label7.Name = "label7";
            label7.Size = new Size(72, 25);
            label7.TabIndex = 20;
            label7.Text = "Type ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(553, 343);
            label6.Name = "label6";
            label6.Size = new Size(117, 25);
            label6.TabIndex = 19;
            label6.Text = "Branch Name";
            // 
            // txtAccType
            // 
            txtAccType.Location = new Point(683, 417);
            txtAccType.Margin = new Padding(3, 2, 3, 2);
            txtAccType.Name = "txtAccType";
            txtAccType.Size = new Size(297, 31);
            txtAccType.TabIndex = 23;
            // 
            // txtBranchName
            // 
            txtBranchName.Location = new Point(683, 343);
            txtBranchName.Margin = new Padding(3, 2, 3, 2);
            txtBranchName.Name = "txtBranchName";
            txtBranchName.Size = new Size(297, 31);
            txtBranchName.TabIndex = 22;
            // 
            // dtpOpenDate
            // 
            dtpOpenDate.Location = new Point(187, 427);
            dtpOpenDate.Margin = new Padding(4, 5, 4, 5);
            dtpOpenDate.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dtpOpenDate.MinDate = new DateTime(1800, 1, 1, 0, 0, 0, 0);
            dtpOpenDate.Name = "dtpOpenDate";
            dtpOpenDate.Size = new Size(297, 31);
            dtpOpenDate.TabIndex = 25;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1154, 13);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(116, 37);
            btnSearch.TabIndex = 26;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbbTypeID
            // 
            cbbTypeID.FormattingEnabled = true;
            cbbTypeID.Location = new Point(683, 379);
            cbbTypeID.Name = "cbbTypeID";
            cbbTypeID.Size = new Size(297, 33);
            cbbTypeID.TabIndex = 27;
            // 
            // Management
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 667);
            Controls.Add(cbbTypeID);
            Controls.Add(btnSearch);
            Controls.Add(dtpOpenDate);
            Controls.Add(txtAccType);
            Controls.Add(txtBranchName);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew1);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCreate);
            Controls.Add(btnClose);
            Controls.Add(dgvStudent);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Management";
            Text = "Management";
            Load += Management_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudent;
        private Button btnClose;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnNew1;
        private TextBox txtName;
        private TextBox txtID;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtSearch;
        private Label label4;
        private Label label7;
        private Label label6;
        private TextBox txtAccType;
        private TextBox txtBranchName;
        private DateTimePicker dtpOpenDate;
        private Button btnSearch;
        private ComboBox cbbTypeID;
    }
}