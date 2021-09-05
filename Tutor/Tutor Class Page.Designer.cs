namespace IOOP_School_System
{
    partial class ClassTutorPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassTutorPage));
            this.StudentLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.Homelabel = new System.Windows.Forms.Label();
            this.LogoutLink = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.UpdateClassLabel = new System.Windows.Forms.Label();
            this.CreateClassLabel = new System.Windows.Forms.Label();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.dataGridView_Schedule = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Schedule)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentLabel
            // 
            this.StudentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.StudentLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLabel.Location = new System.Drawing.Point(0, 222);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(117, 41);
            this.StudentLabel.TabIndex = 21;
            this.StudentLabel.Text = "Your Student";
            this.StudentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StudentLabel.Click += new System.EventHandler(this.StudentLabel_Click);
            // 
            // ClassLabel
            // 
            this.ClassLabel.BackColor = System.Drawing.Color.White;
            this.ClassLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClassLabel.Location = new System.Drawing.Point(0, 132);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(117, 40);
            this.ClassLabel.TabIndex = 20;
            this.ClassLabel.Text = "Your Class";
            this.ClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Homelabel
            // 
            this.Homelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Homelabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Homelabel.Location = new System.Drawing.Point(0, 90);
            this.Homelabel.Name = "Homelabel";
            this.Homelabel.Size = new System.Drawing.Size(117, 40);
            this.Homelabel.TabIndex = 19;
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
            this.LogoutLink.Location = new System.Drawing.Point(16, 418);
            this.LogoutLink.Name = "LogoutLink";
            this.LogoutLink.Size = new System.Drawing.Size(73, 21);
            this.LogoutLink.TabIndex = 18;
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
            this.label5.TabIndex = 22;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // UpdateClassLabel
            // 
            this.UpdateClassLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.UpdateClassLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateClassLabel.Location = new System.Drawing.Point(0, 173);
            this.UpdateClassLabel.Name = "UpdateClassLabel";
            this.UpdateClassLabel.Size = new System.Drawing.Size(117, 23);
            this.UpdateClassLabel.TabIndex = 23;
            this.UpdateClassLabel.Text = "Update Class";
            this.UpdateClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateClassLabel.Click += new System.EventHandler(this.UpdateClassLabel_Click);
            // 
            // CreateClassLabel
            // 
            this.CreateClassLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.CreateClassLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateClassLabel.Location = new System.Drawing.Point(0, 197);
            this.CreateClassLabel.Name = "CreateClassLabel";
            this.CreateClassLabel.Size = new System.Drawing.Size(117, 23);
            this.CreateClassLabel.TabIndex = 24;
            this.CreateClassLabel.Text = "Create Class";
            this.CreateClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateClassLabel.Click += new System.EventHandler(this.CreateClassLabel_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayButton.Location = new System.Drawing.Point(433, 43);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(84, 28);
            this.DisplayButton.TabIndex = 2;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click_1);
            // 
            // dataGridView_Schedule
            // 
            this.dataGridView_Schedule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.dataGridView_Schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Schedule.Location = new System.Drawing.Point(136, 90);
            this.dataGridView_Schedule.Name = "dataGridView_Schedule";
            this.dataGridView_Schedule.Size = new System.Drawing.Size(644, 346);
            this.dataGridView_Schedule.TabIndex = 3;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(320, 11);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(315, 27);
            this.dateTimePicker.TabIndex = 1;
            // 
            // ClassTutorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.dataGridView_Schedule);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.CreateClassLabel);
            this.Controls.Add(this.UpdateClassLabel);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.Homelabel);
            this.Controls.Add(this.LogoutLink);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClassTutorPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APU Tution System";
            this.Load += new System.EventHandler(this.ClassTutorPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Schedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Label Homelabel;
        private System.Windows.Forms.LinkLabel LogoutLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label UpdateClassLabel;
        private System.Windows.Forms.Label CreateClassLabel;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.DataGridView dataGridView_Schedule;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}