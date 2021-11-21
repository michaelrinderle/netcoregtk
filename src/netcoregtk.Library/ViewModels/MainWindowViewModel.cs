using Gtk;
using netcoregtk.Library.Models;
using netcoregtk.Library.ViewModels;
using UI = Gtk.Builder.ObjectAttribute;

namespace netcoregtk.ViewModels
{
    public class MainWindowViewModel : BaseViewWindow
    {
        [UI] private Label _label1 = null;
        [UI] private Button _button1 = null;

        private bool flipMessage;

        public MainWindowViewModel(ViewModelBindings binding)
            : base(new Builder(binding.Resource), binding.Window) { }

        public override void InitializeWindow()
        {
            DeleteEvent += MainWindow_DeleteEvent;
            _button1.Clicked += Button1_Clicked;
        }

        private void Button1_Clicked(object? sender, EventArgs e)
        {
            _label1.Text = (flipMessage) ? "Hip Hop Hooray" : "Ho! Hey Ho!";
            flipMessage = !flipMessage;
        }

        private void MainWindow_DeleteEvent(object o, DeleteEventArgs args)
        {
            Application.Quit();
        }
    }
}
