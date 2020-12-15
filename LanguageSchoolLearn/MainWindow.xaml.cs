using LanguageSchoolLearn.Views;
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

namespace LanguageSchoolLearn
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var login = LoginBox.Text;
            var password = PasswodBox.Password;
            var user = App.Entities.Client.FirstOrDefault(x=> x.FirstName == login && x.LastName == password);
            //Viktor 4321
            //Den 1234
            if (user != null)
            {
                if (user.GenderCode == "м")
                {
                    var view = new AdminView();
                    this.Hide();
                    view.ShowDialog();
                    this.Close();
                }
                else
                {
                    var view = new UserView();
                    this.Hide();
                    view.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}
