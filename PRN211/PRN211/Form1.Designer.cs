namespace PRN211
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(599, 237);
            btnLogin.Margin = new Padding(2, 2, 2, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(115, 36);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 111);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(201, 111);
            txtUsername.Margin = new Padding(2, 2, 2, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Input username";
            txtUsername.Size = new Size(515, 31);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(201, 175);
            txtPassword.Margin = new Padding(2, 2, 2, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Input password";
            txtPassword.Size = new Size(515, 31);
            txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 175);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 621);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label2;
    }
}