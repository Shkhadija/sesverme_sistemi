namespace C__FF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show(
                    "Username daxil edin",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtUsername.Focus();
                return;
            }

            
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show(
                    "Password daxil edin",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtPassword.Focus();
                return;
            }

            
            if (!rbAdmin.Checked && !rbVoter.Checked)
            {
                MessageBox.Show(
                    "Zəhmət olmasa rol seçin",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            
            if (rbAdmin.Checked)
            {
                if (username == "admin" && password == "1234")
                {
                    MessageBox.Show(
                        "Xoş gəldiniz, Admin!",
                        "Admin Panel",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    AdminForm admin = new AdminForm();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Admin username və ya password yanlışdır",
                        "Login Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            
            else if (rbVoter.Checked)
            {
                
                if ((username == "voter1" ||
                     username == "voter2" ||
                     username == "voter3" ||
                     username == "voter4" ||
                     username == "voter5" ||
                     username == "voter") 
                     && password == "1234")
                {
                    VoterForm voter = new VoterForm();
                    voter.Show();
                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show(
                        "Voter username və ya password səhvdir",
                        "Login Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }

        }
    }
}
