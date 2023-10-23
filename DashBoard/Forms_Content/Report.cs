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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            dataGridAppointments.DataSource = null;
            dataGridAppointments.DataSource = ReportBL.GetReportDataGrid();
            lblTotalIncome.Text = ReportBL.TotalINcome(ReportBL.GetReportDataGrid()).ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridAppointments.DataSource = null;
            dataGridAppointments.DataSource = ReportBL.ReportsOnRange(PickerFromDate.Value,PickerToDate.Value);
            lblTotalIncome.Text = ReportBL.TotalINcome(ReportBL.ReportsOnRange(PickerFromDate.Value, PickerToDate.Value)).ToString();
        }

        private void btnSearchByPatientName_Click(object sender, EventArgs e)
        {
            //dataGridAppointments.DataSource = null;
            //dataGridAppointments.DataSource = ReportBL.SearchByPatientName(PickerFromDate.Value, PickerToDate.Value,txtPatientName.Text);
            //lblTotalIncome.Text = "0";
        }

        private void txtPatientName_TextChanged(object sender, EventArgs e)
        {
            dataGridAppointments.DataSource = null;
            dataGridAppointments.DataSource = ReportBL.SearchByChar(txtPatientName.Text);
            lblTotalIncome.Text = ReportBL.TotalINcome(ReportBL.SearchByChar(txtPatientName.Text)).ToString();
        }
    }
}
