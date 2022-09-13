using daydream.Utils;

namespace daydream.Protection.Obfuscation
{
    public class XOR
    {
        /*
        * XorFile - Encrypts a file with a key
        * @param bytes - bytes to encrypt
        * @param key - Key to encrypt with
        */
        private static byte[] XorAlgo(byte[] bytes, string key)
        {
            byte[] keyBytes = System.Text.Encoding.UTF8.GetBytes(key);

            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] ^= keyBytes[i % keyBytes.Length];
            }

            return bytes;
        }

        /*
        * XorFile - Encrypts a file with a key
        * @param file - The file to encrypt
        * @param key - The key to encrypt the file with
        */
        public static void XorFile(string file, string key)
        {
            string output = "crypted_xor.exe";

            file = Path.GetFullPath(file);

            try
            {
                // Check if file exists
                if (!File.Exists(file))
                {
                    throw new FileNotFoundException(String.Format("File \"{0}\" does not exist.", file));
                }

                if (string.IsNullOrEmpty(key))
                {
                    Logger.Write("Key is empty!", Logger.LogLevel.Error);
                    return;
                }

                Logger.Write($"Reading {file}.", Logger.LogLevel.Info);
                byte[] bytes = File.ReadAllBytes(file);

                Logger.Write("Encoding data.", Logger.LogLevel.Info);
                byte[] encodedBytes = XOR.XorAlgo(bytes, key);

                Logger.Write($"Writing {output}.", Logger.LogLevel.Info);
                File.WriteAllBytes(output, encodedBytes);

                Logger.Write($"File {file} encrypted to {output} with key {key}", Logger.LogLevel.Success);
            }
            catch (Exception e)
            {
                Logger.Write($"Error: {e.Message}", Logger.LogLevel.Error);
            }

        }
    }
}