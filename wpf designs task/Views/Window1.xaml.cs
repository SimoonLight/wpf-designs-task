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

namespace wpf_designs_task.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public string? username_
        {
            get { return (string)GetValue(username_Property); }
            set { SetValue(username_Property, value); }
        }
        public static readonly DependencyProperty username_Property =
            DependencyProperty.Register("username_", typeof(string), typeof(Window1));

        public string? password_
        {
            get { return (string)GetValue(password_Property); }
            set { SetValue(password_Property, value); }
        }
        public static readonly DependencyProperty password_Property =
            DependencyProperty.Register("password_", typeof(string), typeof(Window1));


        public Window1()
        {
            InitializeComponent();
            DataContext = this;
            //username_ = "enter your username";
            //password_ = "enter your password";

            username_ = "";
            password_ = "";
        }
        private void login_btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(username_);
            MessageBox.Show(password_);
            if (username_!= "" && username_ != "enter your username" && password_ !="" && password_ != "enter your password")
            {
                MessageBox.Show("Login Succesfully");
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void password_txtbox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (password_ == "enter your password") 
            {
                password_ = "";
            }
        }

        private void username_txtbox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (username_ == "enter your username")
            {
                username_ = "";
            }
        }

        private void username_txtbox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (username_=="")
            {
                username_ = "enter your username";
            }
        }

        private void password_txtbox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (password_ == "")
            {
                password_ = "enter your password";
            }
        }
    }
}
