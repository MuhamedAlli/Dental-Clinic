using DashBoard.ServicesDBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoard.Forms_Content
{
    public partial class AddNewUserForm : Form
    {
        public AddNewUserForm()
        {
            InitializeComponent();
        }

        private void AddNewUserForm_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void comobBoxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comobBoxUserType.SelectedIndex == 0)
            {
                txtEmail.ReadOnly = false;
                txtAddress.ReadOnly = true;
                numberSalary.ReadOnly = true;
                dataPickerHireDate.Enabled = false;
            }
            else
            {
                txtEmail.ReadOnly = true; ;
                txtAddress.ReadOnly = false;
                numberSalary.ReadOnly = false;
                dataPickerHireDate.Enabled = true;

            }
            //txtFullName.Text = "Eslam";
            //string str = txtFullName.Text;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (comobBoxUserType.SelectedIndex == 0)
            {
                if(UserBL.AddDoctorToDatabase(txtSSN.Text, txtPassword.Text, txtFullName.Text, txtPhoneNum.Text, txtEmail.Text))
                {
                    MessageBox.Show("Doctor Added Successfully");
                    ClearInputs();
                }
                
            }
            else if(comobBoxUserType.SelectedIndex == 1)
            {
                if(UserBL.AddReceptionistToDatabase(txtSSN.Text, txtPassword.Text, txtFullName.Text, txtPhoneNum.Text, txtAddress.Text, numberSalary.Value, dataPickerHireDate.Value))
                {
                    MessageBox.Show("Receptionist Added Successfully");
                    ClearInputs();
                }
                
            }
            else
            {
                MessageBox.Show("Please Select type of user");
            }
            FillDataGridView();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

        }

        private void dataGridAllUsers_DoubleClick(object sender, EventArgs e)
        {
            var selectedRow = dataGridAllUsers.Rows[dataGridAllUsers.CurrentCell.RowIndex];
            if (selectedRow.Cells["UserType"].Value.ToString() == "Doctor")
            {
                var doctor = UserBL.SelectDoctorBySSN(selectedRow.Cells["SSN"].Value.ToString());
                txtSSN.Text = doctor.Doc_SSN;
                txtSSN.ReadOnly = true;

                txtFullName.Text = doctor.FName;
                txtPhoneNum.Text = doctor.Phone;
                txtEmail.Text = doctor.Email;

                txtAddress.ReadOnly = true;
                numberSalary.ReadOnly = true;
                dataPickerHireDate.Enabled = false;

            }
            else
            {
                var recep = UserBL.SelectReceptionistBySSN(selectedRow.Cells["SSN"].Value.ToString());
                txtSSN.Text = recep.Recp_SSN;
                txtSSN.ReadOnly = true;

                txtFullName.Text = recep.FName;
                txtPhoneNum.Text = recep.Phone;

                txtEmail.ReadOnly = true;

                txtAddress.Text = recep.Address;

            }

            txtPassword.Text = UserBL.SelectUserPassword(selectedRow.Cells["SSN"].Value.ToString());
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridAllUsers.Rows[dataGridAllUsers.CurrentCell.RowIndex];
            if (selectedRow.Cells["UserType"].Value.ToString() == "Doctor")
            {
                if(UserBL.UpdateDoctor(txtSSN.Text, txtFullName.Text, txtPhoneNum.Text, txtEmail.Text,txtPassword.Text))
                    MessageBox.Show("Doctor Updated Successfully");
            }
            else
            {
                if(UserBL.UpdateReceptionist(txtSSN.Text, txtFullName.Text, txtPhoneNum.Text, txtAddress.Text, numberSalary.Value, dataPickerHireDate.Value,txtPassword.Text))
                    MessageBox.Show("Receptionist Updated Successfully");
            }
            FillDataGridView();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        void ClearInputs()
        {
            comobBoxUserType.SelectedIndex = -1;
            txtSSN.Text = "";
            txtPassword.Text = "";
            txtFullName.Text = "";
            txtPhoneNum.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";

            txtSSN.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtAddress.ReadOnly = false;
            numberSalary.ReadOnly = false;
            dataPickerHireDate.Enabled = true;
        }

        void FillDataGridView()
        {
            dataGridAllUsers.DataSource = null;
            dataGridAllUsers.DataSource = UserBL.AllUser();
        }
    }
}
