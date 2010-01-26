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
    public partial class Layers : UserControl
    {
        Compare compare = new Compare();
        DelegateCompare dlgCompare;

        public Layers()
        {
            InitializeComponent();
        }

        private void checkBoxFileName_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonFNequal.Checked = true;
            dlgCompare += compare.CompareFileName;
        }

        private void radioButtonFNequal_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)(sender)).Checked == true)
            {
                dlgCompare += compare.CompareFileName;
            }
            else
            {
                dlgCompare -= compare.CompareFileName;
            }
            
        }

        private void radioButtonFNSimilar_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)(sender)).Checked == true)
            {
                dlgCompare += compare.CompareSimilarFileName;
            }
            else
            {
                dlgCompare -= compare.CompareSimilarFileName;
            }
        }

        public ArrayList GetduplicateFiles(ArrayList files)
        {
            return compare.Run(files, dlgCompare);

        }
    }
}
