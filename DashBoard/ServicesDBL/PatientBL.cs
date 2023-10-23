using DashBoard.ModelDAL;
using DashBoard.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoard.ServicesDBL
{
   
    internal class PatientBL
    {

        public static DentalClinicEntities db = new DentalClinicEntities();

        public PatientBL()
        {
            
        }
        public static int GetIdForPatient(string patientName)
        {
            var patient = db.Patients.FirstOrDefault(p => p.FName == patientName);
            if (patient != null)
                return patient.patient_Id;
            return 0;
            
   
        }
        public static string GetIdForDoctor(string DoctorName)
        {
            return db.Doctors.FirstOrDefault(p => p.FName == DoctorName).Doc_SSN;

        }
        public static List<AddPatientDataGridViewVM> fillDataGridViewPatient()
        {
            var allPatientList = db.Patients.OrderByDescending(p => p.patient_Id).ToList();

            List<AddPatientDataGridViewVM> AllpatientVM = new List<AddPatientDataGridViewVM>();
            foreach (var Patient in allPatientList)
            {
                AllpatientVM.Add(new AddPatientDataGridViewVM()
                {   
                    PatientID = Patient.patient_Id,
                    FName = Patient.FName,
                    Age = Patient.Age,
                    Gender = Patient.Gender,
                    Phone = Patient.Phone,
                    Address = Patient.Address
                });
            }
            return AllpatientVM;
        }
        public static void savepatient(string txtPatientName, int numpatientAge, string combGenderPatinet, string txtPatientAddress, string txtpatinetPhoneNumber) 
        {
            if (validateName_Address_Phone(txtPatientName, txtPatientAddress, txtpatinetPhoneNumber)==false 
                ||string.IsNullOrEmpty(combGenderPatinet))
            {
                MessageBox.Show("please try to enter correct data ");

            }
            else
            {
                
                var oldpatient = db.Patients.FirstOrDefault(p => p.FName == txtPatientName);

                if (oldpatient == null)
                {
                    Patient NewPatient = new Patient()
                    {
                        FName = txtPatientName,
                        Age = numpatientAge,
                        Gender = combGenderPatinet.ToString(),
                        Phone = txtpatinetPhoneNumber,
                        Address = txtPatientAddress,

                    };
                    db.Patients.Add(NewPatient);
                    db.SaveChanges();
                    MessageBox.Show("Data of Patient Successfully Created .....");
                }
                else
                    MessageBox.Show($"this patient is Exist :- {oldpatient.FName}");
            }
        }

        public static void updatePatient(int id,string txtPatientName, int numpatientAge, string combGenderPatinet, string txtPatientAddress, string txtpatinetPhoneNumber)
        {
            if (validateName_Address_Phone(txtPatientName, txtPatientAddress, txtpatinetPhoneNumber) == false
              || string.IsNullOrEmpty(combGenderPatinet))
            {
                MessageBox.Show("please try to enter correct data ....");

            }
            else
            {

                var oldpatient = db.Patients.FirstOrDefault(p => p.patient_Id == id);
                oldpatient.FName = txtPatientName;
                oldpatient.Gender = combGenderPatinet;
                oldpatient.Phone = txtpatinetPhoneNumber;
                oldpatient.Address = txtPatientAddress;
                oldpatient.Age = numpatientAge;
                db.SaveChanges();
                 db.Entry(oldpatient).State=EntityState.Modified;

                MessageBox.Show("Update Successfully...");
            }



            }
        public static void DeletePatient(int id)
        {
            var deletePatient = db.Patients.FirstOrDefault(p => p.patient_Id == id);

            if (deletePatient != null)
            {
                var confirmationResult = MessageBox.Show("Are you sure you want to delete the patient?", "Warning", MessageBoxButtons.OKCancel);

                if (confirmationResult == DialogResult.OK)
                {
                    db.Patients.Remove(deletePatient);
                    db.SaveChanges();
                    MessageBox.Show("Patient deleted successfully.", "Success");
                }
            }
            else
            {
                MessageBox.Show("Patient not found.", "Error");
            }
        }



        private static bool validateName_Address_Phone(string txtPatientName, string txtPatientAddress, string txtpatinetPhoneNumber)
        {
            if (chechName(txtPatientName) == true)
            {
                if (chechAddress(txtPatientAddress) == true)
                {
                    if (chechPhoneNumber(txtpatinetPhoneNumber) == true)
                    {
                        return true;
                    }
                    else 
                    { return false; }
                }
                else { return false; }
            }
            else
                return false;
        }

        private static bool chechName(string txtPatientName)
        {
            string fullNamePattern = @"^[a-zA-Z]{3,}(?:[\s.]+[a-zA-Z]{3,})*$";
            if (Regex.IsMatch(txtPatientName, fullNamePattern))
                return true;

            return false;

        }
        private static bool chechAddress(string txtPatientAddress)
        {
            string fullNamePattern = @"[A-Za-z0-9'\.\-\s\,]";
            if (Regex.IsMatch(txtPatientAddress, fullNamePattern))
                return true;

            return false;

        }
        private static bool chechPhoneNumber(string txtpatinetPhoneNumber)
        {
            string fullNamePattern = @"01[0125][0-9]{8}";
            if (Regex.IsMatch(txtpatinetPhoneNumber, fullNamePattern))
                return true;

            return false;

        }

    }
}
