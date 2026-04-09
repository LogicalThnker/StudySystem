using System;
using System.Windows;

namespace StudySystem
{
    public class EntryPoint
    {
        [STAThread]
        public static void Main()
        {
            var app = new Application();
            var mainWindow = new MainWindow();
            app.Run(mainWindow);
        }
    }
}
