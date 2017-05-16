using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeX
{
    class OddrEven
    {

    }




    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int largest = 0;
            int count = 0;
            int cnt=0;
      
            Console.Write("Enter a Number : ");

            string v = Console.ReadLine();

            i = int.Parse(v);
            cnt = i;

            do
            {

                if (i > largest) { largest = i; }
                if (i % 2 == 0)
                {
                    Console.Write(i + "/2 = ");
                    i = i / 2;
                    Console.Write(i);
                    Console.WriteLine();

                }
                else
                {
                    Console.Write("(" + i + "*3)" + "+1 =");
                    i = i * 3;
                    i = i + 1;
                    Console.Write(i);
                    Console.WriteLine();

                    count++;
                } while (i > 1) ;

                Console.WriteLine("The largest number reached was " + largest);
                Console.WriteLine("The number of iterations was " + count);

                Console.Read();

            } while (true);

    {

            }
        }
    }


