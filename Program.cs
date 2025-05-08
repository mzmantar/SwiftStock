using SwiftStock.Views;

namespace SwiftStock
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configure l'application pour utiliser les paramètres par défaut (DPI élevé, police, etc.)
            Application.EnableVisualStyles(); // Remplacement de ApplicationConfiguration.Initialize()
            Application.SetCompatibleTextRenderingDefault(false);

            // Lance l'application avec le formulaire principal
            Application.Run(new LoginView());
        }
    }
}
