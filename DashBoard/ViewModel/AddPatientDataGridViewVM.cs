using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard.ViewModel
{
    internal class AddPatientDataGridViewVM
    {
        public int PatientID { get; set; }
        [Display(Name ="Full Name")]
        public string FName { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    }
}
