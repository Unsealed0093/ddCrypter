using daydream.Utils;

namespace daydream.Protection.Anti
{
    public class Sandboxie
    {
        public static void AntiSandboxie()
        {

            if (Environment.GetEnvironmentVariable("SANDBOXIE_INSTALL_PATH") != null)
            {
                Environment.Exit(0);
            }

            Logger.Write("Sandboxie is not installed!", Logger.LogLevel.Info);
        }
    }
}