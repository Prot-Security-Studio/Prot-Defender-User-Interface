using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using Panuon.WPF.UI;
using System.Windows.Shapes;

namespace ProtUserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : WindowX
    {
        public void SetBkgTop(double top)
        {
            MenuBkg.Margin = new Thickness(MenuBkg.Margin.Left, top, MenuBkg.Margin.Right, MenuBkg.Margin.Bottom);
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Menu_0_View_Click(object sender, RoutedEventArgs e)
        {
            SetBkgTop(Menu_0_View.Margin.Top);
            TabControl.SelectedIndex = 0;
        }

        private void Menu_1_Scan_Click(object sender, RoutedEventArgs e)
        {
            SetBkgTop(Menu_1_Scan.Margin.Top);
            TabControl.SelectedIndex = 1;
        }

        private void Menu_2_Protection_Click(object sender, RoutedEventArgs e)
        {
            SetBkgTop(Menu_2_Protection.Margin.Top);
        }

        private void Menu_3_Settings_Click(object sender, RoutedEventArgs e)
        {
            SetBkgTop(Menu_3_Settings.Margin.Top);
        }
    }
}