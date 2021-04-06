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
            this.pList = new System.Windows.Forms.ListView();
            this.btnToggleHide = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pList
            // 
            this.pList.HideSelection = false;
            this.pList.Location = new System.Drawing.Point(32, 29);
            this.pList.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pList.Name = "pList";
            this.pList.Size = new System.Drawing.Size(1108, 874);
            this.pList.TabIndex = 0;
            this.pList.UseCompatibleStateImageBehavior = false;
            this.pList.View = System.Windows.Forms.View.List;
            // 
            // btnToggleHide
            // 
            this.btnToggleHide.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleHide.Location = new System.Drawing.Point(32, 1069);
            this.btnToggleHide.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnToggleHide.Name = "btnToggleHide";
            this.btnToggleHide.Size = new System.Drawing.Size(1112, 72);
            this.btnToggleHide.TabIndex = 1;
            this.btnToggleHide.Text = "Hide/Show Passwords";
            this.btnToggleHide.UseVisualStyleBackColor = true;
            this.btnToggleHide.Click += new System.EventHandler(this.btnToggleHide_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(29, 945);
            this.btnNew.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(339, 72);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New Password";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(421, 945);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(339, 72);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Password";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(805, 945);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(339, 72);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Password";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // PassList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 1174);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnToggleHide);
            this.Controls.Add(this.pList);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "PassList";
            this.Text = "Password Bank";
            this.Load += new System.EventHandler(this.PassList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView pList;
        private System.Windows.Forms.Button btnToggleHide;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}