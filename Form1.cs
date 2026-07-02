using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fileProperties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string fileLocation = "";
        FileInfo fileInfo;
        private void Form1_Load(object sender, EventArgs e)
        {
            // choose file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                fileLocation = openFileDialog.FileName;
            }
            Icon fileIcon = Icon.ExtractAssociatedIcon(fileLocation);
            //fileInfo
            fileInfo = new FileInfo(fileLocation);

            //show properity

            //path
            textName.Text = Path.GetFileName(fileLocation);
            string mFileType = fileInfo.Extension.Substring(1, fileInfo.Extension.Length - 1);
            textExtension.Text = mFileType.ToUpper() + " File " +"(" + fileInfo.Extension + ")";
            textLocation.Text = fileInfo.DirectoryName;
            textSize.Text = ((Double)fileInfo.Length/1024).ToString("#,###") + " KB" + "(" + fileInfo.Length + " bytes)";
            textCreated.Text = fileInfo.CreationTime.ToString();
            textAccessed.Text = fileInfo.LastAccessTime.ToString();
            textModified.Text = fileInfo.LastWriteTime.ToString();
            Image fileImage = Bitmap.FromHicon(new Icon(fileIcon, new Size(48,48)).Handle);
            mfileIcon.Image = fileImage;
            fileInfo.Attributes.ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkHidden.Checked)
            {
                fileInfo.Attributes = FileAttributes.Hidden;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileIcon_Click(object sender, EventArgs e)
        {

        }
    }
}
