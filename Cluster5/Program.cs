namespace Cluster5
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            List<Player> scores = new List<Player>();


            ApplicationConfiguration.Initialize();
            Application.Run(new Menu(scores));
        }
    }
}