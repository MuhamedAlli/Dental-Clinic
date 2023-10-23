using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard.ViewModel
{
    internal class ReportDataGrid
    {
        [Display(Name = "ID")]
        public int AppointmentID { get; set; }
        [Display(Name = "Patient Name")]
        public string PatientName { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        [Display(Name = "Receptionist")]
        public string ReceptionistName { get; set; }
        public double Price { get; set; }
    }
}

