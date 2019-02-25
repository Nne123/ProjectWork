using System.Collections.Generic;

namespace Class_Library
{
    public class clsMOTTimeCollection
    {
        private List<clsMOTTime> mAllMOTTimes = new List<clsMOTTime>();

        // public constructor for the class
        public clsMOTTimeCollection()
        {
            // create an instance of the class we want to create
            clsMOTTime AMOTTime = new clsMOTTime();
            // set the MOTTime to 13
            AMOTTime.MOTTime = 13;
            // add the MOTTime to the private list of MOTTimes
            mAllMOTTimes.Add(AMOTTime);
            // re initialise the AMOTTime object to accept a new item
            AMOTTime = new clsMOTTime();
            // set the MOTTime 16
            AMOTTime.MOTTime = 16;
            // add the seconf mot time to the private list of MOTTimes
            mAllMOTTimes.Add(AMOTTime);
            // the private list now contains two counties
        }

        // public property for Count
        public int Count
        {
            get
            {
                // return the count property of the private list
                return mAllMOTTimes.Count;
            }
            set
            {
                // later
            }
        }
        public List<clsMOTTime> AllMOTTimes
        {
            // getter sends data to requesting code
            get
            {
                // return the private data member
                return mAllMOTTimes;
            }
            // setter accepts data from other objects
            set
            {
                // assign the incoming value to the private data member
                mAllMOTTimes = value;
            }
        
        }

    }
}