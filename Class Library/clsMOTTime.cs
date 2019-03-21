using System;

namespace Class_Library
{
    public class clsMOTTime
    {
        private Int32 mMOTTimeID;

        public int MOTTimeID
        {
            get
            {
                return mMOTTimeID;
            }
            set
            {
                mMOTTimeID = value;
            }
        }

        private Int32 mMOTTime;
        public int MOTTime
        {
            get
            {
                return mMOTTime;
            }
            set
            {
                mMOTTime = value;
            }
        }

        public string Valid(string someMOTTime)
        {
            //string variable to store the error message
            string Error = "";
            // create a temporary variable to store the staff id
            Int32 MOTTimeTemp;
            try
            {
                MOTTimeTemp = Convert.ToInt32(someMOTTime);
                if (MOTTimeTemp < 10)
                {
                    Error = Error + "The MOT Time must be 10 or later ";
                }
                if (MOTTimeTemp > 16)
                {
                    Error = Error + "The MOT Time must be four digits : ";
                }
            }
            catch
            {
                Error = Error + "The MOT Time was not valid";
            }

            return Error;
        }
    }
}