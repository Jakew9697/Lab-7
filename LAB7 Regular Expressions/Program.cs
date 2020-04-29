using System;
using System.Text.RegularExpressions;

namespace LAB7_Regular_Expressions
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();


            Console.WriteLine("Enter your email: ");
            string email = Console.ReadLine();


            Console.WriteLine("Enter your phone number: ");
            string phoneNumber = Console.ReadLine();


            Console.WriteLine("Enter the date: ");
            string date = Console.ReadLine();


            ValidateNames(name);
            ValidateEmails(email);
            ValidatePhoneNumber(phoneNumber);
            ValidateDate(date);
        }


        public static bool ValidateNames(string name)
        {

            if (name[0] != char.ToUpper(name[0]))
            {
                Console.WriteLine("Name is not uppercase");
                return false;
            }
            else if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine("Name contains invalid characters... ");
                return false; 
            }
            else if (name.Length > 30)
            {
                Console.WriteLine("Name is more than 30 characters... ");
                return false;
            }
            else
            {
                return true;
            }
        }


        public static bool ValidateEmails(string email)
        {
            bool isEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            bool specialCharacters =  Regex.IsMatch(email, "^[a-zA-Z0-9 ]*$");

            if (specialCharacters == false )
            {
                Console.WriteLine("Email contained special characters... ");
                return false;
            }
            if (isEmail == false)
            {
                Console.WriteLine("Invalid Email... ");
                return false;
            }
            else if (email.Length > 30 && email.Length < 5)
            {
                Console.WriteLine("Email must contain 5 - 30 characters... ");
                return false;
            }
            else
            {
                return true;
            }
        }

        
        public static bool ValidatePhoneNumber(string number)
        {              
            var r = new Regex(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$");


            if (!r.IsMatch(number))
            {
                Console.WriteLine("invalid phone number... ");
                return false;
            }
            else
            {
                return true;
            }
        }



        public static bool ValidateDate(string date)
        {
            if (!Regex.Match(date, @"^(0[1-9]|1[0-9]|2[0-9]|3[0,1])([/+-])(0[1-9]|1[0-2])([/+-])(19|20)[0-9]{2}$").Success)
            {
                Console.WriteLine("Invalid date... ");
                return false;               
            }
            else
            {
                return true;
            }
        }
    }
}
