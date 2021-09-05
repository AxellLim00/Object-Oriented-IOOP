namespace IOOP_School_System
{
    partial class HomeTutorPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeTutorPage));
            this.monthCalendarHome = new System.Windows.Forms.MonthCalendar();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.Homelabel = new System.Windows.Forms.Label();
            this.LogoutLink = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Contact = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendarHome
            // 
            this.monthCalendarHome.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.monthCalendarHome.Location = new System.Drawing.Point(323, 327);
            this.monthCalendarHome.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendarHome.Name = "monthCalendarHome";
            this.monthCalendarHome.TabIndex = 19;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.BackColor = System.Drawing.Color.White;
            this.WelcomeLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(164, 33);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(900, 50);
            this.WelcomeLabel.TabIndex = 18;
            this.WelcomeLabel.Text = "Welcome to the School System Software\r\n\r\n";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WelcomeLabel.Click += new System.EventHandler(this.WelcomeLabel_Click);
            // 
            // StudentLabel
            // 
            this.StudentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.StudentLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLabel.Location = new System.Drawing.Point(0, 216);
            this.StudentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(156, 50);
            this.StudentLabel.TabIndex = 15;
            this.StudentLabel.Text = "Your Student";
            this.StudentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StudentLabel.Click += new System.EventHandler(this.StudentLabel_Click);
            // 
            // ClassLabel
            // 
            this.ClassLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClassLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassLabel.Location = new System.Drawing.Point(0, 163);
            this.ClassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(156, 50);
            this.ClassLabel.TabIndex = 14;
            this.ClassLabel.Text = "Your Class";
            this.ClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClassLabel.Click += new System.EventHandler(this.UpdateLabel_Click);
            // 
            // Homelabel
            // 
            this.Homelabel.BackColor = System.Drawing.Color.White;
            this.Homelabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Homelabel.Location = new System.Drawing.Point(0, 111);
            this.Homelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Homelabel.Name = "Homelabel";
            this.Homelabel.Size = new System.Drawing.Size(156, 49);
            this.Homelabel.TabIndex = 13;
            this.Homelabel.Text = "Home";
            this.Homelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LogoutLink
            // 
            this.LogoutLink.AutoSize = true;
            this.LogoutLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LogoutLink.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLink.LinkColor = System.Drawing.Color.Transparent;
            this.LogoutLink.Location = new System.Drawing.Point(22, 510);
            this.LogoutLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogoutLink.Name = "LogoutLink";
            this.LogoutLink.Size = new System.Drawing.Size(87, 23);
            this.LogoutLink.TabIndex = 12;
            this.LogoutLink.TabStop = true;
            this.LogoutLink.Text = "Log Out";
            this.LogoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label5.Location = new System.Drawing.Point(0, -1);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 556);
            this.label5.TabIndex = 17;
            // 
            // textBox_Contact
            // 
            this.textBox_Contact.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Contact.Location = new System.Drawing.Point(544, 269);
            this.textBox_Contact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Contact.Name = "textBox_Contact";
            this.textBox_Contact.ReadOnly = true;
            this.textBox_Contact.Size = new System.Drawing.Size(336, 32);
            this.textBox_Contact.TabIndex = 35;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.Location = new System.Drawing.Point(544, 230);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.ReadOnly = true;
            this.textBox_Email.Size = new System.Drawing.Size(336, 32);
            this.textBox_Email.TabIndex = 34;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FirstName.Location = new System.Drawing.Point(544, 173);
            this.textBox_FirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.ReadOnly = true;
            this.textBox_FirstName.Size = new System.Drawing.Size(336, 32);
            this.textBox_FirstName.TabIndex = 33;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID.Location = new System.Drawing.Point(544, 133);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(336, 32);
            this.textBox_ID.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Contact Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Email                    :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Full Name            :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "LecturerID            :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Location = new System.Drawing.Point(214, 85);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 2);
            this.panel1.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(237, 327);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "Date :";
            // 
            // HomeTutorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_Contact);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendarHome);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.Homelabel);
            this.Controls.Add(this.LogoutLink);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomeTutorPage";
            this.Text = "APU Tution System";
            this.Load += new System.EventHandler(this.HomeTutorPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendarHome;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Label Homelabel;
        private System.Windows.Forms.LinkLabel LogoutLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Contact;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}