namespace IOOP_School_System
{
    partial class TableStudentPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableStudentPage));
            this.TableLabel = new System.Windows.Forms.Label();
            this.FinanceLabel = new System.Windows.Forms.Label();
            this.UpdateLabel = new System.Windows.Forms.Label();
            this.HomeLabel = new System.Windows.Forms.Label();
            this.LogOutLink = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.labelnowhour = new System.Windows.Forms.Label();
            this.labelnowtime = new System.Windows.Forms.Label();
            this.labeltime = new System.Windows.Forms.Label();
            this.dataGridView_schedule = new System.Windows.Forms.DataGridView();
            this.TimeTableLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_schedule)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLabel
            // 
            this.TableLabel.BackColor = System.Drawing.Color.White;
            this.TableLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableLabel.Location = new System.Drawing.Point(0, 268);
            this.TableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(156, 50);
            this.TableLabel.TabIndex = 6;
            this.TableLabel.Text = "Time Table";
            this.TableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TableLabel.Click += new System.EventHandler(this.TableLabel_Click);
            // 
            // FinanceLabel
            // 
            this.FinanceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FinanceLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinanceLabel.Location = new System.Drawing.Point(0, 215);
            this.FinanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FinanceLabel.Name = "FinanceLabel";
            this.FinanceLabel.Size = new System.Drawing.Size(156, 50);
            this.FinanceLabel.TabIndex = 5;
            this.FinanceLabel.Text = "Financials";
            this.FinanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FinanceLabel.Click += new System.EventHandler(this.FinanceLabel_Click);
            // 
            // UpdateLabel
            // 
            this.UpdateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.UpdateLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateLabel.Location = new System.Drawing.Point(0, 162);
            this.UpdateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpdateLabel.Name = "UpdateLabel";
            this.UpdateLabel.Size = new System.Drawing.Size(156, 50);
            this.UpdateLabel.TabIndex = 4;
            this.UpdateLabel.Text = "Update Information";
            this.UpdateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateLabel.Click += new System.EventHandler(this.UpdateLabel_Click);
            // 
            // HomeLabel
            // 
            this.HomeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.HomeLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLabel.Location = new System.Drawing.Point(0, 111);
            this.HomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(156, 49);
            this.HomeLabel.TabIndex = 3;
            this.HomeLabel.Text = "Home";
            this.HomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HomeLabel.Click += new System.EventHandler(this.HomeLabel_Click);
            // 
            // LogOutLink
            // 
            this.LogOutLink.AutoSize = true;
            this.LogOutLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LogOutLink.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutLink.LinkColor = System.Drawing.Color.Transparent;
            this.LogOutLink.Location = new System.Drawing.Point(27, 516);
            this.LogOutLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogOutLink.Name = "LogOutLink";
            this.LogOutLink.Size = new System.Drawing.Size(87, 23);
            this.LogOutLink.TabIndex = 7;
            this.LogOutLink.TabStop = true;
            this.LogOutLink.Text = "Log Out";
            this.LogOutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOutLink_LinkClicked);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label5.Location = new System.Drawing.Point(0, -1);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 556);
            this.label5.TabIndex = 8;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelnowhour
            // 
            this.labelnowhour.AutoSize = true;
            this.labelnowhour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnowhour.Location = new System.Drawing.Point(666, 18);
            this.labelnowhour.Name = "labelnowhour";
            this.labelnowhour.Size = new System.Drawing.Size(60, 23);
            this.labelnowhour.TabIndex = 96;
            this.labelnowhour.Text = "..........";
            // 
            // labelnowtime
            // 
            this.labelnowtime.AutoSize = true;
            this.labelnowtime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnowtime.Location = new System.Drawing.Point(401, 18);
            this.labelnowtime.Name = "labelnowtime";
            this.labelnowtime.Size = new System.Drawing.Size(60, 23);
            this.labelnowtime.TabIndex = 95;
            this.labelnowtime.Text = "..........";
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltime.Location = new System.Drawing.Point(185, 18);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(188, 23);
            this.labeltime.TabIndex = 94;
            this.labeltime.Text = "Date/Time            :";
            // 
            // dataGridView_schedule
            // 
            this.dataGridView_schedule.AllowUserToAddRows = false;
            this.dataGridView_schedule.AllowUserToDeleteRows = false;
            this.dataGridView_schedule.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_schedule.Location = new System.Drawing.Point(187, 111);
            this.dataGridView_schedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_schedule.Name = "dataGridView_schedule";
            this.dataGridView_schedule.ReadOnly = true;
            this.dataGridView_schedule.RowTemplate.Height = 24;
            this.dataGridView_schedule.Size = new System.Drawing.Size(847, 421);
            this.dataGridView_schedule.TabIndex = 93;
            // 
            // TimeTableLabel
            // 
            this.TimeTableLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TimeTableLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeTableLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeTableLabel.Location = new System.Drawing.Point(187, 81);
            this.TimeTableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeTableLabel.Name = "TimeTableLabel";
            this.TimeTableLabel.Size = new System.Drawing.Size(847, 451);
            this.TimeTableLabel.TabIndex = 91;
            this.TimeTableLabel.Text = "Time Table";
            this.TimeTableLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TableStudentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.labelnowhour);
            this.Controls.Add(this.labelnowtime);
            this.Controls.Add(this.labeltime);
            this.Controls.Add(this.dataGridView_schedule);
            this.Controls.Add(this.TimeTableLabel);
            this.Controls.Add(this.TableLabel);
            this.Controls.Add(this.FinanceLabel);
            this.Controls.Add(this.UpdateLabel);
            this.Controls.Add(this.HomeLabel);
            this.Controls.Add(this.LogOutLink);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TableStudentPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APU Tution System";
            this.Load += new System.EventHandler(this.TableStudentPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_schedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.Label FinanceLabel;
        private System.Windows.Forms.Label UpdateLabel;
        private System.Windows.Forms.Label HomeLabel;
        private System.Windows.Forms.LinkLabel LogOutLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelnowhour;
        private System.Windows.Forms.Label labelnowtime;
        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.DataGridView dataGridView_schedule;
        private System.Windows.Forms.Label TimeTableLabel;
    }
}