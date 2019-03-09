using System;

namespace Initials
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your full name: ");
            string nameInitials = Console.ReadLine();

            string[] strSplit = nameInitials.Split();
            foreach (string res in strSplit)
            {
                Console.Write(res.Substring(0, 1));
            }

            Initials(nameInitials);

            Console.ReadLine();
        }

        public static string Initials(string nameInitials)
        {
            
            nameInitials = nameInitials.ToUpper();
            string[] strSplit = nameInitials.Split();
            //foreach (string res in strSplit)
            //{
            //    Console.Write(res.Substring(0, 1));
            //}
            
            return nameInitials;
        }

        // TODO: Create a method that takes in a full name and return the initials in all capital letters.
    }
}
  
