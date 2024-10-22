namespace LapTrinhMang
{
    partial class MainForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnChat = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Username = new System.Windows.Forms.Label();
            this.tbcChangeProfile = new System.Windows.Forms.TabControl();
            this.tbpChangeProfile = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNameProfile = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbpChangePassWord = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tbcChangeProfile.SuspendLayout();
            this.tbpChangeProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Controls.Add(this.btnProfile);
            this.panel2.Controls.Add(this.btnChat);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 452);
            this.panel2.TabIndex = 0;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSetting.Location = new System.Drawing.Point(13, 250);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(85, 34);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProfile.Location = new System.Drawing.Point(13, 185);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(85, 34);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "ProFile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnChat
            // 
            this.btnChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChat.Location = new System.Drawing.Point(13, 117);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(85, 34);
            this.btnChat.TabIndex = 1;
            this.btnChat.Text = "Chat";
            this.btnChat.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHome.Location = new System.Drawing.Point(13, 43);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(85, 34);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.Username);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(802, 89);
            this.panel3.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(122, 27);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(109, 39);
            this.Username.TabIndex = 1;
            this.Username.Text = "label1";
            // 
            // tbcChangeProfile
            // 
            this.tbcChangeProfile.Controls.Add(this.tbpChangeProfile);
            this.tbcChangeProfile.Controls.Add(this.tbpChangePassWord);
            this.tbcChangeProfile.Location = new System.Drawing.Point(116, 95);
            this.tbcChangeProfile.Name = "tbcChangeProfile";
            this.tbcChangeProfile.SelectedIndex = 0;
            this.tbcChangeProfile.Size = new System.Drawing.Size(688, 359);
            this.tbcChangeProfile.TabIndex = 0;
            // 
            // tbpChangeProfile
            // 
            this.tbpChangeProfile.Controls.Add(this.textBox1);
            this.tbpChangeProfile.Controls.Add(this.pictureBox3);
            this.tbpChangeProfile.Controls.Add(this.txtNameProfile);
            this.tbpChangeProfile.Controls.Add(this.textBox2);
            this.tbpChangeProfile.Controls.Add(this.label6);
            this.tbpChangeProfile.Controls.Add(this.label3);
            this.tbpChangeProfile.Controls.Add(this.label5);
            this.tbpChangeProfile.Location = new System.Drawing.Point(4, 22);
            this.tbpChangeProfile.Name = "tbpChangeProfile";
            this.tbpChangeProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tbpChangeProfile.Size = new System.Drawing.Size(680, 333);
            this.tbpChangeProfile.TabIndex = 0;
            this.tbpChangeProfile.Text = "Change Profile";
            this.tbpChangeProfile.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 223);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 7;
            // 
            // txtNameProfile
            // 
            this.txtNameProfile.Location = new System.Drawing.Point(268, 173);
            this.txtNameProfile.Name = "txtNameProfile";
            this.txtNameProfile.Size = new System.Drawing.Size(207, 20);
            this.txtNameProfile.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(268, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PassWord";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "UserName";
            // 
            // tbpChangePassWord
            // 
            this.tbpChangePassWord.Location = new System.Drawing.Point(4, 22);
            this.tbpChangePassWord.Name = "tbpChangePassWord";
            this.tbpChangePassWord.Padding = new System.Windows.Forms.Padding(3);
            this.tbpChangePassWord.Size = new System.Drawing.Size(680, 333);
            this.tbpChangePassWord.TabIndex = 1;
            this.tbpChangePassWord.Text = "Change PassWord";
            this.tbpChangePassWord.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::LapTrinhMang.Properties.Resources.Screenshot_2024_09_10_043044_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox3.Image = global::LapTrinhMang.Properties.Resources.Screenshot_2024_09_10_043044_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(313, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbcChangeProfile);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tbcChangeProfile.ResumeLayout(false);
            this.tbpChangeProfile.ResumeLayout(false);
            this.tbpChangeProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TabControl tbcChangeProfile;
        private System.Windows.Forms.TabPage tbpChangeProfile;
        private System.Windows.Forms.TabPage tbpChangePassWord;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNameProfile;
        private System.Windows.Forms.Label label6;
    }
}