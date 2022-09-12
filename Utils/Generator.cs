using System.Security.Cryptography;

namespace daydream.Utils
{
    public class Generator
    {
        public static string GetRandomBase64String(int count)
        {
            return Convert.ToBase64String(RandomNumberGenerator.GetBytes(count));
        }

        public static int GetRandomInteger(int count)
        {
            return Convert.ToInt32(RandomNumberGenerator.GetInt32(count));
        }

        
    }
}