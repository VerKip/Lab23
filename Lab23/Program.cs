using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n=Convert.ToInt32(Console.ReadLine());

            FctrlAsync(n);
            Console.ReadKey();
        }

        static void Fctrl(int n)
        {
            int f = 1;
            if (n == 0)
            {
                f = 1;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    f *= i;
                    Thread.Sleep(100);
                }
            }
            Console.WriteLine(f);
        }

        static async void FctrlAsync (int n)
        {
            await Task.Run(() => Fctrl(n));
        }
    }
}
