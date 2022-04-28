using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradus = 0;
            int min = 0;
            int sec = 0;
            double radiant;

            Console.WriteLine("Введите хар-ки угла");
            Console.Write("Градусов = ");
            gradus = Convert.ToInt32(Console.ReadLine());
            Console.Write("Минут = ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Секунд = ");
            sec = Convert.ToInt32(Console.ReadLine());

            Ugol ugol = new Ugol(gradus, min, sec);

            ugol.dataMesage();
            ugol.ToRadians(out radiant);

            Console.WriteLine();
            Console.Write("В сравнении с прямым углом заданный угол - ");


            if (radiant > ((double)Math.PI / 2))
            {
                Console.WriteLine(" больше ");
            }
            else
            {
                if (radiant == (double)Math.PI / 2)
                {
                    Console.WriteLine(" ему равен ");
                }
                else
                {
                    Console.WriteLine(" меньше ");
                }

            }
            Console.WriteLine("Прямой угол в радианах {0}", (double)Math.PI / 2);
            Console.ReadKey();

        }
    }
}