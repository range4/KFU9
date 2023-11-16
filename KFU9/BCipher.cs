using System;
using System.Text;
namespace KFU9
{
    internal class BCipher : ICipher
    {
        private static readonly char[] alph = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя .,!?:;()".ToCharArray();

        public string Encode(string text)
        {
            StringBuilder encodedText = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                int charindex = Array.IndexOf(alph, currentChar);
                if (charindex >= 0 && charindex < alph.Length)
                {
                    encodedText.Append(alph[charindex + 1]);
                }
            }
            return encodedText.ToString();
        }

        public string Decode(string text)
        {
            StringBuilder decodedText = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                int charindex = Array.IndexOf(alph, currentChar);
                if (charindex >= 0 && charindex < alph.Length)
                {
                    decodedText.Append(alph[charindex - 1]);
                }
            }
            return decodedText.ToString();
        }
    }
}
