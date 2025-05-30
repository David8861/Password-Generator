using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator
{
    public class PassGen
    {

        public static void Main(string[] args)
        {

            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            var StringChar = new char[15];
            var character = new Random();

            for (int i = 0; i < StringChar.Length; i++)
            {
                StringChar[i] = characters[character.Next(characters.Length)];
            }

            var finalString = new String(StringChar);

            Console.WriteLine(finalString);

            Console.ReadLine();
        }
}

    }
