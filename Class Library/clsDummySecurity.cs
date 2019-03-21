using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// This class simulates simple authentication
/// clearly the completed version of this code would link to the data layer
/// </summary>


namespace Class_Library
{
    public class clsDummySecurity
    {
        public Int32 SignIn(string UserName, string Password)
        {
            //if there is some text in username and password
            if (UserName != "" & Password != "")
            {
                //return a hard coded user id of 42
                return 42;
            }
            else
            {
                //otherwise return 0 indicating user not found
                return 0;
            }
        }
    }
}