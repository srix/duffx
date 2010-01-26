using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Duffx
{
    public partial class FilesDirs : UserControl
    {
        public FilesDirs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        public ArrayList GetFiles()
        {
            //TODO:Put in background thread
            ArrayList files = CollectFileNames.GetFiles(textBox1.Text);

            return files;
        }
    }
}
