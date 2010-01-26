namespace Duffx
{
    partial class Layers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonFNSimilar = new System.Windows.Forms.RadioButton();
            this.radioButtonFNequal = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxFileName = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonFNSimilar);
            this.groupBox3.Controls.Add(this.radioButtonFNequal);
            this.groupBox3.Location = new System.Drawing.Point(243, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 197);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Layer Configuration";
            // 
            // radioButtonFNSimilar
            // 
            this.radioButtonFNSimilar.AutoSize = true;
            this.radioButtonFNSimilar.Location = new System.Drawing.Point(6, 42);
            this.radioButtonFNSimilar.Name = "radioButtonFNSimilar";
            this.radioButtonFNSimilar.Size = new System.Drawing.Size(124, 17);
            this.radioButtonFNSimilar.TabIndex = 1;
            this.radioButtonFNSimilar.TabStop = true;
            this.radioButtonFNSimilar.Text = "File names are similar";
            this.radioButtonFNSimilar.UseVisualStyleBackColor = true;
            this.radioButtonFNSimilar.CheckedChanged += new System.EventHandler(this.radioButtonFNSimilar_CheckedChanged);
            // 
            // radioButtonFNequal
            // 
            this.radioButtonFNequal.AutoSize = true;
            this.radioButtonFNequal.Location = new System.Drawing.Point(6, 19);
            this.radioButtonFNequal.Name = "radioButtonFNequal";
            this.radioButtonFNequal.Size = new System.Drawing.Size(119, 17);
            this.radioButtonFNequal.TabIndex = 0;
            this.radioButtonFNequal.TabStop = true;
            this.radioButtonFNequal.Text = "File Name are equal";
            this.radioButtonFNequal.UseVisualStyleBackColor = true;
            this.radioButtonFNequal.CheckedChanged += new System.EventHandler(this.radioButtonFNequal_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(243, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 79);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LayerInfo";
            // 
            // checkBoxFileName
            // 
            this.checkBoxFileName.AutoSize = true;
            this.checkBoxFileName.Location = new System.Drawing.Point(11, 25);
            this.checkBoxFileName.Name = "checkBoxFileName";
            this.checkBoxFileName.Size = new System.Drawing.Size(73, 17);
            this.checkBoxFileName.TabIndex = 0;
            this.checkBoxFileName.Text = "File Name";
            this.checkBoxFileName.UseVisualStyleBackColor = true;
            this.checkBoxFileName.CheckedChanged += new System.EventHandler(this.checkBoxFileName_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxFileName);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 282);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comparison Layers";
            // 
            // Layers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Layers";
            this.Size = new System.Drawing.Size(677, 299);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonFNSimilar;
        private System.Windows.Forms.RadioButton radioButtonFNequal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxFileName;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
