using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password_chacker
{
    class Program
    {
        static void Main(string[] args)
        {
            string passcode;
            string message = "";
            bool lenght = false;
            bool lower_letter = false;
            bool upper_letter = false;
            bool digit = false;
            bool symbol = false;
            bool strong = false;

            Console.WriteLine("enter your new passcode");
            passcode = Console.ReadLine();

            if (passcode.Length >= 8 && passcode.Length <= 50) 
            {
                lenght = true;
            }

            if (!lenght)
            {
                message = "password must be at least 8 characters long";
            }

            for (int i = 0; i < passcode.Length; i++)
            {
                if (Char.IsLower(passcode[i]))
                {
                    lower_letter = true;
                    break;
                }
                
            }

            for (int i = 0; i < passcode.Length; i++)
            {
                if (Char.IsUpper(passcode[i]))
                {
                    upper_letter = true;
                    break;
                }
                else
                {
                    message = "password must contain at least one upper case letter";
                }
            }

            for (int i = 0; i < passcode.Length; i++)
            {
                if (Char.IsDigit(passcode[i]))
                {
                    digit = true;
                    break;
                }
            }

            for (int i = 0; i < passcode.Length; i++)
            {
                if (Char.IsSymbol(passcode[i]))
                {
                    symbol = true;
                    break;
                }
            }

            strong = symbol && lower_letter && upper_letter && digit && symbol && lenght;

            //passcode errors

            if (!lenght)
            {
                message = "password must be at least 8 characters long";
            }
            else if (!lower_letter)
            {
                message = "password must contain at least a lower case letter";
            }
            else if (!upper_letter)
            {
                message = "password must contain at least an upper case letter";
            }
            else if (!symbol)
            {
                message = "password must contain at least a symbol";
            }
            else if (!digit)
            {
                message = "password must contain at least a digit";
            }


            if (strong)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("the passcode you entered is strong.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("the passcode you entered is not strong.");
                Console.WriteLine(message);
            }

        }
    }
}
