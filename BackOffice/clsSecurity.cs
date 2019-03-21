using System;

namespace BackOffice
{
    internal class clsSecurity
    {
        public bool Authenticated { get; internal set; }
        public object Admin { get; internal set; }
        public string UserEMail { get; internal set; }

        internal void SignOut()
        {
            throw new NotImplementedException();
        }

        internal string SignIn(string text1, string text2)
        {
            throw new NotImplementedException();
        }

        internal string SignUp(string eMail, string password1, string password2, bool v)
        {
            throw new NotImplementedException();
        }

        internal string ChangePassword(string text1, string text2, string text3, string text4)
        {
            throw new NotImplementedException();
        }
    }
}