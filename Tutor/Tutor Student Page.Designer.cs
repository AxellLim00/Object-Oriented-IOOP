namespace IOOP_School_System
{
    partial class StudentTutorPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentTutorPage));
            this.StudentLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.Homelabel = new System.Windows.Forms.Label();
            this.LogoutLink = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_StudentID = new System.Windows.Forms.ComboBox();
            this.comboBox_CourseID = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.dataGridView_StudentInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StudentInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentLabel
            // 
            this.StudentLabel.BackColor = System.Drawing.Color.White;
            this.StudentLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLabel.Location = new System.Drawing.Point(0, 216);
            this.StudentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(156, 50);
            this.StudentLabel.TabIndex = 26;
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
            this.ClassLabel.TabIndex = 25;
            this.ClassLabel.Text = "Your Class";
            this.ClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClassLabel.Click += new System.EventHandler(this.ClassLabel_Click);
            // 
            // Homelabel
            // 
            this.Homelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Homelabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Homelabel.Location = new System.Drawing.Point(0, 111);
            this.Homelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Homelabel.Name = "Homelabel";
            this.Homelabel.Size = new System.Drawing.Size(156, 49);
            this.Homelabel.TabIndex = 24;
            this.Homelabel.Text = "Home";
            this.Homelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Homelabel.Click += new System.EventHandler(this.Homelabel_Click);
            // 
            // LogoutLink
            // 
            this.LogoutLink.AutoSize = true;
            this.LogoutLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LogoutLink.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLink.LinkColor = System.Drawing.Color.Transparent;
            this.LogoutLink.Location = new System.Drawing.Point(22, 514);
            this.LogoutLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogoutLink.Name = "LogoutLink";
            this.LogoutLink.Size = new System.Drawing.Size(87, 23);
            this.LogoutLink.TabIndex = 23;
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
            this.label5.TabIndex = 27;
            // 
            // comboBox_StudentID
            // 
            this.comboBox_StudentID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_StudentID.FormattingEnabled = true;
            this.comboBox_StudentID.Location = new System.Drawing.Point(293, 282);
            this.comboBox_StudentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_StudentID.Name = "comboBox_StudentID";
            this.comboBox_StudentID.Size = new System.Drawing.Size(176, 29);
            this.comboBox_StudentID.TabIndex = 2;
            this.comboBox_StudentID.SelectedIndexChanged += new System.EventHandler(this.comboBox_StudentID_SelectedIndexChanged);
            // 
            // comboBox_CourseID
            // 
            this.comboBox_CourseID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_CourseID.FormattingEnabled = true;
            this.comboBox_CourseID.Location = new System.Drawing.Point(293, 350);
            this.comboBox_CourseID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_CourseID.Name = "comboBox_CourseID";
            this.comboBox_CourseID.Size = new System.Drawing.Size(176, 29);
            this.comboBox_CourseID.TabIndex = 3;
            this.comboBox_CourseID.SelectedIndexChanged += new System.EventHandler(this.comboBox_CourseID_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(218, 178);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Detailed Instruction";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(175, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 117);
            this.label6.TabIndex = 52;
            this.label6.Text = "Search up your \r\nStudent PUBLIC information, \r\nmore detailed information \r\nmustbe" +
    " seen only with \r\nADMIN approval ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Name.Location = new System.Drawing.Point(293, 416);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(175, 28);
            this.textBox_Name.TabIndex = 4;
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(171, 419);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 21);
            this.label7.TabIndex = 50;
            this.label7.Text = "Name        :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 387);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 21);
            this.label3.TabIndex = 49;
            this.label3.Text = "OR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 353);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 48;
            this.label4.Text = "Course ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 319);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 21);
            this.label2.TabIndex = 47;
            this.label2.Text = "OR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 285);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "Student ID :";
            // 
            // DisplayButton
            // 
            this.DisplayButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayButton.Location = new System.Drawing.Point(239, 476);
            this.DisplayButton.Margin = new System.Windows.Forms.Padding(4);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(136, 46);
            this.DisplayButton.TabIndex = 5;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // dataGridView_StudentInfo
            // 
            this.dataGridView_StudentInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.dataGridView_StudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StudentInfo.Location = new System.Drawing.Point(478, 27);
            this.dataGridView_StudentInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_StudentInfo.Name = "dataGridView_StudentInfo";
            this.dataGridView_StudentInfo.Size = new System.Drawing.Size(561, 510);
            this.dataGridView_StudentInfo.TabIndex = 44;
            // 
            // StudentTutorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.comboBox_StudentID);
            this.Controls.Add(this.comboBox_CourseID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.dataGridView_StudentInfo);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.Homelabel);
            this.Controls.Add(this.LogoutLink);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentTutorPage";
            this.Text = "APU Tution System";
            this.Load += new System.EventHandler(this.StudentTutorPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StudentInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Label Homelabel;
        private System.Windows.Forms.LinkLabel LogoutLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_StudentID;
        private System.Windows.Forms.ComboBox comboBox_CourseID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.DataGridView dataGridView_StudentInfo;
    }
}