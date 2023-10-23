using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DashBoard.ServicesDBL
{
    internal static class ValidationInputs
    {
        public static bool checkSSN(string ssn)
        {
            string ssnPattern = @"[0-9]{14}";
            if (Regex.IsMatch(ssn, ssnPattern))
                return true;

            return false;
        }
        public static bool checkName(string name)
        {
            string fullNamePattern = @"^[a-zA-Z]{2,}(?:[\s.]+[a-zA-Z]{3,})*$";
            if (Regex.IsMatch(name, fullNamePattern))
                return true;

            return false;

        }
        public static bool checkAddress(string address)
        {
            string addressPattern = @"[A-Za-z0-9'\.\-\s\,]";
            if (Regex.IsMatch(address, addressPattern))
                return true;

            return false;

        }
        public static bool checkPhoneNumber(string phone)
        {
            string phonePattern = @"01[0125][0-9]{8}$";
            if (Regex.IsMatch(phone, phonePattern))
                return true;

            return false;

        }
        public static bool checkEmail(string email)
        {
            try
            {
                var m = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool checkSalary(string salary)
        {
            if(float.TryParse(salary,out float salary2))
            {
                if (salary2 > 0)
                    return true;
                return false;
            }
            return false;
        }
    }
}
