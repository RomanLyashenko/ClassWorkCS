using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _14._05._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = "C:\\Users\\Взрослая академия\\Desktop\\File.txt";

            //if (File.Exists(path))
            //{
            //    Console.WriteLine("File exists");
            //}
            //else
            //{
            //    File.Create(path);
            //}
            //string text = File.ReadAllText(path);
            //Console.WriteLine(text);

            //File.AppendAllText(path, "\nbim bim bam bam");
            //Console.WriteLine(text);
            //File.WriteAllText(path, "afvafayehfgayfuje");

            // task 1

            string path = "C:\\Users\\Взрослая академия\\Desktop\\Day17.txt";

            if (File.Exists(path))
            {
                Console.WriteLine("File exists");
            }
            else
            {
                File.Create(path);
            }

            string name = "a";
            string lastName = "b";
            string patronymic = "c";
            string birthDate = "17.10.2000";

            List<List<double>> fractionalТNumbers = new List<List<double>>()
            {
                new List<double>() { 1.1, 2.2, 3.3 },
                new List<double>() { 4.4, 5.5, 6.6 },
                new List<double>() { 7.7, 8.8, 9.9 }
            };

            List<List<int>> generalТNumbers = new List<List<int>>()
            {
                new List<int>() { 1, 2, 3 },
                new List<int>() { 4, 5, 6 },
                new List<int>() { 7, 8, 9 }
            };

            string date = DateTime.Now.ToString("dd.MM.yyyy");
            File.AppendAllText(path, name+" " +lastName+ " " + patronymic + " " + birthDate + "\n" + "3" + " " + "3" + "\n");
            File.AppendAllText(path, "1.1, 2.2, 3.3" + "\n" + "4.4, 5.5, 6.6" + "\n" + "7.7, 8.8, 9.9");
            File.AppendAllText(path, "3" + " " + "3" + "\n" + "1, 2, 3" + " " + "4, 5, 6" + " " + "7, 8, 9 " + "\n" + date);

            // task 2

            string path2 = "C:\\Users\\Взрослая академия\\Desktop\\FileFor2task.txt";
            
            if (File.Exists(path2))
            {
                Console.WriteLine("File exists");
            }
            else
            {
                File.Create(path2);
            }

            string text = "Here you can find activities to practise your reading skills.\nReading will help you to improve your understanding of the language\nand build your vocabulary.The self-study lessons in this section\nare written and organised by English level based on the Common\nEuropean Framework of Reference for languages(CEFR).There are different\ntypes of texts and interactive exercises that practise the reading skills\nyou need to do well in your studies, to get ahead at work and to\ncommunicate in English in your free time.";
            char[] delimiters = new char[] { ' ', '\n', '\r', '.', ',', '!', '?', ';', ':', '-', '\t' };
            string[] words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            string reversedText = new string(text.Reverse().ToArray());

            File.AppendAllText(path2, reversedText);

            
        }
    }
}
