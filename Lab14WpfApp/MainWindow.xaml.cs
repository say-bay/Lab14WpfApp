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

namespace Lab14WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                productName = "Хлеб",
                productPrice = 56,
                productImage = "/Data/1.jpg",
                productCategory = productCategories.Food
            });
            products.Add(new Product()
            {
                productName = "СВЧ",
                productPrice = 12500,
                productImage = "/Data/2.jpg",
                productCategory = productCategories.Technic
            });
            products.Add(new Product()
            {
                productName = "Кефир",
                productPrice = 70,
                productImage = "/Data/3.jpg",
                productCategory = productCategories.Food
            });

            listBox.ItemsSource = products;
        }
    }
}
