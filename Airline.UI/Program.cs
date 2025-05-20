using Airline.UI;

namespace airline
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            while (true)
            {
                using (var loginForm = new Login())
                {
                    // Show login as modal dialog
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        using (var mainMenu = new MainMenu())
                        {
                            // Show main menu as modal dialog
                            if (mainMenu.ShowDialog() != DialogResult.Retry)
                                break; // Exit app if not logging out
                        }
                    }
                    else
                    {
                        break; // Exit app if login cancelled/closed
                    }
                }
            }
        }
    }
}