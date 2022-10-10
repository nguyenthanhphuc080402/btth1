namespace BTHT1._1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjButton1 = new BTTH1.RJButton();
            this.btn_close = new BTTH1.RJButton();
            this.btn_music = new BTTH1.RJButton();
            this.btn_start = new BTTH1.RJButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BTHT1._1.Properties.Resources.background1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_music);
            this.panel1.Controls.Add(this.btn_start);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 745);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Transparent;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton1.BackgroundImage = global::BTHT1._1.Properties.Resources.list;
            this.rjButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(0, 3);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(100, 98);
            this.rjButton1.TabIndex = 37;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = global::BTHT1._1.Properties.Resources.Delete;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_close.BorderRadius = 20;
            this.btn_close.BorderSize = 0;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1230, -3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(57, 57);
            this.btn_close.TabIndex = 36;
            this.btn_close.TextColor = System.Drawing.Color.White;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_music
            // 
            this.btn_music.BackColor = System.Drawing.Color.Transparent;
            this.btn_music.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_music.BackgroundImage = global::BTHT1._1.Properties.Resources.NotVolu;
            this.btn_music.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_music.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_music.BorderRadius = 20;
            this.btn_music.BorderSize = 0;
            this.btn_music.FlatAppearance.BorderSize = 0;
            this.btn_music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_music.ForeColor = System.Drawing.Color.White;
            this.btn_music.Location = new System.Drawing.Point(426, 567);
            this.btn_music.Name = "btn_music";
            this.btn_music.Size = new System.Drawing.Size(57, 57);
            this.btn_music.TabIndex = 35;
            this.btn_music.TextColor = System.Drawing.Color.White;
            this.btn_music.UseVisualStyleBackColor = false;
            this.btn_music.Click += new System.EventHandler(this.btn_music_Click);
            // 
            // btn_start
            // 
            this.btn_start.AutoSize = true;
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_start.BackgroundImage = global::BTHT1._1.Properties.Resources._1start;
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_start.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_start.BorderRadius = 0;
            this.btn_start.BorderSize = 0;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.Location = new System.Drawing.Point(347, 630);
            this.btn_start.Name = "btn_start";
            this.btn_start.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_start.Size = new System.Drawing.Size(216, 80);
            this.btn_start.TabIndex = 0;
            this.btn_start.TextColor = System.Drawing.Color.White;
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            this.btn_start.MouseLeave += new System.EventHandler(this.btn_start_MouseLeave);
            this.btn_start.MouseHover += new System.EventHandler(this.btn_start_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 745);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BTTH1.RJButton btn_start;
        private System.Windows.Forms.Panel panel1;
        private BTTH1.RJButton btn_music;
        private BTTH1.RJButton btn_close;
        private BTTH1.RJButton rjButton1;
    }
}

