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


namespace QLThuoc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ContentPresenter_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void listViewItem_Selected(object sender, RoutedEventArgs e)
        {
            MainGrid.Children.Clear();
            
            txb_TenMenu.Text = "User";
            UCT_WPF.Uct_HeThong a = new UCT_WPF.Uct_HeThong();
            txb_TenMenu.Text += " --> Hệ Thống";
            MainGrid.Children.Add(a);
        }

        private void listViewItem1_Selected(object sender, RoutedEventArgs e)
        {
            MainGrid.Children.Clear();
            
            txb_TenMenu.Text = "User";
            UCT_WPF.UCT_DanhMuc a = new UCT_WPF.UCT_DanhMuc();
            txb_TenMenu.Text += " --> Danh mục";
            MainGrid.Children.Add(a);
        }

        private void listViewItem2_Selected(object sender, RoutedEventArgs e)
        {
            MainGrid.Children.Clear();
            
            txb_TenMenu.Text = "User";
            UCT_WPF.UCT_HoaDon a = new UCT_WPF.UCT_HoaDon();
            txb_TenMenu.Text += " --> Hóa đơn";
            MainGrid.Children.Add(a);
        }

        private void listViewItem3_Selected(object sender, RoutedEventArgs e)
        {
            MainGrid.Children.Clear();
            
            txb_TenMenu.Text = "User";
            UCT_WPF.UCT_ThongKe a = new UCT_WPF.UCT_ThongKe();
            txb_TenMenu.Text += " --> Thông kê";
            MainGrid.Children.Add(a);
        }

        private void listViewItem4_Selected(object sender, RoutedEventArgs e)
        {
            MainGrid.Children.Clear();
            
            txb_TenMenu.Text = "User";
            UCT_WPF.UCT_GioiThieu a = new UCT_WPF.UCT_GioiThieu();
            txb_TenMenu.Text += " --> Trợ giúp";
            MainGrid.Children.Add(a);
        }

        private void btn_home_Click(object sender, RoutedEventArgs e)
        {
            MainGrid.Children.Clear();
            
            txb_TenMenu.Text = "User";
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WPF_Login fa = new WPF_Login();
            fa.ShowDialog();
        }
    }
}
