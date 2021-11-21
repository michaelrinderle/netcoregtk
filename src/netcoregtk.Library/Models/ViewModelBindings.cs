
namespace netcoregtk.Library.Models
{
    public class ViewModelBindings
    {
        public string Resource { get; set; }
        public string Window { get; set; }

        public ViewModelBindings(string resource, string window)
        {
            this.Resource = resource;
            this.Window = window;
        }
    }
}
