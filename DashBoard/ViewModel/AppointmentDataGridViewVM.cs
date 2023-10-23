using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard.ViewModel
{
    internal class AppointmentDataGridViewVM
    {
        public int AppointmentId { get; set; }
        public string PatientName { get; set; }
        public string Satuts { get; set; }
        public double Price { get; set; }
        public System.DateTime Date { get; set; }
        public string Time { get; set; }
        public string DoctorName { get; set; }
        public string ReceptionName { get; set; }
    }
}
