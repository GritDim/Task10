using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Ugol
    {
        int gradus;
        int min;
        int sec;
        public int Gradus
        {
            set
            {
                if ((0 <= value) && (value <= 360))
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Градусы угла должны быть в пределах от 0 до 360");
                    Console.ReadKey();
                    return;
                }
            }

            get
            {
                return gradus;
            }
        }


        public int Min
        {
            set
            {
                if ((0 <= value) && (value <= 360))
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Минуты должны быть в пределах от 0 до 60");
                    Console.ReadKey();
                    return;
                }
            }

            get
            {
                return min;
            }
        }

        public int Sec
        {
            set
            {
                if ((0 <= value) && (value <= 60))
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Секунды должны быть в пределах от 0 до 60");
                    Console.ReadKey();

                }
            }

            get
            {
                return sec;
            }
        }

        public Ugol(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
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

