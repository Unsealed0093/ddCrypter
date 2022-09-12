namespace daydream.Utils
{
    public static class Logger
    {
        public enum LogLevel
        {
            Info,
            Success,
            Warning,
            Error,
        }

        public static void Write(string message, LogLevel type)
        {
            switch(type)
            {   
                case LogLevel.Info:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} [-] {message}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case LogLevel.Success:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} [+] {message}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case LogLevel.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} [?] {message}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case LogLevel.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} [!] {message}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
    }
}