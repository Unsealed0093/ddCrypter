using daydream.Utils;

namespace daydream.Protection.Anti
{
    public class VirtualBox
    {
        public static void AntiVirtualBox()
        {
            if (Environment.GetEnvironmentVariable("VBOX_INSTALL_PATH") != null)
            {
                Environment.Exit(0);
            }

            Logger.Write("VirtualBox is not installed!", Logger.LogLevel.Info);
        }
    }
}