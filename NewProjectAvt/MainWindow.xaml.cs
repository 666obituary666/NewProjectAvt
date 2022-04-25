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

namespace NewProjectAvt
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Users DataBase = new Users();
        public MainWindow()
        {
            InitializeComponent();
            DataBase.ConnectionUsers();
        }

        private void tblogin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnint_Click(object sender, RoutedEventArgs e)
        {
            int input = DataBase.UsersLogin(tblogin.Text, tbpassword.Text);
            if(input > 0)
            {
                MessageBox.Show("Вы вошли под своим логином!");
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Вы ввели неправильный логин или пароль");
            }
        }
    }
}
