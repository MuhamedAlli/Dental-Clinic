using DashBoard.Forms_Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoard
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Run(new LoginForm());


        }
    }

    internal class AppointmentClass
    {

        public int Receptionist_SSN { get; set; }
        public int PatientID { get; set; }
        public int Price { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
