using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            int Cr, Pr, amount, Unit;
            int rate;
            Console.Write("Enter the current reading :");
            Cr = int.Parse(Console.ReadLine());
            Console.Write("Enter the previous reading :");
            Pr = int.Parse(Console.ReadLine());
            Unit = Math.Abs(Pr - Cr);
            string type;
            Console.Write("Enter the type :");
            type = Console.ReadLine();



            switch (type)
            {


                case "D":
                    rate = 4;
                    break;
                case "C":
                    rate = 10;
                    break;
                case "I":
                    rate = 15;
                    break;
                default:
                    Console.Write("Invalid input");
                    rate = 0;
                    break;

            }
            amount = Unit * rate;
            Console.WriteLine("BillAmount:{0}", amount);
        }
}   }
        
           


    

