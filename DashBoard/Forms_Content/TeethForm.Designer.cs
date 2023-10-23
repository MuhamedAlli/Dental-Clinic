namespace DashBoard.Forms_Content
{
    partial class TeethForm
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
            this.txtToothNum = new System.Windows.Forms.TextBox();
            this.txtToothName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChooseToothImage = new System.Windows.Forms.Button();
            this.btnAddTooth = new System.Windows.Forms.Button();
            this.labDoctorName = new System.Windows.Forms.Label();
            this.combToothNumber = new System.Windows.Forms.ComboBox();
            this.btnUpdateTooth = new System.Windows.Forms.Button();
            this.btnDeleteTooth = new System.Windows.Forms.Button();
            this.pxToothImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pxToothImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtToothNum
            // 
            this.txtToothNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtToothNum.Location = new System.Drawing.Point(272, 117);
            this.txtToothNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtToothNum.Name = "txtToothNum";
            this.txtToothNum.Size = new System.Drawing.Size(730, 34);
            this.txtToothNum.TabIndex = 0;
            // 
            // txtToothName
            // 
            this.txtToothName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtToothName.Location = new System.Drawing.Point(272, 183);
            this.txtToothName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtToothName.Name = "txtToothName";
            this.txtToothName.Size = new System.Drawing.Size(730, 34);
            this.txtToothName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tooth Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tooth Name :";
            // 
            // btnChooseToothImage
            // 
            this.btnChooseToothImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChooseToothImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChooseToothImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseToothImage.ForeColor = System.Drawing.Color.White;
            this.btnChooseToothImage.Location = new System.Drawing.Point(831, 225);
            this.btnChooseToothImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChooseToothImage.Name = "btnChooseToothImage";
            this.btnChooseToothImage.Size = new System.Drawing.Size(171, 313);
            this.btnChooseToothImage.TabIndex = 4;
            this.btnChooseToothImage.Text = "Choose Tooth Image";
            this.btnChooseToothImage.UseVisualStyleBackColor = false;
            this.btnChooseToothImage.Click += new System.EventHandler(this.btnChooseToothImage_Click);
            // 
            // btnAddTooth
            // 
            this.btnAddTooth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddTooth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddTooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTooth.ForeColor = System.Drawing.Color.White;
            this.btnAddTooth.Location = new System.Drawing.Point(272, 546);
            this.btnAddTooth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddTooth.Name = "btnAddTooth";
            this.btnAddTooth.Size = new System.Drawing.Size(730, 42);
            this.btnAddTooth.TabIndex = 6;
            this.btnAddTooth.Text = "Add Tooth";
            this.btnAddTooth.UseVisualStyleBackColor = false;
            this.btnAddTooth.Click += new System.EventHandler(this.btnAddTooth_Click);
            // 
            // labDoctorName
            // 
            this.labDoctorName.AutoSize = true;
            this.labDoctorName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDoctorName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labDoctorName.Location = new System.Drawing.Point(8, 44);
            this.labDoctorName.Name = "labDoctorName";
            this.labDoctorName.Size = new System.Drawing.Size(243, 25);
            this.labDoctorName.TabIndex = 20;
            this.labDoctorName.Text = "Choose Tooth Number :";
            // 
            // combToothNumber
            // 
            this.combToothNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combToothNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combToothNumber.FormattingEnabled = true;
            this.combToothNumber.Location = new System.Drawing.Point(272, 41);
            this.combToothNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combToothNumber.Name = "combToothNumber";
            this.combToothNumber.Size = new System.Drawing.Size(730, 37);
            this.combToothNumber.TabIndex = 19;
            this.combToothNumber.SelectedIndexChanged += new System.EventHandler(this.combToothNumber_SelectedIndexChanged);
            // 
            // btnUpdateTooth
            // 
            this.btnUpdateTooth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdateTooth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateTooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTooth.ForeColor = System.Drawing.Color.White;
            this.btnUpdateTooth.Location = new System.Drawing.Point(272, 601);
            this.btnUpdateTooth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateTooth.Name = "btnUpdateTooth";
            this.btnUpdateTooth.Size = new System.Drawing.Size(340, 42);
            this.btnUpdateTooth.TabIndex = 21;
            this.btnUpdateTooth.Text = "Update Tooth";
            this.btnUpdateTooth.UseVisualStyleBackColor = false;
            this.btnUpdateTooth.Click += new System.EventHandler(this.btnUpdateTooth_Click);
            // 
            // btnDeleteTooth
            // 
            this.btnDeleteTooth.BackColor = System.Drawing.Color.Red;
            this.btnDeleteTooth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteTooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTooth.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTooth.Location = new System.Drawing.Point(662, 601);
            this.btnDeleteTooth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteTooth.Name = "btnDeleteTooth";
            this.btnDeleteTooth.Size = new System.Drawing.Size(340, 42);
            this.btnDeleteTooth.TabIndex = 22;
            this.btnDeleteTooth.Text = "Delete Tooth";
            this.btnDeleteTooth.UseVisualStyleBackColor = false;
            this.btnDeleteTooth.Click += new System.EventHandler(this.btnDeleteTooth_Click);
            // 
            // pxToothImage
            // 
            this.pxToothImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pxToothImage.Location = new System.Drawing.Point(272, 225);
            this.pxToothImage.Margin = new System.Windows.Forms.Padding(4);
            this.pxToothImage.Name = "pxToothImage";
            this.pxToothImage.Size = new System.Drawing.Size(551, 313);
            this.pxToothImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxToothImage.TabIndex = 5;
            this.pxToothImage.TabStop = false;
            // 
            // TeethForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1511, 659);
            this.Controls.Add(this.btnDeleteTooth);
            this.Controls.Add(this.btnUpdateTooth);
            this.Controls.Add(this.labDoctorName);
            this.Controls.Add(this.combToothNumber);
            this.Controls.Add(this.btnAddTooth);
            this.Controls.Add(this.pxToothImage);
            this.Controls.Add(this.btnChooseToothImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToothName);
            this.Controls.Add(this.txtToothNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TeethForm";
            this.Text = "Teeth";
            this.Load += new System.EventHandler(this.Teeth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pxToothImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToothNum;
        private System.Windows.Forms.TextBox txtToothName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChooseToothImage;
        private System.Windows.Forms.PictureBox pxToothImage;
        private System.Windows.Forms.Button btnAddTooth;
        private System.Windows.Forms.Label labDoctorName;
        private System.Windows.Forms.ComboBox combToothNumber;
        private System.Windows.Forms.Button btnUpdateTooth;
        private System.Windows.Forms.Button btnDeleteTooth;
    }
}