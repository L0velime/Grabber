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
        String idKeyString;
        String urlString;
        String newUrlString;
        String trimValue;
        int trimValueInt;
        String trimmedUrl;
        String trimmedID;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void idNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            idKeyString = idNumberTextBox.Text;
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

            int MaxLength = trimValueInt;
            trimmedID = idKeyString;
            if (trimmedID.Length > MaxLength)
                trimmedID = trimmedID.Substring(0, MaxLength);
            string newPrivateId = "file=%2F" + trimmedID + "000%2F" + idKeyString + "%2F" + idKeyString + ".mp4";
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
    }
}
