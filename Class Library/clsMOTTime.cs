using System;

namespace Class_Library
{
    public class clsMOTTime
    {
        public int MOTTimeID { get; set; }
        public int MOTTime { get; set; }

        public string Valid(int someMOTTime)
        {
            //string variable to store the error message
            string Error = "";
            // create a temporary variable to store the staff id
            Int32 MOTTimeTemp;
            try
            {
                MOTTimeTemp = Convert.ToInt32(MOTTime);
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