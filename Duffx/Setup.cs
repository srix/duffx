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
        Layers layers;
        FilesDirs fileDirs;
        Filters filtersForm;
        Duplicates duplicates;
        Processors processors;

        public Setup()
        {
            InitializeComponent();

            layers = new Layers();
            tabPageLayers.Controls.Add(layers);

            fileDirs = new FilesDirs();
            tabPageFilesDirs.Controls.Add(fileDirs);

            filtersForm = new Filters();
            tabPageFilters.Controls.Add(filtersForm);

            duplicates = new Duplicates();
            tabPageDuplicates.Controls.Add(duplicates);

            processors = new Processors();
            tabPageProcessors.Controls.Add(processors);


        }



        private void findDuplicate_Click(object sender, EventArgs e)
        {
            //TODO: Validate FIle Name

          
            //TODO:Put in background thread
            ArrayList files = fileDirs.GetFiles();

            ArrayList dupFiles = layers.GetduplicateFiles(files);

            duplicates.ClearList();
            duplicates.ShowDuplicates(dupFiles);
            
        }




    }
}
