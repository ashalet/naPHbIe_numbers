using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naPHbIe_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            int result = 0;
            int count = 0;
            for (int i = 2; i <= a; i+=2)
            {
                result += i;
                count += 1;
            }
            Console.WriteLine(result);
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
