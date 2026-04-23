using System.Security.Cryptography;

namespace Prac.src;

public class Generator : IGenerator
{
    //method to Encrypt url
    public string Generate(int length = 4)
    {
        var bytes = new byte[length];
        RandomNumberGenerator.Fill(bytes);
        return BitConverter.ToString(bytes).Replace("-", "").ToLower();
    }
}