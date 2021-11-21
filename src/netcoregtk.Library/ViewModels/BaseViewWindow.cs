using Gtk;
using netcoregtk.Library.Models;

namespace netcoregtk.Library.ViewModels
{
    public abstract class BaseViewWindow : Window
    {
        public BaseViewWindow(ViewModelBindings binding)
            : this(new Builder(binding.Resource), binding.Window) { }

        public BaseViewWindow(Builder builder, string window)
            : base(builder.GetRawOwnedObject(window))
        {
            builder.Autoconnect(this);
            this.InitializeWindow();
        }


        public abstract void InitializeWindow();

    }
}
