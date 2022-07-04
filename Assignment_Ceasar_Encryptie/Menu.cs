using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Ceasar_Encryptie
{
    internal class Menu
    {
        public string SelectChoice(char[] secretMessage, int secretKey)
        {
            UserInputs userInputs = new UserInputs();
            Cryptor decrypt = new Cryptor();
            Console.WriteLine("Show encrypted message = \"s\" ");
            Console.WriteLine("Decrypy message = \"d\" ");
            string decryptedMessage = "";
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "s":
                    for (int i = 0; i < secretMessage.Length; i++)
                    {
                        Console.Write($"{secretMessage[i]}  ");
                    }
                    Console.WriteLine("Druk op enter om door te gaan");
                    Console.ReadLine();
                    break;
                case "d":
                    int secretGeuss = userInputs.InputCypher();
                    if (secretGeuss == secretKey)
                    {
                        secretKey = 0 - secretGeuss;
                        char[] fetchDecrypt = decrypt.EnAndDeCrypt(secretMessage, secretKey);
                        decryptedMessage = new String(fetchDecrypt) ; //String.Join("",fetchDecrypt)

                    }
                    else
                    {
                        decryptedMessage = "failed";
                        Console.WriteLine(decryptedMessage);
                        Console.WriteLine("Return to menu with enter");
                        Console.ReadLine();
                    }
                    break;
                default:
                    break;
            }
            return decryptedMessage;
        }
    }
}
