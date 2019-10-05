namespace EncryptDecryptGUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.groupEncDec = new System.Windows.Forms.GroupBox();
            this.radioEncrypt = new System.Windows.Forms.RadioButton();
            this.radioDecrypt = new System.Windows.Forms.RadioButton();
            this.groupAlgorithm = new System.Windows.Forms.GroupBox();
            this.radioSHA256 = new System.Windows.Forms.RadioButton();
            this.radioMD5 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageTextEncDec = new System.Windows.Forms.TabPage();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupSourceText = new System.Windows.Forms.GroupBox();
            this.txtSource = new EncryptDecryptGUI.CustomTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPasswordText = new System.Windows.Forms.TextBox();
            this.btnGeneratePasswordText = new System.Windows.Forms.Button();
            this.groupTargetText = new System.Windows.Forms.GroupBox();
            this.txtTarget = new EncryptDecryptGUI.CustomTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnCopyClipboard = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.tabPageFileEncDec = new System.Windows.Forms.TabPage();
            this.groupTargetFile = new System.Windows.Forms.GroupBox();
            this.txtTargetFile = new System.Windows.Forms.TextBox();
            this.btnBrowseTargetFile = new System.Windows.Forms.Button();
            this.groupSourceFile = new System.Windows.Forms.GroupBox();
            this.txtSourceFile = new System.Windows.Forms.TextBox();
            this.btnBrowseSourceFile = new System.Windows.Forms.Button();
            this.groupPassword = new System.Windows.Forms.GroupBox();
            this.txtPasswordFile = new System.Windows.Forms.TextBox();
            this.btnGeneratePasswordFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel4.SuspendLayout();
            this.groupEncDec.SuspendLayout();
            this.groupAlgorithm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageTextEncDec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupSourceText.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupTargetText.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPageFileEncDec.SuspendLayout();
            this.groupTargetFile.SuspendLayout();
            this.groupSourceFile.SuspendLayout();
            this.groupPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.CreatePrompt = true;
            this.saveFileDialog.Filter = "Txt files|*.txt";
            this.saveFileDialog.Title = "Save encrypted/decrypted data to file";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnExecute);
            this.panel4.Controls.Add(this.btnClearAll);
            this.panel4.Controls.Add(this.groupEncDec);
            this.panel4.Controls.Add(this.groupAlgorithm);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(790, 74);
            this.panel4.TabIndex = 1;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(342, 40);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(85, 26);
            this.btnExecute.TabIndex = 4;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(342, 8);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(85, 26);
            this.btnClearAll.TabIndex = 2;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // groupEncDec
            // 
            this.groupEncDec.Controls.Add(this.radioEncrypt);
            this.groupEncDec.Controls.Add(this.radioDecrypt);
            this.groupEncDec.Location = new System.Drawing.Point(176, 3);
            this.groupEncDec.Name = "groupEncDec";
            this.groupEncDec.Size = new System.Drawing.Size(160, 63);
            this.groupEncDec.TabIndex = 3;
            this.groupEncDec.TabStop = false;
            this.groupEncDec.Text = "Encrypt/Decrypt";
            // 
            // radioEncrypt
            // 
            this.radioEncrypt.AutoSize = true;
            this.radioEncrypt.Checked = true;
            this.radioEncrypt.Location = new System.Drawing.Point(6, 29);
            this.radioEncrypt.Name = "radioEncrypt";
            this.radioEncrypt.Size = new System.Drawing.Size(61, 17);
            this.radioEncrypt.TabIndex = 1;
            this.radioEncrypt.TabStop = true;
            this.radioEncrypt.Text = "Encrypt";
            this.radioEncrypt.UseVisualStyleBackColor = true;
            // 
            // radioDecrypt
            // 
            this.radioDecrypt.AutoSize = true;
            this.radioDecrypt.Location = new System.Drawing.Point(78, 29);
            this.radioDecrypt.Name = "radioDecrypt";
            this.radioDecrypt.Size = new System.Drawing.Size(62, 17);
            this.radioDecrypt.TabIndex = 0;
            this.radioDecrypt.Text = "Decrypt";
            this.radioDecrypt.UseVisualStyleBackColor = true;
            // 
            // groupAlgorithm
            // 
            this.groupAlgorithm.Controls.Add(this.radioSHA256);
            this.groupAlgorithm.Controls.Add(this.radioMD5);
            this.groupAlgorithm.Location = new System.Drawing.Point(10, 3);
            this.groupAlgorithm.Name = "groupAlgorithm";
            this.groupAlgorithm.Size = new System.Drawing.Size(160, 63);
            this.groupAlgorithm.TabIndex = 2;
            this.groupAlgorithm.TabStop = false;
            this.groupAlgorithm.Text = "Algorithm";
            // 
            // radioSHA256
            // 
            this.radioSHA256.AutoSize = true;
            this.radioSHA256.Location = new System.Drawing.Point(78, 29);
            this.radioSHA256.Name = "radioSHA256";
            this.radioSHA256.Size = new System.Drawing.Size(65, 17);
            this.radioSHA256.TabIndex = 1;
            this.radioSHA256.Text = "SHA256";
            this.radioSHA256.UseVisualStyleBackColor = true;
            // 
            // radioMD5
            // 
            this.radioMD5.AutoSize = true;
            this.radioMD5.Checked = true;
            this.radioMD5.Location = new System.Drawing.Point(6, 29);
            this.radioMD5.Name = "radioMD5";
            this.radioMD5.Size = new System.Drawing.Size(48, 17);
            this.radioMD5.TabIndex = 0;
            this.radioMD5.TabStop = true;
            this.radioMD5.Text = "MD5";
            this.radioMD5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 621);
            this.panel1.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageTextEncDec);
            this.tabControl.Controls.Add(this.tabPageFileEncDec);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(790, 621);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageTextEncDec
            // 
            this.tabPageTextEncDec.Controls.Add(this.splitContainer);
            this.tabPageTextEncDec.Location = new System.Drawing.Point(4, 22);
            this.tabPageTextEncDec.Name = "tabPageTextEncDec";
            this.tabPageTextEncDec.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTextEncDec.Size = new System.Drawing.Size(782, 595);
            this.tabPageTextEncDec.TabIndex = 0;
            this.tabPageTextEncDec.Text = "Text Encryption";
            this.tabPageTextEncDec.UseVisualStyleBackColor = true;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(3, 3);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.AutoScroll = true;
            this.splitContainer.Panel1.Controls.Add(this.groupSourceText);
            this.splitContainer.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.groupTargetText);
            this.splitContainer.Panel2.Controls.Add(this.panel5);
            this.splitContainer.Size = new System.Drawing.Size(776, 589);
            this.splitContainer.SplitterDistance = 388;
            this.splitContainer.TabIndex = 0;
            // 
            // groupSourceText
            // 
            this.groupSourceText.BackColor = System.Drawing.Color.Transparent;
            this.groupSourceText.Controls.Add(this.txtSource);
            this.groupSourceText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSourceText.Location = new System.Drawing.Point(0, 0);
            this.groupSourceText.Name = "groupSourceText";
            this.groupSourceText.Size = new System.Drawing.Size(388, 559);
            this.groupSourceText.TabIndex = 3;
            this.groupSourceText.TabStop = false;
            this.groupSourceText.Text = "Source Text";
            // 
            // txtSource
            // 
            this.txtSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSource.Location = new System.Drawing.Point(3, 16);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSource.Size = new System.Drawing.Size(382, 540);
            this.txtSource.TabIndex = 0;
            this.txtSource.DoubleClick += new System.EventHandler(this.TxtSource_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPasswordText);
            this.panel2.Controls.Add(this.btnGeneratePasswordText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 559);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 30);
            this.panel2.TabIndex = 2;
            // 
            // txtPasswordText
            // 
            this.txtPasswordText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPasswordText.Font = new System.Drawing.Font("Consolas", 13F);
            this.txtPasswordText.Location = new System.Drawing.Point(0, 1);
            this.txtPasswordText.Name = "txtPasswordText";
            this.txtPasswordText.Size = new System.Drawing.Size(275, 28);
            this.txtPasswordText.TabIndex = 1;
            // 
            // btnGeneratePasswordText
            // 
            this.btnGeneratePasswordText.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGeneratePasswordText.Location = new System.Drawing.Point(275, 0);
            this.btnGeneratePasswordText.Name = "btnGeneratePasswordText";
            this.btnGeneratePasswordText.Size = new System.Drawing.Size(113, 30);
            this.btnGeneratePasswordText.TabIndex = 0;
            this.btnGeneratePasswordText.Text = "Generate Password";
            this.btnGeneratePasswordText.UseVisualStyleBackColor = true;
            this.btnGeneratePasswordText.Click += new System.EventHandler(this.BtnGeneratePassword_Click);
            // 
            // groupTargetText
            // 
            this.groupTargetText.Controls.Add(this.txtTarget);
            this.groupTargetText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTargetText.Location = new System.Drawing.Point(0, 0);
            this.groupTargetText.Name = "groupTargetText";
            this.groupTargetText.Size = new System.Drawing.Size(384, 559);
            this.groupTargetText.TabIndex = 1;
            this.groupTargetText.TabStop = false;
            this.groupTargetText.Text = "Target Text";
            // 
            // txtTarget
            // 
            this.txtTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTarget.Location = new System.Drawing.Point(3, 16);
            this.txtTarget.Multiline = true;
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.ReadOnly = true;
            this.txtTarget.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTarget.Size = new System.Drawing.Size(378, 540);
            this.txtTarget.TabIndex = 0;
            this.txtTarget.DoubleClick += new System.EventHandler(this.TxtTarget_DoubleClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAbout);
            this.panel5.Controls.Add(this.btnCopyClipboard);
            this.panel5.Controls.Add(this.btnSaveToFile);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 559);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(384, 30);
            this.panel5.TabIndex = 0;
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAbout.Location = new System.Drawing.Point(147, 0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(30, 30);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "?";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // btnCopyClipboard
            // 
            this.btnCopyClipboard.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCopyClipboard.Location = new System.Drawing.Point(177, 0);
            this.btnCopyClipboard.Name = "btnCopyClipboard";
            this.btnCopyClipboard.Size = new System.Drawing.Size(114, 30);
            this.btnCopyClipboard.TabIndex = 1;
            this.btnCopyClipboard.Text = "Copy to clipboard";
            this.btnCopyClipboard.UseVisualStyleBackColor = true;
            this.btnCopyClipboard.Click += new System.EventHandler(this.BtnCopyClipboard_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSaveToFile.Location = new System.Drawing.Point(291, 0);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(93, 30);
            this.btnSaveToFile.TabIndex = 0;
            this.btnSaveToFile.Text = "Save to file";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.BtnSaveToFile_Click);
            // 
            // tabPageFileEncDec
            // 
            this.tabPageFileEncDec.Controls.Add(this.groupTargetFile);
            this.tabPageFileEncDec.Controls.Add(this.groupSourceFile);
            this.tabPageFileEncDec.Controls.Add(this.groupPassword);
            this.tabPageFileEncDec.Location = new System.Drawing.Point(4, 22);
            this.tabPageFileEncDec.Name = "tabPageFileEncDec";
            this.tabPageFileEncDec.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFileEncDec.Size = new System.Drawing.Size(782, 595);
            this.tabPageFileEncDec.TabIndex = 1;
            this.tabPageFileEncDec.Text = "File Encryption";
            this.tabPageFileEncDec.UseVisualStyleBackColor = true;
            // 
            // groupTargetFile
            // 
            this.groupTargetFile.Controls.Add(this.txtTargetFile);
            this.groupTargetFile.Controls.Add(this.btnBrowseTargetFile);
            this.groupTargetFile.Location = new System.Drawing.Point(6, 114);
            this.groupTargetFile.Name = "groupTargetFile";
            this.groupTargetFile.Size = new System.Drawing.Size(471, 48);
            this.groupTargetFile.TabIndex = 4;
            this.groupTargetFile.TabStop = false;
            this.groupTargetFile.Text = "Target File";
            this.groupTargetFile.Visible = false;
            // 
            // txtTargetFile
            // 
            this.txtTargetFile.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetFile.Location = new System.Drawing.Point(3, 17);
            this.txtTargetFile.Name = "txtTargetFile";
            this.txtTargetFile.Size = new System.Drawing.Size(347, 27);
            this.txtTargetFile.TabIndex = 1;
            // 
            // btnBrowseTargetFile
            // 
            this.btnBrowseTargetFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBrowseTargetFile.Location = new System.Drawing.Point(356, 16);
            this.btnBrowseTargetFile.Name = "btnBrowseTargetFile";
            this.btnBrowseTargetFile.Size = new System.Drawing.Size(112, 29);
            this.btnBrowseTargetFile.TabIndex = 0;
            this.btnBrowseTargetFile.Text = "Browse Target";
            this.btnBrowseTargetFile.UseVisualStyleBackColor = true;
            this.btnBrowseTargetFile.Click += new System.EventHandler(this.BtnBrowseTargetFile_Click);
            // 
            // groupSourceFile
            // 
            this.groupSourceFile.Controls.Add(this.txtSourceFile);
            this.groupSourceFile.Controls.Add(this.btnBrowseSourceFile);
            this.groupSourceFile.Location = new System.Drawing.Point(6, 60);
            this.groupSourceFile.Name = "groupSourceFile";
            this.groupSourceFile.Size = new System.Drawing.Size(471, 48);
            this.groupSourceFile.TabIndex = 3;
            this.groupSourceFile.TabStop = false;
            this.groupSourceFile.Text = "Source File";
            // 
            // txtSourceFile
            // 
            this.txtSourceFile.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceFile.Location = new System.Drawing.Point(3, 17);
            this.txtSourceFile.Name = "txtSourceFile";
            this.txtSourceFile.Size = new System.Drawing.Size(347, 27);
            this.txtSourceFile.TabIndex = 1;
            // 
            // btnBrowseSourceFile
            // 
            this.btnBrowseSourceFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBrowseSourceFile.Location = new System.Drawing.Point(356, 16);
            this.btnBrowseSourceFile.Name = "btnBrowseSourceFile";
            this.btnBrowseSourceFile.Size = new System.Drawing.Size(112, 29);
            this.btnBrowseSourceFile.TabIndex = 0;
            this.btnBrowseSourceFile.Text = "Browse Source";
            this.btnBrowseSourceFile.UseVisualStyleBackColor = true;
            this.btnBrowseSourceFile.Click += new System.EventHandler(this.BtnBrowseSourceFile_Click);
            // 
            // groupPassword
            // 
            this.groupPassword.Controls.Add(this.txtPasswordFile);
            this.groupPassword.Controls.Add(this.btnGeneratePasswordFile);
            this.groupPassword.Location = new System.Drawing.Point(6, 6);
            this.groupPassword.Name = "groupPassword";
            this.groupPassword.Size = new System.Drawing.Size(471, 48);
            this.groupPassword.TabIndex = 2;
            this.groupPassword.TabStop = false;
            this.groupPassword.Text = "Password";
            // 
            // txtPasswordFile
            // 
            this.txtPasswordFile.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordFile.Location = new System.Drawing.Point(3, 17);
            this.txtPasswordFile.Name = "txtPasswordFile";
            this.txtPasswordFile.Size = new System.Drawing.Size(347, 27);
            this.txtPasswordFile.TabIndex = 1;
            // 
            // btnGeneratePasswordFile
            // 
            this.btnGeneratePasswordFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGeneratePasswordFile.Location = new System.Drawing.Point(356, 16);
            this.btnGeneratePasswordFile.Name = "btnGeneratePasswordFile";
            this.btnGeneratePasswordFile.Size = new System.Drawing.Size(112, 29);
            this.btnGeneratePasswordFile.TabIndex = 0;
            this.btnGeneratePasswordFile.Text = "Generate Password";
            this.btnGeneratePasswordFile.UseVisualStyleBackColor = true;
            this.btnGeneratePasswordFile.Click += new System.EventHandler(this.BtnGeneratePasswordFile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 705);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Encryptor/Decryptor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel4.ResumeLayout(false);
            this.groupEncDec.ResumeLayout(false);
            this.groupEncDec.PerformLayout();
            this.groupAlgorithm.ResumeLayout(false);
            this.groupAlgorithm.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageTextEncDec.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.groupSourceText.ResumeLayout(false);
            this.groupSourceText.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupTargetText.ResumeLayout(false);
            this.groupTargetText.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.tabPageFileEncDec.ResumeLayout(false);
            this.groupTargetFile.ResumeLayout(false);
            this.groupTargetFile.PerformLayout();
            this.groupSourceFile.ResumeLayout(false);
            this.groupSourceFile.PerformLayout();
            this.groupPassword.ResumeLayout(false);
            this.groupPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageTextEncDec;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox groupSourceText;
        private CustomTextBox txtSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPasswordText;
        private System.Windows.Forms.Button btnGeneratePasswordText;
        private System.Windows.Forms.GroupBox groupTargetText;
        private CustomTextBox txtTarget;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnCopyClipboard;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.TabPage tabPageFileEncDec;
        private System.Windows.Forms.GroupBox groupTargetFile;
        private System.Windows.Forms.TextBox txtTargetFile;
        private System.Windows.Forms.Button btnBrowseTargetFile;
        private System.Windows.Forms.GroupBox groupSourceFile;
        private System.Windows.Forms.TextBox txtSourceFile;
        private System.Windows.Forms.Button btnBrowseSourceFile;
        private System.Windows.Forms.GroupBox groupPassword;
        private System.Windows.Forms.TextBox txtPasswordFile;
        private System.Windows.Forms.Button btnGeneratePasswordFile;
        private System.Windows.Forms.GroupBox groupEncDec;
        private System.Windows.Forms.RadioButton radioEncrypt;
        private System.Windows.Forms.RadioButton radioDecrypt;
        private System.Windows.Forms.GroupBox groupAlgorithm;
        private System.Windows.Forms.RadioButton radioSHA256;
        private System.Windows.Forms.RadioButton radioMD5;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

