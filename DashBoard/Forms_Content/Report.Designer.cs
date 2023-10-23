namespace DashBoard.Forms_Content
{
    partial class Report
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
            this.dataGridAppointments = new System.Windows.Forms.DataGridView();
            this.PickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.labDate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.PickerToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.labpatientName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppointments)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridAppointments.Location = new System.Drawing.Point(355, 63);
            this.dataGridAppointments.Margin = new System.Windows.Forms.Padding(2);
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
            this.dataGridAppointments.Size = new System.Drawing.Size(662, 370);
            this.dataGridAppointments.TabIndex = 16;
            // 
            // PickerFromDate
            // 
            this.PickerFromDate.CustomFormat = "dd/MM/yyyy";
            this.PickerFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PickerFromDate.Location = new System.Drawing.Point(121, 95);
            this.PickerFromDate.Margin = new System.Windows.Forms.Padding(2);
            this.PickerFromDate.MinDate = new System.DateTime(2023, 10, 6, 0, 0, 0, 0);
            this.PickerFromDate.Name = "PickerFromDate";
            this.PickerFromDate.ShowUpDown = true;
            this.PickerFromDate.Size = new System.Drawing.Size(230, 26);
            this.PickerFromDate.TabIndex = 19;
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labDate.Location = new System.Drawing.Point(2, 94);
            this.labDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(50, 20);
            this.labDate.TabIndex = 18;
            this.labDate.Text = "From";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Green;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(6, 196);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(345, 36);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search by Date";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // PickerToDate
            // 
            this.PickerToDate.CustomFormat = "dd/MM/yyyy";
            this.PickerToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PickerToDate.Location = new System.Drawing.Point(121, 145);
            this.PickerToDate.Margin = new System.Windows.Forms.Padding(2);
            this.PickerToDate.MinDate = new System.DateTime(2023, 10, 6, 0, 0, 0, 0);
            this.PickerToDate.Name = "PickerToDate";
            this.PickerToDate.ShowUpDown = true;
            this.PickerToDate.Size = new System.Drawing.Size(230, 26);
            this.PickerToDate.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(2, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(117, 279);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Total Income";
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIncome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalIncome.Location = new System.Drawing.Point(166, 319);
            this.lblTotalIncome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(24, 25);
            this.lblTotalIncome.TabIndex = 23;
            this.lblTotalIncome.Text = "0";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPatientName.Location = new System.Drawing.Point(492, 21);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(525, 28);
            this.txtPatientName.TabIndex = 25;
            this.txtPatientName.TextChanged += new System.EventHandler(this.txtPatientName_TextChanged);
            // 
            // labpatientName
            // 
            this.labpatientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labpatientName.AutoSize = true;
            this.labpatientName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labpatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labpatientName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labpatientName.Location = new System.Drawing.Point(351, 26);
            this.labpatientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labpatientName.Name = "labpatientName";
            this.labpatientName.Size = new System.Drawing.Size(117, 20);
            this.labpatientName.TabIndex = 24;
            this.labpatientName.Text = "Patient Name";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1028, 442);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.labpatientName);
            this.Controls.Add(this.lblTotalIncome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PickerToDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PickerFromDate);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridAppointments);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAppointments;
        private System.Windows.Forms.DateTimePicker PickerFromDate;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker PickerToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label labpatientName;
    }
}