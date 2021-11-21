using Gdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netcoregtk.Views
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
