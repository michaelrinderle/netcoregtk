using netcoregtk.Library.Models;
using netcoregtk.ViewModels;

namespace netcoregtk.Views
{
    public class MainWindow : BaseView<MainWindowViewModel>
    {
        public MainWindow()
        {
            ViewModelWindow =
                new MainWindowViewModel(new ViewModelBindings(
                    "netcoregtk.Library.UI.MainWindow.glade",
                    "MainWindow"));
        }
    }
}
