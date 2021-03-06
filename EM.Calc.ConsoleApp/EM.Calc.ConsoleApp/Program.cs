﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using EM.Calc.Core;

namespace EM.Calc.ConsoleApp
{
    class Program
    {
        // "1+1"
        // sum 12 32 34
        static void Main(string[] args)
        {
            double[] values;
            string operation;

            var calc = new Core.Calc();

            // найти файл с операцией
            // загрузить этот файл

            // найти в нем операцию
            var type = typeof(SumOperation);
            var memebers = type.GetMembers();

            // добавить операцию в калькулятор


            string[] operations = calc.Operations
                .Select(o => o.Name)
                .ToArray();

            if (args.Length == 0)
            {
                Console.WriteLine("Список операций:");

                foreach (var item in operations)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Введите операцию: ");


                operation = Console.ReadLine();

                Console.WriteLine("Введите аргументы через пробел: ");
                var operands = Console.ReadLine();
                values = ConvertToDouble(
                    operands.Split(new[] { " ", ";" }, StringSplitOptions.RemoveEmptyEntries)
                );
            }
            else
            {
                operation = args[0].ToLower();
                values = ConvertToDouble(args, 1);
            }

            var result = calc.Execute(operation, values);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        private static double[] ConvertToDouble(string[] args, int start = 0)
        {
            return args
                .Skip(start)
                .Select(Convert.ToDouble)
                .ToArray();
        }


    }
}


