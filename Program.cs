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
                // Check if Sandboxie is installed
                Sandboxie.AntiSandboxie();

                // Check if Anubis is installed
                Anubis.AntiAnubis();

                // Check if Wireshark is installed
                Wireshark.AntiWireshark();

                // Check if Virtualbox is installed
                VirtualBox.AntiVirtualBox();

                // Check if Vmware is installed
                Vmware.AntiVmware();
            }

            Console.Write("Input: ");
            
            string? input = Console.ReadLine();
            string[] argsArray = input.Split(' ');

            if (argsArray.Length == 0)
            {
                Console.WriteLine("No arguments!");
                return;
            }

            if(argsArray[0] == "xor")
            {
                if (argsArray.Length < 3)
                {
                    Console.WriteLine("Not enough arguments!");
                    return;
                }

                XOR.XorFile(argsArray[1], argsArray[2]);
            }


        }
    }
}