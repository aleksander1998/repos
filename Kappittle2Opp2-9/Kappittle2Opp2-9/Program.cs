using System;

namespace Kappittle2Opp2_9
{
    namespace kappittle_2_Opp_2_9
    {
        class Program
        {
            static void Main(string[] args)
            {
                Exercise2_9();
            }

            private static void Exercise2_9()
            {
                Console.Write("Skriv inn tekst: ");
                var line = Console.ReadLine() + " ";
                var wordCount = 0;
                var charsInCurrentWord = 0;
                foreach (var character in line)
                {
                    var isSpace = character == ' ';
                    if (isSpace)
                    {
                        Console.WriteLine("ordlengde = " + charsInCurrentWord);
                        charsInCurrentWord = 0;
                    }
                    else
                    {
                        if (charsInCurrentWord == 0) wordCount++;
                        charsInCurrentWord++;
                    }
                }
            }
        }
    }
}