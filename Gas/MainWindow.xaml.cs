using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Gas
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ShopItems gas;
        private ShopItems burger;
        private ShopItems water;
        private ShopItems chocolate;
        public MainWindow()
        {
            InitializeComponent();

            gas = new ShopItems();
            burger = new ShopItems();
            water = new ShopItems();
            chocolate = new ShopItems();

            gasPrice.DataContext = gas;
            gasCount.DataContext = gas;
            burgerPrice.DataContext = burger;
            burgerCount.DataContext = burger;
            waterPrice.DataContext = water;
            waterCount.DataContext = water;
            chocolatePrice.DataContext = chocolate;
            chocolateCount.DataContext = chocolate;
        }
    
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            payment.Text = gas.Price * gas.Count + burger.Price * burger.Count + water.Price * water.Count + chocolate.Price * chocolate.Count + "";
        }
    }
}
