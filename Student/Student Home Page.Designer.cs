namespace IOOP_School_System
{
    partial class HomeStudentPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeStudentPage));
            this.LogoutLink = new System.Windows.Forms.LinkLabel();
            this.Homelabel = new System.Windows.Forms.Label();
            this.UpdateLabel = new System.Windows.Forms.Label();
            this.FinanceLabel = new System.Windows.Forms.Label();
            this.TableLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.name2label = new System.Windows.Forms.Label();
            this.welcomeLabel1 = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_contact = new System.Windows.Forms.TextBox();
            this.addresslabel = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.contactlabel = new System.Windows.Forms.Label();
            this.doblabel = new System.Windows.Forms.Label();
            this.textBox_lastname = new System.Windows.Forms.TextBox();
            this.textBox_firstname = new System.Windows.Forms.TextBox();
            this.lastLabel = new System.Windows.Forms.Label();
            this.FirstLabel = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.textBox_StudentID = new System.Windows.Forms.TextBox();
            this.textBox_dob = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.labeldate = new System.Windows.Forms.Label();
            this.textBox_dr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LogoutLink
            // 
            this.LogoutLink.AutoSize = true;
            this.LogoutLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LogoutLink.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLink.LinkColor = System.Drawing.Color.Transparent;
            this.LogoutLink.Location = new System.Drawing.Point(25, 415);
            this.LogoutLink.Name = "LogoutLink";
            this.LogoutLink.Size = new System.Drawing.Size(73, 21);
            this.LogoutLink.TabIndex = 6;
            this.LogoutLink.TabStop = true;
            this.LogoutLink.Text = "Log Out";
            this.LogoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Homelabel
            // 
            this.Homelabel.BackColor = System.Drawing.Color.White;
            this.Homelabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Homelabel.Location = new System.Drawing.Point(0, 90);
            this.Homelabel.Name = "Homelabel";
            this.Homelabel.Size = new System.Drawing.Size(117, 40);
            this.Homelabel.TabIndex = 2;
            this.Homelabel.Text = "Home";
            this.Homelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UpdateLabel
            // 
            this.UpdateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.UpdateLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateLabel.Location = new System.Drawing.Point(0, 132);
            this.UpdateLabel.Name = "UpdateLabel";
            this.UpdateLabel.Size = new System.Drawing.Size(117, 41);
            this.UpdateLabel.TabIndex = 3;
            this.UpdateLabel.Text = "Update Information";
            this.UpdateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateLabel.Click += new System.EventHandler(this.UpdateLabel_Click);
            // 
            // FinanceLabel
            // 
            this.FinanceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FinanceLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinanceLabel.Location = new System.Drawing.Point(0, 176);
            this.FinanceLabel.Name = "FinanceLabel";
            this.FinanceLabel.Size = new System.Drawing.Size(117, 41);
            this.FinanceLabel.TabIndex = 4;
            this.FinanceLabel.Text = "Financials";
            this.FinanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FinanceLabel.Click += new System.EventHandler(this.FinanceLabel_Click);
            // 
            // TableLabel
            // 
            this.TableLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TableLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableLabel.Location = new System.Drawing.Point(0, 219);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(117, 41);
            this.TableLabel.TabIndex = 5;
            this.TableLabel.Text = "Time Table";
            this.TableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TableLabel.Click += new System.EventHandler(this.TableLabel_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Location = new System.Drawing.Point(0, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 452);
            this.label5.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Location = new System.Drawing.Point(158, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 2);
            this.panel1.TabIndex = 1;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.White;
            this.labelWelcome.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(150, 16);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(635, 76);
            this.labelWelcome.TabIndex = 29;
            this.labelWelcome.Text = "Welcome to the School System Software\r\n\r\n";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWelcome.Click += new System.EventHandler(this.labelWelcome_Click);
            // 
            // name2label
            // 
            this.name2label.AutoSize = true;
            this.name2label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name2label.Location = new System.Drawing.Point(226, 83);
            this.name2label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name2label.Name = "name2label";
            this.name2label.Size = new System.Drawing.Size(42, 21);
            this.name2label.TabIndex = 56;
            this.name2label.Text = "User";
            // 
            // welcomeLabel1
            // 
            this.welcomeLabel1.AutoSize = true;
            this.welcomeLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel1.Location = new System.Drawing.Point(141, 83);
            this.welcomeLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel1.Name = "welcomeLabel1";
            this.welcomeLabel1.Size = new System.Drawing.Size(87, 21);
            this.welcomeLabel1.TabIndex = 55;
            this.welcomeLabel1.Text = "Welcome,";
            // 
            // textBox_address
            // 
            this.textBox_address.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_address.Location = new System.Drawing.Point(294, 321);
            this.textBox_address.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.ReadOnly = true;
            this.textBox_address.Size = new System.Drawing.Size(246, 64);
            this.textBox_address.TabIndex = 99;
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(294, 283);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.ReadOnly = true;
            this.textBox_email.Size = new System.Drawing.Size(246, 27);
            this.textBox_email.TabIndex = 98;
            // 
            // textBox_contact
            // 
            this.textBox_contact.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_contact.Location = new System.Drawing.Point(294, 247);
            this.textBox_contact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_contact.Name = "textBox_contact";
            this.textBox_contact.ReadOnly = true;
            this.textBox_contact.Size = new System.Drawing.Size(246, 27);
            this.textBox_contact.TabIndex = 97;
            // 
            // addresslabel
            // 
            this.addresslabel.AutoSize = true;
            this.addresslabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslabel.Location = new System.Drawing.Point(143, 321);
            this.addresslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addresslabel.Name = "addresslabel";
            this.addresslabel.Size = new System.Drawing.Size(144, 21);
            this.addresslabel.TabIndex = 96;
            this.addresslabel.Text = "Address                 :";
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillabel.Location = new System.Drawing.Point(143, 285);
            this.emaillabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(139, 21);
            this.emaillabel.TabIndex = 95;
            this.emaillabel.Text = "Email                     :";
            // 
            // contactlabel
            // 
            this.contactlabel.AutoSize = true;
            this.contactlabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactlabel.Location = new System.Drawing.Point(141, 249);
            this.contactlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contactlabel.Name = "contactlabel";
            this.contactlabel.Size = new System.Drawing.Size(157, 21);
            this.contactlabel.TabIndex = 94;
            this.contactlabel.Text = "Contact Number  :";
            // 
            // doblabel
            // 
            this.doblabel.AutoSize = true;
            this.doblabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doblabel.Location = new System.Drawing.Point(143, 217);
            this.doblabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.doblabel.Name = "doblabel";
            this.doblabel.Size = new System.Drawing.Size(151, 21);
            this.doblabel.TabIndex = 93;
            this.doblabel.Text = "Date of Birth          :";
            // 
            // textBox_lastname
            // 
            this.textBox_lastname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lastname.Location = new System.Drawing.Point(294, 184);
            this.textBox_lastname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_lastname.Name = "textBox_lastname";
            this.textBox_lastname.ReadOnly = true;
            this.textBox_lastname.Size = new System.Drawing.Size(246, 27);
            this.textBox_lastname.TabIndex = 92;
            // 
            // textBox_firstname
            // 
            this.textBox_firstname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_firstname.Location = new System.Drawing.Point(294, 149);
            this.textBox_firstname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_firstname.Name = "textBox_firstname";
            this.textBox_firstname.ReadOnly = true;
            this.textBox_firstname.Size = new System.Drawing.Size(246, 27);
            this.textBox_firstname.TabIndex = 91;
            // 
            // lastLabel
            // 
            this.lastLabel.AutoSize = true;
            this.lastLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastLabel.Location = new System.Drawing.Point(144, 186);
            this.lastLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastLabel.Name = "lastLabel";
            this.lastLabel.Size = new System.Drawing.Size(145, 21);
            this.lastLabel.TabIndex = 89;
            this.lastLabel.Text = "Last Name            :";
            // 
            // FirstLabel
            // 
            this.FirstLabel.AutoSize = true;
            this.FirstLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstLabel.Location = new System.Drawing.Point(143, 151);
            this.FirstLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstLabel.Name = "FirstLabel";
            this.FirstLabel.Size = new System.Drawing.Size(147, 21);
            this.FirstLabel.TabIndex = 88;
            this.FirstLabel.Text = "First Name             :";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.Location = new System.Drawing.Point(143, 120);
            this.labelid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(150, 21);
            this.labelid.TabIndex = 87;
            this.labelid.Text = "Student ID             :";
            // 
            // textBox_StudentID
            // 
            this.textBox_StudentID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_StudentID.Location = new System.Drawing.Point(294, 118);
            this.textBox_StudentID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_StudentID.Name = "textBox_StudentID";
            this.textBox_StudentID.ReadOnly = true;
            this.textBox_StudentID.Size = new System.Drawing.Size(246, 27);
            this.textBox_StudentID.TabIndex = 90;
            // 
            // textBox_dob
            // 
            this.textBox_dob.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_dob.Location = new System.Drawing.Point(294, 214);
            this.textBox_dob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_dob.Name = "textBox_dob";
            this.textBox_dob.ReadOnly = true;
            this.textBox_dob.Size = new System.Drawing.Size(246, 27);
            this.textBox_dob.TabIndex = 100;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(554, 110);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 101;
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldate.Location = new System.Drawing.Point(144, 405);
            this.labeldate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(153, 21);
            this.labeldate.TabIndex = 102;
            this.labeldate.Text = "Date Registered   :";
            // 
            // textBox_dr
            // 
            this.textBox_dr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_dr.Location = new System.Drawing.Point(294, 402);
            this.textBox_dr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_dr.Name = "textBox_dr";
            this.textBox_dr.ReadOnly = true;
            this.textBox_dr.Size = new System.Drawing.Size(246, 27);
            this.textBox_dr.TabIndex = 103;
            // 
            // HomeStudentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_dr);
            this.Controls.Add(this.labeldate);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBox_dob);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_contact);
            this.Controls.Add(this.addresslabel);
            this.Controls.Add(this.emaillabel);
            this.Controls.Add(this.contactlabel);
            this.Controls.Add(this.doblabel);
            this.Controls.Add(this.textBox_lastname);
            this.Controls.Add(this.textBox_firstname);
            this.Controls.Add(this.textBox_StudentID);
            this.Controls.Add(this.lastLabel);
            this.Controls.Add(this.FirstLabel);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.name2label);
            this.Controls.Add(this.welcomeLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.TableLabel);
            this.Controls.Add(this.FinanceLabel);
            this.Controls.Add(this.UpdateLabel);
            this.Controls.Add(this.Homelabel);
            this.Controls.Add(this.LogoutLink);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeStudentPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APU Tution System";
            this.Load += new System.EventHandler(this.HomeStudentPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel LogoutLink;
        private System.Windows.Forms.Label Homelabel;
        private System.Windows.Forms.Label UpdateLabel;
        private System.Windows.Forms.Label FinanceLabel;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label name2label;
        private System.Windows.Forms.Label welcomeLabel1;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_contact;
        private System.Windows.Forms.Label addresslabel;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label contactlabel;
        private System.Windows.Forms.Label doblabel;
        private System.Windows.Forms.TextBox textBox_lastname;
        private System.Windows.Forms.TextBox textBox_firstname;
        private System.Windows.Forms.Label lastLabel;
        private System.Windows.Forms.Label FirstLabel;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.TextBox textBox_StudentID;
        private System.Windows.Forms.TextBox textBox_dob;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.TextBox textBox_dr;
    }
}