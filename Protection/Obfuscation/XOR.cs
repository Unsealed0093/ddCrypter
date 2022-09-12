using daydream.Utils;

namespace daydream.Protection.Obfuscation
{
    public class XOR
    {
        private static byte[] XorAlgo(byte[] bytes, string key)
        {
            byte[] keyBytes = System.Text.Encoding.UTF8.GetBytes(key);

            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] ^= keyBytes[i % keyBytes.Length];
            }

            return bytes;
        }

        public static void XorFile(string file, string key)
        {
            string output = "crypted_xor.exe";

            // Check if file exists
            if (!File.Exists(file))
            {
                Logger.Write("File does not exist!", Logger.LogLevel.Error);
                return;
            }

            if(string.IsNullOrEmpty(key))
            {
                Logger.Write("Key is empty!", Logger.LogLevel.Error);
                return;
            }

            Logger.Write("Reading file.", Logger.LogLevel.Info);
            byte[] bytes = File.ReadAllBytes(file);

            Logger.Write("Encoding data.", Logger.LogLevel.Info);
            byte[] encodedBytes = XOR.XorAlgo(bytes, key);

            Logger.Write("Writing file.", Logger.LogLevel.Info);
            File.WriteAllBytes(output, encodedBytes);

            Logger.Write("File obfuscated!", Logger.LogLevel.Success);

        }
    }
}