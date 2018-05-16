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
using System.Windows.Shapes;

namespace QLThuoc
{
    /// <summary>
    /// Interaction logic for WPF_Login.xaml
    /// </summary>
    public partial class WPF_Login : Window
    {
        public WPF_Login()
        {
            InitializeComponent();
        }
        int Chk_Remmber_check = 1;

        private void main_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Chk_Remmber_MouseEnter(object sender, MouseEventArgs e)
        {
            //Chk_Remmber.Source = new BitmapImage(new Uri("pack://application:,,,/Assets/remember_.png"));
            //Chk_Remmber.Stretch = Stretch.UniformToFill;
        }

        private void Chk_Remmber_MouseLeave(object sender, MouseEventArgs e)
        {
            //Chk_Remmber.Source = new BitmapImage(new Uri("pack://application:,,,/Assets/remember.png"));
            //Chk_Remmber.Stretch = Stretch.UniformToFill;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Chk_Remmber.Stretch = Stretch.UniformToFill;
        }

        private void Chk_Remmber_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Txt_MatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(Txt_MatKhau.Password.ToString());
        }

        private void Txt_TaiKhoan_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show(Txt_TaiKhoan.Text.ToString ());
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Chk_Remmber_MouseDown(object sender, MouseButtonEventArgs e)
        {         
            if(Chk_Remmber_check == 1)
            {
                Chk_Remmber.Source = new BitmapImage(new Uri("pack://application:,,,/Assets/remember_.png"));
                Chk_Remmber.Stretch = Stretch.UniformToFill;
                Chk_Remmber_check = 2;
                return;
            }

            if (Chk_Remmber_check == 2)
            {
                Chk_Remmber.Source = new BitmapImage(new Uri("pack://application:,,,/Assets/remember.png"));
                Chk_Remmber.Stretch = Stretch.UniformToFill;
                Chk_Remmber_check = 1;
                return;
            }

        }
    }
}
