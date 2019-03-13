using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_Library;

namespace BackOffice
{
    public partial class frmMainAppointment : Form
    {
        clsAppointment mThisAppointment = new clsAppointment();

        public frmMainAppointment()
        {
            InitializeComponent();
        }

        private void frmMainAppointment_Load(object sender, EventArgs e)
        {

        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            lblError.Text = DisplayAppointments() + "  found";
        }

        Int32 DisplayAppointments()
        {
            // create an instance of the appointment collection
            clsAppointmentCollection MyAppointments = new clsAppointmentCollection();
            // find all appointments
            MyAppointments.FindAllAppointments();
            // set the data source of the list box
            lstAppointments.DataSource = MyAppointments.AppointmentList;
            // set the text to be displayed
            lstAppointments.DisplayMember = "MOTDate";
            // set the primary key
            lstAppointments.ValueMember = "AppointmentID";
            // return the count in the list
            return MyAppointments.Count; 
        }

        Int32 AddAppointments()
        {
            // set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@MOTDate", mThisAppointment.MOTDate);
            DB.AddParameter("@MOTTimeID", mThisAppointment.MOTTimeID);
            DB.AddParameter("@CarRegNo", mThisAppointment.CarRegNo);
            DB.AddParameter("@CustomerID", mThisAppointment.CustomerID);
            DB.AddParameter("@StaffID", mThisAppointment.StaffID);
            DB.AddParameter("@JobID", mThisAppointment.JobID);
            DB.AddParameter("@Active", mThisAppointment.Active);
            // execute the query returing the primary key value
            return DB.Execute("sproc_tblAppointment_Insert");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
