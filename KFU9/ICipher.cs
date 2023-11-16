using System;
namespace KFU9
{
	internal interface ICipher
	{
        string Encode(string text);
        string Decode(string text);
    }
}

