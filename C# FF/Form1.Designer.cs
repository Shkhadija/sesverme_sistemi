namespace C__FF
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
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            btnLogin = new Button();
            rbAdmin = new RadioButton();
            rbVoter = new RadioButton();
            label1 = new Label();
            chkShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BorderStyle = BorderStyle.Fixed3D;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(336, 49);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(141, 33);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Login Panel";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BorderStyle = BorderStyle.FixedSingle;
            lblUsername.Location = new Point(209, 169);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(80, 22);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(305, 169);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(305, 241);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(216, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += textBox1_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BorderStyle = BorderStyle.FixedSingle;
            lblPassword.Location = new Point(209, 241);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(75, 22);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Control;
            btnLogin.Location = new Point(336, 364);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // rbAdmin
            // 
            rbAdmin.AutoSize = true;
            rbAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            rbAdmin.Location = new Point(305, 299);
            rbAdmin.Name = "rbAdmin";
            rbAdmin.Size = new Size(72, 24);
            rbAdmin.TabIndex = 6;
            rbAdmin.TabStop = true;
            rbAdmin.Text = "Admin";
            rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbVoter
            // 
            rbVoter.AutoSize = true;
            rbVoter.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            rbVoter.Location = new Point(412, 299);
            rbVoter.Name = "rbVoter";
            rbVoter.Size = new Size(64, 24);
            rbVoter.TabIndex = 7;
            rbVoter.TabStop = true;
            rbVoter.Text = "Voter";
            rbVoter.UseVisualStyleBackColor = true;
            rbVoter.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(209, 301);
            label1.Name = "label1";
            label1.Size = new Size(44, 22);
            label1.TabIndex = 8;
            label1.Text = "Role:";
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(468, 242);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(52, 24);
            chkShowPassword.TabIndex = 9;
            chkShowPassword.Text = "👁";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(chkShowPassword);
            Controls.Add(label1);
            Controls.Add(rbVoter);
            Controls.Add(rbAdmin);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnLogin;
        private RadioButton rbAdmin;
        private RadioButton rbVoter;
        private Label label1;
        private CheckBox chkShowPassword;
    }
}
