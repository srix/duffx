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
    public partial class Duplicates : UserControl
    {
        public Duplicates()
        {
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

        public void ShowDuplicates(ArrayList dupFiles)
        {
            bool toggleClr = true;
            int GroupCntr = 1;
            foreach (FileMetaData curFile in dupFiles)
            {
                Color bckClr = toggleClr == true ? Color.AliceBlue : Color.AntiqueWhite;
                toggleClr = !toggleClr;

                ListViewItem lvi = new ListViewItem(GroupCntr.ToString());
                lvi.SubItems.Add(curFile.Name);
                lvi.SubItems.Add(curFile.FolderPath);
                lvi.SubItems.Add(curFile.Size.ToString());
                lvi.SubItems.Add(curFile.DateCreated.ToLongTimeString());
                lvi.BackColor = bckClr;
                listView1.Items.Add(lvi);

                foreach (FileMetaData dupfile in curFile.GetDupFiles())
                {
                    ListViewItem lviDup = new ListViewItem(GroupCntr.ToString());

                    lviDup.SubItems.Add(dupfile.Name);
                    lviDup.SubItems.Add(dupfile.FolderPath);
                    lviDup.SubItems.Add(dupfile.Size.ToString());
                    lviDup.SubItems.Add(dupfile.DateCreated.ToLongTimeString());
                    lviDup.BackColor = bckClr;
                    listView1.Items.Add(lviDup);
                }
                GroupCntr++;
            }
        }

        public void ClearList()
        {
            listView1.Items.Clear();
        }
    }
}
