namespace Pandora.App.Views
{
    partial class Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Master));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnAdmin = new FontAwesome.Sharp.IconButton();
            this.btnEntries = new FontAwesome.Sharp.IconButton();
            this.btnVehicle = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnAdmin);
            this.panelMenu.Controls.Add(this.btnEntries);
            this.panelMenu.Controls.Add(this.btnVehicle);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(277, 681);
            this.panelMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLogout.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 32;
            this.btnLogout.Location = new System.Drawing.Point(0, 617);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLogout.Size = new System.Drawing.Size(275, 62);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.White;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.btnAdmin.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            this.btnAdmin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmin.IconSize = 32;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(0, 411);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAdmin.Size = new System.Drawing.Size(275, 70);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Administrativo";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnEntries
            // 
            this.btnEntries.BackColor = System.Drawing.Color.White;
            this.btnEntries.FlatAppearance.BorderSize = 0;
            this.btnEntries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntries.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEntries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.btnEntries.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnEntries.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.btnEntries.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEntries.IconSize = 32;
            this.btnEntries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntries.Location = new System.Drawing.Point(0, 325);
            this.btnEntries.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.btnEntries.Name = "btnEntries";
            this.btnEntries.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEntries.Size = new System.Drawing.Size(275, 70);
            this.btnEntries.TabIndex = 3;
            this.btnEntries.Text = "Registros";
            this.btnEntries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEntries.UseVisualStyleBackColor = false;
            this.btnEntries.Click += new System.EventHandler(this.btnEntries_Click);
            // 
            // btnVehicle
            // 
            this.btnVehicle.BackColor = System.Drawing.Color.White;
            this.btnVehicle.FlatAppearance.BorderSize = 0;
            this.btnVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.btnVehicle.IconChar = FontAwesome.Sharp.IconChar.CarRear;
            this.btnVehicle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.btnVehicle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVehicle.IconSize = 32;
            this.btnVehicle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicle.Location = new System.Drawing.Point(0, 239);
            this.btnVehicle.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnVehicle.Size = new System.Drawing.Size(275, 70);
            this.btnVehicle.TabIndex = 2;
            this.btnVehicle.Text = "Veículos";
            this.btnVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVehicle.UseVisualStyleBackColor = false;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.btnDashboard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 153);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDashboard.Size = new System.Drawing.Size(275, 70);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(275, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(11, 11);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(249, 115);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(285, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 657);
            this.panel1.TabIndex = 1;
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pandora";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnAdmin;
        private FontAwesome.Sharp.IconButton btnEntries;
        private FontAwesome.Sharp.IconButton btnVehicle;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnLogout;
        private PictureBox btnHome;
        private Panel panel1;
    }
}