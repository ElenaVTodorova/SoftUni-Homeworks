using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            for (int i = username.Length-1; i >= 0; i--)
            {
                password += username[i];
            }
            int counter = 0;
            string login = Console.ReadLine();
            while (login!= password)
            {                
                counter++;
                if (counter==4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                login = Console.ReadLine();
            }           

                Console.WriteLine($"User {username} logged in.");
        }
    }
}
