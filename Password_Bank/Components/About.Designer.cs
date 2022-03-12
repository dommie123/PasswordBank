namespace Password_Bank.Components
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.lbAbout = new System.Windows.Forms.Label();
            this.rtbAbout = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbAbout
            // 
            this.lbAbout.AutoSize = true;
            this.lbAbout.Location = new System.Drawing.Point(73, 264);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(271, 17);
            this.lbAbout.TabIndex = 0;
            this.lbAbout.Text = "Copyright 2021 - 2022; All rights reserved";
            // 
            // rtbAbout
            // 
            this.rtbAbout.Enabled = false;
            this.rtbAbout.Location = new System.Drawing.Point(12, 12);
            this.rtbAbout.Name = "rtbAbout";
            this.rtbAbout.Size = new System.Drawing.Size(392, 249);
            this.rtbAbout.TabIndex = 1;
            this.rtbAbout.Text = resources.GetString("rtbAbout.Text");
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 293);
            this.Controls.Add(this.rtbAbout);
            this.Controls.Add(this.lbAbout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAbout;
        private System.Windows.Forms.RichTextBox rtbAbout;
    }
}