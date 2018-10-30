using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Calc.ConsoleApp
{
    class Program
    {

        public void inputMas(int[] args)
        {

        }


        static void Main(string[] args)
        {
            var calc = new EM.Calc.Core.Calc();
            while (true)
            {
                string key = Console.ReadLine();
                string command = null;
                string numbers = null;
                int result = 0;
                key = key.Replace(" ", string.Empty);

                for (int i = 0; i < key.Length; i++)
                    if ((key[i] < 48) || (key[i] > 57))
                        command = command + key[i];
                    else
                        numbers = numbers + key[i];

                int[] masNumber = new int[numbers.Length];

                for (int i = 0; i < numbers.Length; i++)
                    masNumber[i] = Convert.ToInt32(numbers[i].ToString());

                switch (command)
                {
        /*            case "sum":
                        result = calc.Sum(masNumber);
                        break;
                    case "sub":
                        result = calc.Sub(masNumber);
                        break;*/
                    case "pow":
                        result = calc.Pow(masNumber);
                        break;
                    default:
                        Console.WriteLine("Ошибка ввода");
                        continue;
                }

                Console.WriteLine("Ответ: " + result);
                Console.ReadKey();
            }
        }
    }
}
