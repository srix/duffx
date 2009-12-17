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
    public partial class ResultForm : Form
    {
        ArrayList dupFiles;

        public ResultForm( ArrayList dupFiles)
        {
            this.dupFiles = dupFiles;
            InitializeComponent();

            // Set the view to show details.
            listView1.View = View.Details;

            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;

            // Display check boxes.
            listView1.CheckBoxes = true;

            // Allow the user to rearrange columns.
            listView1.AllowColumnReorder = true;


            //listView1.Columns.Add("?");
            listView1.Columns.Add("Set");
            listView1.Columns.Add("File name");
            listView1.Columns.Add("Location");
            listView1.Columns.Add("File size");
            listView1.Columns.Add("Date Created");
            
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            bool toggleClr = true;
            int GroupCntr = 1;
            foreach (FileMetaData fileMetaData in dupFiles)
            {
                Color bckClr = toggleClr == true ? Color.AliceBlue : Color.AntiqueWhite;
                toggleClr = !toggleClr;

                ListViewItem lvi = new ListViewItem(GroupCntr.ToString());
                lvi.SubItems.Add(fileMetaData.Name);
                lvi.SubItems.Add(fileMetaData.FolderPath);
                lvi.SubItems.Add(fileMetaData.Size.ToString());
                lvi.SubItems.Add(fileMetaData.DateCreated.ToLongTimeString());
                lvi.BackColor = bckClr;
                listView1.Items.Add(lvi);

                foreach (FileMetaData dupfile in fileMetaData.GetDupFiles())
                {
                    ListViewItem lviDup = new ListViewItem(GroupCntr.ToString());

                    lviDup.SubItems.Add(dupfile.Name);
                    lviDup.SubItems.Add(fileMetaData.FolderPath);
                    lviDup.SubItems.Add(fileMetaData.Size.ToString());
                    lviDup.SubItems.Add(fileMetaData.DateCreated.ToLongTimeString());
                    lviDup.BackColor = bckClr;
                    listView1.Items.Add(lviDup);
                }
                GroupCntr++;
            }
        }
    }
}
