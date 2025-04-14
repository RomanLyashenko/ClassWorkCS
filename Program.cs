using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _14._04._2025
{
    internal class Program
    {
        //static int mult1(int min, int max)
        //{
        //    int mult = 1;
        //    for(int i=min;i <= max; i++)
        //    {
        //        mult *= i;
        //    }
        //    return mult;
        //}

        //static bool fib(int num)
        //{
        //    List<int> arr = new List<int>();
        //    arr[0] = 0;
        //    arr[1] = 1;
        //    for(int i=2 ;i <= num; i++)
        //    {
        //        int a = arr[i - 1] + arr[i - 2];
        //        arr.Add(a);
        //    }
        //    int[] carr = arr.ToArray();
        //    if (num == carr[num-1] + carr[num-2])
        //    {
        //        return false;
        //    }
        //    for(int i=2;i< Math.Pow(num, 2); i++)
        //    {
        //        if (!(num % i == 0))
        //        {
        //            return true;
        //         }
        //    }
        //}

        static void Main(string[] args)
        {

            //Console.WriteLine(mult1(1, 5));
            //Console.WriteLine(fib(89));

            //int[,] b = { { 1, 2, 3 }, { 4, 5, 6 } };
            //int row = b.GetLength(0);
            //int colum = b.GetLength(1);


            //// task 5

            //int min = b[0, 0];
            //int max = b[0, 0];

            //for(int i=0; i < row; i++)
            //{
            //    for(int j=0; j< colum; j++)
            //    {
            //        if (b[i, j] > max)
            //        {
            //            max = b[i, j];
            //        }
            //        if (b[i, j] < min)
            //        {
            //            min = b[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine(max);
            //Console.WriteLine(min);

            //// task 6

            ////string sen = Console.ReadLine();
            ////int count = 0;

            //for(int i=0; i < sen.Length; i++)
            //{
            //    if (sen[i] == ' ' || sen[i] == '.')
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //// task 7

            //char[] let = { 'a', 'e', 'i', 'o', 'u', 'y', 'а', 'у', 'о', 'и', 'э', 'ы', 'я', 'ю', 'е', 'ё'};

            //string sen = Console.ReadLine();
            //int count = 0;

            //for (int i = 0; i < sen.Length; i++)
            //{
            //    for (int j = 0; j < let.Length; j++)
            //    {
            //        if (sen[i] == let[j] || sen[i].ToString() == let[j].ToString().ToUpper())
            //        {
            //            count++;
            //        }
            //    }
            //}
            //Console.WriteLine(count);


            //// task 9

            //string sen1 = Console.ReadLine();
            //string sen2 = Console.ReadLine();
            //int count = 0;
            //int r = 0;
            //for(int i=0 ;i < sen1.Length; i++)
            //{
            //    if (sen1[i] == sen2[0])
            //    {
            //        count++;
            //        for (int j=1;j< sen2.Length; j++)
            //        {
            //            Console.WriteLine(count);
            //            if (sen1[i+j] == sen2[j]) 
            //            {
            //                Console.WriteLine(Convert.ToString(sen1[i + j]), Convert.ToString(sen2[j]));
            //                count++;

            //                if (count == sen2.Length)
            //                {
            //                    r++;
            //                    count = 0;
            //                }
            //            }
            //            else
            //            {
            //                count = 0;
            //                break;
            //            }

            //        }
            //    }
            //}
            //Console.WriteLine(r);


            City a = new City();
            a.name1("Москва");
            a.country1("Россия");
            a.population1(1200000);
            a.telCode1(890);
            a.amountOfDistricts1(4);
            a.districts1("Западный");
            a.districts1("Восточный");
            a.districts1("Южный");
            a.districts1("Сервеный");
            a.enter();
        }
    }

    public class City
    {
        private string name;
        private string country;
        private int population;
        private int telCode;
        private string districts;
        private int amountOfDistricts;

        public void name1(string a)
        {
            this.name = a;
        }
        public void country1(string a)
        {
            this.country = a;
        }
        public void population1(int a)
        {
            this.population = a;
        }
        public void telCode1(int a)
        {
            this.telCode = a;
        }

        public void districts1(string a)
        {
            this.districts = a;
        }

        public void amountOfDistricts1(int a)
        {
            this.amountOfDistricts = a;
        }
        public void enter()
        {
            Console.WriteLine($"Город {name}");
            Console.WriteLine($"Стран {country}");
            Console.WriteLine($"Численность {population}");
            Console.WriteLine($"Телефонный номер {telCode}");
            Console.WriteLine($"Количество районов {amountOfDistricts}");
            for (int i = 0; i < amountOfDistricts; i++)
            {
                Console.WriteLine($"Район {districts}");
            }
        }
    }
}
