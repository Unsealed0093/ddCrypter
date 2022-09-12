using daydream.Utils;

namespace daydream.Protection.Anti
{
    public class Vmware
    {
        public static void AntiVmware()
        {
            if (Environment.GetEnvironmentVariable("VMWARE_INSTALL_PATH") != null)
            {
                Environment.Exit(0);
            }
            
            Logger.Write("Vmware is not installed!", Logger.LogLevel.Info);

        }
    }
}