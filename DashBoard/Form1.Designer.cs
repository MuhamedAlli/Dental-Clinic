namespace DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelMenue = new System.Windows.Forms.Panel();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.PanelTitlBar = new System.Windows.Forms.Panel();
            this.label1_title = new System.Windows.Forms.Label();
            this.layoutPanel = new System.Windows.Forms.Panel();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btn_Users = new System.Windows.Forms.Button();
            this.btn_Reports = new System.Windows.Forms.Button();
            this.btn_Teeth = new System.Windows.Forms.Button();
            this.btn_Diagnosis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnPatient = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1_Content = new System.Windows.Forms.Panel();
            this.PanelMenue.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            this.PanelTitlBar.SuspendLayout();
            this.layoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenue
            // 
            this.PanelMenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.PanelMenue.Controls.Add(this.btn_Users);
            this.PanelMenue.Controls.Add(this.btn_Reports);
            this.PanelMenue.Controls.Add(this.btn_Teeth);
            this.PanelMenue.Controls.Add(this.btn_Diagnosis);
            this.PanelMenue.Controls.Add(this.button1);
            this.PanelMenue.Controls.Add(this.BtnPatient);
            this.PanelMenue.Controls.Add(this.PanelLogo);
            this.PanelMenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenue.Location = new System.Drawing.Point(0, 0);
            this.PanelMenue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelMenue.Name = "PanelMenue";
            this.PanelMenue.Size = new System.Drawing.Size(182, 597);
            this.PanelMenue.TabIndex = 0;
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.PanelLogo.Controls.Add(this.pictureBox1);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelLogo.ForeColor = System.Drawing.Color.White;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(182, 207);
            this.PanelLogo.TabIndex = 0;
            // 
            // PanelTitlBar
            // 
            this.PanelTitlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.PanelTitlBar.Controls.Add(this.label1_title);
            this.PanelTitlBar.Controls.Add(this.layoutPanel);
            this.PanelTitlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitlBar.Location = new System.Drawing.Point(182, 0);
            this.PanelTitlBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelTitlBar.Name = "PanelTitlBar";
            this.PanelTitlBar.Size = new System.Drawing.Size(846, 65);
            this.PanelTitlBar.TabIndex = 1;
            // 
            // label1_title
            // 
            this.label1_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1_title.AutoSize = true;
            this.label1_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1_title.Location = new System.Drawing.Point(363, 25);
            this.label1_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1_title.Name = "label1_title";
            this.label1_title.Size = new System.Drawing.Size(71, 26);
            this.label1_title.TabIndex = 0;
            this.label1_title.Text = "Home";
            // 
            // layoutPanel
            // 
            this.layoutPanel.Controls.Add(this.btnMaximize);
            this.layoutPanel.Controls.Add(this.btnMinimize);
            this.layoutPanel.Controls.Add(this.btnClose);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Size = new System.Drawing.Size(846, 37);
            this.layoutPanel.TabIndex = 1;
            this.layoutPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.layoutPanel_MouseDown);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(776, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(23, 37);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 8;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.Image = global::DashBoard.Properties.Resources.Fa_Team_Fontawesome_Regular_FontAwesome_Regular_Window_Restore_512;
            this.btnMinimize.Location = new System.Drawing.Point(799, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 37);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(823, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 37);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btn_Users
            // 
            this.btn_Users.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Users.FlatAppearance.BorderSize = 0;
            this.btn_Users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Users.ForeColor = System.Drawing.Color.White;
            this.btn_Users.Image = global::DashBoard.Properties.Resources.Paitient_Icon1;
            this.btn_Users.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Users.Location = new System.Drawing.Point(0, 534);
            this.btn_Users.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Users.Name = "btn_Users";
            this.btn_Users.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Users.Size = new System.Drawing.Size(182, 64);
            this.btn_Users.TabIndex = 6;
            this.btn_Users.Text = "Users";
            this.btn_Users.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Users.UseVisualStyleBackColor = true;
            this.btn_Users.Click += new System.EventHandler(this.btn_Users_Click);
            // 
            // btn_Reports
            // 
            this.btn_Reports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Reports.FlatAppearance.BorderSize = 0;
            this.btn_Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reports.ForeColor = System.Drawing.Color.White;
            this.btn_Reports.Image = global::DashBoard.Properties.Resources.Paitient_Icon1;
            this.btn_Reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reports.Location = new System.Drawing.Point(0, 470);
            this.btn_Reports.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Reports.Name = "btn_Reports";
            this.btn_Reports.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Reports.Size = new System.Drawing.Size(182, 64);
            this.btn_Reports.TabIndex = 5;
            this.btn_Reports.Text = "Reports";
            this.btn_Reports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Reports.UseVisualStyleBackColor = true;
            this.btn_Reports.Click += new System.EventHandler(this.btn_Reports_Click);
            // 
            // btn_Teeth
            // 
            this.btn_Teeth.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Teeth.FlatAppearance.BorderSize = 0;
            this.btn_Teeth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Teeth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Teeth.ForeColor = System.Drawing.Color.White;
            this.btn_Teeth.Image = global::DashBoard.Properties.Resources.Paitient_Icon1;
            this.btn_Teeth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Teeth.Location = new System.Drawing.Point(0, 406);
            this.btn_Teeth.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Teeth.Name = "btn_Teeth";
            this.btn_Teeth.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Teeth.Size = new System.Drawing.Size(182, 64);
            this.btn_Teeth.TabIndex = 4;
            this.btn_Teeth.Text = "Teeth Record";
            this.btn_Teeth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Teeth.UseVisualStyleBackColor = true;
            this.btn_Teeth.Click += new System.EventHandler(this.btn_Teeth_Click);
            // 
            // btn_Diagnosis
            // 
            this.btn_Diagnosis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Diagnosis.FlatAppearance.BorderSize = 0;
            this.btn_Diagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Diagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Diagnosis.ForeColor = System.Drawing.Color.White;
            this.btn_Diagnosis.Image = global::DashBoard.Properties.Resources.Paitient_Icon1;
            this.btn_Diagnosis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Diagnosis.Location = new System.Drawing.Point(0, 342);
            this.btn_Diagnosis.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Diagnosis.Name = "btn_Diagnosis";
            this.btn_Diagnosis.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Diagnosis.Size = new System.Drawing.Size(182, 64);
            this.btn_Diagnosis.TabIndex = 3;
            this.btn_Diagnosis.Text = "  Diagnosis";
            this.btn_Diagnosis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Diagnosis.UseVisualStyleBackColor = true;
            this.btn_Diagnosis.Click += new System.EventHandler(this.btn_Diagnosis_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::DashBoard.Properties.Resources.Appointment_Icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 277);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(182, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "  Appointment";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnPatient
            // 
            this.BtnPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPatient.FlatAppearance.BorderSize = 0;
            this.BtnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPatient.ForeColor = System.Drawing.Color.White;
            this.BtnPatient.Image = global::DashBoard.Properties.Resources.Paitient_Icon1;
            this.BtnPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPatient.Location = new System.Drawing.Point(0, 207);
            this.BtnPatient.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPatient.Name = "BtnPatient";
            this.BtnPatient.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnPatient.Size = new System.Drawing.Size(182, 70);
            this.BtnPatient.TabIndex = 1;
            this.BtnPatient.Text = "  Patient";
            this.BtnPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPatient.UseVisualStyleBackColor = true;
            this.BtnPatient.Click += new System.EventHandler(this.BtnPatient_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DashBoard.Properties.Resources.Logo_Clinic1;
            this.pictureBox1.Location = new System.Drawing.Point(26, 57);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 138);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1_Content
            // 
            this.panel1_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1_Content.Location = new System.Drawing.Point(182, 65);
            this.panel1_Content.Name = "panel1_Content";
            this.panel1_Content.Size = new System.Drawing.Size(846, 532);
            this.panel1_Content.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 597);
            this.Controls.Add(this.panel1_Content);
            this.Controls.Add(this.PanelTitlBar);
            this.Controls.Add(this.PanelMenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(980, 484);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelMenue.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.PanelTitlBar.ResumeLayout(false);
            this.PanelTitlBar.PerformLayout();
            this.layoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenue;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Button BtnPatient;
        private System.Windows.Forms.Button btn_Diagnosis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PanelTitlBar;
        private System.Windows.Forms.Label label1_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Teeth;
        private System.Windows.Forms.Button btn_Reports;
        private System.Windows.Forms.Button btn_Users;
        private System.Windows.Forms.Panel layoutPanel;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panel1_Content;
    }
}

