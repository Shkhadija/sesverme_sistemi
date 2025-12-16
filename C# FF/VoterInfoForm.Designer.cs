namespace C__FF
{
    partial class VoterInfoForm
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
            lblInfo = new Label();
            txtFullName = new TextBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(23, 84);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(294, 20);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Zəhmət olmasa ad və soyadınızı daxil edin.";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(23, 132);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(125, 27);
            txtFullName.TabIndex = 1;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(40, 244);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Təsdiqlə";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(279, 244);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Ləğv et";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // VoterInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(txtFullName);
            Controls.Add(lblInfo);
            Name = "VoterInfoForm";
            Text = "Səsvermə Təsdiqi";
            FormClosing += VoterInfoForm_FormClosing;
            Load += VoterInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private TextBox txtFullName;
        private Button btnConfirm;
        private Button btnCancel;
    }
}