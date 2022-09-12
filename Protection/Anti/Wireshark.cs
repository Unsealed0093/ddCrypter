using daydream.Utils;

namespace daydream.Protection.Anti
{
    public class Wireshark
    {
        public static void AntiWireshark()
        {

            if (Environment.GetEnvironmentVariable("WIRESHARK_DISPLAY_NAME") != null)
            {
                Environment.Exit(0);
            }
            
            Logger.Write("Wireshark is not installed!", Logger.LogLevel.Info);
        }
    }
}