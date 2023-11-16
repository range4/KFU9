using System;
using System.Text;
namespace KFU9
{
	internal class ACipher : ICipher
	{
        public string Encode(string text)
        {
            StringBuilder encodedText = new StringBuilder();
            for (short i = 0; i < text.Length; i++)
            {
                ushort charindex = (char)text[i];
                encodedText.Append((char)(charindex + 1));
            }
            return encodedText.ToString();
        }

        public string Decode(string text)
        {
            StringBuilder decodedText = new StringBuilder();
            for (short i = 0; i < text.Length; i++)
            {
                ushort charindex = (char)text[i];
                decodedText.Append((char)(charindex - 1));
            }
            return decodedText.ToString();

        }
    }
}

