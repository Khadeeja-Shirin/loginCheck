using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password_wrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName1, userName2, passWord1, passWord2;
            int length, a;
            bool isLogin = false;
            Console.Write("Registration: ");
            userName1 = Console.ReadLine();
            Console.Write("Please enter your new password (6 characters minimum): ");
            passWord1 = Console.ReadLine();
            length = passWord1.Length;
            a = 3;
            if (length < 6)
            {
                Console.WriteLine();
                Console.WriteLine("Minimum of 6 characters. Please try again.");
                Console.Write("Please enter your new password: ");
                passWord1 = Console.ReadLine();
            }
            do
            {
                Console.WriteLine();
                Console.WriteLine("Please login below.");
                Console.Write("Please enter your username: ");
                userName2 = Console.ReadLine();
                Console.Write("Please enter your password: ");
                passWord2 = Console.ReadLine();

                if ((userName1 == userName2) && (passWord1 == passWord2))
                {
                    isLogin = true;
                    Console.WriteLine("Login Successfully! Welcome ");
                }
                

                else if ((userName1 != userName2) && (passWord1 != passWord2))
                {
                    Console.WriteLine("Sorry, that username and password does not match. ");
                    a--;
                    if (a == 2)
                    {
                        Console.WriteLine("You have 2 attempts remaining. ");
                    }
                    if (a == 1)
                    {
                        Console.WriteLine("You have 1 attempt remaining. ");
                    }
                }
                else if (userName1 != userName2)
                {
                    Console.Write("Sorry, that username does not match. ");
                    a--;
                    if (a == 2)
                    {
                        Console.WriteLine("You have 2 attempts remaining. ");
                    }
                    if (a == 1)
                    {
                        Console.WriteLine("You have 1 attempt remaining. ");
                    }
                }
                else if (passWord1 != passWord2)
                {
                    Console.Write("Sorry, that password does not match. ");
                    a--;
                    if (a == 2)
                    {
                        Console.WriteLine("You have 2 attempts remaining. ");
                    }
                    if (a == 1)
                    {
                        Console.WriteLine("You have 1 attempt remaining. ");
                    }
                }
            } 
            while (a > 0 && isLogin==false);
            if (a == 0)
            {
                Console.WriteLine("You have no attempts remaining. Goodbye.");
            }
            Console.ReadKey();
        }

       
        
    }
}

