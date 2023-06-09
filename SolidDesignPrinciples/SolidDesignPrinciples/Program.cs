using System;

namespace SolidDesignPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter 1 to RUN Single Responsibility Principle.");
            Console.WriteLine("Please Enter 2 to RUN Open Closed Principle.");
            Console.WriteLine("Please Enter 3 to RUN Liskov Substitution Principle.");
            Console.WriteLine("Please Enter 4 to RUN Dependency Inversion Principle.");


            int value = Convert.ToInt32(Console.ReadLine());

            switch (value)
            {
                case 1:
                    SingleResponsibilityPrinciple srp = new SingleResponsibilityPrinciple();
                    srp.SRP();
                    break;
                case 2:
                    OpenClosedPrinciple ocp = new OpenClosedPrinciple();
                    ocp.OCP();
                    break;
                case 3:
                    LiskovSubstitutionPrinciple lsp = new LiskovSubstitutionPrinciple();
                    lsp.LSP();
                    break;
                case 4:
                    DependencyInversionPrinciple dip = new DependencyInversionPrinciple();
                    
                    break;
                default:
                    Console.WriteLine("Please visit next time.");
                    break;
            }

            Console.ReadKey();

        }
    }
}
