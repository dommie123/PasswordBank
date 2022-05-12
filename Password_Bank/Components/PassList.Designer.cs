namespace Password_Bank
{
    partial class PassList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassList));
            this.pList = new System.Windows.Forms.ListView();
            this.btnToggleHide = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbSearchWebsites = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupPasswordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmCopyPaste = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copywebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStrip = cmCopyPaste;
            this.mainMenu.SuspendLayout();
            this.cmCopyPaste.SuspendLayout();
            this.SuspendLayout();
            // 
            // pList
            // 
            this.pList.HideSelection = false;
            this.pList.Location = new System.Drawing.Point(16, 78);
            this.pList.Margin = new System.Windows.Forms.Padding(4);
            this.pList.Name = "pList";
            this.pList.Size = new System.Drawing.Size(556, 453);
            this.pList.TabIndex = 0;
            this.pList.UseCompatibleStateImageBehavior = false;
            this.pList.View = System.Windows.Forms.View.List;
            // 
            // btnToggleHide
            // 
            this.btnToggleHide.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleHide.Location = new System.Drawing.Point(16, 584);
            this.btnToggleHide.Margin = new System.Windows.Forms.Padding(4);
            this.btnToggleHide.Name = "btnToggleHide";
            this.btnToggleHide.Size = new System.Drawing.Size(556, 37);
            this.btnToggleHide.TabIndex = 1;
            this.btnToggleHide.Text = "Hide/Show Passwords";
            this.btnToggleHide.UseVisualStyleBackColor = true;
            this.btnToggleHide.Click += new System.EventHandler(this.BtnToggleHideClick);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(16, 539);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(170, 37);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New Password";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNewPasswordClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(210, 539);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(170, 37);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Password";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdatePasswordClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(402, 539);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 37);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Password";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDeletePassword);
            // 
            // lbSearchWebsites
            // 
            this.lbSearchWebsites.AutoSize = true;
            this.lbSearchWebsites.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchWebsites.Location = new System.Drawing.Point(12, 41);
            this.lbSearchWebsites.Name = "lbSearchWebsites";
            this.lbSearchWebsites.Size = new System.Drawing.Size(130, 19);
            this.lbSearchWebsites.TabIndex = 5;
            this.lbSearchWebsites.Text = "Search Websites: ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(157, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(415, 22);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(590, 28);
            this.mainMenu.TabIndex = 7;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupPasswordsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // backupPasswordsToolStripMenuItem
            // 
            this.backupPasswordsToolStripMenuItem.Name = "backupPasswordsToolStripMenuItem";
            this.backupPasswordsToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.backupPasswordsToolStripMenuItem.Text = "Backup Passwords";
            this.backupPasswordsToolStripMenuItem.Click += new System.EventHandler(this.BackupPasswordsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // cmCopyPaste
            // 
            this.cmCopyPaste.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmCopyPaste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copywebsiteToolStripMenuItem});
            this.cmCopyPaste.Name = "cmCopyPaste";
            this.cmCopyPaste.Size = new System.Drawing.Size(211, 56);
            this.cmCopyPaste.Opening += new System.ComponentModel.CancelEventHandler(this.CmCopyPaste_Opening);
            // 
            // copywebsiteToolStripMenuItem
            // 
            this.copywebsiteToolStripMenuItem.Name = "copywebsiteToolStripMenuItem";
            this.copywebsiteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.copywebsiteToolStripMenuItem.Text = "Copy [website]";
            this.copywebsiteToolStripMenuItem.Click += new System.EventHandler(this.CopyWebsiteToolStripMenuItem_Click);
            // 
            // PassList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 639);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lbSearchWebsites);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnToggleHide);
            this.Controls.Add(this.pList);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PassList";
            this.Text = "Password Bank";
            this.Load += new System.EventHandler(this.PassList_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.cmCopyPaste.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView pList;
        private System.Windows.Forms.Button btnToggleHide;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbSearchWebsites;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupPasswordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmCopyPaste;
        private System.Windows.Forms.ToolStripMenuItem copywebsiteToolStripMenuItem;
    }
}