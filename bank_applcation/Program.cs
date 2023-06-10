using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_applcation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bank = 0;
            while (true)
            {

                Console.WriteLine("1:depoist money.");
                Console.WriteLine("2:withdraw money.");
                Console.WriteLine("3:display money.");
                Console.WriteLine("4:Exit.");
                string unm= Console.ReadLine();
                
                switch (unm)
                {
                    case "1":
                        Console.WriteLine("enter the amount");
                        bank+= Convert.ToDouble(Console.ReadLine());
                        ;
                        break;
                    case "2":
                        
                        Console.WriteLine("enter the amount to withdraw");
                        double b= Convert.ToDouble(Console.ReadLine());
                        if (bank < b)
                        {
                            Console.WriteLine("رصيدك غير كافي");
                        }
                        else
                        {
                            bank-=b;
                        }
                       
                        break;
                    case "3":
                        Console.WriteLine(bank);
                        break;
         
                       


                }
            }
        }
    }
}
