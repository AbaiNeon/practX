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

namespace WpfTest
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string login1 = "User1";
            string login2 = "User2";

            string password1 = "1";
            string password2 = "2";

            if (login.Text == login1 && password.Text == password1)
            {
                Page1 page1 = new Page1();
                this.NavigationService.Navigate(page1);
            }
            else if (login.Text == login2 && password.Text == password2)
            {
                Page2 page2 = new Page2();
                this.NavigationService.Navigate(page2);
            }

        }
    }
}
