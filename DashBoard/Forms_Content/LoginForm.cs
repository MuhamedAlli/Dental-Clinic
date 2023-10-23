//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace DashBoard.Forms_Content
//{
//    public partial class LoginForm : Form
//    {
//        public LoginForm()
//        {
//            InitializeComponent();
//        }
//    }
//}

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

namespace DashBoard.Forms_Content
{
    public partial class LoginForm : Form
    {
        DentalClinicEntities db;
        public LoginForm()
        {
            db=new DentalClinicEntities();
            InitializeComponent();
        }
        private void closedbtn_Click(object sender, EventArgs e)
        {
            // this.Close();
            Application.Exit();
        }
        private void ImageShowPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == false)
                txtPassword.UseSystemPasswordChar = true;
            else
                txtPassword.UseSystemPasswordChar = false;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length!=0 || txtPassword.Text.Length!=0)
            {
                user loginuser = db.users.FirstOrDefault(u => u.SSN_User == txtUserName.Text);
                if (loginuser != null)
                {
                    if (loginuser.SSN_User == txtUserName.Text && loginuser.PasswordHash == txtPassword.Text)
                    {
                        loginuser.IsLogin = true;
                        db.SaveChanges();
                        this.Hide();
                        Form1 mainForm = new Form1();
                        mainForm.ShowDialog();
                        loginuser.IsLogin = false;
                        db.SaveChanges();
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("username or password invalid");
                    }
                }
                else
                    MessageBox.Show("username or password invalid");
            }
            else
                MessageBox.Show("Enter your username and password");

        }

    }
}

