using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SCAT
{
    public class ClassCalc
    {
        public bool Check(string Login, string Password)
        {
            string LoginUser = "1";
            bool result = false;
            if (Login == LoginUser)
            {
                result = true;

            }
            return result;
            //if (Login == "1" && Password == "12")
            //{
            //    MessageBox.Show("hgh");
            //    return true;
            //}
            //else return false;
        }
        private void Check()
        {
            //string a = TxtLogin.Text;
            //string b = TxtPassword.Text;
            //if (a == "1" && b == "12")
            //{
            //    MessageBox.Show("hgh");

            //}
            //else return;
        }
    }
}
