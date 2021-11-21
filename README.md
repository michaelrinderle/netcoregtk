# .Net Core GTK Template
MVC, Cross platform C# GUI Template

# Features
 + Easy To Use MVC Pattern

# Example

+ Glade View Code Behind 
```
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
```

+ View Model 
```
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
```

+ Glade Markup 
```
public class MainWindowViewModel : BaseViewWindow
<?xml version="1.0"?>
<interface>
  <requires lib="gtk+" version="2.16"/>
  <!-- interface-naming-policy project-wide -->
  <object class="GtkWindow" id="MainWindow">
    <child>
      <object class="GtkTable" id="table1">
        <property name="visible">True</property>
        <property name="n_columns">2</property>
        <child>
          <object class="GtkButton" id="_button1">
            <property name="label" translatable="yes">button</property>
            <property name="visible">True</property>
            <property name="can_focus">True</property>
            <property name="receives_default">True</property>
          </object>
        </child>
        <child>
          <object class="GtkLabel" id="_label1">
            <property name="visible">True</property>
            <property name="label" translatable="yes">label</property>
          </object>
          <packing>
            <property name="left_attach">1</property>
            <property name="right_attach">2</property>
          </packing>
        </child>
      </object>
    </child>
  </object>
</interface>
```