using System.Collections.Generic;

namespace Class_Library
{
    public class clsAppointmentCollection
    {
        public List<clsAppointment> AppointmentList { get; set; }
        public int Count { get; set; }
        public clsAppointment ThisAppointment { get; set; }
    }
}