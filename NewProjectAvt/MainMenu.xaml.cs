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
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        Users db = new Users();
        public MainMenu()
        {
            InitializeComponent();
            db.ConnectionUsers();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            db.AddUsers(tbfirstname.Text, tblastname.Text, tblogin.Text, tbpassword.Text);
            
        }
    }
}
