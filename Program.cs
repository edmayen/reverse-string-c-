using System;

namespace Excersice1
{
    class Program
    {
        static void Main(string[] args)
        {
            name();
        }

        public static void name()
        {
            string name;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            char[] aux = name.ToCharArray();
            for(int i = 0, j = name.Length - 1; i < j; i++, j--)
            {
                char c = aux[i];
                aux[i] = aux[j];
                aux[j] = c;
            }
            string reverseName = new string(aux);
            Console.WriteLine("The name entered was: " + name + "\n");
            Console.WriteLine("Reverse name: " + reverseName + "\n\n\n");
        }
    }
}
