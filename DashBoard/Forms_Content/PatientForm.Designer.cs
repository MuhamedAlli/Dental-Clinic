namespace DashBoard.Forms_Content
{
    partial class PatientForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPatientSave = new System.Windows.Forms.Button();
            this.btnPatientEdit = new System.Windows.Forms.Button();
            this.btnPatientDelete = new System.Windows.Forms.Button();
            this.labpatientName = new System.Windows.Forms.Label();
            this.labPatientAge = new System.Windows.Forms.Label();
            this.GenderPatient = new System.Windows.Forms.Label();
            this.labPatientPhone = new System.Windows.Forms.Label();
            this.labPatientAddress = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtPatientAddress = new System.Windows.Forms.TextBox();
            this.dataGridAllPatient = new System.Windows.Forms.DataGridView();
            this.numpatientAge = new System.Windows.Forms.NumericUpDown();
            this.combGenderPatinet = new System.Windows.Forms.ComboBox();
            this.txtpatinetPhoneNumber = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpatientAge)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPatientSave
            // 
            this.btnPatientSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPatientSave.BackColor = System.Drawing.Color.Green;
            this.btnPatientSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPatientSave.Location = new System.Drawing.Point(51, 469);
            this.btnPatientSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPatientSave.Name = "btnPatientSave";
            this.btnPatientSave.Size = new System.Drawing.Size(411, 44);
            this.btnPatientSave.TabIndex = 0;
            this.btnPatientSave.Text = "Save";
            this.btnPatientSave.UseVisualStyleBackColor = false;
            this.btnPatientSave.Click += new System.EventHandler(this.btnPatientSave_Click);
            // 
            // btnPatientEdit
            // 
            this.btnPatientEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPatientEdit.BackColor = System.Drawing.Color.Blue;
            this.btnPatientEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPatientEdit.Location = new System.Drawing.Point(51, 536);
            this.btnPatientEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPatientEdit.Name = "btnPatientEdit";
            this.btnPatientEdit.Size = new System.Drawing.Size(135, 44);
            this.btnPatientEdit.TabIndex = 1;
            this.btnPatientEdit.Text = "Edit";
            this.btnPatientEdit.UseVisualStyleBackColor = false;
            this.btnPatientEdit.Click += new System.EventHandler(this.btnPatientEdit_Click);
            // 
            // btnPatientDelete
            // 
            this.btnPatientDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPatientDelete.BackColor = System.Drawing.Color.Red;
            this.btnPatientDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPatientDelete.Location = new System.Drawing.Point(339, 536);
            this.btnPatientDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPatientDelete.Name = "btnPatientDelete";
            this.btnPatientDelete.Size = new System.Drawing.Size(123, 44);
            this.btnPatientDelete.TabIndex = 2;
            this.btnPatientDelete.Text = "Delete";
            this.btnPatientDelete.UseVisualStyleBackColor = false;
            this.btnPatientDelete.Click += new System.EventHandler(this.btnPatientDelete_Click);
            // 
            // labpatientName
            // 
            this.labpatientName.AutoSize = true;
            this.labpatientName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labpatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labpatientName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labpatientName.Location = new System.Drawing.Point(15, 18);
            this.labpatientName.Name = "labpatientName";
            this.labpatientName.Size = new System.Drawing.Size(141, 25);
            this.labpatientName.TabIndex = 4;
            this.labpatientName.Text = "Patient Name";
            // 
            // labPatientAge
            // 
            this.labPatientAge.AutoSize = true;
            this.labPatientAge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labPatientAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPatientAge.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labPatientAge.Location = new System.Drawing.Point(15, 89);
            this.labPatientAge.Name = "labPatientAge";
            this.labPatientAge.Size = new System.Drawing.Size(51, 25);
            this.labPatientAge.TabIndex = 5;
            this.labPatientAge.Text = "Age";
            // 
            // GenderPatient
            // 
            this.GenderPatient.AutoSize = true;
            this.GenderPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenderPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderPatient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GenderPatient.Location = new System.Drawing.Point(15, 175);
            this.GenderPatient.Name = "GenderPatient";
            this.GenderPatient.Size = new System.Drawing.Size(83, 25);
            this.GenderPatient.TabIndex = 6;
            this.GenderPatient.Text = "Gender";
            // 
            // labPatientPhone
            // 
            this.labPatientPhone.AutoSize = true;
            this.labPatientPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labPatientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPatientPhone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labPatientPhone.Location = new System.Drawing.Point(12, 258);
            this.labPatientPhone.Name = "labPatientPhone";
            this.labPatientPhone.Size = new System.Drawing.Size(74, 25);
            this.labPatientPhone.TabIndex = 7;
            this.labPatientPhone.Text = "Phone";
            // 
            // labPatientAddress
            // 
            this.labPatientAddress.AutoSize = true;
            this.labPatientAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labPatientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPatientAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labPatientAddress.Location = new System.Drawing.Point(12, 335);
            this.labPatientAddress.Name = "labPatientAddress";
            this.labPatientAddress.Size = new System.Drawing.Size(92, 25);
            this.labPatientAddress.TabIndex = 8;
            this.labPatientAddress.Text = "Address";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPatientName.Location = new System.Drawing.Point(165, 18);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(311, 34);
            this.txtPatientName.TabIndex = 10;
            // 
            // txtPatientAddress
            // 
            this.txtPatientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientAddress.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPatientAddress.Location = new System.Drawing.Point(165, 332);
            this.txtPatientAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPatientAddress.Name = "txtPatientAddress";
            this.txtPatientAddress.Size = new System.Drawing.Size(311, 34);
            this.txtPatientAddress.TabIndex = 13;
            // 
            // dataGridAllPatient
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(128)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(194)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridAllPatient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAllPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAllPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAllPatient.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridAllPatient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAllPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridAllPatient.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(127)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAllPatient.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridAllPatient.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridAllPatient.Location = new System.Drawing.Point(484, 12);
            this.dataGridAllPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridAllPatient.Name = "dataGridAllPatient";
            this.dataGridAllPatient.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAllPatient.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridAllPatient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(123)))), ((int)(((byte)(244)))));
            this.dataGridAllPatient.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridAllPatient.RowTemplate.DividerHeight = 1;
            this.dataGridAllPatient.RowTemplate.Height = 45;
            this.dataGridAllPatient.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAllPatient.Size = new System.Drawing.Size(883, 644);
            this.dataGridAllPatient.TabIndex = 15;
            this.dataGridAllPatient.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridAllPatient_SelectionChanged);
            // 
            // numpatientAge
            // 
            this.numpatientAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numpatientAge.Location = new System.Drawing.Point(165, 89);
            this.numpatientAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numpatientAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numpatientAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numpatientAge.Name = "numpatientAge";
            this.numpatientAge.Size = new System.Drawing.Size(309, 34);
            this.numpatientAge.TabIndex = 16;
            this.numpatientAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // combGenderPatinet
            // 
            this.combGenderPatinet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combGenderPatinet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combGenderPatinet.FormattingEnabled = true;
            this.combGenderPatinet.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.combGenderPatinet.Location = new System.Drawing.Point(165, 169);
            this.combGenderPatinet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combGenderPatinet.Name = "combGenderPatinet";
            this.combGenderPatinet.Size = new System.Drawing.Size(311, 37);
            this.combGenderPatinet.TabIndex = 17;
            // 
            // txtpatinetPhoneNumber
            // 
            this.txtpatinetPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpatinetPhoneNumber.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtpatinetPhoneNumber.Location = new System.Drawing.Point(165, 252);
            this.txtpatinetPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpatinetPhoneNumber.Name = "txtpatinetPhoneNumber";
            this.txtpatinetPhoneNumber.Size = new System.Drawing.Size(311, 34);
            this.txtpatinetPhoneNumber.TabIndex = 18;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Clear.BackColor = System.Drawing.Color.Gray;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Clear.Location = new System.Drawing.Point(51, 614);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(411, 44);
            this.btn_Clear.TabIndex = 19;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1371, 669);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.txtpatinetPhoneNumber);
            this.Controls.Add(this.combGenderPatinet);
            this.Controls.Add(this.numpatientAge);
            this.Controls.Add(this.dataGridAllPatient);
            this.Controls.Add(this.txtPatientAddress);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.labPatientAddress);
            this.Controls.Add(this.labPatientPhone);
            this.Controls.Add(this.GenderPatient);
            this.Controls.Add(this.labPatientAge);
            this.Controls.Add(this.labpatientName);
            this.Controls.Add(this.btnPatientDelete);
            this.Controls.Add(this.btnPatientEdit);
            this.Controls.Add(this.btnPatientSave);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PatientForm";
            this.Text = "Patient";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpatientAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPatientSave;
        private System.Windows.Forms.Button btnPatientEdit;
        private System.Windows.Forms.Button btnPatientDelete;
        private System.Windows.Forms.Label labpatientName;
        private System.Windows.Forms.Label labPatientAge;
        private System.Windows.Forms.Label GenderPatient;
        private System.Windows.Forms.Label labPatientPhone;
        private System.Windows.Forms.Label labPatientAddress;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtPatientAddress;
        private System.Windows.Forms.DataGridView dataGridAllPatient;
        private System.Windows.Forms.NumericUpDown numpatientAge;
        private System.Windows.Forms.TextBox txtpatinetPhoneNumber;
        private System.Windows.Forms.ComboBox combGenderPatinet;
        private System.Windows.Forms.Button btn_Clear;
    }
}