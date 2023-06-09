using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance;
            s1.PrintDetails("This is the 1st message");


            Singleton s2 = Singleton.GetInstance;
            s1.PrintDetails("This is the 2nd message");

            Console.ReadLine();
        }
    }
}
