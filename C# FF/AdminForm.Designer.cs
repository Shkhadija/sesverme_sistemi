namespace C__FF
{
    partial class AdminForm
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
            components = new System.ComponentModel.Container();
            lblWelcome = new Label();
            panelNav = new Panel();
            btnLogout = new Button();
            btnReports = new Button();
            btnCandidatesStats = new Button();
            btnVoterList = new Button();
            panelContent = new Panel();
            panelCandidateStats = new Panel();
            dgvCandidates = new DataGridView();
            colCandidateName = new DataGridViewTextBoxColumn();
            colVoteCount = new DataGridViewTextBoxColumn();
            colPercent = new DataGridViewTextBoxColumn();
            pbCan3 = new ProgressBar();
            lblCan1Name = new Label();
            pbCan2 = new ProgressBar();
            lblCan1Percent = new Label();
            pbCan1 = new ProgressBar();
            lblCan2Name = new Label();
            lblCan2Percent = new Label();
            lblCan3Percent = new Label();
            lblCan3Name = new Label();
            panelVoterList = new Panel();
            dgvVoters = new DataGridView();
            colVoterName = new DataGridViewTextBoxColumn();
            colVoteDate = new DataGridViewTextBoxColumn();
            colCandidate = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            cmbFilterCandidate = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            timerSession = new System.Windows.Forms.Timer(components);
            panelReports = new Panel();
            btnExportTxt = new Button();
            lblTotalVotes = new Label();
            lblWinnerPercent = new Label();
            lblWinner = new Label();
            lblReportTitle = new Label();
            panelNav.SuspendLayout();
            panelContent.SuspendLayout();
            panelCandidateStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCandidates).BeginInit();
            panelVoterList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVoters).BeginInit();
            panelReports.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(192, 17);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(159, 20);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Xoş gəlmisiniz, Admin!";
            // 
            // panelNav
            // 
            panelNav.BackColor = SystemColors.ActiveBorder;
            panelNav.Controls.Add(btnLogout);
            panelNav.Controls.Add(btnReports);
            panelNav.Controls.Add(btnCandidatesStats);
            panelNav.Controls.Add(btnVoterList);
            panelNav.Dock = DockStyle.Left;
            panelNav.Location = new Point(0, 0);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(200, 416);
            panelNav.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.CadetBlue;
            btnLogout.Dock = DockStyle.Top;
            btnLogout.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(0, 245);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 80);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.CadetBlue;
            btnReports.Dock = DockStyle.Top;
            btnReports.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.Location = new Point(0, 156);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(200, 89);
            btnReports.TabIndex = 3;
            btnReports.Text = "Reports / Export";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click_1;
            // 
            // btnCandidatesStats
            // 
            btnCandidatesStats.BackColor = Color.CadetBlue;
            btnCandidatesStats.Dock = DockStyle.Top;
            btnCandidatesStats.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCandidatesStats.Location = new Point(0, 74);
            btnCandidatesStats.Name = "btnCandidatesStats";
            btnCandidatesStats.Size = new Size(200, 82);
            btnCandidatesStats.TabIndex = 1;
            btnCandidatesStats.Text = "Candidates Stats";
            btnCandidatesStats.UseVisualStyleBackColor = false;
            btnCandidatesStats.Click += btnCandidatesStats_Click;
            // 
            // btnVoterList
            // 
            btnVoterList.BackColor = Color.CadetBlue;
            btnVoterList.Dock = DockStyle.Top;
            btnVoterList.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoterList.Location = new Point(0, 0);
            btnVoterList.Name = "btnVoterList";
            btnVoterList.Size = new Size(200, 74);
            btnVoterList.TabIndex = 0;
            btnVoterList.Text = "Voter List";
            btnVoterList.UseVisualStyleBackColor = false;
            btnVoterList.Click += btnVoterList_Click;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(panelReports);
            panelContent.Controls.Add(panelCandidateStats);
            panelContent.Controls.Add(panelVoterList);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(200, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(582, 416);
            panelContent.TabIndex = 2;
            // 
            // panelCandidateStats
            // 
            panelCandidateStats.BackColor = SystemColors.ActiveBorder;
            panelCandidateStats.Controls.Add(dgvCandidates);
            panelCandidateStats.Controls.Add(pbCan3);
            panelCandidateStats.Controls.Add(lblCan1Name);
            panelCandidateStats.Controls.Add(pbCan2);
            panelCandidateStats.Controls.Add(lblCan1Percent);
            panelCandidateStats.Controls.Add(pbCan1);
            panelCandidateStats.Controls.Add(lblCan2Name);
            panelCandidateStats.Controls.Add(lblCan2Percent);
            panelCandidateStats.Controls.Add(lblCan3Percent);
            panelCandidateStats.Controls.Add(lblCan3Name);
            panelCandidateStats.Dock = DockStyle.Fill;
            panelCandidateStats.Location = new Point(0, 0);
            panelCandidateStats.Name = "panelCandidateStats";
            panelCandidateStats.Size = new Size(582, 416);
            panelCandidateStats.TabIndex = 16;
            panelCandidateStats.Visible = false;
            // 
            // dgvCandidates
            // 
            dgvCandidates.BackgroundColor = SystemColors.ButtonFace;
            dgvCandidates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCandidates.Columns.AddRange(new DataGridViewColumn[] { colCandidateName, colVoteCount, colPercent });
            dgvCandidates.Location = new Point(38, 17);
            dgvCandidates.Name = "dgvCandidates";
            dgvCandidates.RowHeadersWidth = 51;
            dgvCandidates.Size = new Size(428, 169);
            dgvCandidates.TabIndex = 3;
            // 
            // colCandidateName
            // 
            colCandidateName.DataPropertyName = "Candidate";
            colCandidateName.HeaderText = "Namizəd adı";
            colCandidateName.MinimumWidth = 6;
            colCandidateName.Name = "colCandidateName";
            colCandidateName.ReadOnly = true;
            colCandidateName.Width = 125;
            // 
            // colVoteCount
            // 
            colVoteCount.DataPropertyName = "VoteCount";
            colVoteCount.HeaderText = "Alınan səs sayı";
            colVoteCount.MinimumWidth = 6;
            colVoteCount.Name = "colVoteCount";
            colVoteCount.ReadOnly = true;
            colVoteCount.Width = 125;
            // 
            // colPercent
            // 
            colPercent.DataPropertyName = "Percent";
            colPercent.HeaderText = "Səs faizi (%)";
            colPercent.MinimumWidth = 6;
            colPercent.Name = "colPercent";
            colPercent.ReadOnly = true;
            colPercent.Width = 125;
            // 
            // pbCan3
            // 
            pbCan3.Location = new Point(187, 315);
            pbCan3.Name = "pbCan3";
            pbCan3.Size = new Size(180, 20);
            pbCan3.Style = ProgressBarStyle.Continuous;
            pbCan3.TabIndex = 13;
            // 
            // lblCan1Name
            // 
            lblCan1Name.AutoSize = true;
            lblCan1Name.Location = new Point(38, 211);
            lblCan1Name.Name = "lblCan1Name";
            lblCan1Name.Size = new Size(131, 20);
            lblCan1Name.TabIndex = 5;
            lblCan1Name.Text = "Fatimə Bayramova";
            // 
            // pbCan2
            // 
            pbCan2.Location = new Point(190, 265);
            pbCan2.Name = "pbCan2";
            pbCan2.Size = new Size(180, 20);
            pbCan2.Style = ProgressBarStyle.Continuous;
            pbCan2.TabIndex = 12;
            // 
            // lblCan1Percent
            // 
            lblCan1Percent.AutoSize = true;
            lblCan1Percent.Location = new Point(396, 211);
            lblCan1Percent.Name = "lblCan1Percent";
            lblCan1Percent.Size = new Size(29, 20);
            lblCan1Percent.TabIndex = 7;
            lblCan1Percent.Text = "0%";
            // 
            // pbCan1
            // 
            pbCan1.Location = new Point(191, 211);
            pbCan1.Name = "pbCan1";
            pbCan1.Size = new Size(180, 20);
            pbCan1.Style = ProgressBarStyle.Continuous;
            pbCan1.TabIndex = 6;
            // 
            // lblCan2Name
            // 
            lblCan2Name.AutoSize = true;
            lblCan2Name.Location = new Point(39, 265);
            lblCan2Name.Name = "lblCan2Name";
            lblCan2Name.Size = new Size(103, 20);
            lblCan2Name.TabIndex = 8;
            lblCan2Name.Text = "Aslan İsmayıllı";
            // 
            // lblCan2Percent
            // 
            lblCan2Percent.AutoSize = true;
            lblCan2Percent.Location = new Point(396, 265);
            lblCan2Percent.Name = "lblCan2Percent";
            lblCan2Percent.Size = new Size(29, 20);
            lblCan2Percent.TabIndex = 9;
            lblCan2Percent.Text = "0%";
            // 
            // lblCan3Percent
            // 
            lblCan3Percent.AutoSize = true;
            lblCan3Percent.Location = new Point(396, 315);
            lblCan3Percent.Name = "lblCan3Percent";
            lblCan3Percent.Size = new Size(29, 20);
            lblCan3Percent.TabIndex = 10;
            lblCan3Percent.Text = "0%";
            // 
            // lblCan3Name
            // 
            lblCan3Name.AutoSize = true;
            lblCan3Name.Location = new Point(39, 315);
            lblCan3Name.Name = "lblCan3Name";
            lblCan3Name.Size = new Size(137, 20);
            lblCan3Name.TabIndex = 11;
            lblCan3Name.Text = "Sevgi Məmmədova";
            // 
            // panelVoterList
            // 
            panelVoterList.Controls.Add(dgvVoters);
            panelVoterList.Controls.Add(cmbFilterCandidate);
            panelVoterList.Dock = DockStyle.Fill;
            panelVoterList.Location = new Point(0, 0);
            panelVoterList.Name = "panelVoterList";
            panelVoterList.Size = new Size(582, 416);
            panelVoterList.TabIndex = 14;
            // 
            // dgvVoters
            // 
            dgvVoters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVoters.Columns.AddRange(new DataGridViewColumn[] { colVoterName, colVoteDate, colCandidate, colStatus });
            dgvVoters.Location = new Point(15, 17);
            dgvVoters.Name = "dgvVoters";
            dgvVoters.RowHeadersWidth = 51;
            dgvVoters.Size = new Size(553, 215);
            dgvVoters.TabIndex = 0;
            dgvVoters.CellFormatting += dgvVoters_CellFormatting;
            // 
            // colVoterName
            // 
            colVoterName.DataPropertyName = "FullName";
            colVoterName.HeaderText = "Ad, Soyad";
            colVoterName.MinimumWidth = 6;
            colVoterName.Name = "colVoterName";
            colVoterName.Width = 125;
            // 
            // colVoteDate
            // 
            colVoteDate.DataPropertyName = "VoteDate";
            colVoteDate.HeaderText = "Tarix";
            colVoteDate.MinimumWidth = 6;
            colVoteDate.Name = "colVoteDate";
            colVoteDate.Width = 125;
            // 
            // colCandidate
            // 
            colCandidate.DataPropertyName = "Candidate";
            colCandidate.HeaderText = "Namizəd";
            colCandidate.MinimumWidth = 6;
            colCandidate.Name = "colCandidate";
            colCandidate.ReadOnly = true;
            colCandidate.Width = 125;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status ";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.Width = 125;
            // 
            // cmbFilterCandidate
            // 
            cmbFilterCandidate.FormattingEnabled = true;
            cmbFilterCandidate.Location = new Point(386, 259);
            cmbFilterCandidate.Name = "cmbFilterCandidate";
            cmbFilterCandidate.Size = new Size(182, 28);
            cmbFilterCandidate.TabIndex = 1;
            cmbFilterCandidate.Text = "Namizədə görə filtr";
            cmbFilterCandidate.SelectedIndexChanged += cmbFilterCandidate_SelectedIndexChanged;
            // 
            // timerSession
            // 
            timerSession.Interval = 1000;
            timerSession.Tick += timerSession_Tick;
            // 
            // panelReports
            // 
            panelReports.BackColor = SystemColors.ActiveBorder;
            panelReports.Controls.Add(btnExportTxt);
            panelReports.Controls.Add(lblTotalVotes);
            panelReports.Controls.Add(lblWinnerPercent);
            panelReports.Controls.Add(lblWinner);
            panelReports.Controls.Add(lblReportTitle);
            panelReports.Dock = DockStyle.Fill;
            panelReports.Location = new Point(0, 0);
            panelReports.Name = "panelReports";
            panelReports.Size = new Size(582, 416);
            panelReports.TabIndex = 17;
            panelReports.Visible = false;
            // 
            // btnExportTxt
            // 
            btnExportTxt.BackColor = SystemColors.Control;
            btnExportTxt.Location = new Point(218, 315);
            btnExportTxt.Name = "btnExportTxt";
            btnExportTxt.Size = new Size(264, 62);
            btnExportTxt.TabIndex = 11;
            btnExportTxt.Text = "Nəticəni TXT olaraq ixrac et";
            btnExportTxt.UseVisualStyleBackColor = false;
            btnExportTxt.Click += btnExportTxt_Click_1;
            // 
            // lblTotalVotes
            // 
            lblTotalVotes.AutoSize = true;
            lblTotalVotes.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotalVotes.Location = new Point(29, 211);
            lblTotalVotes.Name = "lblTotalVotes";
            lblTotalVotes.Size = new Size(182, 31);
            lblTotalVotes.TabIndex = 10;
            lblTotalVotes.Text = "Ümumi səs sayı:";
            // 
            // lblWinnerPercent
            // 
            lblWinnerPercent.AutoSize = true;
            lblWinnerPercent.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            lblWinnerPercent.ForeColor = Color.Green;
            lblWinnerPercent.Location = new Point(29, 155);
            lblWinnerPercent.Name = "lblWinnerPercent";
            lblWinnerPercent.Size = new Size(160, 31);
            lblWinnerPercent.TabIndex = 9;
            lblWinnerPercent.Text = "Qələbə faizi: -";
            // 
            // lblWinner
            // 
            lblWinner.AutoSize = true;
            lblWinner.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWinner.Location = new Point(29, 98);
            lblWinner.Name = "lblWinner";
            lblWinner.Size = new Size(187, 31);
            lblWinner.TabIndex = 8;
            lblWinner.Text = "Qalib namizəd: -";
            // 
            // lblReportTitle
            // 
            lblReportTitle.AutoSize = true;
            lblReportTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblReportTitle.Location = new Point(101, 17);
            lblReportTitle.Name = "lblReportTitle";
            lblReportTitle.Size = new Size(381, 38);
            lblReportTitle.TabIndex = 7;
            lblReportTitle.Text = "Səsvermənin yekun nəticəsi";
            lblReportTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 416);
            Controls.Add(panelContent);
            Controls.Add(panelNav);
            Controls.Add(lblWelcome);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            FormClosing += AdminForm_FormClosing;
            Load += AdminForm_Load;
            Shown += AdminForm_Shown;
            panelNav.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelCandidateStats.ResumeLayout(false);
            panelCandidateStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCandidates).EndInit();
            panelVoterList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVoters).EndInit();
            panelReports.ResumeLayout(false);
            panelReports.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Panel panelNav;
        private Button btnLogout;
        private Button btnReports;
        private Button btnCandidatesStats;
        private Button btnVoterList;
        private Panel panelContent;
        private DataGridView dgvVoters;
        private ComboBox cmbFilterCandidate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panelVoterList;
        private System.Windows.Forms.Timer timerSession;
        private DataGridView dgvVotes;
        private DataGridViewTextBoxColumn colVoterName;
        private DataGridViewTextBoxColumn colVoteDate;
        private DataGridViewTextBoxColumn colCandidate;
        private DataGridViewTextBoxColumn colStatus;
        private Panel panelCandidateStats;
        private DataGridView dgvCandidates;
        private ProgressBar pbCan3;
        private Label lblCan1Name;
        private ProgressBar pbCan2;
        private Label lblCan1Percent;
        private ProgressBar pbCan1;
        private Label lblCan2Name;
        private Label lblCan2Percent;
        private Label lblCan3Percent;
        private Label lblCan3Name;
        private DataGridViewTextBoxColumn colCandidateName;
        private DataGridViewTextBoxColumn colVoteCount;
        private DataGridViewTextBoxColumn colPercent;
        private Panel panelReports;
        private Button btnExportTxt;
        private Label lblTotalVotes;
        private Label lblWinnerPercent;
        private Label lblWinner;
        private Label lblReportTitle;
    }
}