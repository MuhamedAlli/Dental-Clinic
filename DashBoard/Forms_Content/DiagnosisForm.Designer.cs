namespace DashBoard.Forms_Content
{
    partial class DiagnosisForm
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
            this.btnAddDig = new System.Windows.Forms.Button();
            this.btnSpecialDog = new System.Windows.Forms.Button();
            this.btnDeleteDig = new System.Windows.Forms.Button();
            this.btnSearchDig = new System.Windows.Forms.Button();
            this.dataGridViewHistoryDiagnosis = new System.Windows.Forms.DataGridView();
            this.labhistory = new System.Windows.Forms.Label();
            this.comboPatientNameDiagnosis = new System.Windows.Forms.ComboBox();
            this.txtpatinetPhoneNumberDig = new System.Windows.Forms.TextBox();
            this.combGenderPatinetDig = new System.Windows.Forms.ComboBox();
            this.numpatientAgeDig = new System.Windows.Forms.NumericUpDown();
            this.txtPatientAddressDig = new System.Windows.Forms.TextBox();
            this.txtPatientNameDig = new System.Windows.Forms.TextBox();
            this.labPatientAddressDig = new System.Windows.Forms.Label();
            this.labPatientPhoneDig = new System.Windows.Forms.Label();
            this.GenderPatientDig = new System.Windows.Forms.Label();
            this.labPatientAgeDig = new System.Windows.Forms.Label();
            this.labpatientNameDig = new System.Windows.Forms.Label();
            this.Rich_textBox_Diagnosis = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoryDiagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpatientAgeDig)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddDig
            // 
            this.btnAddDig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddDig.BackColor = System.Drawing.Color.Green;
            this.btnAddDig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDig.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddDig.Location = new System.Drawing.Point(12, 483);
            this.btnAddDig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddDig.Name = "btnAddDig";
            this.btnAddDig.Size = new System.Drawing.Size(193, 44);
            this.btnAddDig.TabIndex = 0;
            this.btnAddDig.Text = "Add Diagnosis";
            this.btnAddDig.UseVisualStyleBackColor = false;
            this.btnAddDig.Click += new System.EventHandler(this.btnAddDig_Click);
            // 
            // btnSpecialDog
            // 
            this.btnSpecialDog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSpecialDog.BackColor = System.Drawing.Color.Blue;
            this.btnSpecialDog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpecialDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpecialDog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSpecialDog.Location = new System.Drawing.Point(217, 483);
            this.btnSpecialDog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSpecialDog.Name = "btnSpecialDog";
            this.btnSpecialDog.Size = new System.Drawing.Size(241, 44);
            this.btnSpecialDog.TabIndex = 1;
            this.btnSpecialDog.Text = "Special Diagnosis";
            this.btnSpecialDog.UseVisualStyleBackColor = false;
            this.btnSpecialDog.Click += new System.EventHandler(this.btnSpecialDog_Click);
            // 
            // btnDeleteDig
            // 
            this.btnDeleteDig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteDig.BackColor = System.Drawing.Color.Red;
            this.btnDeleteDig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDig.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteDig.Location = new System.Drawing.Point(471, 483);
            this.btnDeleteDig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteDig.Name = "btnDeleteDig";
            this.btnDeleteDig.Size = new System.Drawing.Size(224, 44);
            this.btnDeleteDig.TabIndex = 2;
            this.btnDeleteDig.Text = "Delete Diagnosis";
            this.btnDeleteDig.UseVisualStyleBackColor = false;
            this.btnDeleteDig.Visible = false;
            // 
            // btnSearchDig
            // 
            this.btnSearchDig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchDig.BackColor = System.Drawing.Color.Green;
            this.btnSearchDig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDig.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchDig.Location = new System.Drawing.Point(804, 9);
            this.btnSearchDig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchDig.Name = "btnSearchDig";
            this.btnSearchDig.Size = new System.Drawing.Size(155, 44);
            this.btnSearchDig.TabIndex = 16;
            this.btnSearchDig.Text = "Search";
            this.btnSearchDig.UseVisualStyleBackColor = false;
            this.btnSearchDig.Click += new System.EventHandler(this.btnSearchDig_Click);
            // 
            // dataGridViewHistoryDiagnosis
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(128)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(194)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewHistoryDiagnosis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHistoryDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHistoryDiagnosis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHistoryDiagnosis.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewHistoryDiagnosis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistoryDiagnosis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewHistoryDiagnosis.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(127)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHistoryDiagnosis.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewHistoryDiagnosis.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewHistoryDiagnosis.Location = new System.Drawing.Point(12, 59);
            this.dataGridViewHistoryDiagnosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewHistoryDiagnosis.Name = "dataGridViewHistoryDiagnosis";
            this.dataGridViewHistoryDiagnosis.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistoryDiagnosis.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewHistoryDiagnosis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(125)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(123)))), ((int)(((byte)(244)))));
            this.dataGridViewHistoryDiagnosis.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewHistoryDiagnosis.RowTemplate.DividerHeight = 1;
            this.dataGridViewHistoryDiagnosis.RowTemplate.Height = 45;
            this.dataGridViewHistoryDiagnosis.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHistoryDiagnosis.Size = new System.Drawing.Size(678, 401);
            this.dataGridViewHistoryDiagnosis.TabIndex = 18;
            this.dataGridViewHistoryDiagnosis.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDiagnosis_SelectionChanged);
            // 
            // labhistory
            // 
            this.labhistory.AutoSize = true;
            this.labhistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labhistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labhistory.Location = new System.Drawing.Point(211, 9);
            this.labhistory.Name = "labhistory";
            this.labhistory.Size = new System.Drawing.Size(252, 32);
            this.labhistory.TabIndex = 19;
            this.labhistory.Text = "Diagonsis History";
            // 
            // comboPatientNameDiagnosis
            // 
            this.comboPatientNameDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboPatientNameDiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboPatientNameDiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboPatientNameDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPatientNameDiagnosis.FormattingEnabled = true;
            this.comboPatientNameDiagnosis.Location = new System.Drawing.Point(1003, 9);
            this.comboPatientNameDiagnosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboPatientNameDiagnosis.Name = "comboPatientNameDiagnosis";
            this.comboPatientNameDiagnosis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboPatientNameDiagnosis.Size = new System.Drawing.Size(305, 37);
            this.comboPatientNameDiagnosis.TabIndex = 22;
            // 
            // txtpatinetPhoneNumberDig
            // 
            this.txtpatinetPhoneNumberDig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpatinetPhoneNumberDig.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpatinetPhoneNumberDig.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtpatinetPhoneNumberDig.Location = new System.Drawing.Point(1000, 306);
            this.txtpatinetPhoneNumberDig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpatinetPhoneNumberDig.Name = "txtpatinetPhoneNumberDig";
            this.txtpatinetPhoneNumberDig.ReadOnly = true;
            this.txtpatinetPhoneNumberDig.Size = new System.Drawing.Size(311, 34);
            this.txtpatinetPhoneNumberDig.TabIndex = 32;
            // 
            // combGenderPatinetDig
            // 
            this.combGenderPatinetDig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combGenderPatinetDig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combGenderPatinetDig.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.combGenderPatinetDig.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combGenderPatinetDig.FormattingEnabled = true;
            this.combGenderPatinetDig.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.combGenderPatinetDig.Location = new System.Drawing.Point(1000, 223);
            this.combGenderPatinetDig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combGenderPatinetDig.Name = "combGenderPatinetDig";
            this.combGenderPatinetDig.Size = new System.Drawing.Size(311, 37);
            this.combGenderPatinetDig.TabIndex = 31;
            // 
            // numpatientAgeDig
            // 
            this.numpatientAgeDig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numpatientAgeDig.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numpatientAgeDig.Location = new System.Drawing.Point(1000, 143);
            this.numpatientAgeDig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numpatientAgeDig.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numpatientAgeDig.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numpatientAgeDig.Name = "numpatientAgeDig";
            this.numpatientAgeDig.ReadOnly = true;
            this.numpatientAgeDig.Size = new System.Drawing.Size(309, 34);
            this.numpatientAgeDig.TabIndex = 30;
            this.numpatientAgeDig.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtPatientAddressDig
            // 
            this.txtPatientAddressDig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatientAddressDig.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientAddressDig.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPatientAddressDig.Location = new System.Drawing.Point(1000, 383);
            this.txtPatientAddressDig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPatientAddressDig.Name = "txtPatientAddressDig";
            this.txtPatientAddressDig.ReadOnly = true;
            this.txtPatientAddressDig.Size = new System.Drawing.Size(311, 34);
            this.txtPatientAddressDig.TabIndex = 29;
            // 
            // txtPatientNameDig
            // 
            this.txtPatientNameDig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatientNameDig.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientNameDig.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPatientNameDig.Location = new System.Drawing.Point(1000, 73);
            this.txtPatientNameDig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPatientNameDig.Name = "txtPatientNameDig";
            this.txtPatientNameDig.ReadOnly = true;
            this.txtPatientNameDig.Size = new System.Drawing.Size(311, 34);
            this.txtPatientNameDig.TabIndex = 28;
            // 
            // labPatientAddressDig
            // 
            this.labPatientAddressDig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labPatientAddressDig.AutoSize = true;
            this.labPatientAddressDig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labPatientAddressDig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPatientAddressDig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labPatientAddressDig.Location = new System.Drawing.Point(800, 389);
            this.labPatientAddressDig.Name = "labPatientAddressDig";
            this.labPatientAddressDig.Size = new System.Drawing.Size(92, 25);
            this.labPatientAddressDig.TabIndex = 27;
            this.labPatientAddressDig.Text = "Address";
            // 
            // labPatientPhoneDig
            // 
            this.labPatientPhoneDig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labPatientPhoneDig.AutoSize = true;
            this.labPatientPhoneDig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labPatientPhoneDig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPatientPhoneDig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labPatientPhoneDig.Location = new System.Drawing.Point(800, 313);
            this.labPatientPhoneDig.Name = "labPatientPhoneDig";
            this.labPatientPhoneDig.Size = new System.Drawing.Size(74, 25);
            this.labPatientPhoneDig.TabIndex = 26;
            this.labPatientPhoneDig.Text = "Phone";
            // 
            // GenderPatientDig
            // 
            this.GenderPatientDig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GenderPatientDig.AutoSize = true;
            this.GenderPatientDig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenderPatientDig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderPatientDig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GenderPatientDig.Location = new System.Drawing.Point(803, 229);
            this.GenderPatientDig.Name = "GenderPatientDig";
            this.GenderPatientDig.Size = new System.Drawing.Size(83, 25);
            this.GenderPatientDig.TabIndex = 25;
            this.GenderPatientDig.Text = "Gender";
            // 
            // labPatientAgeDig
            // 
            this.labPatientAgeDig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labPatientAgeDig.AutoSize = true;
            this.labPatientAgeDig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labPatientAgeDig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPatientAgeDig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labPatientAgeDig.Location = new System.Drawing.Point(803, 143);
            this.labPatientAgeDig.Name = "labPatientAgeDig";
            this.labPatientAgeDig.Size = new System.Drawing.Size(51, 25);
            this.labPatientAgeDig.TabIndex = 24;
            this.labPatientAgeDig.Text = "Age";
            // 
            // labpatientNameDig
            // 
            this.labpatientNameDig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labpatientNameDig.AutoSize = true;
            this.labpatientNameDig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labpatientNameDig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labpatientNameDig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labpatientNameDig.Location = new System.Drawing.Point(803, 73);
            this.labpatientNameDig.Name = "labpatientNameDig";
            this.labpatientNameDig.Size = new System.Drawing.Size(141, 25);
            this.labpatientNameDig.TabIndex = 23;
            this.labpatientNameDig.Text = "Patient Name";
            // 
            // Rich_textBox_Diagnosis
            // 
            this.Rich_textBox_Diagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rich_textBox_Diagnosis.Location = new System.Drawing.Point(1003, 435);
            this.Rich_textBox_Diagnosis.Name = "Rich_textBox_Diagnosis";
            this.Rich_textBox_Diagnosis.Size = new System.Drawing.Size(308, 96);
            this.Rich_textBox_Diagnosis.TabIndex = 33;
            this.Rich_textBox_Diagnosis.Text = "";
            // 
            // DiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1382, 540);
            this.Controls.Add(this.Rich_textBox_Diagnosis);
            this.Controls.Add(this.txtpatinetPhoneNumberDig);
            this.Controls.Add(this.combGenderPatinetDig);
            this.Controls.Add(this.numpatientAgeDig);
            this.Controls.Add(this.txtPatientAddressDig);
            this.Controls.Add(this.txtPatientNameDig);
            this.Controls.Add(this.labPatientAddressDig);
            this.Controls.Add(this.labPatientPhoneDig);
            this.Controls.Add(this.GenderPatientDig);
            this.Controls.Add(this.labPatientAgeDig);
            this.Controls.Add(this.labpatientNameDig);
            this.Controls.Add(this.comboPatientNameDiagnosis);
            this.Controls.Add(this.labhistory);
            this.Controls.Add(this.dataGridViewHistoryDiagnosis);
            this.Controls.Add(this.btnSearchDig);
            this.Controls.Add(this.btnDeleteDig);
            this.Controls.Add(this.btnSpecialDog);
            this.Controls.Add(this.btnAddDig);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DiagnosisForm";
            this.Text = "Diagnosis";
            this.Load += new System.EventHandler(this.Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoryDiagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpatientAgeDig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDig;
        private System.Windows.Forms.Button btnSpecialDog;
        private System.Windows.Forms.Button btnDeleteDig;
        private System.Windows.Forms.Button btnSearchDig;
        private System.Windows.Forms.DataGridView dataGridViewHistoryDiagnosis;
        private System.Windows.Forms.Label labhistory;
        private System.Windows.Forms.ComboBox comboPatientNameDiagnosis;
        private System.Windows.Forms.TextBox txtpatinetPhoneNumberDig;
        private System.Windows.Forms.ComboBox combGenderPatinetDig;
        private System.Windows.Forms.NumericUpDown numpatientAgeDig;
        private System.Windows.Forms.TextBox txtPatientAddressDig;
        private System.Windows.Forms.TextBox txtPatientNameDig;
        private System.Windows.Forms.Label labPatientAddressDig;
        private System.Windows.Forms.Label labPatientPhoneDig;
        private System.Windows.Forms.Label GenderPatientDig;
        private System.Windows.Forms.Label labPatientAgeDig;
        private System.Windows.Forms.Label labpatientNameDig;
        private System.Windows.Forms.RichTextBox Rich_textBox_Diagnosis;
    }
}