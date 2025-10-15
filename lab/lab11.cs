using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    internal class lab11
    {
        static void Main(string[] args)
        {
            FisrtTask();
            lab12.Second();
            lab13.Third();
            lab14.Fourth();
            lab15.Fifth();
            lab16.Sixth();
            lab17.Seventh();
            lab18.Eights();
        }

        public static void FisrtTask() 
        {
            Console.WriteLine("Введіть день: ");

            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть місяць: ");

            int number2 = int.Parse(Console.ReadLine());

            if (number1 <= 31 && number2 <= 12)
            {
                Console.WriteLine(number1 + "." + number2);
            }
            else
            {
                Console.WriteLine("Число не дійсне");
            }

        }

    }
}


