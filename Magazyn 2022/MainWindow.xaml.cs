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

namespace Magazyn_2022
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AUser Picia = new UserAdministracja("Picia", "Szczepionka", 1);
            AUser Huber = new UserAdministracja("H", "K", 15);
            Testy.Text += Picia.GetAllInfo();
            Testy2.Text += Huber.GetAllInfo();
            
        }
    }
}
