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
            const int SUBSUM = 87;
            for (int i = 0; i < secretMessage.Length; i++)
            {
                char c = (char)(secretMessage[i] + (char)secretKey);
                while (c >= 127)
                {
                    c -= (char)SUBSUM;
                }
                while (c <= 40)
                {
                    c += (char)SUBSUM;
                }
                enOrDecryptedMessage[i] = c;
            }
            return enOrDecryptedMessage;
        }
    }
}
