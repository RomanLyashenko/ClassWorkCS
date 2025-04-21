using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._04._2025
{

    public class Worker
    {
        private string name;
        private string lastName;
        private string fathersName;
        private string dateOfBirth;
        private string phone;
        private string email;
        private string position;
        private string description;
        private decimal salary;

        public void name1(string a)
        {
            this.name = a;
        }
        public void lastName1(string a)
        {
            this.lastName = a;
        }
        public void fathersName1(string a)
        {
            this.fathersName = a;
        }
        public void dateOfBirth1(string a)
        {
            this.dateOfBirth = a;
        }
        public void phone1(string a)
        {
            this.phone = a;
        }
        public void email1(string a)
        {
            this.email = a;
        }
        public void position1(string a)
        {
            this.position = a;
        }
        public void description1(string a)
        {
            this.description = a;
        }

        public void salary1(decimal a)
        {
            this.salary = a;
        }
        public void enter()
        {
            Console.WriteLine($"Фамилия: {this.lastName}");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Отчество: {fathersName}");
            Console.WriteLine($"Дата рождения: {dateOfBirth}");
            Console.WriteLine($"Номер телефона: {phone}");
            Console.WriteLine($"Почта: {email}");
            Console.WriteLine($"Должность: {position}");
            Console.WriteLine($"Служебные обязанности: {description}");
            Console.WriteLine($"Зарплата: {salary}");
        }

        public void input()
        {
            Console.WriteLine("Фамилия:");
            this.lastName = Console.ReadLine();
            Console.WriteLine("Имя:");
            this.name = Console.ReadLine();
            Console.WriteLine("Отчество:");
            this.fathersName = Console.ReadLine();
            Console.WriteLine("Дата рождения:");
            this.dateOfBirth = Console.ReadLine();
            Console.WriteLine("Номер телефона:");
            this.phone = Console.ReadLine();
            Console.WriteLine("Почта:");
            this.email = Console.ReadLine();
            Console.WriteLine("Должность:");
            this.dateOfBirth = Console.ReadLine();
            Console.WriteLine("Обязанности:");
            this.description = Console.ReadLine();
            Console.WriteLine("Зарплата:");
            this.salary = Convert.ToDecimal(Console.ReadLine());
        }

        public static Worker operator +(Worker worker, decimal amount)
        {
            worker.salary += amount;
            return worker;
        }

        public static Worker operator -(Worker worker, decimal amount)
        {
            worker.salary -= amount;
            return worker;
        }

        public static bool operator ==(Worker worker1, Worker worker2)
        {
            if (worker1.salary == null || worker2.salary == null)
            {
                return false;
            }

            return worker1.salary == worker1.salary;

        }
        public static bool operator !=(Worker worker1, Worker worker2)
        {
            if (worker1.salary == null || worker2.salary == null)
            {
                return false;
            }

            return worker1.salary != worker1.salary;
        }
    }

    public class Matrix
    {
        private int height = 7;
        public int width = 7;
        private List<List<int>> matrix = new List<List<int>>();


        public void height1(int a)
        {
            this.height = a;
        }
        public void width1(int a)
        {
            this.width = a;
        }

        public void matrix1(List<List<int>> a)
        {
            this.matrix = a;
        }

        public void writeIn(int number)
        {
            for (int i = 0; i < this.height; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j < this.width; j++)
                {
                    row.Add(number);
                }
                this.matrix.Add(row);
            }
        }

        public void printMatrix()
        {
            for (int i = 0; i < this.height; i++)
            {
                for (int j = 0; j < this.width; j++)
                {
                    Console.Write(this.matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1

            //Worker worker1 = new Worker();
            //worker1.input();
            //Worker worker2 = new Worker();
            //worker2.input();
            //Console.WriteLine($" Зп равны:{worker1 == worker2}");

            // task 2

            Matrix matrix = new Matrix();
            matrix.writeIn(1);
            matrix.printMatrix();
        }
    }
}



