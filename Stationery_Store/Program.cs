using Stationery_Store.Forms;

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
<<<<<<< Updated upstream
            Application.Run(new SellForm());
            //SellForm
            //MainForm
=======
            Application.Run(new Forms.CategoryForm());
>>>>>>> Stashed changes
        }
    }
}