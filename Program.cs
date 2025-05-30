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
    public class Program
    {
        public static void Main(string[] args)
        {

            string user;

            Console.WriteLine("Enter 'pass' to generate a new, unique password.");
            user = Console.ReadLine();

            if (user == "pass")
            {

                Console.WriteLine("Generating...\n");

                PassGen.Main(args);

            }

            else if (user != "Password")
            {
                Console.WriteLine("Nevermind");

                Console.ReadLine();

            }

            
        }

        
    }
}
