using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_1
{
    class Program
    {
        void input(double[] mass, string massname)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine("Enter {0} [{1}]", massname, i);
                string s = Console.ReadLine();
                double element = Convert.ToDouble(s);
                mass[i] = element;
            }
        }
        void counter(double[] mass, out double sum1, out double sum2, out int count0)
        {
            sum1 = 0; sum2 = 0; count0 = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < 0) sum1 += mass[i];
                else
                    if (mass[i] == 0) count0++;
                else sum2 += mass[i];
            }
        }
        void Printer(string massname)
        {
            int n, count0; double[] mass; double sum1, sum2;
            Console.WriteLine("Enter the length of massive {0}", massname);
            n = Convert.ToInt32(Console.ReadLine());
            mass = new double[n];
            Program ob2 = new Program();
            ob2.input(mass, massname);
            ob2.counter(mass, out sum1, out sum2, out count0);
            Console.WriteLine("Massive {0}: sum(-) ={1}, sum(+) = {2}, count of '0' = {3}", massname, sum1, sum2, count0);
        }
        static void Main(string[] args)
        {
            Program ob1 = new Program();
            string[] massnameS = new string[3];
            massnameS[0] = "A";
            massnameS[1] = "B";
            massnameS[2] = "C";
            for (int i = 0; i < 3; i++)
            {
                ob1.Printer(massnameS[i]);
            }
            Console.ReadKey();   
        }
    }
}
