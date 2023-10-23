using DashBoard.ModelDAL;
using DashBoard.ServicesDBL;
using DashBoard.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DashBoard.Forms_Content
{
    public partial class AppointmentForm : Form
    {
          DentalClinicEntities db;
        AppointmentBL AppointmentBL = new AppointmentBL();
       // Form1 mainform { get; set; }

        public AppointmentForm()
        {
            db = new DentalClinicEntities();
            InitializeComponent();
            fillcomboPatientName();
            fillcomboDoctorName();
            fillDataGridViewAppointment();
            var patient = db.Patients.ToList().LastOrDefault().FName;
            comboPatientName.Text = patient;
        }

        private void fillDataGridViewAppointment()
        {   
            List<AppointmentDataGridViewVM> allappointments = AppointmentBL.fillDataGridViewAppoint();
            dataGridAppointments.DataSource = null;
            dataGridAppointments.DataSource= allappointments;
            if (dataGridAppointments.Columns.Contains("AppointmentId"))
            {
                dataGridAppointments.Columns["AppointmentId"].Visible = false;
            }
            ClearFileds();
        }

        private void fillcomboDoctorName()
        {
            var AllDoctor=db.Doctors.ToList();
            combDoctorName.ValueMember = "Doc_SSN";
            combDoctorName.DisplayMember = "FName";
            combDoctorName.DataSource = AllDoctor;
        }

        private void fillcomboPatientName()
        {
            comboPatientName.DataSource = db.Patients.ToList();
            comboPatientName.ValueMember = "patient_Id";
            comboPatientName.DisplayMember = "FName";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
             int patientId=PatientBL.GetIdForPatient(comboPatientName.Text);
            if (patientId == 0)
            {
                MessageBox.Show("Patient is not Exist");
            }
            else
            {
                string doctorId = PatientBL.GetIdForDoctor(combDoctorName.Text);
                DateTime DateAppoint = PickerDateApointent.Value;
                if (DateTime.Now.Day>DateAppoint.Day)
                {
                    MessageBox.Show("invalid Date");
                }
                else
                {
                   

                    user addAppointment = null;
                    Form1 mainform = new Form1();
                
                   
                    if (mainform.Isvisabe == false)
                    {
                        addAppointment = db.users.FirstOrDefault(u => u.IsLogin == true && u.Role == "Admin");

                    }
                    else
                        addAppointment = db.users.FirstOrDefault(u => u.IsLogin == true && u.Role == "User");
                   
                    if (addAppointment != null)
                    {
                        Appointment appointment = new Appointment()
                        {
                            Satuts = combStatus.Text,
                            Price = double.Parse(numupdownPrice.Value.ToString()),
                            Date = PickerDateApointent.Value,
                            Time = PickerTimeApointment.Value.TimeOfDay,
                            patient_Id = patientId,
                            Doc_SSN = doctorId,
                            Recp_SSN = addAppointment.SSN_User

                        };
                        db.Appointments.Add(appointment);
                        db.SaveChanges();
                    }
                    else
                        MessageBox.Show("You must login as Receptionist");
                }
            }
            fillDataGridViewAppointment();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dataGridAppointments.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridAppointments.SelectedRows[0];
                int id = int.Parse(selectedRow.Cells["AppointmentId"].Value.ToString());
                var appointremove = db.Appointments.Find(id);
                if (appointremove != null)
                {
                    var confirmationResult = MessageBox.Show("Are you sure you want to delete the Appointment?", "Warning", MessageBoxButtons.OKCancel);

                    if (confirmationResult == DialogResult.OK)
                    {
                        db.Appointments.Remove(appointremove);
                        db.SaveChanges();
                        MessageBox.Show("Appointment deleted successfully.", "Success");
                    }
                }
            }
             else
                MessageBox.Show("Please select patient");
             
            
            fillDataGridViewAppointment();


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           if (dataGridAppointments.SelectedRows.Count > 0)
           {
              DataGridViewRow selectedRow = dataGridAppointments.SelectedRows[0];
              int id = int.Parse(selectedRow.Cells["AppointmentId"].Value.ToString());
              AppointmentBL.updateAppointment(id, comboPatientName.Text, combDoctorName.Text
                       ,combStatus.Text, double.Parse(numupdownPrice.Value.ToString()), PickerDateApointent.Value,
                        PickerTimeApointment.Value.TimeOfDay);
           }
            else
                MessageBox.Show("Please select patient");
          
            fillDataGridViewAppointment();

        }
        private void dataGridViewAppointment_SelectionChanged(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridAppointments.Rows[e.RowIndex];
                comboPatientName.Text = selectedRow.Cells["PatientName"].Value.ToString();
                combDoctorName.Text = selectedRow.Cells["DoctorName"].Value.ToString();
                combStatus.Text = selectedRow.Cells["Satuts"].Value.ToString();
                numupdownPrice.Value =decimal.Parse(selectedRow.Cells["Price"].Value.ToString());
                PickerDateApointent.Value =DateTime.Parse(selectedRow.Cells["Date"].Value.ToString());
                PickerTimeApointment.Value = DateTime.Parse(selectedRow.Cells["Time"].Value.ToString());
            }
        }


        private void ClearFileds()
        {
            comboPatientName.Text = null;
            combDoctorName.SelectedIndex=0;
            combStatus.SelectedIndex=0;
            numupdownPrice.Value = 0;
            PickerDateApointent.Value = DateTime.Now;
            PickerTimeApointment.Value = DateTime.Now;

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFileds();
        }
    }
}
