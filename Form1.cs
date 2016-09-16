using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Phopy.Properties;

namespace Phopy
{
    public partial class Phopy_form: Form
    {
        public Phopy_form()
        {
            InitializeComponent();

            // load settings
            from_textbox.Text = Settings.Default.fromPath;
            to_textbox.Text = Settings.Default.toPath;
            filetype_textbox.Text = Settings.Default.filetype;
            overwrite_checkbox.Checked = Settings.Default.overwrite;
        }


        private void go_button_Click(object sender, EventArgs e)
        {
            // get values
            string fromPath = from_textbox.Text;
            string toPath = to_textbox.Text;
            string filetype = filetype_textbox.Text;

            // update settings
            Settings.Default.fromPath = fromPath;
            Settings.Default.toPath = toPath;
            Settings.Default.overwrite = overwrite_checkbox.Checked;
            Settings.Default.filetype = filetype;
            Settings.Default.Save();

            // get file list
            string[] files = Directory.GetFiles(fromPath, filetype);

            int fLength = files.Length;
            float pVal = 100f / fLength;
            //foreach (string f in files)
            for (int i=0;i<fLength;i++)
            {
                // get date of file
                DateTime date = File.GetLastWriteTime(files[i]);
                string dayS = date.Day.ToString();
                if (date.Day < 10) { dayS = ("0" + date.Day.ToString()); }
                string monthS = date.Month.ToString();
                if (date.Month < 10) { monthS = ("0" + date.Month.ToString()); }

                string dateS = (date.Year + "_" + monthS + "_" + dayS);

                // check if folder exists for date
                string dirCheck = (toPath + "\\" + dateS);
                if (!Directory.Exists(dirCheck))
                {
                    Directory.CreateDirectory(dirCheck);
                }
                // strip path from filename
                string fName = files[i].Substring(fromPath.Length + 1);
                // construct filename
                string copyPath = (toPath+"\\"+dateS+"\\"+fName);
                // are we overwriting
                if (overwrite_checkbox.Checked)
                {
                    // we are overwriting so delete existing and then copy
                    if (File.Exists(copyPath))
                    {
                        File.Delete(copyPath);
                    }
                    File.Copy(files[i], copyPath);
                }
                else
                {
                    // we are not overwriting so only copy if it doesn't exist
                    if (!File.Exists(copyPath))
                    {
                        File.Copy(files[i], copyPath);
                    }
                }
                
                progressBar1.Value = (int)((i+1) * pVal);
            }
            progressBar1.Value = 100;
        }

        private void fromChoose_but_Click(object sender, EventArgs e)
        {
            string fromPath = from_textbox.Text;

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = fromPath;

            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                string path = fbd.SelectedPath;
                from_textbox.Text = path;
            }
        }

        private void toChoose_but_Click(object sender, EventArgs e)
        {
            string toPath = to_textbox.Text;

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = toPath;

            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                string path = fbd.SelectedPath;
                to_textbox.Text = path;
            }
        }
    }
}
