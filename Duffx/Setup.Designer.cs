namespace Duffx
{
    partial class Setup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.findDuplicate = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLayers = new System.Windows.Forms.TabPage();
            this.tabPageFilesDirs = new System.Windows.Forms.TabPage();
            this.tabPageFilters = new System.Windows.Forms.TabPage();
            this.tabPageDuplicates = new System.Windows.Forms.TabPage();
            this.tabPageMarkers = new System.Windows.Forms.TabPage();
            this.tabPageProcessors = new System.Windows.Forms.TabPage();
            this.tabPageStatusLog = new System.Windows.Forms.TabPage();
            this.tabPageOptions = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // findDuplicate
            // 
            this.findDuplicate.Location = new System.Drawing.Point(522, 356);
            this.findDuplicate.Name = "findDuplicate";
            this.findDuplicate.Size = new System.Drawing.Size(126, 23);
            this.findDuplicate.TabIndex = 2;
            this.findDuplicate.Text = "Find Duplicates";
            this.findDuplicate.UseVisualStyleBackColor = true;
            this.findDuplicate.Click += new System.EventHandler(this.findDuplicate_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLayers);
            this.tabControl1.Controls.Add(this.tabPageFilesDirs);
            this.tabControl1.Controls.Add(this.tabPageFilters);
            this.tabControl1.Controls.Add(this.tabPageDuplicates);
            this.tabControl1.Controls.Add(this.tabPageMarkers);
            this.tabControl1.Controls.Add(this.tabPageProcessors);
            this.tabControl1.Controls.Add(this.tabPageStatusLog);
            this.tabControl1.Controls.Add(this.tabPageOptions);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(694, 335);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageLayers
            // 
            this.tabPageLayers.Location = new System.Drawing.Point(4, 22);
            this.tabPageLayers.Name = "tabPageLayers";
            this.tabPageLayers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLayers.Size = new System.Drawing.Size(686, 309);
            this.tabPageLayers.TabIndex = 0;
            this.tabPageLayers.Text = "Layers";
            this.tabPageLayers.UseVisualStyleBackColor = true;
            // 
            // tabPageFilesDirs
            // 
            this.tabPageFilesDirs.Location = new System.Drawing.Point(4, 22);
            this.tabPageFilesDirs.Name = "tabPageFilesDirs";
            this.tabPageFilesDirs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFilesDirs.Size = new System.Drawing.Size(686, 309);
            this.tabPageFilesDirs.TabIndex = 1;
            this.tabPageFilesDirs.Text = "Files/dirs";
            this.tabPageFilesDirs.UseVisualStyleBackColor = true;
            // 
            // tabPageFilters
            // 
            this.tabPageFilters.Location = new System.Drawing.Point(4, 22);
            this.tabPageFilters.Name = "tabPageFilters";
            this.tabPageFilters.Size = new System.Drawing.Size(686, 309);
            this.tabPageFilters.TabIndex = 2;
            this.tabPageFilters.Text = "Filters";
            this.tabPageFilters.UseVisualStyleBackColor = true;
            // 
            // tabPageDuplicates
            // 
            this.tabPageDuplicates.Location = new System.Drawing.Point(4, 22);
            this.tabPageDuplicates.Name = "tabPageDuplicates";
            this.tabPageDuplicates.Size = new System.Drawing.Size(686, 309);
            this.tabPageDuplicates.TabIndex = 4;
            this.tabPageDuplicates.Text = "Duplicates";
            this.tabPageDuplicates.UseVisualStyleBackColor = true;
            // 
            // tabPageMarkers
            // 
            this.tabPageMarkers.Location = new System.Drawing.Point(4, 22);
            this.tabPageMarkers.Name = "tabPageMarkers";
            this.tabPageMarkers.Size = new System.Drawing.Size(686, 309);
            this.tabPageMarkers.TabIndex = 5;
            this.tabPageMarkers.Text = "Markers";
            this.tabPageMarkers.UseVisualStyleBackColor = true;
            // 
            // tabPageProcessors
            // 
            this.tabPageProcessors.Location = new System.Drawing.Point(4, 22);
            this.tabPageProcessors.Name = "tabPageProcessors";
            this.tabPageProcessors.Size = new System.Drawing.Size(686, 309);
            this.tabPageProcessors.TabIndex = 6;
            this.tabPageProcessors.Text = "Processors";
            this.tabPageProcessors.UseVisualStyleBackColor = true;
            // 
            // tabPageStatusLog
            // 
            this.tabPageStatusLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageStatusLog.Name = "tabPageStatusLog";
            this.tabPageStatusLog.Size = new System.Drawing.Size(686, 309);
            this.tabPageStatusLog.TabIndex = 7;
            this.tabPageStatusLog.Text = "Status Log";
            this.tabPageStatusLog.UseVisualStyleBackColor = true;
            // 
            // tabPageOptions
            // 
            this.tabPageOptions.Location = new System.Drawing.Point(4, 22);
            this.tabPageOptions.Name = "tabPageOptions";
            this.tabPageOptions.Size = new System.Drawing.Size(686, 309);
            this.tabPageOptions.TabIndex = 3;
            this.tabPageOptions.Text = "Options";
            this.tabPageOptions.UseVisualStyleBackColor = true;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 391);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.findDuplicate);
            this.Name = "Setup";
            this.Text = "DuffX";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button findDuplicate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLayers;
        private System.Windows.Forms.TabPage tabPageFilesDirs;
        private System.Windows.Forms.TabPage tabPageFilters;
        private System.Windows.Forms.TabPage tabPageOptions;
        private System.Windows.Forms.TabPage tabPageDuplicates;
        private System.Windows.Forms.TabPage tabPageMarkers;
        private System.Windows.Forms.TabPage tabPageProcessors;
        private System.Windows.Forms.TabPage tabPageStatusLog;
    }
}

