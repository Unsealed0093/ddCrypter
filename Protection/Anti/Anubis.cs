using daydream.Utils;

namespace daydream.Protection.Anti
{
    public class Anubis
    {
        public static void AntiAnubis()
        {
            if (Environment.GetEnvironmentVariable("ANUBIS_INSTALL_PATH") != null)
            {
                Environment.Exit(0);
            }

            Logger.Write("Anubis is not installed!", Logger.LogLevel.Info);
        }
    }
}