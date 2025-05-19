using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _19._05._2025
{
    internal class Program
    {
        static bool IsValidPassword(string password)
        {
            if (password.Length < 8)
                return false;

            if (!Regex.IsMatch(password, @"[A-ZА-Я]")) 
                return false;

            if (!Regex.IsMatch(password, @"\d")) 
                return false;

            if (!Regex.IsMatch(password, @"[\W_]")) 
                return false;

            return true;
        }
        static void Main(string[] args)
        {
            //task 1

            string input = "<p>Hello</p>";
            string output = Regex.Replace(input, "<.*?>", "");
            Console.WriteLine(output);

            //task 2

            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            password = Regex.Replace(password, @"\s{2,}", " ");

            if (IsValidPassword(password))
            {
                Console.WriteLine("Password is strong.");
            }
            else
            {
                Console.WriteLine("Password does not meet the requirements.");
            }

            //task 3

            string input2 = "Hello  world";
            while (input2.Contains("  "))
            {
                input2 = input2.Replace("  ", " ");
            }
            Console.WriteLine(input2);

            //task 4

            string phone = "+7 (123) 456-78-90";
            string pattern = @"^\+7 \(\d{3}\) \d{3}-\d{2}-\d{2}$";

            bool isValid = Regex.IsMatch(phone, pattern);

            Console.WriteLine(isValid ? "The format is correct" : "The format is not correct");
        }
    }
}
