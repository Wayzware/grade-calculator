using System;
using Gtk;

namespace GradeCalculator
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.Init();

            Application app = new Application("org.grade_calculator.grade_calculator", GLib.ApplicationFlags.None);
            app.Register(GLib.Cancellable.Current);

            MainWindow mainWindow = new MainWindow(new GradeManager());
            app.AddWindow(mainWindow);

            mainWindow.Show();
            Application.Run();
        }
    }
}
