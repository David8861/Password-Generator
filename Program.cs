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

            string username;

            Console.WriteLine("Welcome. Would you like to generate a username, password or both for a new account?");
            Console.WriteLine("Enter 'username' or 'password' to continue.");
            username = Console.ReadLine();

            if (username == "password")
            {

                Console.WriteLine("Generating...\n");

                PassGen.Main(args);

            }

            if (username == "username")
            {
                Console.WriteLine("Generating...\n");

                UserGen.Main(args);

            }
            
        }

        
    }
}
