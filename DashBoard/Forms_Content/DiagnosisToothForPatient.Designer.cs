namespace DashBoard.Forms_Content
{
    partial class DiagnosisToothForPatient
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
            this.combToothNumber = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbToothDiag = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pxtoothImage = new System.Windows.Forms.PictureBox();
            this.comboPatientName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labDoctorName = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtoothImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.combToothNumber);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rtbToothDiag);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pxtoothImage);
            this.panel1.Controls.Add(this.comboPatientName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labDoctorName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(11, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 670);
            this.panel1.TabIndex = 0;
            // 
            // combToothNumber
            // 
            this.combToothNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combToothNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combToothNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combToothNumber.FormattingEnabled = true;
            this.combToothNumber.Location = new System.Drawing.Point(351, 123);
            this.combToothNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combToothNumber.Name = "combToothNumber";
            this.combToothNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.combToothNumber.Size = new System.Drawing.Size(401, 37);
            this.combToothNumber.TabIndex = 45;
            this.combToothNumber.SelectedIndexChanged += new System.EventHandler(this.combToothNumber_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(235, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 37);
            this.label4.TabIndex = 44;
            this.label4.Text = "Add Tooth Diagnosis";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(624, 569);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 42);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(276, 569);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 42);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(72, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Tooth Diagnosis :";
            // 
            // rtbToothDiag
            // 
            this.rtbToothDiag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbToothDiag.Location = new System.Drawing.Point(276, 428);
            this.rtbToothDiag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbToothDiag.Name = "rtbToothDiag";
            this.rtbToothDiag.Size = new System.Drawing.Size(476, 117);
            this.rtbToothDiag.TabIndex = 40;
            this.rtbToothDiag.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(81, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tooth Image :";
            // 
            // pxtoothImage
            // 
            this.pxtoothImage.BackColor = System.Drawing.Color.Silver;
            this.pxtoothImage.Location = new System.Drawing.Point(276, 176);
            this.pxtoothImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pxtoothImage.Name = "pxtoothImage";
            this.pxtoothImage.Size = new System.Drawing.Size(477, 225);
            this.pxtoothImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxtoothImage.TabIndex = 38;
            this.pxtoothImage.TabStop = false;
            // 
            // comboPatientName
            // 
            this.comboPatientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboPatientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPatientName.FormattingEnabled = true;
            this.comboPatientName.Location = new System.Drawing.Point(276, 60);
            this.comboPatientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboPatientName.Name = "comboPatientName";
            this.comboPatientName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboPatientName.Size = new System.Drawing.Size(476, 37);
            this.comboPatientName.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(81, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Choose Patient :";
            // 
            // labDoctorName
            // 
            this.labDoctorName.AutoSize = true;
            this.labDoctorName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDoctorName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labDoctorName.Location = new System.Drawing.Point(81, 129);
            this.labDoctorName.Name = "labDoctorName";
            this.labDoctorName.Size = new System.Drawing.Size(243, 25);
            this.labDoctorName.TabIndex = 35;
            this.labDoctorName.Text = "Choose Tooth Number :";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(276, 624);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(476, 42);
            this.btn_Clear.TabIndex = 46;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // DiagnosisToothForPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(909, 690);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DiagnosisToothForPatient";
            this.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiagnosisToothForPatient";
            this.Load += new System.EventHandler(this.DiagnosisToothForPatient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxtoothImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox combToothNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbToothDiag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pxtoothImage;
        private System.Windows.Forms.ComboBox comboPatientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labDoctorName;
        private System.Windows.Forms.Button btn_Clear;
    }
}