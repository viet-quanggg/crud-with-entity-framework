namespace PRN211
{
    partial class CreateStudent
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtID = new TextBox();
            txtAge = new TextBox();
            txtName = new TextBox();
            btnNew = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 60);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 98);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 1;
            label2.Text = "Student Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 134);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 2;
            label3.Text = "Student Age";
            // 
            // txtID
            // 
            txtID.Location = new Point(235, 60);
            txtID.Margin = new Padding(2, 2, 2, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(535, 31);
            txtID.TabIndex = 4;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(235, 134);
            txtAge.Margin = new Padding(2, 2, 2, 2);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(535, 31);
            txtAge.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(235, 98);
            txtName.Margin = new Padding(2, 2, 2, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(535, 31);
            txtName.TabIndex = 7;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(653, 212);
            btnNew.Margin = new Padding(2, 2, 2, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(115, 36);
            btnNew.TabIndex = 8;
            btnNew.Text = "Create";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(88, 212);
            btnCancel.Margin = new Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 36);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CreateStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 545);
            Controls.Add(btnCancel);
            Controls.Add(btnNew);
            Controls.Add(txtName);
            Controls.Add(txtAge);
            Controls.Add(txtID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CreateStudent";
            Text = "CreateStudent";
            Load += CreateStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtID;
        private TextBox txtAge;
        private TextBox txtName;
        private Button btnNew;
        private Button btnCancel;
    }
}