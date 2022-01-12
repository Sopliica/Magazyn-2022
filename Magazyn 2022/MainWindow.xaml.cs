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
using Magazyn_2022.Controler.Factory_Method_Client;
using Magazyn_2022.Controler.Login;
using Magazyn_2022.Model.Klienci;
using Magazyn_2022.Model.Users;

namespace Magazyn_2022
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LoginControler _loginControler;

        public MainWindow()
        {
            InitializeComponent();
            AUser Picia = new UserAdministracja("Picia", "Szczepionka", 1);
            AUser Huber = new UserAdministracja("H", "K", 15);
            Testy.Text += Picia.GetAllInfo();
            Testy.Text += Huber.GetAllInfo();
            IClient dupa = new CompanyClient();
            _loginControler = new LoginControler();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _loginControler.LogIn(loginBox.Text, passwordBox.Text);
        }
        private void loginBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
