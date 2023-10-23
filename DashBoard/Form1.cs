using DashBoard.ModelDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoard
{
    public partial class Form1 : Form
    {
        int _FormAppointment = 0;
        int _FormPatient = 0;
        int _FormDiagnosis = 0;
        int _FormTeeth = 0;
        int _FormReport = 0;
        int _FormUser = 0;
        private Form activeForm;
        public bool Isvisabe=false;

        // form layout
        private Button currentButton;


        DentalClinicEntities db =new DentalClinicEntities();
        public Form1()
        {   
            InitializeComponent();
            var user=db.users.FirstOrDefault(u=>u.Role=="User"&&u.IsLogin==true);
            if(user  != null)
            {
                btn_Diagnosis.Visible = false;
                btn_Teeth.Visible = false;
                btn_Reports.Visible = false;
                btn_Users.Visible = false;
                Isvisabe = true;
            }
          
        }

        // form layout
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1_Content.Controls.Add(childForm);
            this.panel1_Content.Tag = childForm;
            //childForm.BringToFront();
            childForm.Show();
            label1_title.Text = childForm.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _FormPatient = 0;
            _FormDiagnosis = 0;
            _FormTeeth= 0;
            _FormReport = 0;
            _FormUser = 0;
            if (_FormAppointment == 0) {
                _FormAppointment = 1;
                OpenChildForm(new Forms_Content.AppointmentForm(), sender);
            }
        }

        private void BtnPatient_Click(object sender, EventArgs e)
        {
            _FormAppointment = 0;
            _FormDiagnosis = 0;
            _FormTeeth = 0;
            _FormReport = 0;
            _FormUser = 0;
            if (_FormPatient == 0)
            {
                _FormPatient = 1;
                OpenChildForm(new Forms_Content.PatientForm(), sender);
            }
        }

        private void btn_Diagnosis_Click(object sender, EventArgs e)
        {
            _FormAppointment = 0;
            _FormPatient = 0;
            _FormTeeth = 0;
            _FormReport = 0;
            _FormUser = 0;
            if (_FormDiagnosis == 0)
            {
                _FormDiagnosis = 1;
                OpenChildForm(new Forms_Content.DiagnosisForm(), sender);
            }
        }

        private void btn_Teeth_Click(object sender, EventArgs e)
        {

            _FormAppointment = 0;
            _FormPatient = 0;
            _FormDiagnosis = 0;
            _FormReport = 0;
            _FormUser = 0;
            if (_FormTeeth == 0)
            {
                _FormTeeth = 1;
                OpenChildForm(new Forms_Content.TeethForm(), sender);
            }

        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            _FormAppointment = 0;
            _FormPatient = 0;
            _FormDiagnosis = 0;
            _FormTeeth = 0;
            _FormUser = 0;
            if (_FormReport == 0)
            {
                _FormReport = 1;
                OpenChildForm(new Forms_Content.ReportForm(), sender);
            }

        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            _FormAppointment = 0;
            _FormPatient = 0;
            _FormDiagnosis = 0;
            _FormTeeth = 0;
            _FormReport = 0;
            if (_FormUser == 0)
            {
                _FormUser = 1;
                OpenChildForm(new Forms_Content.UserForm(), sender);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {}

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                Rectangle rect = Screen.FromHandle(this.Handle).WorkingArea;
                rect.Location = new Point(0, 0);
                this.MaximizedBounds = rect;
                this.WindowState = FormWindowState.Maximized;
                //this.btnClose.BackColor = Color.Red;
            }
        }

        private void layoutPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
