using System;
using System.Text.RegularExpressions;

namespace regularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            bool cont = true;

            //Call Name validation
            while (cont)
            {

                string name = GetInput($"Please enter your name with correct capitalization. (Ex. John)");
                CheckName(name);

                Console.WriteLine("Would you like to continue? y/n");
                cont = Continue(Console.ReadLine());

            }

            Console.WriteLine();
            Console.WriteLine();

            cont = true;

            //Call Email validation
            while (cont)
            {
                string email = GetInput($"Please enter your email address.");
                CheckEmail(email);

                Console.WriteLine("Would you like to continue? y/n");
                cont = Continue(Console.ReadLine());
            }
            
            Console.WriteLine();
            Console.WriteLine();
            
            cont = true;

            //Call Phone validation
            while (cont)
            {
                string phone = GetInput($"Please enter your phone number in the following format (xxx-xxx-xxxx or xxx.xxx.xxxx).");
                CheckPhone(phone);

                Console.WriteLine("Would you like to continue? y/n");
                cont = Continue(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine();

            cont = true;

            //Call Date validation
            while (cont)
            {
                string date = GetInput($"Please enter your date in the following format (dd/mm/yyyy or dd-mm-yyyy).");
                CheckDate(date);

                Console.WriteLine("Would you like to continue? y/n");
                cont = Continue(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine();

            cont = true;

            //Call HTML validation
            while (cont)
            {
                string html = GetInput($"Please enter your HTML tag in the following format: <tag></tag>");
                CheckHTML(html);

                Console.WriteLine("Would you like to continue? y/n");
                cont = Continue(Console.ReadLine());
            }

        }

        //Continue validation
        public static bool Continue(string cont)
        {
            if (cont[0] == 'n')
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Get User Input
        public static string GetInput (string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            return input;
        }

        //Name validation Method
        public static void CheckName (string name)
        {

            bool correct = false;

            while (!correct)
            {
                if (Regex.IsMatch(name, @"([A-Z])\w+\s[A-Z]\w{0,29}")) 
                //if (Regex.IsMatch(name, @"^([A-Z][A-z]{1,29})$"))
                {
                    Console.WriteLine($"Huzzah! \"{name}\" is in the correct format!");
                    correct = true;
                }
                else
                {
                    Console.WriteLine("Boo, incorrect format!");
                    Console.WriteLine($"Please enter your name with proper Capitalization.");
                    name = Console.ReadLine();
                }
            }
        }


        //Email validation Method
        public static void CheckEmail(string email)
        {
            bool correct = false;

            while (!correct)
            {
                if (Regex.IsMatch(email, @"^([\w\d.]{5,29}[@][\w\d]{5,10}[.][A-z]{2,3})$"))
                {
                    Console.WriteLine($"Huzzah! \"{email}\" is in the correct format!");
                    correct = true;
                }
                else
                {
                    Console.WriteLine("Boo, incorrect format!");
                    Console.WriteLine("Please enter your email in the proper format.");
                    email = Console.ReadLine();
                }

            }
        }

        //Phone validation Method
        public static void CheckPhone(string phone)
        {
            bool correct = false;

            while (!correct)
            {
                if (Regex.IsMatch(phone, @"\b\d{3}[-.]\d{3}[-.]\d{4}\b"))
                {
                    Console.WriteLine($"Huzzah! \"{phone}\" is in the correct format!");
                    correct = true;
                }
                else
                {
                    Console.WriteLine("Boo, incorrect format!");
                    Console.WriteLine("Please enter your phone number in the following format (xxx-xxx-xxxx or xxx.xxx.xxxx).");
                    phone = Console.ReadLine();
                }

            }
        }

        //Date validation Method
        public static void CheckDate(string date)
        {
            bool correct = false;

            while (!correct)
            {
                if (Regex.IsMatch(date, @"^((0[1-9])|([12][0-9])|(3[0-1]))[/-]((0[1-9])|(1[012]))[/-](([0-9]{4}))$"))
                {
                    Console.WriteLine($"Huzzah! \"{date}\" is in the correct format!");
                    correct = true;
                }
                else
                {
                    Console.WriteLine("Boo, incorrect format!");
                    Console.WriteLine("Please enter your date in the following format (dd/mm/yyyy or dd-mm-yyyy).");
                    date = Console.ReadLine();
                }

            }
        }

        //HTML validation Method
        public static void CheckHTML (string html)
        {
            bool correct = false;

            while (!correct)
            {
                if (Regex.IsMatch(html, @"^(\<([A-Z0-9]{0,}|[a-z0-9]{0,})\>.{0,}\<\/([A-Z0-9]{0,}|[a-z0-9]{0,})\>)$"))
                {
                    Console.WriteLine($"Huzzah! \"{html}\" is in the correct format!");
                    correct = true;
                }
                else
                {
                    Console.WriteLine("Boo, incorrect format!");
                    Console.WriteLine("Please enter your HTML tag in the following format: <tag></tag>");
                    html = Console.ReadLine();
                }

            }
        }


    }
}
