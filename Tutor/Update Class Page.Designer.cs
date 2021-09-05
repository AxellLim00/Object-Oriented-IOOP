namespace IOOP_School_System
{
    partial class UpdateClassPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateClassPage));
            this.CreateClassLabel = new System.Windows.Forms.Label();
            this.UpdateClassLabel = new System.Windows.Forms.Label();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.Homelabel = new System.Windows.Forms.Label();
            this.LogoutLink = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.groupBox_step1 = new System.Windows.Forms.GroupBox();
            this.button_DisplayAll = new System.Windows.Forms.Button();
            this.comboBox_CourseID = new System.Windows.Forms.ComboBox();
            this.button_Display = new System.Windows.Forms.Button();
            this.dataGridView_DisplayTable = new System.Windows.Forms.DataGridView();
            this.label_CourseName = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.groupBox_step3 = new System.Windows.Forms.GroupBox();
            this.comboBox_ClassEnd = new System.Windows.Forms.ComboBox();
            this.label_NewEnd = new System.Windows.Forms.Label();
            this.comboBox_ClassStart = new System.Windows.Forms.ComboBox();
            this.label_NewStart = new System.Windows.Forms.Label();
            this.textBox_NewInfo = new System.Windows.Forms.TextBox();
            this.label_NewName = new System.Windows.Forms.Label();
            this.comboBox_Location = new System.Windows.Forms.ComboBox();
            this.label_NewLocation = new System.Windows.Forms.Label();
            this.groupBox_Step2 = new System.Windows.Forms.GroupBox();
            this.radioButton_ClassTime = new System.Windows.Forms.RadioButton();
            this.radioButton_Location = new System.Windows.Forms.RadioButton();
            this.radioButton_CourseName = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox_step1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DisplayTable)).BeginInit();
            this.groupBox_step3.SuspendLayout();
            this.groupBox_Step2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateClassLabel
            // 
            this.CreateClassLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.CreateClassLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateClassLabel.Location = new System.Drawing.Point(0, 197);
            this.CreateClassLabel.Name = "CreateClassLabel";
            this.CreateClassLabel.Size = new System.Drawing.Size(117, 23);
            this.CreateClassLabel.TabIndex = 31;
            this.CreateClassLabel.Text = "Create Class";
            this.CreateClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateClassLabel.Click += new System.EventHandler(this.CreateClassLabel_Click);
            // 
            // UpdateClassLabel
            // 
            this.UpdateClassLabel.BackColor = System.Drawing.Color.White;
            this.UpdateClassLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateClassLabel.Location = new System.Drawing.Point(0, 173);
            this.UpdateClassLabel.Name = "UpdateClassLabel";
            this.UpdateClassLabel.Size = new System.Drawing.Size(117, 23);
            this.UpdateClassLabel.TabIndex = 30;
            this.UpdateClassLabel.Text = "Update Class";
            this.UpdateClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StudentLabel
            // 
            this.StudentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.StudentLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLabel.Location = new System.Drawing.Point(0, 222);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(117, 41);
            this.StudentLabel.TabIndex = 28;
            this.StudentLabel.Text = "Your Student";
            this.StudentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StudentLabel.Click += new System.EventHandler(this.StudentLabel_Click);
            // 
            // ClassLabel
            // 
            this.ClassLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClassLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClassLabel.Location = new System.Drawing.Point(0, 132);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(117, 40);
            this.ClassLabel.TabIndex = 27;
            this.ClassLabel.Text = "Your Class";
            this.ClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClassLabel.Click += new System.EventHandler(this.ClassLabel_Click);
            // 
            // Homelabel
            // 
            this.Homelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Homelabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Homelabel.Location = new System.Drawing.Point(0, 90);
            this.Homelabel.Name = "Homelabel";
            this.Homelabel.Size = new System.Drawing.Size(117, 40);
            this.Homelabel.TabIndex = 26;
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
            this.LogoutLink.Location = new System.Drawing.Point(18, 420);
            this.LogoutLink.Name = "LogoutLink";
            this.LogoutLink.Size = new System.Drawing.Size(73, 21);
            this.LogoutLink.TabIndex = 25;
            this.LogoutLink.TabStop = true;
            this.LogoutLink.Text = "Log Out";
            this.LogoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label5.Location = new System.Drawing.Point(0, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 452);
            this.label5.TabIndex = 29;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(367, 411);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(131, 29);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // groupBox_step1
            // 
            this.groupBox_step1.Controls.Add(this.button_DisplayAll);
            this.groupBox_step1.Controls.Add(this.comboBox_CourseID);
            this.groupBox_step1.Controls.Add(this.button_Display);
            this.groupBox_step1.Controls.Add(this.dataGridView_DisplayTable);
            this.groupBox_step1.Controls.Add(this.label_CourseName);
            this.groupBox_step1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_step1.Location = new System.Drawing.Point(134, 69);
            this.groupBox_step1.Name = "groupBox_step1";
            this.groupBox_step1.Size = new System.Drawing.Size(657, 205);
            this.groupBox_step1.TabIndex = 43;
            this.groupBox_step1.TabStop = false;
            this.groupBox_step1.Text = "Step 1: Choos Course ID";
            // 
            // button_DisplayAll
            // 
            this.button_DisplayAll.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DisplayAll.Location = new System.Drawing.Point(324, 54);
            this.button_DisplayAll.Name = "button_DisplayAll";
            this.button_DisplayAll.Size = new System.Drawing.Size(157, 32);
            this.button_DisplayAll.TabIndex = 3;
            this.button_DisplayAll.Text = "Display All Class Info";
            this.button_DisplayAll.UseVisualStyleBackColor = true;
            this.button_DisplayAll.Click += new System.EventHandler(this.button_DisplayAll_Click);
            // 
            // comboBox_CourseID
            // 
            this.comboBox_CourseID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_CourseID.FormattingEnabled = true;
            this.comboBox_CourseID.Location = new System.Drawing.Point(274, 21);
            this.comboBox_CourseID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_CourseID.Name = "comboBox_CourseID";
            this.comboBox_CourseID.Size = new System.Drawing.Size(188, 27);
            this.comboBox_CourseID.TabIndex = 1;
            this.comboBox_CourseID.SelectedIndexChanged += new System.EventHandler(this.comboBox_CourseID_SelectedIndexChanged);
            // 
            // button_Display
            // 
            this.button_Display.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Display.Location = new System.Drawing.Point(174, 54);
            this.button_Display.Name = "button_Display";
            this.button_Display.Size = new System.Drawing.Size(144, 32);
            this.button_Display.TabIndex = 2;
            this.button_Display.Text = "Display Current Info";
            this.button_Display.UseVisualStyleBackColor = true;
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click);
            // 
            // dataGridView_DisplayTable
            // 
            this.dataGridView_DisplayTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.dataGridView_DisplayTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DisplayTable.Location = new System.Drawing.Point(46, 93);
            this.dataGridView_DisplayTable.Name = "dataGridView_DisplayTable";
            this.dataGridView_DisplayTable.Size = new System.Drawing.Size(585, 90);
            this.dataGridView_DisplayTable.TabIndex = 37;
            // 
            // label_CourseName
            // 
            this.label_CourseName.AutoSize = true;
            this.label_CourseName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CourseName.Location = new System.Drawing.Point(183, 22);
            this.label_CourseName.Name = "label_CourseName";
            this.label_CourseName.Size = new System.Drawing.Size(93, 21);
            this.label_CourseName.TabIndex = 2;
            this.label_CourseName.Text = "Course ID :";
            this.label_CourseName.Click += new System.EventHandler(this.label_CourseName_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(184, 15);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(312, 41);
            this.label_Title.TabIndex = 41;
            this.label_Title.Text = "Update Class Info";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_step3
            // 
            this.groupBox_step3.Controls.Add(this.comboBox_ClassEnd);
            this.groupBox_step3.Controls.Add(this.label_NewEnd);
            this.groupBox_step3.Controls.Add(this.comboBox_ClassStart);
            this.groupBox_step3.Controls.Add(this.label_NewStart);
            this.groupBox_step3.Controls.Add(this.textBox_NewInfo);
            this.groupBox_step3.Controls.Add(this.label_NewName);
            this.groupBox_step3.Controls.Add(this.comboBox_Location);
            this.groupBox_step3.Controls.Add(this.label_NewLocation);
            this.groupBox_step3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_step3.Location = new System.Drawing.Point(426, 280);
            this.groupBox_step3.Name = "groupBox_step3";
            this.groupBox_step3.Size = new System.Drawing.Size(313, 124);
            this.groupBox_step3.TabIndex = 42;
            this.groupBox_step3.TabStop = false;
            this.groupBox_step3.Text = "Step 3: Write the Updated Info";
            // 
            // comboBox_ClassEnd
            // 
            this.comboBox_ClassEnd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ClassEnd.FormattingEnabled = true;
            this.comboBox_ClassEnd.Items.AddRange(new object[] {
            "11:00",
            "11:30",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00"});
            this.comboBox_ClassEnd.Location = new System.Drawing.Point(104, 66);
            this.comboBox_ClassEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_ClassEnd.Name = "comboBox_ClassEnd";
            this.comboBox_ClassEnd.Size = new System.Drawing.Size(188, 27);
            this.comboBox_ClassEnd.TabIndex = 50;
            this.comboBox_ClassEnd.Visible = false;
            this.comboBox_ClassEnd.SelectedIndexChanged += new System.EventHandler(this.comboBox_ClassEnd_SelectedIndexChanged);
            // 
            // label_NewEnd
            // 
            this.label_NewEnd.AutoSize = true;
            this.label_NewEnd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NewEnd.Location = new System.Drawing.Point(14, 71);
            this.label_NewEnd.Name = "label_NewEnd";
            this.label_NewEnd.Size = new System.Drawing.Size(90, 19);
            this.label_NewEnd.TabIndex = 2;
            this.label_NewEnd.Text = "Class End   :";
            this.label_NewEnd.Visible = false;
            // 
            // comboBox_ClassStart
            // 
            this.comboBox_ClassStart.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ClassStart.FormattingEnabled = true;
            this.comboBox_ClassStart.Items.AddRange(new object[] {
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30"});
            this.comboBox_ClassStart.Location = new System.Drawing.Point(104, 29);
            this.comboBox_ClassStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_ClassStart.Name = "comboBox_ClassStart";
            this.comboBox_ClassStart.Size = new System.Drawing.Size(188, 27);
            this.comboBox_ClassStart.TabIndex = 49;
            this.comboBox_ClassStart.Visible = false;
            this.comboBox_ClassStart.SelectedIndexChanged += new System.EventHandler(this.comboBox_ClassStart_SelectedIndexChanged);
            // 
            // label_NewStart
            // 
            this.label_NewStart.AutoSize = true;
            this.label_NewStart.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NewStart.Location = new System.Drawing.Point(12, 35);
            this.label_NewStart.Name = "label_NewStart";
            this.label_NewStart.Size = new System.Drawing.Size(90, 19);
            this.label_NewStart.TabIndex = 0;
            this.label_NewStart.Text = "Class Start  :";
            this.label_NewStart.Visible = false;
            this.label_NewStart.Click += new System.EventHandler(this.label_NewStart_Click);
            // 
            // textBox_NewInfo
            // 
            this.textBox_NewInfo.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NewInfo.Location = new System.Drawing.Point(104, 30);
            this.textBox_NewInfo.Name = "textBox_NewInfo";
            this.textBox_NewInfo.Size = new System.Drawing.Size(188, 28);
            this.textBox_NewInfo.TabIndex = 1;
            // 
            // label_NewName
            // 
            this.label_NewName.AutoSize = true;
            this.label_NewName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NewName.Location = new System.Drawing.Point(14, 32);
            this.label_NewName.Name = "label_NewName";
            this.label_NewName.Size = new System.Drawing.Size(77, 19);
            this.label_NewName.TabIndex = 0;
            this.label_NewName.Text = "New Info :";
            this.label_NewName.Click += new System.EventHandler(this.label_NewName_Click);
            // 
            // comboBox_Location
            // 
            this.comboBox_Location.FormattingEnabled = true;
            this.comboBox_Location.Items.AddRange(new object[] {
            "Room101",
            "Room102",
            "Room103",
            "Room104",
            "Room201",
            "Room202",
            "Room203",
            "Room204",
            "Lab211",
            "Lab212",
            "Lab111",
            "Lab112"});
            this.comboBox_Location.Location = new System.Drawing.Point(104, 24);
            this.comboBox_Location.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_Location.Name = "comboBox_Location";
            this.comboBox_Location.Size = new System.Drawing.Size(188, 27);
            this.comboBox_Location.TabIndex = 2;
            this.comboBox_Location.Visible = false;
            // 
            // label_NewLocation
            // 
            this.label_NewLocation.AutoSize = true;
            this.label_NewLocation.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NewLocation.Location = new System.Drawing.Point(16, 26);
            this.label_NewLocation.Name = "label_NewLocation";
            this.label_NewLocation.Size = new System.Drawing.Size(77, 19);
            this.label_NewLocation.TabIndex = 0;
            this.label_NewLocation.Text = "New Info :";
            this.label_NewLocation.Visible = false;
            this.label_NewLocation.Click += new System.EventHandler(this.label_NewLocation_Click);
            // 
            // groupBox_Step2
            // 
            this.groupBox_Step2.Controls.Add(this.radioButton_ClassTime);
            this.groupBox_Step2.Controls.Add(this.radioButton_Location);
            this.groupBox_Step2.Controls.Add(this.radioButton_CourseName);
            this.groupBox_Step2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Step2.Location = new System.Drawing.Point(162, 280);
            this.groupBox_Step2.Name = "groupBox_Step2";
            this.groupBox_Step2.Size = new System.Drawing.Size(258, 124);
            this.groupBox_Step2.TabIndex = 40;
            this.groupBox_Step2.TabStop = false;
            this.groupBox_Step2.Text = "Step 2: Which Detail to Change";
            // 
            // radioButton_ClassTime
            // 
            this.radioButton_ClassTime.AutoSize = true;
            this.radioButton_ClassTime.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_ClassTime.Location = new System.Drawing.Point(29, 83);
            this.radioButton_ClassTime.Name = "radioButton_ClassTime";
            this.radioButton_ClassTime.Size = new System.Drawing.Size(95, 23);
            this.radioButton_ClassTime.TabIndex = 6;
            this.radioButton_ClassTime.TabStop = true;
            this.radioButton_ClassTime.Text = "Class Time";
            this.radioButton_ClassTime.UseVisualStyleBackColor = true;
            this.radioButton_ClassTime.CheckedChanged += new System.EventHandler(this.radioButton_ClassTime_CheckedChanged);
            // 
            // radioButton_Location
            // 
            this.radioButton_Location.AutoSize = true;
            this.radioButton_Location.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Location.Location = new System.Drawing.Point(29, 54);
            this.radioButton_Location.Name = "radioButton_Location";
            this.radioButton_Location.Size = new System.Drawing.Size(87, 23);
            this.radioButton_Location.TabIndex = 5;
            this.radioButton_Location.TabStop = true;
            this.radioButton_Location.Text = "Location";
            this.radioButton_Location.UseVisualStyleBackColor = true;
            this.radioButton_Location.CheckedChanged += new System.EventHandler(this.radioButton_Location_CheckedChanged);
            // 
            // radioButton_CourseName
            // 
            this.radioButton_CourseName.AutoSize = true;
            this.radioButton_CourseName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_CourseName.Location = new System.Drawing.Point(29, 29);
            this.radioButton_CourseName.Name = "radioButton_CourseName";
            this.radioButton_CourseName.Size = new System.Drawing.Size(120, 23);
            this.radioButton_CourseName.TabIndex = 4;
            this.radioButton_CourseName.TabStop = true;
            this.radioButton_CourseName.Text = "Course Name";
            this.radioButton_CourseName.UseVisualStyleBackColor = true;
            this.radioButton_CourseName.CheckedChanged += new System.EventHandler(this.radioButton_CourseName_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Location = new System.Drawing.Point(171, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 2);
            this.panel1.TabIndex = 45;
            // 
            // UpdateClassPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.groupBox_step1);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.groupBox_step3);
            this.Controls.Add(this.groupBox_Step2);
            this.Controls.Add(this.CreateClassLabel);
            this.Controls.Add(this.UpdateClassLabel);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.Homelabel);
            this.Controls.Add(this.LogoutLink);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateClassPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APU Tution System";
            this.Load += new System.EventHandler(this.UpdateClassPage_Load);
            this.groupBox_step1.ResumeLayout(false);
            this.groupBox_step1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DisplayTable)).EndInit();
            this.groupBox_step3.ResumeLayout(false);
            this.groupBox_step3.PerformLayout();
            this.groupBox_Step2.ResumeLayout(false);
            this.groupBox_Step2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateClassLabel;
        private System.Windows.Forms.Label UpdateClassLabel;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Label Homelabel;
        private System.Windows.Forms.LinkLabel LogoutLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.GroupBox groupBox_step1;
        private System.Windows.Forms.Button button_DisplayAll;
        private System.Windows.Forms.ComboBox comboBox_CourseID;
        private System.Windows.Forms.Button button_Display;
        private System.Windows.Forms.DataGridView dataGridView_DisplayTable;
        private System.Windows.Forms.Label label_CourseName;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.GroupBox groupBox_step3;
        private System.Windows.Forms.ComboBox comboBox_ClassEnd;
        private System.Windows.Forms.Label label_NewEnd;
        private System.Windows.Forms.ComboBox comboBox_ClassStart;
        private System.Windows.Forms.Label label_NewStart;
        private System.Windows.Forms.TextBox textBox_NewInfo;
        private System.Windows.Forms.Label label_NewName;
        private System.Windows.Forms.ComboBox comboBox_Location;
        private System.Windows.Forms.Label label_NewLocation;
        private System.Windows.Forms.GroupBox groupBox_Step2;
        private System.Windows.Forms.RadioButton radioButton_ClassTime;
        private System.Windows.Forms.RadioButton radioButton_Location;
        private System.Windows.Forms.RadioButton radioButton_CourseName;
        private System.Windows.Forms.Panel panel1;
    }
}