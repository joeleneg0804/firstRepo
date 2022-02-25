using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string sInput = "";
            char characterToRemove = ' ';
            //int indexOfCharacter = 0;

            Console.WriteLine("Enter string input: ");
            sInput = Console.ReadLine();

            Console.WriteLine("Enter character to remove: ");
            characterToRemove = Convert.ToChar(Console.ReadLine());

            //indexOfCharacter = sInput.IndexOf(characterToRemove);

            //Console.WriteLine(sInput.Remove(indexOfCharacter, 1));

            Console.WriteLine(removerChar(sInput, characterToRemove));


            Console.ReadLine();

        }

        public static string removerChar(string sInput, char characterToRemove)
        {
            int indexOfCharacter = sInput.IndexOf(characterToRemove);

            return sInput.Remove(indexOfCharacter, 1);
        }
    }
}
