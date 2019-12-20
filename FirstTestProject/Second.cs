using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstTestProject
{
    class Second
    {
       public string str = "variable value";
        public void AppLaunch()
        {
            Console.WriteLine("Launch Browser");
            Console.WriteLine("navigate to URL");
            Console.WriteLine("Maximize Browser");
        }
        public void AppLogin(string UserNme, string Pws)
        {
            Console.WriteLine("Entering Username-"+ UserNme);
            Console.WriteLine("Entering Password-"+ Pws);
            Console.WriteLine("Click Login");
        }

        public string ValidateLogin(string UserNme, string Pws)
        {

            Console.WriteLine("Entering Username-" + UserNme);
            Console.WriteLine("Entering Password-" + Pws);
            Console.WriteLine("Click Login");
            //Asume we are getting this text from application
            string text = "Welcome " + UserNme;
            return text;
        }

        public int addnumbers(int a, int b)
        {
            int c = a + b;
            return c;
        }


    }

}
