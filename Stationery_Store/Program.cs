namespace Stationery_Store
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
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
//<<<<<<< HEAD
            Application.Run(new HomeForm());
            //CategoryForm
            //SellForm
=======
            Application.Run(new MainForm());
>>>>>>> 89fd11ddc265b14422c822a87ce2c6babf5e8265
        }
    }
}