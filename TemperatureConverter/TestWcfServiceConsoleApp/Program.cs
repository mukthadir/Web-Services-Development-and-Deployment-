using System;

namespace TestWcfServiceConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            myServiceRef.Service1Client myWCFProxy = new myServiceRef.Service1Client();

            int celcius = 45;
            int farenheit = 60;

            int f = myWCFProxy.c2f(celcius);
            int c = myWCFProxy.f2c(farenheit);
            
            Console.WriteLine("converted farenheit is {0}", f);
            Console.WriteLine("converted celcius is {0}", c);

            myWCFProxy.Close();
            Console.WriteLine("Press <ENTER> to terminate the client");
            Console.ReadLine();
        }
    }
}
