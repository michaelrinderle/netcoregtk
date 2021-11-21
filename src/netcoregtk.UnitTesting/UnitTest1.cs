using netcoregtk.Library.Models;
using netcoregtk.ViewModels;
using Xunit;

namespace netcoregtk.UnitTesting
{
    public class UnitTest1
    {
        [Fact]
        public void MainWindowViewModelTest()
        {
            var test = new MainWindowViewModel(new ViewModelBindings(
                    "netcoregtk.Library.UI.MainWindow.glade",
                    "MainWindow"));

            Assert.NotNull(test);
        }
    }
}