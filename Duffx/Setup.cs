using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;


namespace Duffx
{

    public partial class Setup : Form
    {


        public Setup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void findDuplicate_Click(object sender, EventArgs e)
        {
            //TODO: Validate FIle Name

          
            //TODO:Put in background thread
            ArrayList files = CollectFileNames.GetFiles(textBox1.Text);

            Compare compare = new Compare();
//            DelegateCompare dlgCompareFileName = compare.CompareFileName;
            DelegateCompare dlgCompareFileName = compare.CompareSimilarFileName;
            ArrayList dupFiles = compare.Run(files, dlgCompareFileName);

            ResultForm resForm = new ResultForm(dupFiles);
            resForm.ShowDialog();

            
        }

        


    }
}
