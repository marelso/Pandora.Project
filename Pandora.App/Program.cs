using Pandora.App.Views;

namespace Pandora.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Master());
        }
    }
}