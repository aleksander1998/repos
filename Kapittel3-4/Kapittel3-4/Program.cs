using System;
using System.Linq;

namespace Kapittel3_4
{
    class Program
    {
        private static string _secretCode = "ECBAD";
        private static string _alphabet = "ABCDE";

        static void Main(string[] args)
        {
            var plainText = args[0];
            var cipherText = Encrypt(plainText);
            Console.WriteLine(cipherText);
            plainText = Decrypt(cipherText);
            Console.WriteLine(plainText);
        }

        private static string Decrypt(string cipherText)
        {
            return CryptImpl(cipherText, _secretCode, _alphabet);
        }

        private static string Encrypt(string plainText)
        {
            return CryptImpl(plainText, _alphabet, _secretCode);
        }


        private static string CryptImpl(string plainText, string from, string to)
        {
            return new string(
                plainText.Select(
                        c => to[from.IndexOf(c)]
                    ).ToArray());
        }

        //private static string CryptImpl(string plainText, string from, string to)
        //{
        //    var result = "";
        //    foreach (var c in plainText)
        //    
        //        var i = from.IndexOf(c);
        //        result += to[i];
        //    }
        //    return result;
        //}
    }
}