using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Private_Video_Grabber
{


    public partial class Form1 : Form
    {
        String urlString;
        String newUrlString;
        String trimValue;
        int trimValueInt;
        String trimmedUrl;
        String trimmedID;
        String fullUrlToSplit;
        String videoName;



        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void idNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void publicLabel_Click(object sender, EventArgs e)
        {

        }

        private void publicUrlTextBox_TextChanged(object sender, EventArgs e)
        {
            urlString = publicUrlTextBox.Text;
            int index = urlString.IndexOf("file=");
            if (index > 0)
                trimmedUrl = urlString.Substring(0, index);
            
        }

        private void newPrivateLabel_Click(object sender, EventArgs e)
        {

        }

        private void newPrivateUrlTextBox_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void createUrlButton_Click(object sender, EventArgs e)
        {
            newPrivateUrlTextBox.Clear();
            char delimiter = '/';
            string[] subUrls = fullUrlToSplit.Split(delimiter);
            idNumberTextBox.Clear();
            idNameTextBox.AppendText(subUrls[5]);
            idNumberTextBox.AppendText(subUrls[4]);
            videoName = subUrls[4];
            int MaxLength = trimValueInt;
            trimmedID = subUrls[4];
            if (trimmedID.Length > MaxLength)
                trimmedID = trimmedID.Substring(0, MaxLength);
            string newPrivateId = "file=%2F" + trimmedID + "000%2F" + subUrls[4] + "%2F" + subUrls[4] + ".mp4";
            newUrlString = trimmedUrl + newPrivateId;
            newPrivateUrlTextBox.AppendText(newUrlString);
            Clipboard.SetText(newUrlString);
            



        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            trimValue = Convert.ToString(Math.Round(numericUpDown1.Value, 0));
            trimValueInt = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            
            
        }

        private void copyUrlButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(newUrlString);
        }

        private void idNumberTextBox_Enter(object sender, EventArgs e)
        {
        
        }

        private void idFullUrl_TextChanged(object sender, EventArgs e)
        {
            fullUrlToSplit = idFullUrl.Text;
        }

        private void idNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idFullUrl_Enter(object sender, EventArgs e)
        {
            idFullUrl.Clear();
        }

        private void idNameTextBox_Enter(object sender, EventArgs e)
        {
            if (videoName != null)
            Clipboard.SetText(videoName);
        }
    }
}
