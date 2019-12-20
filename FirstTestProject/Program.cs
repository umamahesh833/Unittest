using System;
using System.Threading;

namespace FirstTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating obj for class Second
            ThirdClassname Obj = new ThirdClassname();

            Obj.AppLogin("username", "password");
            Obj.classthreemethod();
            added line in main mehtod

            Thread.Sleep(100000);
        }


    }
}
