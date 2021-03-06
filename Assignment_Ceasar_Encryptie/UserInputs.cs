using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Ceasar_Encryptie
{
    internal class UserInputs
    {
        public int InputCypher()
        {
            Console.WriteLine("Geef de encryption key");
            int cypher = int.Parse(Console.ReadLine());
            return cypher;
        }
        public char[] InputMessageToEncrypt()
        {
            List<string> userMessage = new List<string>();
            string lastItem = "";
            int itemCount = 0;
            Console.WriteLine("Schrijf woord(en)zonder spatie om te encrypteren. typ '²' om te stoppen met de invoer");
            while (lastItem != "²")
            {
                lastItem = Console.ReadLine();
                if (lastItem != "²")
                {
                    userMessage.Add(lastItem);
                    userMessage.Add(" ");
                    Console.Write($"{lastItem} ");
                    Console.SetCursorPosition(lastItem.Length, 3);
                    itemCount += lastItem.Length;
                }
            }
            userMessage.RemoveAt(userMessage.Count - 1);    
            string listToArrayFromUserMessage = String.Join("", userMessage.ToArray());
            char[] userMessageInChars = listToArrayFromUserMessage.ToCharArray();
            Console.Clear();
            return userMessageInChars;
        }
    }
}
