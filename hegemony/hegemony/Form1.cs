using System;
using System.IO;
using System.Windows.Forms;

namespace hegemony
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Enter key triggers copy
            this.AcceptButton = btnCopy;
        }

        private void btnFrom_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFrom.Text = openFileDialog.FileName;
            }
        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtTo.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                string sourceFile = txtFrom.Text;

                string destinationFolder = txtTo.Text;

                string fileName = Path.GetFileName(sourceFile);

                string destinationPath = Path.Combine(destinationFolder, fileName);

                File.Copy(sourceFile, destinationPath, true);

                MessageBox.Show(
                    "File copied successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}