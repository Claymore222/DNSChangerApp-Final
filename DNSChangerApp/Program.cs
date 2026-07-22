namespace DNSChangerApp
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            bool autorun = args.Length > 0 && args[0] == "-autorun";
            Application.Run(new Form1(autorun));
        }
    }
}