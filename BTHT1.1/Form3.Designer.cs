namespace BTHT1._1
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pal_left = new System.Windows.Forms.Panel();
            this.lblPoints = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pal_right = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pal_result = new System.Windows.Forms.Panel();
            this.btn_info = new BTTH1.RJButton();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_core = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_music = new BTTH1.RJButton();
            this.btn_home = new BTTH1.RJButton();
            this.btn_pre = new BTTH1.RJButton();
            this.btn_close = new BTTH1.RJButton();
            this.lbl_Feedback = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_check = new BTTH1.RJButton();
            this.picture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pal_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.pal_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pal_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pal_left);
            this.panel1.Controls.Add(this.pal_right);
            this.panel1.Controls.Add(this.pal_result);
            this.panel1.Controls.Add(this.btn_music);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.btn_pre);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.lbl_Feedback);
            this.panel1.Controls.Add(this.txt_input);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_check);
            this.panel1.Controls.Add(this.picture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 745);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pal_left
            // 
            this.pal_left.Controls.Add(this.lblPoints);
            this.pal_left.Controls.Add(this.label7);
            this.pal_left.Controls.Add(this.pictureBox7);
            this.pal_left.Location = new System.Drawing.Point(55, 190);
            this.pal_left.Name = "pal_left";
            this.pal_left.Size = new System.Drawing.Size(296, 305);
            this.pal_left.TabIndex = 37;
            // 
            // lblPoints
            // 
            this.lblPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPoints.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.Color.Black;
            this.lblPoints.Location = new System.Drawing.Point(79, 144);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(131, 61);
            this.lblPoints.TabIndex = 31;
            this.lblPoints.Text = "0";
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 36);
            this.label7.TabIndex = 33;
            this.label7.Text = "Points";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.ImageLocation = "Images\\\\circle.gif";
            this.pictureBox7.Location = new System.Drawing.Point(50, 77);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(197, 191);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 32;
            this.pictureBox7.TabStop = false;
            // 
            // pal_right
            // 
            this.pal_right.Controls.Add(this.label6);
            this.pal_right.Controls.Add(this.lblAttempts);
            this.pal_right.Controls.Add(this.pictureBox5);
            this.pal_right.Location = new System.Drawing.Point(949, 182);
            this.pal_right.Name = "pal_right";
            this.pal_right.Size = new System.Drawing.Size(313, 313);
            this.pal_right.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 36);
            this.label6.TabIndex = 30;
            this.label6.Text = "Vocabulary left";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAttempts
            // 
            this.lblAttempts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAttempts.BackColor = System.Drawing.Color.Transparent;
            this.lblAttempts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAttempts.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttempts.ForeColor = System.Drawing.Color.Black;
            this.lblAttempts.Location = new System.Drawing.Point(130, 148);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(57, 45);
            this.lblAttempts.TabIndex = 28;
            this.lblAttempts.Text = "10";
            this.lblAttempts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.ImageLocation = "Images\\\\circle.gif";
            this.pictureBox5.Location = new System.Drawing.Point(58, 81);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(197, 191);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            // 
            // pal_result
            // 
            this.pal_result.Controls.Add(this.btn_info);
            this.pal_result.Controls.Add(this.lbl_result);
            this.pal_result.Controls.Add(this.lbl_core);
            this.pal_result.Controls.Add(this.pictureBox1);
            this.pal_result.Location = new System.Drawing.Point(357, 134);
            this.pal_result.Name = "pal_result";
            this.pal_result.Size = new System.Drawing.Size(567, 479);
            this.pal_result.TabIndex = 35;
            this.pal_result.Visible = false;
            // 
            // btn_info
            // 
            this.btn_info.BackColor = System.Drawing.Color.Transparent;
            this.btn_info.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_info.BackgroundImage = global::BTHT1._1.Properties.Resources.ranking;
            this.btn_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_info.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_info.BorderRadius = 20;
            this.btn_info.BorderSize = 0;
            this.btn_info.FlatAppearance.BorderSize = 0;
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info.ForeColor = System.Drawing.Color.White;
            this.btn_info.Location = new System.Drawing.Point(243, 326);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(133, 109);
            this.btn_info.TabIndex = 38;
            this.btn_info.TextColor = System.Drawing.Color.White;
            this.btn_info.UseVisualStyleBackColor = false;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_result.Location = new System.Drawing.Point(-7, 280);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(628, 44);
            this.lbl_result.TabIndex = 32;
            this.lbl_result.Text = "Great job! You correctly";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_result.Visible = false;
            // 
            // lbl_core
            // 
            this.lbl_core.BackColor = System.Drawing.Color.Transparent;
            this.lbl_core.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_core.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_core.ForeColor = System.Drawing.Color.Black;
            this.lbl_core.Location = new System.Drawing.Point(245, 123);
            this.lbl_core.Name = "lbl_core";
            this.lbl_core.Size = new System.Drawing.Size(131, 61);
            this.lbl_core.TabIndex = 30;
            this.lbl_core.Text = "0";
            this.lbl_core.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ImageLocation = "Images\\\\circle.gif";
            this.pictureBox1.Location = new System.Drawing.Point(216, 56);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btn_music
            // 
            this.btn_music.BackColor = System.Drawing.Color.Transparent;
            this.btn_music.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_music.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_music.BackgroundImage")));
            this.btn_music.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_music.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_music.BorderRadius = 20;
            this.btn_music.BorderSize = 0;
            this.btn_music.FlatAppearance.BorderSize = 0;
            this.btn_music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_music.ForeColor = System.Drawing.Color.White;
            this.btn_music.Location = new System.Drawing.Point(1205, 631);
            this.btn_music.Name = "btn_music";
            this.btn_music.Size = new System.Drawing.Size(57, 57);
            this.btn_music.TabIndex = 34;
            this.btn_music.TextColor = System.Drawing.Color.White;
            this.btn_music.UseVisualStyleBackColor = false;
            this.btn_music.Click += new System.EventHandler(this.btn_music_Click);
            
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_home.BackgroundImage")));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_home.BorderRadius = 20;
            this.btn_home.BorderSize = 0;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Location = new System.Drawing.Point(82, -6);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(57, 57);
            this.btn_home.TabIndex = 33;
            this.btn_home.TextColor = System.Drawing.Color.White;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_pre
            // 
            this.btn_pre.BackColor = System.Drawing.Color.Transparent;
            this.btn_pre.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_pre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pre.BackgroundImage")));
            this.btn_pre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pre.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_pre.BorderRadius = 20;
            this.btn_pre.BorderSize = 0;
            this.btn_pre.FlatAppearance.BorderSize = 0;
            this.btn_pre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pre.ForeColor = System.Drawing.Color.White;
            this.btn_pre.Location = new System.Drawing.Point(3, -6);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(57, 57);
            this.btn_pre.TabIndex = 32;
            this.btn_pre.TextColor = System.Drawing.Color.White;
            this.btn_pre.UseVisualStyleBackColor = false;
            this.btn_pre.Click += new System.EventHandler(this.btn_pre_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_close.BorderRadius = 20;
            this.btn_close.BorderSize = 0;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1230, -4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(57, 57);
            this.btn_close.TabIndex = 31;
            this.btn_close.TextColor = System.Drawing.Color.White;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_Feedback
            // 
            this.lbl_Feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Feedback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_Feedback.Location = new System.Drawing.Point(323, 572);
            this.lbl_Feedback.Name = "lbl_Feedback";
            this.lbl_Feedback.Size = new System.Drawing.Size(628, 44);
            this.lbl_Feedback.TabIndex = 7;
            this.lbl_Feedback.Text = "Great job! You correctly";
            this.lbl_Feedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Feedback.Visible = false;
            // 
            // txt_input
            // 
            this.txt_input.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input.Location = new System.Drawing.Point(439, 525);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(372, 44);
            this.txt_input.TabIndex = 6;
            this.txt_input.Text = "Type your answer here...";
            this.txt_input.Enter += new System.EventHandler(this.txt_input_Enter);
            this.txt_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_input_KeyDown);
            this.txt_input.Leave += new System.EventHandler(this.txt_input_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(413, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 5;
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_check.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_check.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_check.BorderRadius = 20;
            this.btn_check.BorderSize = 0;
            this.btn_check.FlatAppearance.BorderSize = 0;
            this.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_check.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.ForeColor = System.Drawing.Color.White;
            this.btn_check.Location = new System.Drawing.Point(573, 619);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(205, 61);
            this.btn_check.TabIndex = 4;
            this.btn_check.Text = "CHECK";
            this.btn_check.TextColor = System.Drawing.Color.White;
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture.Location = new System.Drawing.Point(455, 169);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(337, 340);
            this.picture.TabIndex = 3;
            this.picture.TabStop = false;
            this.picture.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBox2_LoadCompleted);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 745);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pal_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.pal_right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pal_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private BTTH1.RJButton btn_check;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label lbl_Feedback;
        private BTTH1.RJButton btn_pre;
        private BTTH1.RJButton btn_close;
        private BTTH1.RJButton btn_home;
        private BTTH1.RJButton btn_music;
        private System.Windows.Forms.Panel pal_result;
        private System.Windows.Forms.Label lbl_core;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pal_left;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel pal_right;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lbl_result;
        private BTTH1.RJButton btn_info;
    }
}