namespace ShareX.UploadersLib.Forms
{
    partial class TheNineGroundsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.username_email_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.username_email_label = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Nine Grounds";
            // 
            // username_email_text
            // 
            this.username_email_text.Location = new System.Drawing.Point(16, 68);
            this.username_email_text.Name = "username_email_text";
            this.username_email_text.Size = new System.Drawing.Size(226, 20);
            this.username_email_text.TabIndex = 1;
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(16, 130);
            this.password_text.Name = "password_text";
            this.password_text.PasswordChar = '*';
            this.password_text.Size = new System.Drawing.Size(226, 20);
            this.password_text.TabIndex = 2;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(12, 107);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(78, 20);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "Password";
            // 
            // username_email_label
            // 
            this.username_email_label.AutoSize = true;
            this.username_email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_email_label.Location = new System.Drawing.Point(12, 45);
            this.username_email_label.Name = "username_email_label";
            this.username_email_label.Size = new System.Drawing.Size(144, 20);
            this.username_email_label.TabIndex = 4;
            this.username_email_label.Text = "Username or Email";
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(16, 170);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(226, 37);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.button_click);
            // 
            // TheNineGroundsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 223);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.username_email_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.username_email_text);
            this.Controls.Add(this.label1);
            this.Name = "TheNineGroundsForm";
            this.Text = "The Nine Grounds Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username_email_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label username_email_label;
        private System.Windows.Forms.Button login_button;
    }
}