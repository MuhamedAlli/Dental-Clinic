//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DashBoard.ModelDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Receptionist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Receptionist()
        {
            this.Appointments = new HashSet<Appointment>();
        }
    
        public string Recp_SSN { get; set; }
        public string FName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public System.DateTime HireDate { get; set; }
        public string SSN_User { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual user user { get; set; }
    }
}