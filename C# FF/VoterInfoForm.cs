using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__FF
{
    public partial class VoterInfoForm : Form
    {
        public string FullName { get; private set; }

        public VoterInfoForm()
        {
            InitializeComponent();
        }

        private void VoterInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show(
                    "Zəhmət olmasa ad və soyad daxil edin",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            FullName = txtFullName.Text.Trim();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
       "Çıxmaq istədiyinizdən əminsiniz?\nAd və soyad daxil etmədən səsiniz qeydə alınmayacaq.",
       "Təsdiq",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question
   );

            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void VoterInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Əgər artıq OK ilə bağlanmırsa (yəni ad-soyad təsdiqlənməyibsə)
            if (this.DialogResult != DialogResult.OK)
            {
                DialogResult result = MessageBox.Show(
                    "Ad və soyad daxil etmədən səsiniz sayılmayacaq.\nÇıxmaq istədiyinizdən əminsiniz?",
                    "Təsdiq",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                {
                    e.Cancel = true; // ❌ bağlanmasın
                }
                // Yes → bağlanacaq, heç nə etmirik
            }
        }
    }
}
