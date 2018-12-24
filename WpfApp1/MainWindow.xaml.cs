using HandyControl.Controls;
using HandyControl.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CmdTest(object sender, RoutedEventArgs e)
        {
            //var picker = SingleOpenHelper.CreateControl<ColorPicker>();
            //var window = new PopupWindow
            //{
            //    PopupElement = picker,
            //    WindowStartupLocation = WindowStartupLocation.CenterScreen,
            //    AllowsTransparency = true,
            //    WindowStyle = WindowStyle.None,
            //    MinWidth = 0,
            //    MinHeight = 0,
            //    Title = "test"
            //};
            //picker.SelectedColorChanged += delegate { window.Close(); };
            //picker.Canceled += delegate { window.Close(); };
            //window.Show();


            var picker = new ColorPicker();
            ContentPresenter contentPresenter = new ContentPresenter
            {
                Content = picker
            };
            Border boder = new Border
            {
            };
            boder.Child = contentPresenter;
            var window = new Window
            {
                Content = boder,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                AllowsTransparency = true,
                WindowStyle = WindowStyle.None,
                MinWidth = 0,
                MinHeight = 0,
                Title = "test"
            };
            picker.SelectedColorChanged += delegate { window.Close(); };
            picker.Canceled += delegate { window.Close(); };
            window.Show();


        }
    }
}
