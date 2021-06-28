using System;

namespace DelegatesDemo
{
    delegate void DispStrDelegate(string param);

    class Program
    {
        static void Capitalize(string text)
        {
            Console.WriteLine("Your input capitalized => " + text.ToUpper());
        }

        static void LowerCased(string text)
        {
            Console.WriteLine("Your input lowercased => " + text.ToLower());
        }

        static void Main(string[] args)
        {
            Console.Write("Enter some text: ");
            string text = Console.ReadLine();

            DispStrDelegate saying1 = Capitalize;
            DispStrDelegate saying2 = LowerCased;
            DispStrDelegate saying3 = Console.WriteLine;

            Console.WriteLine("saying1");
            saying1(text);
            Console.WriteLine("saying2");
            saying2(text);
            Console.WriteLine("saying3");
            saying3(text);


            Console.WriteLine("Hello World!");
        }
    }
}
