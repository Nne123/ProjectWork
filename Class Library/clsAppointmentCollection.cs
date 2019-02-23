using System.Collections.Generic;

namespace Class_Library
{
    public class clsAppointmentCollection
    {
        // private data member for the AllAppointments List
        private List<clsAppointment> mAppointmentList = new List<clsAppointment>();
        
        
        // public property for Count
        public int Count
        {
            get
            {
                return mAppointmentList.Count;
            }
            set
            {
                // we'll come back to
            }
        }

        // public property for AppointmentList
        public List<clsAppointment> AppointmentList
        {
            // getter sends dat to requesting code
            get
            {
                // return the private data member
                return mAppointmentList;
            }    
            // setter accepts data from other objects
            set
            {
                // assign the incoming value to the private data member
                mAppointmentList = value;
            }
        }
        
        public clsAppointment ThisAppointment { get; set; }
    }
}