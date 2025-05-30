using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace Password_Generator
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            string user;

            Console.WriteLine("Enter 'pass' to generate a new, unique password.");
            user = Console.ReadLine();

            if (user == "pass")
            {

                Console.WriteLine("Generating...\n");

                string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

                var StringChar = new char[15];
                var character = new Random();

                for (int i = 0; i < StringChar.Length; i++)
                {
                    StringChar[i] = characters[character.Next(characters.Length)];
                }

                var finalString = new String(StringChar);

                Console.WriteLine(finalString);

            }

            else if (user != "Password")
            {
                Console.WriteLine("Nevermind");

                Console.ReadLine();

            }

            
        }

        
    }
}
