using daydream.Utils;
using daydream.Protection.Obfuscation;
using daydream.Protection.Anti;

namespace daydream
{
    class Program
    {
        static void Main(string[] args)
        {
            // Run if platform is Windows
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                VirtualMachine.CheckEnvironment();
                VirtualMachine.CheckMacAddress();
                VirtualMachine.CheckProcess();
            }

            Console.Write("Input: ");

            string? input = Console.ReadLine();
            string[] argsArray = input.Split(' ');

            if (argsArray.Length == 0)
            {
                Console.WriteLine("No arguments!");
                return;
            }

            switch (argsArray[0])
            {
                case "xor":
                    if (argsArray.Length < 3)
                    {
                        Console.WriteLine("Not enough arguments!");
                        return;
                    }
                    XOR.XorFile(argsArray[1], argsArray[2]);
                    break;
                case "help":
                    Console.WriteLine("xor <file> <key> - Encrypts a file with a key");
                    break;
                default:
                    Console.WriteLine("Invalid argument!");
                    break;
            }
        }
    }
}