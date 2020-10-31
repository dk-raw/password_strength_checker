using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strong_password_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string passcode;
            string[] message = new string[5];
            bool lenght = false;
            bool lower_letter = false;
            bool upper_letter = false;
            bool digit = false;
            bool symbol = false;
            bool strong = false;

            Console.WriteLine("enter your new passcode");
            passcode = Console.ReadLine();

            if (passcode.Length >= 8 && passcode.Length <= 50) //check for lenght (over 8 characters-change the "8" after the passcode.Lenght)
            {
                lenght = true;
            }

            

            for (int i = 0; i < passcode.Length; i++) //check for lower case letter
            {
                if (Char.IsLower(passcode[i]))
                {
                    lower_letter = true;
                    break;
                }

            }

            for (int i = 0; i < passcode.Length; i++) //check for upper case letter
            {
                if (Char.IsUpper(passcode[i]))
                {
                    upper_letter = true;
                    break;
                }
                
            }

            for (int i = 0; i < passcode.Length; i++) //check for digits
            {
                if (Char.IsDigit(passcode[i]))
                {
                    digit = true;
                    break;
                }
            }

            for (int i = 0; i < passcode.Length; i++) //check for symbols
            {
                if (Char.IsSymbol(passcode[i]))
                {
                    symbol = true;
                    break;
                }
            }

            strong = symbol && lower_letter && upper_letter && digit && symbol && lenght;

            //passcode error messages handler

            if (!lenght)
            {
                message[0] = "password must be at least 8 characters long";
            }
            if (!lower_letter)
            {
                message[1] = "password must contain at least a lower case letter";
            }
            if (!upper_letter)
            {
                message[2] = "password must contain at least an upper case letter";
            }
            if (!symbol)
            {
                message[3] = "password must contain at least a symbol";
            }
            if (!digit)
            {
                message[4] = "password must contain at least a digit";
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
                for (int i = 0; i < message.Length; i++)
                {
                    Console.WriteLine(message[i]);
                }
            }
        }
    }
}
