namespace IOOP_School_System
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.LoginButton = new System.Windows.Forms.Button();
            this.UNtxt = new System.Windows.Forms.TextBox();
            this.PWtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_pass = new System.Windows.Forms.PictureBox();
            this.pictureBoxicon = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labeltext1 = new System.Windows.Forms.Label();
            this.labelwebsite = new System.Windows.Forms.Label();
            this.labeltext2 = new System.Windows.Forms.Label();
            this.labeltitle2 = new System.Windows.Forms.Label();
            this.labelbook = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxicon)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(717, 374);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(349, 46);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Sign in";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // UNtxt
            // 
            this.UNtxt.BackColor = System.Drawing.Color.White;
            this.UNtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UNtxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UNtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.UNtxt.Location = new System.Drawing.Point(760, 228);
            this.UNtxt.Margin = new System.Windows.Forms.Padding(4);
            this.UNtxt.Name = "UNtxt";
            this.UNtxt.Size = new System.Drawing.Size(316, 25);
            this.UNtxt.TabIndex = 0;
            this.UNtxt.Text = "Username";
            this.UNtxt.TextChanged += new System.EventHandler(this.UNtxt_TextChanged);
            // 
            // PWtxt
            // 
            this.PWtxt.BackColor = System.Drawing.Color.White;
            this.PWtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWtxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PWtxt.Location = new System.Drawing.Point(760, 282);
            this.PWtxt.Margin = new System.Windows.Forms.Padding(4);
            this.PWtxt.Name = "PWtxt";
            this.PWtxt.PasswordChar = '*';
            this.PWtxt.Size = new System.Drawing.Size(316, 25);
            this.PWtxt.TabIndex = 1;
            this.PWtxt.Text = "PASSWORD";
            this.PWtxt.TextChanged += new System.EventHandler(this.PWtxt_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(585, -3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(585, 612);
            this.label2.TabIndex = 10;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox_user
            // 
            this.pictureBox_user.BackColor = System.Drawing.Color.White;
            this.pictureBox_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_user.BackgroundImage")));
            this.pictureBox_user.Location = new System.Drawing.Point(717, 230);
            this.pictureBox_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_user.Name = "pictureBox_user";
            this.pictureBox_user.Size = new System.Drawing.Size(32, 30);
            this.pictureBox_user.TabIndex = 5;
            this.pictureBox_user.TabStop = false;
            this.pictureBox_user.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Location = new System.Drawing.Point(717, 259);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 2);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox_pass
            // 
            this.pictureBox_pass.BackColor = System.Drawing.Color.White;
            this.pictureBox_pass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_pass.BackgroundImage")));
            this.pictureBox_pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_pass.Location = new System.Drawing.Point(717, 292);
            this.pictureBox_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_pass.Name = "pictureBox_pass";
            this.pictureBox_pass.Size = new System.Drawing.Size(32, 15);
            this.pictureBox_pass.TabIndex = 8;
            this.pictureBox_pass.TabStop = false;
            // 
            // pictureBoxicon
            // 
            this.pictureBoxicon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pictureBoxicon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxicon.BackgroundImage")));
            this.pictureBoxicon.Location = new System.Drawing.Point(156, 80);
            this.pictureBoxicon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxicon.Name = "pictureBoxicon";
            this.pictureBoxicon.Size = new System.Drawing.Size(259, 126);
            this.pictureBoxicon.TabIndex = 10;
            this.pictureBoxicon.TabStop = false;
            this.pictureBoxicon.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTitle.Location = new System.Drawing.Point(93, 228);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(394, 49);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "APU Tution Centre\r\n";
            this.labelTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.White;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitButton.Location = new System.Drawing.Point(717, 428);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(349, 46);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Location = new System.Drawing.Point(717, 315);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 2);
            this.panel2.TabIndex = 5;
            // 
            // labeltext1
            // 
            this.labeltext1.AutoSize = true;
            this.labeltext1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labeltext1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltext1.ForeColor = System.Drawing.SystemColors.Control;
            this.labeltext1.Location = new System.Drawing.Point(162, 327);
            this.labeltext1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltext1.Name = "labeltext1";
            this.labeltext1.Size = new System.Drawing.Size(187, 30);
            this.labeltext1.TabIndex = 7;
            this.labeltext1.Text = "Young Talents,";
            this.labeltext1.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelwebsite
            // 
            this.labelwebsite.AutoSize = true;
            this.labelwebsite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labelwebsite.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelwebsite.ForeColor = System.Drawing.SystemColors.Control;
            this.labelwebsite.Location = new System.Drawing.Point(93, 552);
            this.labelwebsite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelwebsite.Name = "labelwebsite";
            this.labelwebsite.Size = new System.Drawing.Size(354, 42);
            this.labelwebsite.TabIndex = 9;
            this.labelwebsite.Text = "Visit our website : www.aputution.edu.my\r\n\r\n";
            // 
            // labeltext2
            // 
            this.labeltext2.AutoSize = true;
            this.labeltext2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labeltext2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltext2.ForeColor = System.Drawing.SystemColors.Control;
            this.labeltext2.Location = new System.Drawing.Point(236, 357);
            this.labeltext2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltext2.Name = "labeltext2";
            this.labeltext2.Size = new System.Drawing.Size(191, 30);
            this.labeltext2.TabIndex = 8;
            this.labeltext2.Text = "Come from Us ";
            this.labeltext2.Click += new System.EventHandler(this.label5_Click);
            // 
            // labeltitle2
            // 
            this.labeltitle2.AutoSize = true;
            this.labeltitle2.BackColor = System.Drawing.Color.White;
            this.labeltitle2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle2.Location = new System.Drawing.Point(711, 158);
            this.labeltitle2.Name = "labeltitle2";
            this.labeltitle2.Size = new System.Drawing.Size(312, 34);
            this.labeltitle2.TabIndex = 11;
            this.labeltitle2.Text = "Enter your credential :";
            // 
            // labelbook
            // 
            this.labelbook.AutoSize = true;
            this.labelbook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labelbook.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbook.ForeColor = System.Drawing.SystemColors.Control;
            this.labelbook.Location = new System.Drawing.Point(254, 387);
            this.labelbook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelbook.Name = "labelbook";
            this.labelbook.Size = new System.Drawing.Size(95, 74);
            this.labelbook.TabIndex = 12;
            this.labelbook.Text = "🕮";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1168, 603);
            this.Controls.Add(this.labelbook);
            this.Controls.Add(this.labeltitle2);
            this.Controls.Add(this.PWtxt);
            this.Controls.Add(this.labeltext2);
            this.Controls.Add(this.labelwebsite);
            this.Controls.Add(this.labeltext1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.pictureBoxicon);
            this.Controls.Add(this.pictureBox_pass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox_user);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.UNtxt);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APU Tution System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox UNtxt;
        private System.Windows.Forms.TextBox PWtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_user;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_pass;
        private System.Windows.Forms.PictureBox pictureBoxicon;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labeltext1;
        private System.Windows.Forms.Label labelwebsite;
        private System.Windows.Forms.Label labeltext2;
        private System.Windows.Forms.Label labeltitle2;
        private System.Windows.Forms.Label labelbook;
    }
}

