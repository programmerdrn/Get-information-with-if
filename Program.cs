using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace tamrin_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            //دریافت فامیلی
            string fullName = "";
            while (string.IsNullOrWhiteSpace(fullName))
            {
                Console.WriteLine("Pleas Enter Your Family:");
                fullName = Console.ReadLine()?.Trim();

                if (!string.IsNullOrWhiteSpace(fullName))
                {
                    fullName = RemoveSpaces(fullName);
                }
            }
            Console.WriteLine("Welcome To The Next Step.");


            //دریافت شماره تلفن
            string phoneNumber;
            bool isValid = false;
            do
            {
                Console.WriteLine("Enter Ypur PhoneNamber:");
                Console.WriteLine("Start With 0 And 11 ragham");
                phoneNumber = Console.ReadLine();
                phoneNumber.Trim();
                if (Regex.IsMatch(phoneNumber, @"^0\d{10}$"))
                {
                    isValid = true;
                    Console.WriteLine("Your Number Is True");
                }
                else
                {
                    Console.WriteLine("false, Pleas Try Agine");
                }
            } while (!isValid);


            //دریافت سن
            int age = 0;
            bool isValidd = false;
            while (!isValidd)
            {
                Console.WriteLine("Enter Your Age:");
                string inout = Console.ReadLine();
                if (int.TryParse(inout, out age) && age >= 1 && age <= 120)
                {
                    isValidd = true;
                }
                else
                {
                    Console.WriteLine("Enter a Number Between 1 and 120:");
                }
            }


            //نمایش نام،شماره و سن
            Console.WriteLine($" Your Family Is: {fullName} \n Your PhoneNumber Is:{phoneNumber} \n Age Is:{age}");


            //تغییر محیط کنسول
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;

        }


        //متد برای حذف فاصله بین حروف
        static string RemoveSpaces(string input)
        {
            return input.Replace(" ", "");
        }

    }

}
