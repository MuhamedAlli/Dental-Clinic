using DashBoard.ModelDAL;
using DashBoard.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DashBoard.ServicesDBL
{
    internal static class ReportBL
    {
        static DentalClinicEntities context;
        static ReportBL()
        {
            context = new DentalClinicEntities();
        }

        public static List<ReportDataGrid> GetReportDataGrid()
        {
            List<ReportDataGrid> reposrts = new List<ReportDataGrid>();
            var list = from Appoint in context.Appointments
                       join Patient in context.Patients
                       on Appoint.patient_Id equals Patient.patient_Id
                       join Recep in context.Receptionists
                       on Appoint.Recp_SSN equals Recep.Recp_SSN
                       select new
                       {
                           ID = Appoint.Id_Appointment,
                           Patient_Name = Patient.FName,
                           Appoint.Satuts,
                           Appoint.Date,
                           Appoint.Price,
                           Receptionist_Name = Recep.FName
                       };
            foreach (var item in list)
            {
                reposrts.Add(new ReportDataGrid()
                {
                    AppointmentID = item.ID,
                    PatientName = item.Patient_Name,
                    Status = item.Satuts,
                    Date = item.Date,
                    ReceptionistName = item.Receptionist_Name,
                    Price = item.Price
                });
            }
            return reposrts;

        }
        public static double TotalINcome(List<ReportDataGrid> list)
        {
            return list.Sum(S => S.Price);
        }
        public static List<ReportDataGrid> ReportsOnRange(DateTime start, DateTime end)
        {
            return GetReportDataGrid().Where(D => D.Date >= start && D.Date <= end).ToList();
        }
        public static List<ReportDataGrid> SearchByChar(string str)
        {
            return GetReportDataGrid().Where(S => S.PatientName.Contains(str)).ToList();
        }
    }
}
