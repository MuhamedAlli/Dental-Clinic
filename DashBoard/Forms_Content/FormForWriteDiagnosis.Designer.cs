namespace DashBoard.Forms_Content
{
    partial class FormForWriteDiagnosis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForWriteDiagnosis));
            this.RichTxt_Diagnosis = new System.Windows.Forms.RichTextBox();
            this.btn_SaveDiagnosis_Text = new System.Windows.Forms.Button();
            this.btn_Close_Form = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RichTxt_Diagnosis
            // 
            this.RichTxt_Diagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTxt_Diagnosis.Location = new System.Drawing.Point(53, 94);
            this.RichTxt_Diagnosis.Name = "RichTxt_Diagnosis";
            this.RichTxt_Diagnosis.Size = new System.Drawing.Size(679, 442);
            this.RichTxt_Diagnosis.TabIndex = 0;
            this.RichTxt_Diagnosis.Text = "";
            // 
            // btn_SaveDiagnosis_Text
            // 
            this.btn_SaveDiagnosis_Text.BackColor = System.Drawing.Color.Green;
            this.btn_SaveDiagnosis_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveDiagnosis_Text.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_SaveDiagnosis_Text.Location = new System.Drawing.Point(259, 559);
            this.btn_SaveDiagnosis_Text.Name = "btn_SaveDiagnosis_Text";
            this.btn_SaveDiagnosis_Text.Size = new System.Drawing.Size(239, 59);
            this.btn_SaveDiagnosis_Text.TabIndex = 1;
            this.btn_SaveDiagnosis_Text.Text = "Save Diagnosis";
            this.btn_SaveDiagnosis_Text.UseVisualStyleBackColor = false;
            this.btn_SaveDiagnosis_Text.Click += new System.EventHandler(this.btn_SaveDiagnosis_Text_Click);
            // 
            // btn_Close_Form
            // 
            this.btn_Close_Form.BackColor = System.Drawing.Color.Red;
            this.btn_Close_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close_Form.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Close_Form.Location = new System.Drawing.Point(620, 12);
            this.btn_Close_Form.Name = "btn_Close_Form";
            this.btn_Close_Form.Size = new System.Drawing.Size(112, 49);
            this.btn_Close_Form.TabIndex = 2;
            this.btn_Close_Form.Text = "Close";
            this.btn_Close_Form.UseVisualStyleBackColor = false;
            this.btn_Close_Form.Click += new System.EventHandler(this.btn_Close_Form_Click);
            // 
            // FormForWriteDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(122)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.btn_Close_Form);
            this.Controls.Add(this.btn_SaveDiagnosis_Text);
            this.Controls.Add(this.RichTxt_Diagnosis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(350, 150);
            this.Name = "FormForWriteDiagnosis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormForWriteDiagnosis";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTxt_Diagnosis;
        private System.Windows.Forms.Button btn_SaveDiagnosis_Text;
        private System.Windows.Forms.Button btn_Close_Form;
    }
}