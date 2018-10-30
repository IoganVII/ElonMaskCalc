using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Calc.Core
{
    public class Calc
    {
        public int Sum(int[] args)
        {
            var sum = 0;
            for (int i = 0; i < args.Length; i++)
                sum = sum + args[i];
            return sum;
        }

        //перегрузка Sum
        public double Sum(double[] args)
        {
            double sum = 0;
            for (int i = 0; i < args.Length; i++)
                sum = sum + args[i];
            return sum;
        }

        public int Sub(int[] args)
        {
            var sub = args[0] ;
            for (int i = 1; i < args.Length; i++)
                sub = sub - args[i];
            return sub;
        }
        //перегрузка Sub
        public double Sub(double[] args)
        {
            double sub = args[0];
            for (int i = 1; i < args.Length; i++)
                sub = sub - args[i];
            return sub;
        }


        public int Pow(int[] args)
        {
            double pow = args[0];
            for (int i = 1; i < args.Length; i++)
                pow = Math.Pow(pow, args[i]);
            return (int)pow;
        }
        // перегрузка Pow
        public double Pow(double[] args)
        {
            double pow = args[0];
            for (int i = 1; i < args.Length; i++)
                pow = Math.Pow(pow, args[i]);
            return pow;
        }
    }
}
