using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
namespace EM.Calc.Core

{
    public class Calc
    {
        /// <summary>
        /// Операции
        /// </summary>
        public IList<IOperation> Operations { get; set; }

        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        public Calc() : this("")
        {
            
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Path">Путь до сторонних библиотек</param>
        public Calc(string path)
        {
            Operations = new List<IOperation>();

            if (string.IsNullOrWhiteSpace(path))
            {
                path = Environment.CurrentDirectory;
            }
            else
            {
                LoadOperations(Assembly.GetExecutingAssembly());
            }

            //Получаю пути до dll файлов проекта
            var dllFiles = Directory.GetFiles(path, "*.dll", SearchOption.AllDirectories);

            foreach (var dll in dllFiles)
            {
                LoadOperations(Assembly.LoadFrom(dll));
            }
        }

        private void LoadOperations(Assembly assembly)
        {
            // загрузить все типы из сборки
            var types = assembly.GetTypes();

            var needType = typeof(IOperation);

            // перебираем все классы в сборке
            foreach (var item in types.Where(t => t.IsClass && !t.IsAbstract))
            {
                var interfaces = item.GetInterfaces();

                // если класс реализаует заданный интерфейс
                if (item.GetInterface("IOperation") != null)
                {
                    //добавляем в операции экземпляр данного класса
                    var instance = Activator.CreateInstance(item);

                    var operation = instance as IOperation;
                    if (operation != null)
                    {
                        Operations.Add(operation);
                    }
                }
            }
        }

        public double? Execute(string operName, double[] values)
        {
            foreach (var item in Operations)
            {
                if (item.Name == operName)
                {
                    item.Operands = values;

                    item.Execute();

                    return item.Result;
                }
            }

            return null;
        }

        /*
        public int Sum(int[] args)
        {
            return args.Sum();
        }

        [Obsolete("Не используйте это, есть же Execute")]
        public double Sum(double[] args)
        {
            return args.Sum();
        }

        public double Pow(double[] args)
        {
            return args.Aggregate((a, b) => Math.Pow(a, b));
        }

        public double Sub(double[] args)
        {
            return args.Aggregate((a, b) => a - b);
        }

        public double Piu(double[] args)
        {
            return args.Aggregate((a, b) => a * b);
        }

        public double New(double[] args)
        {
            return Double.PositiveInfinity;
        }*/
    }
}

