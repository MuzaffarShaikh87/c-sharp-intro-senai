using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Muzaffar";
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello " + myName);

            Console.WriteLine("Please Enter your name");
            string userName = Console.ReadLine();
            Console.WriteLine("Your name is:" + userName);
            Console.WriteLine("Hey {0} how are you doing", userName);
        }
    }
}
