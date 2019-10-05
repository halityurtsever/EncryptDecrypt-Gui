using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

using TextEncryptDecrypt;

namespace EncryptDecryptGUI
{
    public partial class MainForm : Form
    {
        //################################################################################
        #region Fields

        private EncryptDecryptData m_EncryptDecryptData;

        #endregion

        //################################################################################
        #region Constructor

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        //################################################################################
        #region Form Methods

        #region Common

        private void MainForm_Load(object sender, EventArgs e)
        {
            splitContainer.Panel1MinSize = txtPasswordText.Width +
                                           btnGeneratePasswordText.Width +
                                           30;

            splitContainer.Panel2MinSize = btnAbout.Width +
                                           btnClearAll.Width +
                                           btnCopyClipboard.Width +
                                           btnSaveToFile.Width +
                                           30;

            MinimumSize = new Size(833, 338);
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            m_EncryptDecryptData = new EncryptDecryptData();

            //text encrypt/decrypt tab clear
            txtSource.Text = string.Empty;
            txtTarget.Text = string.Empty;
            txtPasswordText.Text = string.Empty;

            //file encrypt/decrypt tab clear
            txtPasswordFile.Text = string.Empty;
            txtSourceFile.Text = string.Empty;
            txtTargetFile.Text = string.Empty;

            if (tabControl.SelectedIndex == 0)
                txtSource.Focus();
            else
                txtPasswordFile.Focus();
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            var isEncrypt = radioEncrypt.Checked;
            var selectedAlgorithm = radioMD5.Checked ? "MD5" : "SHA256";
            var algorithm = selectedAlgorithm.Equals("MD5") ? HashAlgorithm.MD5 : HashAlgorithm.SHA256;

            try
            {
                if (tabControl.SelectedIndex == 0)
                {
                    TextEncryptDecrypt(algorithm, isEncrypt);
                }
                else
                {
                    FileEncryptDecrypt(algorithm, isEncrypt);
                }
            }
            catch (Exception ex)
            {
                var encryptDecrypt = isEncrypt ? "encrypt" : "decrypt";
                MessageBox.Show($"Text cannot be {encryptDecrypt}ed.\n{ex.Message}\n{ex.StackTrace}",
                    @"Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Text Encrypt/Decrypt

        private void BtnGeneratePassword_Click(object sender, EventArgs e)
        {
            txtPasswordText.Text = GenerateRandomPassword();
        }

        private void BtnSaveToFile_Click(object sender, EventArgs e)
        {
            var stringBuilder = new StringBuilder();
            var messageResult = MessageBox.Show(@"Do you want to append password into the text file",
                @"Append Password?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (messageResult == DialogResult.Yes)
            {
                stringBuilder.AppendLine($"Password: {m_EncryptDecryptData.Password}");
                stringBuilder.AppendLine();
            }

            stringBuilder.AppendLine(m_EncryptDecryptData.TargetText);

            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Filter = @"Txt Files|*.txt";
            var saveResult = saveFileDialog.ShowDialog();

            if (saveResult == DialogResult.OK)
            {
                using (var streamWriter = new StreamWriter(saveFileDialog.OpenFile()))
                {
                    streamWriter.Write(stringBuilder.ToString());
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
        }

        private void BtnCopyClipboard_Click(object sender, EventArgs e)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Password: {m_EncryptDecryptData.Password}");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine(@"Source Data:");
            stringBuilder.AppendLine(m_EncryptDecryptData.SourceText);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine(@"Target Data:");
            stringBuilder.AppendLine(m_EncryptDecryptData.TargetText);

            try
            {
                Clipboard.SetText(stringBuilder.ToString(), TextDataFormat.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(@"Cannot copied to clipboard. Please try again.", @"Error occurred",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            var builder = new StringBuilder();
            builder.AppendLine(@"Coded by Halit Yurtsever");
            builder.AppendLine(@"www.halityurtsever.com");

            var message = builder.ToString();
            var title = "About";
            var boxButtons = MessageBoxButtons.OK;
            var boxIcon = MessageBoxIcon.None;

            MessageBox.Show(message, title, boxButtons, boxIcon);
        }

        private void TxtSource_DoubleClick(object sender, EventArgs e)
        {
            txtSource.SelectAll();
        }

        private void TxtTarget_DoubleClick(object sender, EventArgs e)
        {
            txtTarget.SelectAll();
        }

        #endregion

        #region File Encrypt/Decrypt

        private void BtnGeneratePasswordFile_Click(object sender, EventArgs e)
        {
            txtPasswordFile.Text = GenerateRandomPassword();
        }

        private void BtnBrowseSourceFile_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtSourceFile.Text = openFileDialog.FileName;
            }
        }

        //todo: now target file is invisible. after extend lib, activate this
        private void BtnBrowseTargetFile_Click(object sender, EventArgs e)
        {
            saveFileDialog.CreatePrompt = false;
            saveFileDialog.Filter = @"Encrypt Files|*.encrypt";
            var result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                using (var stream = saveFileDialog.OpenFile())
                {
                    stream.Flush();
                    stream.Close();
                }

                txtTargetFile.Text = saveFileDialog.FileName;
            }
        }

        #endregion

        #endregion

        //################################################################################
        #region Private Members

        private void TextEncryptDecrypt(HashAlgorithm algorithm, bool isEncrypt)
        {
            var sourceText = txtSource.Text;
            var password = txtPasswordText.Text;
            var cipher = new Cipher(algorithm);

            var result = isEncrypt ? cipher.Encrypt(sourceText, password) :
                cipher.Decrypt(sourceText, password);

            txtTarget.Text = result;

            m_EncryptDecryptData.HashAlgorithm = algorithm;
            m_EncryptDecryptData.SourceText = sourceText;
            m_EncryptDecryptData.TargetText = result;
            m_EncryptDecryptData.Password = password;
        }

        private void FileEncryptDecrypt(HashAlgorithm algorithm, bool isEncrypt)
        {
            var sourceFile = txtSourceFile.Text;
            //var targetFile = txtTargetFile.Text;
            var password = txtPasswordFile.Text;

            var cipher = new Cipher(algorithm);

            if (isEncrypt)
            {
                cipher.EncryptFile(sourceFile, password);
            }
            else
            {
                cipher.DecryptFile(sourceFile, password);
            }
        }

        private string GenerateRandomPassword()
        {
            var passwordLength = 22;

            var random = new Random();
            var passwordBytes = new byte[passwordLength];

            for (int i = 0; i < passwordLength; i++)
            {
                passwordBytes[i] = (byte)random.Next(byte.MinValue, byte.MaxValue + 1);
            }

            return Convert.ToBase64String(passwordBytes).Substring(0, passwordLength - 1);
        }

        #endregion
    }
}
