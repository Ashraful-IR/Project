namespace Sub_City_Management
{
    partial class AboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ContactB = new System.Windows.Forms.Button();
            this.PurposeB = new System.Windows.Forms.Button();
            this.MissionB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 545);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 25);
            this.panel1.TabIndex = 121;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(212, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 75);
            this.label5.TabIndex = 104;
            this.label5.Text = "About Us";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 414);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(731, 156);
            this.pictureBox1.TabIndex = 125;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ContactB
            // 
            this.ContactB.FlatAppearance.BorderSize = 0;
            this.ContactB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactB.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactB.Image = ((System.Drawing.Image)(resources.GetObject("ContactB.Image")));
            this.ContactB.Location = new System.Drawing.Point(259, 144);
            this.ContactB.Name = "ContactB";
            this.ContactB.Size = new System.Drawing.Size(211, 133);
            this.ContactB.TabIndex = 124;
            this.ContactB.Text = "Contact Us";
            this.ContactB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ContactB.UseVisualStyleBackColor = true;
            // 
            // PurposeB
            // 
            this.PurposeB.FlatAppearance.BorderSize = 0;
            this.PurposeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurposeB.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurposeB.Image = ((System.Drawing.Image)(resources.GetObject("PurposeB.Image")));
            this.PurposeB.Location = new System.Drawing.Point(487, 212);
            this.PurposeB.Name = "PurposeB";
            this.PurposeB.Size = new System.Drawing.Size(211, 166);
            this.PurposeB.TabIndex = 123;
            this.PurposeB.Text = "Purpose and Objectives";
            this.PurposeB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PurposeB.UseVisualStyleBackColor = true;
            this.PurposeB.Click += new System.EventHandler(this.PurposeB_Click);
            // 
            // MissionB
            // 
            this.MissionB.FlatAppearance.BorderSize = 0;
            this.MissionB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MissionB.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissionB.Image = ((System.Drawing.Image)(resources.GetObject("MissionB.Image")));
            this.MissionB.Location = new System.Drawing.Point(28, 212);
            this.MissionB.Name = "MissionB";
            this.MissionB.Size = new System.Drawing.Size(211, 166);
            this.MissionB.TabIndex = 122;
            this.MissionB.Text = "Mission and Vision";
            this.MissionB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MissionB.UseVisualStyleBackColor = true;
            this.MissionB.Click += new System.EventHandler(this.MissionB_Click);
            // 
            // AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(731, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ContactB);
            this.Controls.Add(this.PurposeB);
            this.Controls.Add(this.MissionB);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutUs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutUs";
            this.Load += new System.EventHandler(this.AboutUs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button MissionB;
        private System.Windows.Forms.Button PurposeB;
        private System.Windows.Forms.Button ContactB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}