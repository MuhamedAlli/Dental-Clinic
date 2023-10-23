namespace DashBoard.Forms_Content
{
    partial class AppointmentForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.labPatientName = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.labstatus = new System.Windows.Forms.Label();
            this.labDate = new System.Windows.Forms.Label();
            this.labtime = new System.Windows.Forms.Label();
            this.PickerDateApointent = new System.Windows.Forms.DateTimePicker();
            this.dataGridAppointments = new System.Windows.Forms.DataGridView();
            this.numupdownPrice = new System.Windows.Forms.NumericUpDown();
            this.combDoctorName = new System.Windows.Forms.ComboBox();
            this.labDoctorName = new System.Windows.Forms.Label();
            this.combStatus = new System.Windows.Forms.ComboBox();
            this.PickerTimeApointment = new System.Windows.Forms.DateTimePicker();
            this.comboPatientName = new System.Windows.Forms.ComboBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(51, 458);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(411, 44);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEdit.BackColor = System.Drawing.Color.Blue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(51, 525);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(135, 44);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(339, 525);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 44);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // labPatientName
            // 
            this.labPatientName.AutoSize = true;
            this.labPatientName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPatientName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labPatientName.Location = new System.Drawing.Point(15, 18);
            this.labPatientName.Name = "labPatientName";
            this.labPatientName.Size = new System.Drawing.Size(141, 25);
            this.labPatientName.TabIndex = 4;
            this.labPatientName.Text = "Patient Name";
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labPrice.Location = new System.Drawing.Point(15, 226);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(61, 25);
            this.labPrice.TabIndex = 5;
            this.labPrice.Text = "Price";
            // 
            // labstatus
            // 
            this.labstatus.AutoSize = true;
            this.labstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labstatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labstatus.Location = new System.Drawing.Point(15, 159);
            this.labstatus.Name = "labstatus";
            this.labstatus.Size = new System.Drawing.Size(74, 25);
            this.labstatus.TabIndex = 6;
            this.labstatus.Text = "Status";
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labDate.Location = new System.Drawing.Point(15, 292);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(57, 25);
            this.labDate.TabIndex = 7;
            this.labDate.Text = "Date";
            // 
            // labtime
            // 
            this.labtime.AutoSize = true;
            this.labtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labtime.Location = new System.Drawing.Point(12, 353);
            this.labtime.Name = "labtime";
            this.labtime.Size = new System.Drawing.Size(60, 25);
            this.labtime.TabIndex = 8;
            this.labtime.Text = "Time";
            // 
            // PickerDateApointent
            // 
            this.PickerDateApointent.CustomFormat = "dd/MM/yyyy";
            this.PickerDateApointent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickerDateApointent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PickerDateApointent.Location = new System.Drawing.Point(173, 293);
            this.PickerDateApointent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PickerDateApointent.MinDate = new System.DateTime(2023, 10, 6, 0, 0, 0, 0);
            this.PickerDateApointent.Name = "PickerDateApointent";
            this.PickerDateApointent.ShowUpDown = true;
            this.PickerDateApointent.Size = new System.Drawing.Size(305, 30);
            this.PickerDateApointent.TabIndex = 14;
            // 
            // dataGridAppointments
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(128)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(194)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAppointments.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridAppointments.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(127)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAppointments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridAppointments.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridAppointments.Location = new System.Drawing.Point(484, 12);
            this.dataGridAppointments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridAppointments.Name = "dataGridAppointments";
            this.dataGridAppointments.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridAppointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(123)))), ((int)(((byte)(244)))));
            this.dataGridAppointments.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridAppointments.RowTemplate.DividerHeight = 1;
            this.dataGridAppointments.RowTemplate.Height = 45;
            this.dataGridAppointments.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAppointments.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridAppointments.Size = new System.Drawing.Size(883, 622);
            this.dataGridAppointments.TabIndex = 15;
            this.dataGridAppointments.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAppointment_SelectionChanged);
            // 
            // numupdownPrice
            // 
            this.numupdownPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numupdownPrice.Location = new System.Drawing.Point(173, 226);
            this.numupdownPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numupdownPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numupdownPrice.Name = "numupdownPrice";
            this.numupdownPrice.Size = new System.Drawing.Size(305, 34);
            this.numupdownPrice.TabIndex = 16;
            // 
            // combDoctorName
            // 
            this.combDoctorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combDoctorName.FormattingEnabled = true;
            this.combDoctorName.Location = new System.Drawing.Point(173, 89);
            this.combDoctorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combDoctorName.Name = "combDoctorName";
            this.combDoctorName.Size = new System.Drawing.Size(305, 37);
            this.combDoctorName.TabIndex = 17;
            // 
            // labDoctorName
            // 
            this.labDoctorName.AutoSize = true;
            this.labDoctorName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDoctorName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labDoctorName.Location = new System.Drawing.Point(12, 89);
            this.labDoctorName.Name = "labDoctorName";
            this.labDoctorName.Size = new System.Drawing.Size(137, 25);
            this.labDoctorName.TabIndex = 18;
            this.labDoctorName.Text = "Doctor Name";
            // 
            // combStatus
            // 
            this.combStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combStatus.FormattingEnabled = true;
            this.combStatus.Items.AddRange(new object[] {
            "Examination",
            "ReExamination"});
            this.combStatus.Location = new System.Drawing.Point(173, 159);
            this.combStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combStatus.Name = "combStatus";
            this.combStatus.Size = new System.Drawing.Size(305, 37);
            this.combStatus.TabIndex = 19;
            // 
            // PickerTimeApointment
            // 
            this.PickerTimeApointment.AllowDrop = true;
            this.PickerTimeApointment.CustomFormat = "HH:mm";
            this.PickerTimeApointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickerTimeApointment.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.PickerTimeApointment.Location = new System.Drawing.Point(173, 353);
            this.PickerTimeApointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PickerTimeApointment.MaxDate = new System.DateTime(9998, 10, 6, 0, 0, 0, 0);
            this.PickerTimeApointment.MinDate = new System.DateTime(2023, 10, 6, 0, 0, 0, 0);
            this.PickerTimeApointment.Name = "PickerTimeApointment";
            this.PickerTimeApointment.ShowUpDown = true;
            this.PickerTimeApointment.Size = new System.Drawing.Size(305, 30);
            this.PickerTimeApointment.TabIndex = 20;
            this.PickerTimeApointment.Value = new System.DateTime(2023, 10, 6, 0, 0, 0, 0);
            // 
            // comboPatientName
            // 
            this.comboPatientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboPatientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPatientName.FormattingEnabled = true;
            this.comboPatientName.Location = new System.Drawing.Point(175, 18);
            this.comboPatientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboPatientName.Name = "comboPatientName";
            this.comboPatientName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboPatientName.Size = new System.Drawing.Size(305, 37);
            this.comboPatientName.TabIndex = 21;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Clear.BackColor = System.Drawing.Color.Gray;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Clear.Location = new System.Drawing.Point(51, 590);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(411, 44);
            this.btn_Clear.TabIndex = 22;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1371, 647);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.comboPatientName);
            this.Controls.Add(this.PickerTimeApointment);
            this.Controls.Add(this.combStatus);
            this.Controls.Add(this.labDoctorName);
            this.Controls.Add(this.combDoctorName);
            this.Controls.Add(this.numupdownPrice);
            this.Controls.Add(this.dataGridAppointments);
            this.Controls.Add(this.PickerDateApointent);
            this.Controls.Add(this.labtime);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.labstatus);
            this.Controls.Add(this.labPrice);
            this.Controls.Add(this.labPatientName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AppointmentForm";
            this.Text = "Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label labPatientName;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label labstatus;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Label labtime;
        private System.Windows.Forms.DateTimePicker PickerDateApointent;
        private System.Windows.Forms.DataGridView dataGridAppointments;
        private System.Windows.Forms.NumericUpDown numupdownPrice;
        private System.Windows.Forms.ComboBox combDoctorName;
        private System.Windows.Forms.Label labDoctorName;
        private System.Windows.Forms.ComboBox combStatus;
        private System.Windows.Forms.DateTimePicker PickerTimeApointment;
        private System.Windows.Forms.ComboBox comboPatientName;
        private System.Windows.Forms.Button btn_Clear;
    }
}