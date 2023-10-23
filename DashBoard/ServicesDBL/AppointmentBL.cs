using DashBoard.ModelDAL;
using DashBoard.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoard.ServicesDBL
{
    internal class AppointmentBL
    {
        public DentalClinicEntities db;
        public AppointmentBL()
        {
            db = new DentalClinicEntities();
            
        }
        public  string GetDoctorName(string ssn)
        {
            return db.Doctors.FirstOrDefault(d=>d.Doc_SSN==ssn).FName;
        }
        public  string GetReceptionistName(string ssn)
        {
            var receptionName= db.Receptionists.FirstOrDefault(d => d.Recp_SSN == ssn).FName;
            if (receptionName != null)
                return receptionName;
            return null;
        }


        public string GetPatientNameById(int? patientId)
        {
            return db.Patients.FirstOrDefault(p=>p.patient_Id==patientId).FName;
        }
        public  List<AppointmentDataGridViewVM> fillDataGridViewAppoint()
        {
            var allPatientList = db.Appointments.Where(a=>a.IsValid==false).OrderByDescending(p => p.Id_Appointment).ToList();
            List<AppointmentDataGridViewVM> AllAppointmentVM = new List<AppointmentDataGridViewVM>();
            foreach (var appoint in allPatientList)
            {
                AllAppointmentVM.Add(new AppointmentDataGridViewVM()
                {
                    AppointmentId = appoint.Id_Appointment,
                    PatientName = GetPatientNameById(appoint.patient_Id),
                    Satuts = appoint.Satuts,
                    Price = appoint.Price,
                    Date = appoint.Date,
                    Time = appoint.Time.ToString("hh\\:mm"),
                    DoctorName = GetDoctorName(appoint.Doc_SSN),
                    ReceptionName = GetReceptionistName(appoint.Recp_SSN)
            }) ;
            }
            return AllAppointmentVM;
        }

       public void updateAppointment(int id, string comboPatientName, string combDoctorName,
       string combStatus, double price, DateTime Datepiker, TimeSpan timepiker)
        {
            int patientId = PatientBL.GetIdForPatient(comboPatientName);
            if (patientId == 0)
            {
                MessageBox.Show("Patient is not Exist");
            }
            else
            {
                string doctorId = PatientBL.GetIdForDoctor(combDoctorName);
                DateTime DateAppoint = Datepiker;
                if (DateAppoint <= DateTime.Now)
                {
                    MessageBox.Show("invalid Date");

                }
                var oldAppointment = db.Appointments.FirstOrDefault(p => p.Id_Appointment == id);
                oldAppointment.Time = timepiker;
                oldAppointment.Price = price;
                oldAppointment.Date = DateAppoint;
                oldAppointment.Satuts = combStatus;
                oldAppointment.patient_Id = patientId;
                oldAppointment.Doc_SSN = doctorId;
                oldAppointment.Recp_SSN = "30506070809012";
                db.SaveChanges();
                // db.Entry(oldAppointment).State = EntityState.Modified;

                MessageBox.Show("Update Successfully...");
            }
        }


    }
}
