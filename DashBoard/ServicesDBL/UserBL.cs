using DashBoard.ModelDAL;
using DashBoard.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DashBoard.ServicesDBL
{
    internal static class UserBL
    {
        static DentalClinicEntities context;
        static UserBL()
        {
            context = new DentalClinicEntities();
        }
        public static List<UserShowProperties> AllUser()
        {
            List<UserShowProperties> users = new List<UserShowProperties>();
            var userDoctors = from D in context.Doctors
                              join U in context.users
                              on D.SSN_User equals U.SSN_User
                              select new { D.SSN_User, D.FName };

            foreach (var user in userDoctors)
            {
                users.Add(new UserShowProperties()
                {
                    SSN = user.SSN_User,
                    Name = user.FName,
                    UserType = "Doctor"
                });
            }

            var userReceptionists = from D in context.Receptionists
                                    join U in context.users
                                    on D.SSN_User equals U.SSN_User
                                    select new { D.SSN_User, D.FName };

            foreach (var user in userReceptionists)
            {
                users.Add(new UserShowProperties()
                {
                    SSN = user.SSN_User,
                    Name = user.FName,
                    UserType = "Receptionist"
                });
            }

            return users;
        }

        #region Using Delegate
        //public static void AddNewUser(int type ,string ssn,string password,string name,string phone,string email,string address, decimal? salary,DateTime? hireDate,Action<string,string,string,string,string, decimal?,DateTime?> addNew)
        //{
        //    if (ValidationInputs.checkSSN(ssn) && SSNExists(ssn))
        //    {
        //        if (ValidationInputs.checkName(name))
        //        {
        //            if (ValidationInputs.checkPhoneNumber(phone))
        //            {
        //                if (password != "")
        //                {
        //                    if (type == 0)
        //                    {
        //                        if (ValidationInputs.checkEmail(email))
        //                        {
        //                            addNew(ssn, password, name, phone, email, null, null);
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("The Email must contain @");
        //                        }
        //                    }
        //                    else
        //                    {
        //                        if (ValidationInputs.checkAddress(address))
        //                        {
        //                            addNew(ssn, password, name, phone, address, salary, hireDate);
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Enter Valid Address");
        //                        }
        //                    }
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Enter the Password");
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("The Phone must be 11 number starts with 010 or 011 or 012 or 015");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("The Name must be at least 3 chars");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("The SSN must be 14 number or that SSN is already exists");
        //    }
        //} 
        #endregion

        static bool SSNExists(string ssn)
        {
            if (context.users.FirstOrDefault(U => U.SSN_User == ssn) == null)
                return false;
            return true;
        }
        public static bool ValidateUserInputs(int type, string ssn, string password, string name, string phone, string email, string address,string salary)
        {
            if (ValidationInputs.checkSSN(ssn))
            {
                if (ValidationInputs.checkName(name))
                {
                    if (ValidationInputs.checkPhoneNumber(phone))
                    {
                        if (password != "")
                        {
                            if (type == 0)
                            {
                                if (ValidationInputs.checkEmail(email))
                                {
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show("The Email must contain @");
                                }
                            }
                            else
                            {
                                if (ValidationInputs.checkAddress(address))
                                {
                                    if (ValidationInputs.checkSalary(salary))
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Salary must be more than 0");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Enter Valid Address");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter the Password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Phone must be 11 number starts with 010 or 011 or 012 or 015");
                    }
                }
                else
                {
                    MessageBox.Show("The Name must be at least 3 chars");
                }
            }
            else
            {
                MessageBox.Show("The SSN must be 14 number or that SSN is already exists");
            }
            return false;
        }

        public static bool AddDoctorToDatabase(string ssn, string password, string name, string phone, string email)
        {
            if (!SSNExists(ssn))
            {
                if (ValidateUserInputs(0, ssn, password, name, phone, email, null,null))
                {
                    user newUser = new user()
                    {
                        SSN_User = ssn,
                        PasswordHash = password,
                        Role = "User"
                    };
                    Doctor newDoctor = new Doctor()
                    {
                        Doc_SSN = ssn,
                        FName = name,
                        Phone = phone,
                        Email = email,
                        user = newUser
                    };
                    try
                    {
                        context.Doctors.Add(newDoctor);
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                return true;
            }
            else
            {
                MessageBox.Show("That SSN is already exists");
            }
            return false;
        }
        public static bool AddReceptionistToDatabase(string ssn, string password, string name, string phone, string address, decimal salary, DateTime hireDate)
        {
            if (!SSNExists(ssn))
            {
                if (ValidateUserInputs(1, ssn, password, name, phone, null, address, salary.ToString()))
                {
                    user newUser = new user()
                    {
                        SSN_User = ssn,
                        PasswordHash = password,
                        Role = "User"
                    };

                    Receptionist newReceptionist = new Receptionist()
                    {
                        Recp_SSN = ssn,
                        FName = name,
                        Phone = phone,
                        Address = address,
                        Salary = float.Parse(salary.ToString()),
                        HireDate = hireDate,
                        user = newUser
                    };

                    try
                    {
                        context.Receptionists.Add(newReceptionist);
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                return true;
            }
            else
            {
                MessageBox.Show("That SSN is already exists");
            }
            return false;
        }

        // -------------------------------->>>
        public static Doctor SelectDoctorBySSN(string ssn)
        {
            return context.Doctors.FirstOrDefault(D => D.Doc_SSN == ssn);
        }

        public static Receptionist SelectReceptionistBySSN(string ssn)
        {
            return context.Receptionists.FirstOrDefault(R => R.Recp_SSN == ssn);
        }
        public static string SelectUserPassword(string ssn)
        {
            return context.users.FirstOrDefault(U => U.SSN_User == ssn)?.PasswordHash ?? "";
        }

        public static bool UpdateDoctor(string ssn, string name, string phone, string email, string password)
        {
            try
            {
                if (ValidateUserInputs(0, ssn, password, name, phone, email, null, null))
                {
                    var doc = context.Doctors.FirstOrDefault(D => D.Doc_SSN == ssn);
                    doc.FName = name;
                    doc.Phone = phone;
                    doc.Email = email;

                    var recepPassword = context.users.FirstOrDefault(U => U.SSN_User == ssn);
                    recepPassword.PasswordHash = password;

                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public static bool UpdateReceptionist(string ssn, string name, string phone, string address, decimal salary, DateTime hireDate, string password)
        {
            try
            {
                if (ValidateUserInputs(1, ssn, password, name, phone, null, address,salary.ToString()))
                {
                    var recep = context.Receptionists.FirstOrDefault(R => R.Recp_SSN == ssn);

                    recep.FName = name;
                    recep.Phone = phone;
                    recep.Address = address;
                    recep.Salary = float.Parse(salary.ToString());
                    recep.HireDate = hireDate;

                    var recepPassword = context.users.FirstOrDefault(U => U.SSN_User == ssn);
                    recepPassword.PasswordHash = password;

                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }
}
