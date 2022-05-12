namespace Password_Bank
{
    partial class Password_Bank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password_Bank));
            this.lbwelcome = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbwelcome
            // 
            this.lbwelcome.AutoSize = true;
            this.lbwelcome.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbwelcome.Location = new System.Drawing.Point(63, 58);
            this.lbwelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbwelcome.Name = "lbwelcome";
            this.lbwelcome.Size = new System.Drawing.Size(539, 56);
            this.lbwelcome.TabIndex = 0;
            this.lbwelcome.Text = "Welcome to Password Bank!";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("Comic Sans MS", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(246, 211);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(163, 49);
            this.btnSignIn.TabIndex = 1;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.BtnSigninClick);
            // 
            // Password_Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 296);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lbwelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Password_Bank";
            this.Text = "Password Bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbwelcome;
        private System.Windows.Forms.Button btnSignIn;
    }
}

