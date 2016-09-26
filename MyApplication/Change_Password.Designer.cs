namespace MyApplication
{
    partial class Change_Password
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
            this.Canclebutton = new System.Windows.Forms.Button();
            this.Changebutton = new System.Windows.Forms.Button();
            this.Showusernamelabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordlabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordtextBox = new System.Windows.Forms.TextBox();
            this.OldPasswordlabel = new System.Windows.Forms.Label();
            this.OldPasswordtextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordlabel = new System.Windows.Forms.Label();
            this.NewPasswordtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Canclebutton
            // 
            this.Canclebutton.Location = new System.Drawing.Point(115, 134);
            this.Canclebutton.Name = "Canclebutton";
            this.Canclebutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Canclebutton.Size = new System.Drawing.Size(75, 23);
            this.Canclebutton.TabIndex = 11;
            this.Canclebutton.Text = "&Cancle";
            this.Canclebutton.UseVisualStyleBackColor = true;
            this.Canclebutton.Click += new System.EventHandler(this.CancleButton);
            // 
            // Changebutton
            // 
            this.Changebutton.Location = new System.Drawing.Point(214, 134);
            this.Changebutton.Name = "Changebutton";
            this.Changebutton.Size = new System.Drawing.Size(75, 23);
            this.Changebutton.TabIndex = 10;
            this.Changebutton.Text = "&Change";
            this.Changebutton.UseVisualStyleBackColor = true;
            this.Changebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Showusernamelabel
            // 
            this.Showusernamelabel.AutoSize = true;
            this.Showusernamelabel.Location = new System.Drawing.Point(12, 19);
            this.Showusernamelabel.Name = "Showusernamelabel";
            this.Showusernamelabel.Size = new System.Drawing.Size(19, 13);
            this.Showusernamelabel.TabIndex = 9;
            this.Showusernamelabel.Text = "dd";
            this.Showusernamelabel.Click += new System.EventHandler(this.Showusernamelabel_Click);
            // 
            // ConfirmPasswordlabel
            // 
            this.ConfirmPasswordlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmPasswordlabel.AutoSize = true;
            this.ConfirmPasswordlabel.Location = new System.Drawing.Point(12, 75);
            this.ConfirmPasswordlabel.Name = "ConfirmPasswordlabel";
            this.ConfirmPasswordlabel.Size = new System.Drawing.Size(88, 13);
            this.ConfirmPasswordlabel.TabIndex = 7;
            this.ConfirmPasswordlabel.Text = "&ConfirmPassword";
            // 
            // ConfirmPasswordtextBox
            // 
            this.ConfirmPasswordtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmPasswordtextBox.Location = new System.Drawing.Point(115, 72);
            this.ConfirmPasswordtextBox.Name = "ConfirmPasswordtextBox";
            this.ConfirmPasswordtextBox.Size = new System.Drawing.Size(174, 20);
            this.ConfirmPasswordtextBox.TabIndex = 8;
            // 
            // OldPasswordlabel
            // 
            this.OldPasswordlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OldPasswordlabel.AutoSize = true;
            this.OldPasswordlabel.Location = new System.Drawing.Point(12, 101);
            this.OldPasswordlabel.Name = "OldPasswordlabel";
            this.OldPasswordlabel.Size = new System.Drawing.Size(69, 13);
            this.OldPasswordlabel.TabIndex = 7;
            this.OldPasswordlabel.Text = "&OldPassword";
            // 
            // OldPasswordtextBox
            // 
            this.OldPasswordtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OldPasswordtextBox.Location = new System.Drawing.Point(115, 98);
            this.OldPasswordtextBox.Name = "OldPasswordtextBox";
            this.OldPasswordtextBox.PasswordChar = '*';
            this.OldPasswordtextBox.Size = new System.Drawing.Size(174, 20);
            this.OldPasswordtextBox.TabIndex = 8;
            // 
            // NewPasswordlabel
            // 
            this.NewPasswordlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewPasswordlabel.AutoSize = true;
            this.NewPasswordlabel.Location = new System.Drawing.Point(12, 48);
            this.NewPasswordlabel.Name = "NewPasswordlabel";
            this.NewPasswordlabel.Size = new System.Drawing.Size(75, 13);
            this.NewPasswordlabel.TabIndex = 5;
            this.NewPasswordlabel.Text = "&NewPassword";
            // 
            // NewPasswordtextBox
            // 
            this.NewPasswordtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewPasswordtextBox.Location = new System.Drawing.Point(115, 45);
            this.NewPasswordtextBox.Name = "NewPasswordtextBox";
            this.NewPasswordtextBox.Size = new System.Drawing.Size(174, 20);
            this.NewPasswordtextBox.TabIndex = 6;
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 175);
            this.Controls.Add(this.Canclebutton);
            this.Controls.Add(this.Changebutton);
            this.Controls.Add(this.Showusernamelabel);
            this.Controls.Add(this.ConfirmPasswordlabel);
            this.Controls.Add(this.ConfirmPasswordtextBox);
            this.Controls.Add(this.OldPasswordlabel);
            this.Controls.Add(this.OldPasswordtextBox);
            this.Controls.Add(this.NewPasswordlabel);
            this.Controls.Add(this.NewPasswordtextBox);
            this.Name = "Change_Password";
            this.Text = "Change_Password";
            this.Load += new System.EventHandler(this.Change_Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewPasswordlabel;
        private System.Windows.Forms.TextBox NewPasswordtextBox;
        private System.Windows.Forms.Label OldPasswordlabel;
        private System.Windows.Forms.TextBox OldPasswordtextBox;
        private System.Windows.Forms.TextBox ConfirmPasswordtextBox;
        private System.Windows.Forms.Label ConfirmPasswordlabel;
        private System.Windows.Forms.Label Showusernamelabel;
        private System.Windows.Forms.Button Changebutton;
        private System.Windows.Forms.Button Canclebutton;
    }
}