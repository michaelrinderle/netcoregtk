
namespace netcoregtk.Library.Views
{
    public abstract class BaseView<T>
    {
        public T? ViewModelWindow { get; set; }

        public T GetWindow()
        {
            return ViewModelWindow;
        }
    }
}
