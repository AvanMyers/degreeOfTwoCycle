using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreeOFTwoCycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int starterNumber = 2;
            int finalNumber = starterNumber;
            int degree = 1;
            int minRandom = 2;
            int maxRandom = 100;
            int value = random.Next(minRandom, maxRandom);
            bool isOpen = true;

            Console.WriteLine("Случайное число " + value);

            while (value <= finalNumber)
            {
                finalNumber *= starterNumber;
                degree++;
            }

            Console.WriteLine($"Для числа {value} будет {starterNumber} в степени {degree}, то есть {finalNumber}. {value} < {finalNumber}");
            Console.ReadKey();
        }
    }
}
