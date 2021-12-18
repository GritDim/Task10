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
            double radiant = 0;

            Console.WriteLine("Введите хар-ки угла");
            Console.Write("градусов = ");
            try
            {
                gradus = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода данных");
                Console.ReadKey();
                return;
            }


            if ((gradus < 0) || (gradus > 360))
            {
                Console.WriteLine("Ошибка ввода данных");
                Console.ReadKey();
                return;
            }

            Console.Write("минут = ");

            try
            {
                min = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода данных");
                Console.ReadKey();
                return;
            }

            
            if ((min < 0) || (min > 60))
            {
                Console.WriteLine("Ошибка ввода данных");
                Console.ReadKey();
                return;
            }


            Console.Write("секунд = ");

            try
            {
                sec = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода данных");
                Console.ReadKey();
                return;
            }

            

            if ((sec < 0) || (sec > 60))
            {
                Console.WriteLine("Ошибка ввода данных");
                Console.ReadKey();
                return;
            }

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

    public class Ugol
    {
        public int gradus;
        public int min;
        public int sec;


        public Ugol(int gradus, int min, int sec)
        {
            this.gradus = gradus;
            this.min = min;
            this.sec = sec;
        }

        public void dataMesage()
        {
            Console.WriteLine("Задан угол {0} - градусов, {1} - минут, {2} - секунд", gradus, min, sec);

        }

        public void ToRadians(out double radiant)
        {
            radiant = (gradus + (double)min / 60 + (double)sec / 3600) * Math.PI / 180;
            Console.WriteLine("Задан угол в радианах - {0}", radiant);
        }

    }

}
