namespace C__FF
{
    partial class VoterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoterForm));
            lblTitle = new Label();
            lblDate = new Label();
            grpCandidates = new GroupBox();
            pnlCandidate3 = new Panel();
            lblCandidate3Info = new Label();
            picCandidate3 = new PictureBox();
            rbCandidate3 = new RadioButton();
            pnlCandidate2 = new Panel();
            lblCandidate2Info = new Label();
            picCandidate2 = new PictureBox();
            rbCandidate2 = new RadioButton();
            pnlCandidate1 = new Panel();
            lblCandidate1Info = new Label();
            picCandidate1 = new PictureBox();
            rbCandidate1 = new RadioButton();
            lblSelectedCandidate = new Label();
            btnVote = new Button();
            lblVoteStatus = new Label();
            grpRules = new GroupBox();
            lblRules = new Label();
            lblFooter = new Label();
            lblSelectedName = new Label();
            timerSession = new System.Windows.Forms.Timer(components);
            grpCandidates.SuspendLayout();
            pnlCandidate3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCandidate3).BeginInit();
            pnlCandidate2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCandidate2).BeginInit();
            pnlCandidate1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCandidate1).BeginInit();
            grpRules.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(245, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(248, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Səsvermə səhifəsi";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(536, 57);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(112, 20);
            lblDate.TabIndex = 1;
            lblDate.Text = "Səsvermə tarixi:";
            // 
            // grpCandidates
            // 
            grpCandidates.Controls.Add(pnlCandidate3);
            grpCandidates.Controls.Add(rbCandidate3);
            grpCandidates.Controls.Add(pnlCandidate2);
            grpCandidates.Controls.Add(rbCandidate2);
            grpCandidates.Controls.Add(pnlCandidate1);
            grpCandidates.Controls.Add(rbCandidate1);
            grpCandidates.Location = new Point(12, 80);
            grpCandidates.Name = "grpCandidates";
            grpCandidates.Size = new Size(700, 300);
            grpCandidates.TabIndex = 2;
            grpCandidates.TabStop = false;
            grpCandidates.Text = "Namizədlər";
            // 
            // pnlCandidate3
            // 
            pnlCandidate3.BackColor = SystemColors.ScrollBar;
            pnlCandidate3.BorderStyle = BorderStyle.FixedSingle;
            pnlCandidate3.Controls.Add(lblCandidate3Info);
            pnlCandidate3.Controls.Add(picCandidate3);
            pnlCandidate3.Location = new Point(477, 26);
            pnlCandidate3.Name = "pnlCandidate3";
            pnlCandidate3.Size = new Size(200, 230);
            pnlCandidate3.TabIndex = 3;
            // 
            // lblCandidate3Info
            // 
            lblCandidate3Info.ImageAlign = ContentAlignment.BottomRight;
            lblCandidate3Info.Location = new Point(36, 150);
            lblCandidate3Info.Name = "lblCandidate3Info";
            lblCandidate3Info.Size = new Size(138, 71);
            lblCandidate3Info.TabIndex = 4;
            lblCandidate3Info.Text = "Sosial layihələr və \r\naztəminatlı ailələrə dəstək";
            // 
            // picCandidate3
            // 
            picCandidate3.Image = (Image)resources.GetObject("picCandidate3.Image");
            picCandidate3.Location = new Point(36, 17);
            picCandidate3.Name = "picCandidate3";
            picCandidate3.Size = new Size(128, 125);
            picCandidate3.SizeMode = PictureBoxSizeMode.StretchImage;
            picCandidate3.TabIndex = 3;
            picCandidate3.TabStop = false;
            // 
            // rbCandidate3
            // 
            rbCandidate3.AutoSize = true;
            rbCandidate3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbCandidate3.Location = new Point(492, 262);
            rbCandidate3.Name = "rbCandidate3";
            rbCandidate3.Size = new Size(185, 27);
            rbCandidate3.TabIndex = 4;
            rbCandidate3.Text = "Sevgi Məmmədova";
            rbCandidate3.UseVisualStyleBackColor = true;
            rbCandidate3.CheckedChanged += rbCandidate3_CheckedChanged;
            // 
            // pnlCandidate2
            // 
            pnlCandidate2.BackColor = SystemColors.ScrollBar;
            pnlCandidate2.BorderStyle = BorderStyle.FixedSingle;
            pnlCandidate2.Controls.Add(lblCandidate2Info);
            pnlCandidate2.Controls.Add(picCandidate2);
            pnlCandidate2.Location = new Point(247, 26);
            pnlCandidate2.Name = "pnlCandidate2";
            pnlCandidate2.Size = new Size(200, 230);
            pnlCandidate2.TabIndex = 4;
            // 
            // lblCandidate2Info
            // 
            lblCandidate2Info.Location = new Point(19, 149);
            lblCandidate2Info.Name = "lblCandidate2Info";
            lblCandidate2Info.Size = new Size(176, 62);
            lblCandidate2Info.TabIndex = 3;
            lblCandidate2Info.Text = "Sosial rifahın artırılması\r\n                 və \r\nməşğulluq proqramları\r\n";
            // 
            // picCandidate2
            // 
            picCandidate2.Image = Properties.Resources.WhatsApp_Image_2025_12_12_at_21_55_15;
            picCandidate2.Location = new Point(39, 17);
            picCandidate2.Name = "picCandidate2";
            picCandidate2.Size = new Size(117, 125);
            picCandidate2.SizeMode = PictureBoxSizeMode.StretchImage;
            picCandidate2.TabIndex = 4;
            picCandidate2.TabStop = false;
            // 
            // rbCandidate2
            // 
            rbCandidate2.AutoSize = true;
            rbCandidate2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbCandidate2.Location = new Point(287, 262);
            rbCandidate2.Name = "rbCandidate2";
            rbCandidate2.Size = new Size(145, 27);
            rbCandidate2.TabIndex = 3;
            rbCandidate2.Text = "Aslan İsmayıllı";
            rbCandidate2.UseVisualStyleBackColor = true;
            rbCandidate2.CheckedChanged += rbCandidate2_CheckedChanged;
            // 
            // pnlCandidate1
            // 
            pnlCandidate1.BackColor = SystemColors.ScrollBar;
            pnlCandidate1.BorderStyle = BorderStyle.FixedSingle;
            pnlCandidate1.Controls.Add(lblCandidate1Info);
            pnlCandidate1.Controls.Add(picCandidate1);
            pnlCandidate1.Location = new Point(15, 26);
            pnlCandidate1.Name = "pnlCandidate1";
            pnlCandidate1.Size = new Size(200, 230);
            pnlCandidate1.TabIndex = 0;
            // 
            // lblCandidate1Info
            // 
            lblCandidate1Info.Location = new Point(34, 148);
            lblCandidate1Info.Name = "lblCandidate1Info";
            lblCandidate1Info.Size = new Size(139, 72);
            lblCandidate1Info.TabIndex = 3;
            lblCandidate1Info.Text = "Təhsil islahatları\r\n           və \r\ngənclər siyasəti\r\n";
            lblCandidate1Info.Click += lblCandidate1Info_Click;
            // 
            // picCandidate1
            // 
            picCandidate1.Image = Properties.Resources.WhatsApp_Image_2025_12_12_at_21_49_02;
            picCandidate1.Location = new Point(34, 17);
            picCandidate1.Name = "picCandidate1";
            picCandidate1.Size = new Size(126, 125);
            picCandidate1.SizeMode = PictureBoxSizeMode.StretchImage;
            picCandidate1.TabIndex = 3;
            picCandidate1.TabStop = false;
            // 
            // rbCandidate1
            // 
            rbCandidate1.AutoSize = true;
            rbCandidate1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbCandidate1.Location = new Point(36, 262);
            rbCandidate1.Name = "rbCandidate1";
            rbCandidate1.Size = new Size(179, 27);
            rbCandidate1.TabIndex = 3;
            rbCandidate1.Text = "Fatimə Bayramova";
            rbCandidate1.UseVisualStyleBackColor = true;
            rbCandidate1.CheckedChanged += rbCandidate1_CheckedChanged;
            // 
            // lblSelectedCandidate
            // 
            lblSelectedCandidate.AutoSize = true;
            lblSelectedCandidate.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSelectedCandidate.Location = new Point(27, 394);
            lblSelectedCandidate.Name = "lblSelectedCandidate";
            lblSelectedCandidate.Size = new Size(152, 23);
            lblSelectedCandidate.TabIndex = 3;
            lblSelectedCandidate.Text = "Seçdiyiniz namizəd:";
            lblSelectedCandidate.Click += lblSelectedCandidate_Click;
            // 
            // btnVote
            // 
            btnVote.Enabled = false;
            btnVote.Location = new Point(592, 469);
            btnVote.Name = "btnVote";
            btnVote.Size = new Size(120, 40);
            btnVote.TabIndex = 5;
            btnVote.Text = "Səs ver";
            btnVote.UseVisualStyleBackColor = true;
            btnVote.Click += btnVote_Click;
            // 
            // lblVoteStatus
            // 
            lblVoteStatus.Font = new Font("Leelawadee", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblVoteStatus.ForeColor = Color.Green;
            lblVoteStatus.Location = new Point(333, 417);
            lblVoteStatus.Name = "lblVoteStatus";
            lblVoteStatus.Size = new Size(356, 40);
            lblVoteStatus.TabIndex = 6;
            lblVoteStatus.Text = "Səsverməni tamamlamısınız!";
            // 
            // grpRules
            // 
            grpRules.Controls.Add(lblRules);
            grpRules.Location = new Point(27, 443);
            grpRules.Name = "grpRules";
            grpRules.Size = new Size(300, 100);
            grpRules.TabIndex = 7;
            grpRules.TabStop = false;
            grpRules.Text = "Qaydalar";
            // 
            // lblRules
            // 
            lblRules.AutoSize = true;
            lblRules.Location = new Point(6, 36);
            lblRules.Name = "lblRules";
            lblRules.Size = new Size(222, 40);
            lblRules.TabIndex = 8;
            lblRules.Text = "• Yalnız 1 dəfə səs verə bilərsiniz\r\n• Səs geri alına bilməz\r\n";
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFooter.ForeColor = SystemColors.GrayText;
            lblFooter.Location = new Point(481, 526);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(231, 17);
            lblFooter.TabIndex = 9;
            lblFooter.Text = "© 2025 Voting System – C# WinForms";
            // 
            // lblSelectedName
            // 
            lblSelectedName.Location = new Point(185, 397);
            lblSelectedName.Name = "lblSelectedName";
            lblSelectedName.Size = new Size(150, 20);
            lblSelectedName.TabIndex = 10;
            lblSelectedName.Text = " ";
            // 
            // timerSession
            // 
            timerSession.Interval = 1000;
            timerSession.Tick += timerSession_Tick;
            // 
            // VoterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(lblSelectedName);
            Controls.Add(lblFooter);
            Controls.Add(grpRules);
            Controls.Add(lblVoteStatus);
            Controls.Add(btnVote);
            Controls.Add(lblSelectedCandidate);
            Controls.Add(grpCandidates);
            Controls.Add(lblDate);
            Controls.Add(lblTitle);
            Name = "VoterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Voting System";
            FormClosed += VoterForm_FormClosed;
            Load += VoterForm_Load;
            Shown += VoterForm_Shown;
            grpCandidates.ResumeLayout(false);
            grpCandidates.PerformLayout();
            pnlCandidate3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCandidate3).EndInit();
            pnlCandidate2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCandidate2).EndInit();
            pnlCandidate1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCandidate1).EndInit();
            grpRules.ResumeLayout(false);
            grpRules.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDate;
        private GroupBox grpCandidates;
        private Panel pnlCandidate1;
        private Label lblCandidate1Info;
        private RadioButton rbCandidate1;
        private PictureBox picCandidate1;
        private Panel pnlCandidate3;
        private PictureBox picCandidate3;
        private Panel pnlCandidate2;
        private PictureBox picCandidate2;
        private RadioButton rbCandidate3;
        private RadioButton rbCandidate2;
        private Label lblCandidate3Info;
        private Label lblCandidate2Info;
        private Label lblSelectedCandidate;
        private Button btnVote;
        private Label lblVoteStatus;
        private GroupBox grpRules;
        private Label lblRules;
        private Label lblFooter;
        private Label lblSelectedName;
        private System.Windows.Forms.Timer timerSession;
    }
}