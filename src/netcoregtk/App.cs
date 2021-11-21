using netcoregtk.Views;
using Gtk;


namespace netcoregtk
{
    public static class App
    {

        [STAThread]
        public static void Main(string[] args)
        {
            Application.Init();

            var app = new Application("net.sofdigital.easyapply", GLib.ApplicationFlags.None);
            app.Register(GLib.Cancellable.Current);

            var view = new MainWindow();
            var window = view.GetWindow();
            app.AddWindow(window);

            window.Show();
            Application.Run();
        }
    }
}