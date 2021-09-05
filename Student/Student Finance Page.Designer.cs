namespace IOOP_School_System
{
    partial class FinanceStudentPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinanceStudentPage));
            this.TableLabel = new System.Windows.Forms.Label();
            this.FinanceLabel = new System.Windows.Forms.Label();
            this.UpdateLabel = new System.Windows.Forms.Label();
            this.HomeLabel = new System.Windows.Forms.Label();
            this.LogOutLink = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labeltitle = new System.Windows.Forms.Label();
            this.dataGridView_fee = new System.Windows.Forms.DataGridView();
            this.FinanceInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fee)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLabel
            // 
            this.TableLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TableLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.FinanceLabel.BackColor = System.Drawing.Color.White;
            this.FinanceLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinanceLabel.Location = new System.Drawing.Point(0, 215);
            this.FinanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FinanceLabel.Name = "FinanceLabel";
            this.FinanceLabel.Size = new System.Drawing.Size(156, 50);
            this.FinanceLabel.TabIndex = 5;
            this.FinanceLabel.Text = "Financials";
            this.FinanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UpdateLabel
            // 
            this.UpdateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.UpdateLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateLabel.Location = new System.Drawing.Point(-7, 162);
            this.UpdateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpdateLabel.Name = "UpdateLabel";
            this.UpdateLabel.Size = new System.Drawing.Size(163, 50);
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
            this.LogOutLink.Location = new System.Drawing.Point(27, 518);
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Location = new System.Drawing.Point(197, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 2);
            this.panel1.TabIndex = 31;
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.BackColor = System.Drawing.Color.White;
            this.labeltitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.Location = new System.Drawing.Point(189, 32);
            this.labeltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(215, 188);
            this.labeltitle.TabIndex = 33;
            this.labeltitle.Text = "Tution Fee\r\n\r\n\r\n ";
            this.labeltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView_fee
            // 
            this.dataGridView_fee.AllowUserToDeleteRows = false;
            this.dataGridView_fee.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_fee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_fee.Location = new System.Drawing.Point(185, 194);
            this.dataGridView_fee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_fee.Name = "dataGridView_fee";
            this.dataGridView_fee.ReadOnly = true;
            this.dataGridView_fee.RowTemplate.Height = 24;
            this.dataGridView_fee.Size = new System.Drawing.Size(845, 304);
            this.dataGridView_fee.TabIndex = 32;
            // 
            // FinanceInfoLabel
            // 
            this.FinanceInfoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FinanceInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FinanceInfoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinanceInfoLabel.Location = new System.Drawing.Point(185, 162);
            this.FinanceInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FinanceInfoLabel.Name = "FinanceInfoLabel";
            this.FinanceInfoLabel.Size = new System.Drawing.Size(845, 336);
            this.FinanceInfoLabel.TabIndex = 30;
            this.FinanceInfoLabel.Text = "Your Financial";
            this.FinanceInfoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FinanceStudentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView_fee);
            this.Controls.Add(this.FinanceInfoLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labeltitle);
            this.Controls.Add(this.TableLabel);
            this.Controls.Add(this.FinanceLabel);
            this.Controls.Add(this.UpdateLabel);
            this.Controls.Add(this.HomeLabel);
            this.Controls.Add(this.LogOutLink);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FinanceStudentPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APU Tution System";
            this.Load += new System.EventHandler(this.FinanceStudentPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fee)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.DataGridView dataGridView_fee;
        private System.Windows.Forms.Label FinanceInfoLabel;
    }
}