using System;
namespace AnagramDemo
{
    public class Program
    {
        public static void Main(string[]args)
        {
            string OP1, OP2;

            Console.WriteLine("Enter the First Word:");
            OP1 =Console.ReadLine();

            Console.WriteLine("Enter the Second Word:");
            OP2 =Console.ReadLine();

            char[] ch1 = OP1.ToLower().ToCharArray();
            char[] ch2 = OP2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("Both the Words are Anagrams");
            }
            else
            {
                Console.WriteLine("Both the Words are not Anagrams");
            }
        }
    }
}

