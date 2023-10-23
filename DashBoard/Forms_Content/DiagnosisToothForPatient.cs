using DashBoard.ModelDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DashBoard.Forms_Content
{
    public partial class DiagnosisToothForPatient : Form
    {
        DentalClinicEntities context;
        public DiagnosisToothForPatient()
        {
            context = new DentalClinicEntities();
            InitializeComponent();
        }

        private void fillcomboPatientName()
        {
            comboPatientName.DataSource = context.Patients.ToList();
            comboPatientName.ValueMember = "patient_Id";
            comboPatientName.DisplayMember = "FName";
        }
        void onToothNumberChange(int tNumber)
        {
            Tooth tooth = context.Teeth.FirstOrDefault(t => t.NumberTooth == tNumber);
            if (tooth != null)
            {
                byte[] imageData = tooth.Image;
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(stream: ms);
                    pxtoothImage.Image = image;
                }
            }
        }
        void getAllTeethData()
        {
            combToothNumber.Items.Clear();
            List<int> teethList = context.Teeth.Select(t => t.NumberTooth).ToList();
            combToothNumber.ValueMember = "NumberTooth";
            combToothNumber.DisplayMember = "NumberTooth";
            combToothNumber.DataSource = teethList;
            //foreach (int i in teethList)
            //{
            //    combToothNumber.Items.Add(i);
            //}
        }
        private void DiagnosisToothForPatient_Load(object sender, EventArgs e)
        {
            fillcomboPatientName();
            getAllTeethData();
        }


        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void combToothNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tooth = int.Parse(combToothNumber.Text.ToString());
            onToothNumberChange(tooth);
        }
        private byte[] ImageToByteArray(Image image)
        {
            pxtoothImage.Dispose();
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        //byte[] imageBytes;
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (pxtoothImage.Image != null && (int.TryParse(combToothNumber.Text, out int ToothNum) == true) && rtbToothDiag.Text != "" && comboPatientName.SelectedIndex != -1)
            {
                int result = Convert.ToInt32(comboPatientName.SelectedValue);

                //imageBytes = ImageToByteArray(pxtoothImage.Image);

                PatientTooth patientTooth = new PatientTooth()
                {
                    patient_Id = result,
                    NumberTooth = ToothNum,
                    Diagnosis = rtbToothDiag.Text
                };
                patientTooth.ImageTooth = context.Teeth.FirstOrDefault(t => t.NumberTooth == ToothNum).Image;
                context.PatientTeeth.Add(patientTooth);

                int recordEff = context.SaveChanges();

                if (recordEff > 0)
                {
                    MessageBox.Show("Added Diagnosis Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Failed To Add Diagnosis!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Plz Fill All Inputs!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearFields()
        {

            //comboPatientName.DataSource = null;
            //comboPatientName.Items.Clear();
            rtbToothDiag.Clear();
            pxtoothImage.Image=null;
            //combToothNumber.DataSource = null;
            //combToothNumber.Items.Clear();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
