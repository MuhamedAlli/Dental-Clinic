using DashBoard.ModelDAL;
using DashBoard.ServicesDBL;
using DashBoard.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoard.Forms_Content
{
    public partial class DiagnosisForm : Form
    {
        
        DentalClinicEntities db;
        FormForWriteDiagnosis FormWriteDiagnosis;
        public int PatieniID=0;
        public int AppointmentID=0;
        public int DiagnosisId = 0;
        public DataGridView DatGrid { get { return dataGridViewHistoryDiagnosis; } set { value = dataGridViewHistoryDiagnosis; } }
        //public string Text_Of_Diagnosis { get { return Rich_textBox_Diagnosis.Text; } set { Rich_textBox_Diagnosis.Text = value; } }
        public DiagnosisForm()
        {
            db=new DentalClinicEntities();
            InitializeComponent();
            fillcomboPatientDiagnosisName();
            var patient = db.Patients.ToList().LastOrDefault().FName;
            comboPatientNameDiagnosis.Text = patient;
        }
        private void fillcomboPatientDiagnosisName()
        {
            comboPatientNameDiagnosis.DataSource = db.Patients.ToList();
            comboPatientNameDiagnosis.ValueMember = "patient_Id";
            comboPatientNameDiagnosis.DisplayMember = "FName";
        }
        private void Appointment_Load(object sender, EventArgs e)
        {
           

         
        }

        private void btnSearchDig_Click(object sender, EventArgs e)
        {

            Patient patientDig = db.Patients.FirstOrDefault(p => p.FName == comboPatientNameDiagnosis.Text);
            if (patientDig != null)
            {
                int patientId = patientDig.patient_Id;
                var appointment = db.Appointments.Where(p => p.patient_Id == patientId).ToList();
                if (appointment != null)
                {
                   // int appointmentId = appointment.Id_Appointment;
                    txtPatientNameDig.Text = patientDig.FName;
                    numpatientAgeDig.Value = patientDig.Age;
                    combGenderPatinetDig.Text = patientDig.Gender;
                    txtpatinetPhoneNumberDig.Text = patientDig.Phone;
                    txtPatientAddressDig.Text = patientDig.Address;
                    fillDataGridViewPatientDiagnosis(patientId);

                }
                else
                {
                    MessageBox.Show("Appointment not Exist");
                }
            }
            else
                MessageBox.Show("Patient not Exist");

        }



        public void fillDataGridViewPatientDiagnosis(int patientId)
        {
            PatieniID = patientId;

            var query = from t1 in db.Patients
                        join t2 in db.Appointments on t1.patient_Id equals t2.patient_Id
                        join t3 in db.Diagnosis on t2.Id_Appointment equals t3.Id_Appointment
                        where t1.patient_Id == patientId
                        select new
                        {
                            // Select the properties you need from the joined tables
                             t2.Date,
                             t3.Description_Diagnosis,
                             t3.Id_Appointment,
                             t3.Diagnosis_Id
                        };

            var result= query.ToList();

            dataGridViewHistoryDiagnosis.DataSource = result;
            if (dataGridViewHistoryDiagnosis.Columns.Contains("Id_Appointment")&& dataGridViewHistoryDiagnosis.Columns.Contains("Diagnosis_Id"))
            {
                dataGridViewHistoryDiagnosis.Columns["Id_Appointment"].Visible = false;
                dataGridViewHistoryDiagnosis.Columns["Diagnosis_Id"].Visible = false;
            }

        }

        private void btnAddDig_Click(object sender, EventArgs e)
        {

            if (PatieniID == 0 || AppointmentID == 0)
            {

                MessageBox.Show("You Must select a Patient firstly .....", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                var appointment = db.Appointments.Where(p => p.patient_Id == PatieniID).ToList().Last().Id_Appointment;
                AppointmentID = appointment;
                string StTextDefault = "";
                FormWriteDiagnosis = new FormForWriteDiagnosis(this, PatieniID, AppointmentID, 0, StTextDefault);
                FormWriteDiagnosis.ShowDialog();
            }

        }

        private void dataGridViewDiagnosis_SelectionChanged(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewHistoryDiagnosis.Rows[e.RowIndex];
                string OldDiagnosisText = selectedRow.Cells["Description_Diagnosis"].Value.ToString();
                AppointmentID = int.Parse(selectedRow.Cells["Id_Appointment"].Value.ToString());
                DiagnosisId = int.Parse(selectedRow.Cells["Diagnosis_Id"].Value.ToString());
                FormWriteDiagnosis = new FormForWriteDiagnosis(this, PatieniID, AppointmentID, DiagnosisId, OldDiagnosisText);
                FormWriteDiagnosis.ShowDialog();
                
            }
            dataGridViewHistoryDiagnosis.Refresh();
            fillDataGridViewPatientDiagnosis(PatieniID);

        }

        private void btnSpecialDog_Click(object sender, EventArgs e)
        {
            DiagnosisToothForPatient toothForPatient = new DiagnosisToothForPatient();
            toothForPatient.ShowDialog();


        }
    }
}
