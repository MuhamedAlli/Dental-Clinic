using DashBoard.ModelDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DashBoard.ServicesDBL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DashBoard.ViewModel;

namespace DashBoard.Forms_Content
{
    public enum Gender
    {
        male = 'M', female = 'F',
    }
    public partial class PatientForm : Form
    {
       // DentalClinicEntities db = new DentalClinicEntities();
        public PatientForm()
        {
            InitializeComponent();

            reloadFormPatientDataGridView();

        }

        private void reloadFormPatientDataGridView()
        {
            var allPatient = PatientBL.fillDataGridViewPatient();
            dataGridAllPatient.DataSource = null;
            // Hide the "PatientID" column
            dataGridAllPatient.DataSource = allPatient;
            if (dataGridAllPatient.Columns.Contains("PatientID"))
            {
                dataGridAllPatient.Columns["PatientID"].Visible = false;
            }
          
        }



        private void btnPatientSave_Click(object sender, EventArgs e)
        {

            string txtPatientName1 = txtPatientName.Text;
            int numpatientAge1 = int.Parse(numpatientAge.Value.ToString());
            string combGenderPatinet1 = combGenderPatinet.Text;
            string txtPatientAddress1 = txtPatientAddress.Text;
            string txtpatinetPhoneNumber1 = txtpatinetPhoneNumber.Text;
            PatientBL.savepatient(txtPatientName1, numpatientAge1, combGenderPatinet1, txtPatientAddress1, txtpatinetPhoneNumber1);
            reloadFormPatientDataGridView();
            clearfileds();
            dataGridAllPatient.Refresh();


        }
        private void dataGridAllPatient_SelectionChanged(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridAllPatient.Rows[e.RowIndex];
                txtPatientName.Text = selectedRow.Cells["FName"].Value.ToString();
                combGenderPatinet.Text = selectedRow.Cells["Gender"].Value.ToString();
                txtPatientAddress.Text = selectedRow.Cells["Address"].Value.ToString();
                txtpatinetPhoneNumber.Text = selectedRow.Cells["Phone"].Value.ToString();
                numpatientAge.Value = int.Parse(selectedRow.Cells["Age"].Value.ToString());
            }
        }

        private void btnPatientEdit_Click(object sender, EventArgs e)
        {

            if (dataGridAllPatient.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridAllPatient.SelectedRows[0];
                int id = int.Parse(selectedRow.Cells["PatientID"].Value.ToString());
                PatientBL.updatePatient(id, txtPatientName.Text,int.Parse(numpatientAge.Value.ToString())
                    ,combGenderPatinet.Text, txtPatientAddress.Text, txtpatinetPhoneNumber.Text);

                
            }
            clearfileds();
            dataGridAllPatient.DataSource= null;
            reloadFormPatientDataGridView();

        }

        private void clearfileds()
        {
            txtPatientName.Clear();
            numpatientAge.ResetText();
            combGenderPatinet.ResetText();
            txtPatientAddress.Clear();
            txtpatinetPhoneNumber.Clear();
        }

        private void btnPatientDelete_Click(object sender, EventArgs e)
        {
            if (dataGridAllPatient.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridAllPatient.SelectedRows[0];
                int id = int.Parse(selectedRow.Cells["PatientID"].Value.ToString());
                PatientBL.DeletePatient(id);
                reloadFormPatientDataGridView();

            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clearfileds();
        }
    }
}
