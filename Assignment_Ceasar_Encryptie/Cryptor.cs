using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Ceasar_Encryptie
{
    internal class Cryptor
    {
        public char[] EnAndDeCrypt(char[] secretMessage, int secretKey) 
        {
            char[] enOrDecryptedMessage = new char[secretMessage.Length];
            for (int i = 0; i < secretMessage.Length; i++)
            {
                char c = (char)(secretMessage[i] + (char)secretKey);
                enOrDecryptedMessage[i] = c;
            }
            return enOrDecryptedMessage;
        }
    }
}
