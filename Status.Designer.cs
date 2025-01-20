namespace Sub_City_Management
{
    partial class Status
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Status));
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddB = new System.Windows.Forms.Button();
            this.SearchB = new Guna.UI2.WinForms.Guna2TextBox();
            this.SearchButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 580);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 25);
            this.panel1.TabIndex = 193;
            // 
            // AddB
            // 
            this.AddB.FlatAppearance.BorderSize = 0;
            this.AddB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddB.Image = ((System.Drawing.Image)(resources.GetObject("AddB.Image")));
            this.AddB.Location = new System.Drawing.Point(675, 12);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(44, 44);
            this.AddB.TabIndex = 208;
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // SearchB
            // 
            this.SearchB.AutoRoundedCorners = true;
            this.SearchB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SearchB.BorderRadius = 13;
            this.SearchB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchB.DefaultText = "";
            this.SearchB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.SearchB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchB.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SearchB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchB.IconLeft = ((System.Drawing.Image)(resources.GetObject("SearchB.IconLeft")));
            this.SearchB.Location = new System.Drawing.Point(33, 21);
            this.SearchB.Name = "SearchB";
            this.SearchB.PasswordChar = '\0';
            this.SearchB.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SearchB.PlaceholderText = "Search Here";
            this.SearchB.SelectedText = "";
            this.SearchB.Size = new System.Drawing.Size(338, 28);
            this.SearchB.TabIndex = 209;
            this.SearchB.TextChanged += new System.EventHandler(this.SearchB_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SearchButton.BorderRadius = 5;
            this.SearchButton.BorderThickness = 1;
            this.SearchButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.SearchButton.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SearchButton.Location = new System.Drawing.Point(377, 21);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 28);
            this.SearchButton.TabIndex = 210;
            this.SearchButton.Text = "Search";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(731, 605);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AddB);
            this.Controls.Add(this.SearchB);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Status";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Status";
            this.Load += new System.EventHandler(this.Status_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddB;
        private Guna.UI2.WinForms.Guna2TextBox SearchB;
        private Guna.UI2.WinForms.Guna2Button SearchButton;
    }
}