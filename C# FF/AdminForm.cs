using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;


namespace C__FF
{
    public partial class AdminForm : Form
    {
        int secondsSpent = 0;
        void LoadFinalReport()
        {
            var validVotes = VoteRepository.Votes
                .Where(v => v.Status == VoteStatus.Qebul_Edildi)
                .ToList();

            int totalVotes = validVotes.Count;
            lblTotalVotes.Text = $"Ümumi səs sayı: {totalVotes}";

            if (totalVotes == 0)
            {
                lblWinner.Text = "Qalib namizəd: yoxdur";
                lblWinnerPercent.Text = "Qələbə faizi: 0%";
                return;
            }

            var winnerGroup = validVotes
                .GroupBy(v => v.Candidate)
                .OrderByDescending(g => g.Count())
                .First();

            int winnerVotes = winnerGroup.Count();
            int percent = winnerVotes * 100 / totalVotes;

            lblWinner.Text = $"Qalib namizəd: {winnerGroup.Key}";
            lblWinnerPercent.Text = $"Qələbə faizi: {percent}%";
        }

        void LoadCandidateStats()
        {
            dgvCandidates.AutoGenerateColumns = false;

            var validVotes = VoteRepository.Votes
                .Where(v => v.Status == VoteStatus.Qebul_Edildi)
                .ToList();

            int totalVotes = validVotes.Count;


            var stats = validVotes
                .GroupBy(v => v.Candidate)
                .Select(g => new CandidateStat
                {
                    Candidate = g.Key,
                    VoteCount = g.Count(),
                    Percent = totalVotes == 0
                        ? "0%"
                        : $"{(g.Count() * 100 / totalVotes)}%"
                })
                .ToList();

            dgvCandidates.DataSource = null;
            dgvCandidates.DataSource = stats;


            UpdateCandidateUI(
                "Fatimə Bayramova",
                pbCan1,
                lblCan1Percent
            );

            UpdateCandidateUI(
                "Aslan İsmayıllı",
                pbCan2,
                lblCan2Percent
            );

            UpdateCandidateUI(
                "Sevgi Məmmədova",
                pbCan3,
                lblCan3Percent
            );
        }

        void UpdateCandidateUI(string candidateName, ProgressBar pb, Label lbl)
        {
            var votes = VoteRepository.Votes
                .Where(v => v.Status == VoteStatus.Qebul_Edildi)
                .ToList();

            int total = votes.Count;

            int count = votes.Count(v => v.Candidate == candidateName);

            int percent = total == 0 ? 0 : (count * 100 / total);

            pb.Value = percent;
            lbl.Text = percent + "%";
        }

        public AdminForm()
        {
            InitializeComponent();
        }



        private void ShowPanel(Panel panelToShow)
        {
            panelVoterList.Visible = false;
            panelCandidateStats.Visible = false;
            panelReports.Visible = false;
            panelToShow.Visible = true;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            panelVoterList.Visible = true;
            cmbFilterCandidate.Items.Clear();
            cmbFilterCandidate.Items.Add("All");
            cmbFilterCandidate.Items.Add("Fatimə Bayramova");
            cmbFilterCandidate.Items.Add("Aslan İsmayıllı");
            cmbFilterCandidate.Items.Add("Sevgi Məmmədova");

            cmbFilterCandidate.SelectedIndex = 0;

        }

        private void AdminForm_Shown(object sender, EventArgs e)
        {
            secondsSpent = 0;
            timerSession.Start();

            dgvVoters.DataSource = null;
            dgvVoters.DataSource = VoteRepository.Votes;

        }

        private void btnVoterList_Click(object sender, EventArgs e)
        {
            ShowPanel(panelVoterList);
            dgvVoters.AutoGenerateColumns = false;
            dgvVoters.DataSource = null;
            dgvVoters.DataSource = VoteRepository.Votes;
        }

        private void btnCandidatesStats_Click(object sender, EventArgs e)
        {
            ShowPanel(panelCandidateStats);
            LoadCandidateStats();
        }






        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerSession_Tick(object sender, EventArgs e)
        {
            secondsSpent++;
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerSession.Stop();

            int minutes = secondsSpent / 60;
            int seconds = secondsSpent % 60;

            MessageBox.Show(
                $"Siz Admin panelində {minutes} dəqiqə {seconds} saniyə qaldınız.",
                "Vaxt Məlumatı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        private void dtpFilterDate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dgvVoters_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvVoters.Columns[e.ColumnIndex].Name != "colStatus")
                return;

            if (e.Value == null) return;

            string status = e.Value.ToString();

            if (status == VoteStatus.Qebul_Edildi.ToString())
            {
                e.CellStyle.ForeColor = Color.Green;
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
            }
            else if (status == VoteStatus.Natamam.ToString())
            {
                e.CellStyle.ForeColor = Color.Orange;
            }
            else if (status == VoteStatus.Legv_Edildi.ToString())
            {
                e.CellStyle.ForeColor = Color.Red;
            }
        }

        private void cmbFilterCandidate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterCandidate.SelectedItem == null) return;

            string selected = cmbFilterCandidate.SelectedItem.ToString();

            dgvVoters.DataSource = null;

            if (selected == "All")
                dgvVoters.DataSource = VoteRepository.Votes;
            else
                dgvVoters.DataSource = VoteRepository.Votes
                    .Where(v => v.Candidate == selected)
                    .ToList();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıxmaq istədiyinizə əminsiniz?", "Logout", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 login = new Form1();
                login.Show();

                this.Close();
            }
        }

        private void btnReports_Click_1(object sender, EventArgs e)
        {
            ShowPanel(panelReports);
            LoadFinalReport();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void btnExportTxt_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt";
            sfd.FileName = "sesverme_hesabati.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var validVotes = VoteRepository.Votes
                    .Where(v => v.Status == VoteStatus.Qebul_Edildi)
                    .ToList();

                int totalVotes = validVotes.Count;

                string content = "Səsvermənin Yekun Hesabatı\n";
                content += "--------------------------\n";
                content += $"Tarix: {DateTime.Now:dd.MM.yyyy HH:mm}\n\n";

                if (totalVotes == 0)
                {
                    content += "Heç bir səs qeydə alınmayıb.";
                }
                else
                {
                    var winner = validVotes
                        .GroupBy(v => v.Candidate)
                        .OrderByDescending(g => g.Count())
                        .First();

                    int percent = winner.Count() * 100 / totalVotes;

                    content += $"Qalib namizəd: {winner.Key}\n";
                    content += $"Səs sayı: {winner.Count()}\n";
                    content += $"Qələbə faizi: {percent}%\n";
                    content += $"Ümumi səs: {totalVotes}\n";
                }

                System.IO.File.WriteAllText(sfd.FileName, content);

                MessageBox.Show(
                    "Hesabat uğurla ixrac olundu.",
                    "Export",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}
