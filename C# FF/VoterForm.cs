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
    public partial class VoterForm : Form
    {
        string selectedCandidate = "";
        int secondsSpent = 0;
        bool hasVoted = false;

        public VoterForm()
        {
            InitializeComponent();
        }

        private void VoterForm_Load(object sender, EventArgs e)
        {

            lblDate.Text = "Səsvermə tarixi: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm");
        }

        private void lblCandidate1Info_Click(object sender, EventArgs e)
        {

        }

        private void rbCandidate2_CheckedChanged(object sender, EventArgs e)
        {
            if (hasVoted || !rbCandidate2.Checked) return;

            selectedCandidate = rbCandidate2.Text;
            lblSelectedName.Text = selectedCandidate;
            btnVote.Enabled = true;
        }

        private void lblSelectedCandidate_Click(object sender, EventArgs e)
        {

        }

        private void rbCandidate3_CheckedChanged(object sender, EventArgs e)
        {
            if (hasVoted || !rbCandidate3.Checked) return;

            selectedCandidate = rbCandidate3.Text;
            lblSelectedName.Text = selectedCandidate;
            btnVote.Enabled = true;
        }

        private void VoterForm_Shown(object sender, EventArgs e)
        {


            btnVote.Enabled = false;
            lblVoteStatus.Visible = false;
            secondsSpent = 0;
            timerSession.Start();
        }

        private void rbCandidate1_CheckedChanged(object sender, EventArgs e)
        {
            if (hasVoted || !rbCandidate1.Checked) return;

            selectedCandidate = rbCandidate1.Text;
            lblSelectedName.Text = selectedCandidate;
            btnVote.Enabled = true;
        }

        private void timerSession_Tick(object sender, EventArgs e)
        {
            secondsSpent++;

        }

        private void VoterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerSession.Stop();

            if (!hasVoted && !string.IsNullOrEmpty(selectedCandidate))
            {
                VoteRepository.Votes.Add(new Vote
                {
                    Candidate = selectedCandidate,
                    Status = VoteStatus.Natamam
                });
            }

            Form1 login = new Form1();
            login.Show();

            int minutes = secondsSpent / 60;
            int seconds = secondsSpent % 60;

            MessageBox.Show(
                $"Siz bu səhifədə {minutes} dəqiqə {seconds} saniyə qaldınız.",
                "Vaxt Məlumatı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private async void btnVote_Click(object sender, EventArgs e)
        {
            VoterInfoForm infoForm = new VoterInfoForm();
            DialogResult result = infoForm.ShowDialog();

            if (result != DialogResult.OK) return;

            hasVoted = true;

            VoteRepository.Votes.Add(new Vote
            {
                FullName = infoForm.FullName,
                Candidate = selectedCandidate,
                VoteDate = DateTime.Now,
                Status = VoteStatus.Qebul_Edildi
            });

            rbCandidate1.Enabled = false;
            rbCandidate2.Enabled = false;
            rbCandidate3.Enabled = false;
            btnVote.Enabled = false;

            lblVoteStatus.Visible = true;

            MessageBox.Show(
                "Səsiniz uğurla qeydə alındı.",
                "Uğurlu əməliyyat",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
