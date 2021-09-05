namespace IOOP_School_System
{
    partial class CourseStaffPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseStaffPage));
            this.CourseeLabel = new System.Windows.Forms.Label();
            this.idlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.FeePaymentLabel = new System.Windows.Forms.Label();
            this.RegisterStudentLabel = new System.Windows.Forms.Label();
            this.HomeLabel = new System.Windows.Forms.Label();
            this.LogOutLink = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_course = new System.Windows.Forms.ComboBox();
            this.comboBox_id = new System.Windows.Forms.ComboBox();
            this.FeeLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.daylabel = new System.Windows.Forms.Label();
            this.dataGridView_course = new System.Windows.Forms.DataGridView();
            this.selectlabel = new System.Windows.Forms.Label();
            this.button_check = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_fee = new System.Windows.Forms.TextBox();
            this.textBox_day = new System.Windows.Forms.TextBox();
            this.textBox_duration = new System.Windows.Forms.TextBox();
            this.textBox_course = new System.Windows.Forms.TextBox();
            this.textBox_enrollid = new System.Windows.Forms.TextBox();
            this.button_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_course)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseeLabel
            // 
            this.CourseeLabel.AutoSize = true;
            this.CourseeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseeLabel.Location = new System.Drawing.Point(242, 174);
            this.CourseeLabel.Name = "CourseeLabel";
            this.CourseeLabel.Size = new System.Drawing.Size(209, 23);
            this.CourseeLabel.TabIndex = 62;
            this.CourseeLabel.Text = "Course                     :";
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlabel.Location = new System.Drawing.Point(239, 121);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(200, 23);
            this.idlabel.TabIndex = 60;
            this.idlabel.Text = "Student ID              :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Location = new System.Drawing.Point(193, 88);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 2);
            this.panel1.TabIndex = 59;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.White;
            this.WelcomeLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(195, 29);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(479, 47);
            this.WelcomeLabel.TabIndex = 58;
            this.WelcomeLabel.Text = "Choose student course \r\n";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CourseLabel
            // 
            this.CourseLabel.BackColor = System.Drawing.Color.White;
            this.CourseLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseLabel.Location = new System.Drawing.Point(1, 214);
            this.CourseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(156, 50);
            this.CourseLabel.TabIndex = 57;
            this.CourseLabel.Text = "Select Course";
            this.CourseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FeePaymentLabel
            // 
            this.FeePaymentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FeePaymentLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeePaymentLabel.Location = new System.Drawing.Point(0, 267);
            this.FeePaymentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FeePaymentLabel.Name = "FeePaymentLabel";
            this.FeePaymentLabel.Size = new System.Drawing.Size(157, 50);
            this.FeePaymentLabel.TabIndex = 55;
            this.FeePaymentLabel.Text = "Fee Payment";
            this.FeePaymentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FeePaymentLabel.Click += new System.EventHandler(this.FeePaymentLabel_Click);
            // 
            // RegisterStudentLabel
            // 
            this.RegisterStudentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RegisterStudentLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterStudentLabel.Location = new System.Drawing.Point(1, 161);
            this.RegisterStudentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegisterStudentLabel.Name = "RegisterStudentLabel";
            this.RegisterStudentLabel.Size = new System.Drawing.Size(156, 50);
            this.RegisterStudentLabel.TabIndex = 54;
            this.RegisterStudentLabel.Text = "Register Student";
            this.RegisterStudentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegisterStudentLabel.Click += new System.EventHandler(this.RegisterStudentLabel_Click_1);
            // 
            // HomeLabel
            // 
            this.HomeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.HomeLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLabel.Location = new System.Drawing.Point(1, 109);
            this.HomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(156, 49);
            this.HomeLabel.TabIndex = 53;
            this.HomeLabel.Text = "Home";
            this.HomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HomeLabel.Click += new System.EventHandler(this.HomeLabel_Click_1);
            // 
            // LogOutLink
            // 
            this.LogOutLink.AutoSize = true;
            this.LogOutLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LogOutLink.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutLink.LinkColor = System.Drawing.Color.Transparent;
            this.LogOutLink.Location = new System.Drawing.Point(14, 512);
            this.LogOutLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogOutLink.Name = "LogOutLink";
            this.LogOutLink.Size = new System.Drawing.Size(87, 23);
            this.LogOutLink.TabIndex = 52;
            this.LogOutLink.TabStop = true;
            this.LogOutLink.Text = "Log Out";
            this.LogOutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOutLink_LinkClicked);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label5.Location = new System.Drawing.Point(1, -3);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 556);
            this.label5.TabIndex = 56;
            // 
            // comboBox_course
            // 
            this.comboBox_course.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_course.FormattingEnabled = true;
            this.comboBox_course.Location = new System.Drawing.Point(510, 310);
            this.comboBox_course.Name = "comboBox_course";
            this.comboBox_course.Size = new System.Drawing.Size(322, 31);
            this.comboBox_course.TabIndex = 2;
            this.comboBox_course.SelectedIndexChanged += new System.EventHandler(this.comboBox_course_SelectedIndexChanged);
            // 
            // comboBox_id
            // 
            this.comboBox_id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_id.FormattingEnabled = true;
            this.comboBox_id.Location = new System.Drawing.Point(510, 118);
            this.comboBox_id.Name = "comboBox_id";
            this.comboBox_id.Size = new System.Drawing.Size(156, 31);
            this.comboBox_id.TabIndex = 1;
            this.comboBox_id.SelectedIndexChanged += new System.EventHandler(this.comboBox_id_SelectedIndexChanged);
            // 
            // FeeLabel
            // 
            this.FeeLabel.AutoSize = true;
            this.FeeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeeLabel.Location = new System.Drawing.Point(242, 358);
            this.FeeLabel.Name = "FeeLabel";
            this.FeeLabel.Size = new System.Drawing.Size(207, 23);
            this.FeeLabel.TabIndex = 64;
            this.FeeLabel.Text = "Fee                          :";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationLabel.Location = new System.Drawing.Point(239, 440);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(199, 23);
            this.DurationLabel.TabIndex = 65;
            this.DurationLabel.Text = "Duration                 :";
            // 
            // daylabel
            // 
            this.daylabel.AutoSize = true;
            this.daylabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daylabel.Location = new System.Drawing.Point(242, 398);
            this.daylabel.Name = "daylabel";
            this.daylabel.Size = new System.Drawing.Size(205, 23);
            this.daylabel.TabIndex = 66;
            this.daylabel.Text = "Day                         :";
            // 
            // dataGridView_course
            // 
            this.dataGridView_course.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_course.Location = new System.Drawing.Point(510, 174);
            this.dataGridView_course.Name = "dataGridView_course";
            this.dataGridView_course.RowTemplate.Height = 24;
            this.dataGridView_course.Size = new System.Drawing.Size(503, 109);
            this.dataGridView_course.TabIndex = 67;
            this.dataGridView_course.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_course_CellContentClick);
            // 
            // selectlabel
            // 
            this.selectlabel.AutoSize = true;
            this.selectlabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectlabel.Location = new System.Drawing.Point(242, 313);
            this.selectlabel.Name = "selectlabel";
            this.selectlabel.Size = new System.Drawing.Size(192, 23);
            this.selectlabel.TabIndex = 68;
            this.selectlabel.Text = "Select Course       :";
            // 
            // button_check
            // 
            this.button_check.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_check.Location = new System.Drawing.Point(858, 357);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(145, 31);
            this.button_check.TabIndex = 3;
            this.button_check.Text = "Check";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(510, 487);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(345, 48);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "Add Course";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_fee
            // 
            this.textBox_fee.BackColor = System.Drawing.Color.White;
            this.textBox_fee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_fee.Location = new System.Drawing.Point(510, 360);
            this.textBox_fee.Name = "textBox_fee";
            this.textBox_fee.ReadOnly = true;
            this.textBox_fee.Size = new System.Drawing.Size(322, 32);
            this.textBox_fee.TabIndex = 71;
            // 
            // textBox_day
            // 
            this.textBox_day.BackColor = System.Drawing.Color.White;
            this.textBox_day.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_day.Location = new System.Drawing.Point(510, 398);
            this.textBox_day.Name = "textBox_day";
            this.textBox_day.ReadOnly = true;
            this.textBox_day.Size = new System.Drawing.Size(322, 32);
            this.textBox_day.TabIndex = 72;
            // 
            // textBox_duration
            // 
            this.textBox_duration.BackColor = System.Drawing.Color.White;
            this.textBox_duration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_duration.Location = new System.Drawing.Point(510, 436);
            this.textBox_duration.Name = "textBox_duration";
            this.textBox_duration.ReadOnly = true;
            this.textBox_duration.Size = new System.Drawing.Size(322, 32);
            this.textBox_duration.TabIndex = 73;
            // 
            // textBox_course
            // 
            this.textBox_course.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_course.Location = new System.Drawing.Point(858, 310);
            this.textBox_course.Name = "textBox_course";
            this.textBox_course.ReadOnly = true;
            this.textBox_course.Size = new System.Drawing.Size(71, 32);
            this.textBox_course.TabIndex = 74;
            this.textBox_course.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
            // 
            // textBox_enrollid
            // 
            this.textBox_enrollid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_enrollid.Location = new System.Drawing.Point(935, 310);
            this.textBox_enrollid.Name = "textBox_enrollid";
            this.textBox_enrollid.ReadOnly = true;
            this.textBox_enrollid.Size = new System.Drawing.Size(68, 32);
            this.textBox_enrollid.TabIndex = 75;
            this.textBox_enrollid.TextChanged += new System.EventHandler(this.textBox_enrollid_TextChanged);
            // 
            // button_refresh
            // 
            this.button_refresh.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.Location = new System.Drawing.Point(858, 113);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(145, 31);
            this.button_refresh.TabIndex = 5;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // CourseStaffPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.textBox_enrollid);
            this.Controls.Add(this.textBox_course);
            this.Controls.Add(this.textBox_duration);
            this.Controls.Add(this.textBox_day);
            this.Controls.Add(this.textBox_fee);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.selectlabel);
            this.Controls.Add(this.dataGridView_course);
            this.Controls.Add(this.daylabel);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.FeeLabel);
            this.Controls.Add(this.comboBox_course);
            this.Controls.Add(this.CourseeLabel);
            this.Controls.Add(this.comboBox_id);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.FeePaymentLabel);
            this.Controls.Add(this.RegisterStudentLabel);
            this.Controls.Add(this.HomeLabel);
            this.Controls.Add(this.LogOutLink);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CourseStaffPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APU Tution System";
            this.Load += new System.EventHandler(this.CourseStaffPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_course)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CourseeLabel;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.Label FeePaymentLabel;
        private System.Windows.Forms.Label RegisterStudentLabel;
        private System.Windows.Forms.Label HomeLabel;
        private System.Windows.Forms.LinkLabel LogOutLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_course;
        private System.Windows.Forms.ComboBox comboBox_id;
        private System.Windows.Forms.Label FeeLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label daylabel;
        private System.Windows.Forms.DataGridView dataGridView_course;
        private System.Windows.Forms.Label selectlabel;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_fee;
        private System.Windows.Forms.TextBox textBox_day;
        private System.Windows.Forms.TextBox textBox_duration;
        private System.Windows.Forms.TextBox textBox_course;
        private System.Windows.Forms.TextBox textBox_enrollid;
        private System.Windows.Forms.Button button_refresh;
    }
}