using DashBoard.ModelDAL;
using DashBoard.ServicesDBL;
using DashBoard.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoard.Forms_Content
{
    public partial class FormForWriteDiagnosis : Form
    {
        DentalClinicEntities db;
        public DiagnosisForm formDiagnosis_Obj;
        public int PatintID;
        public int AppointementID;
        public string DescriptionText;
        public int Diagnosis_Id;
        public FormForWriteDiagnosis(DiagnosisForm form1,int _PatieniID,int _AppointmentID, int _Diagnosis_Id,string _DescriptionText)
        {
            InitializeComponent();
            formDiagnosis_Obj = form1;
            PatintID = _PatieniID;
            AppointementID = _AppointmentID;
            DescriptionText = _DescriptionText;
            db = new DentalClinicEntities();
            RichTxt_Diagnosis.Text = DescriptionText;
            Diagnosis_Id = _Diagnosis_Id;

        }

        private void btn_SaveDiagnosis_Text_Click(object sender, EventArgs e)
        {

            //formDiagnosis_Obj.Text_Of_Diagnosis = RichTxt_Diagnosis.Text;
            //MessageBox.Show(formDiagnosis_Obj.Text_Of_Diagnosis.ToString());
            if (PatintID == 0 || AppointementID == 0  || RichTxt_Diagnosis.Text.Length == 0)
            {

                MessageBox.Show("No Diagnosis is Insereted or Return To Select Patient");

            }
            else {

                formDiagnosis_Obj.DatGrid.DataSource = null;
                db.Diagnosis.AddOrUpdate(new Diagnosi {Diagnosis_Id=Diagnosis_Id, patient_Id = PatintID ,Id_Appointment= AppointementID ,Description_Diagnosis= RichTxt_Diagnosis.Text });
                var appointment=db.Appointments.FirstOrDefault(a => a.Id_Appointment == AppointementID);
                appointment.IsValid = true;
                db.SaveChanges();

               // formDiagnosis_Obj.fillDataGridViewPatientDiagnosis(PatintID, AppointementID);
                this.Close();
            }
            
        }

        private void btn_Close_Form_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
