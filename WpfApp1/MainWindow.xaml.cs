using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            InitializeProducts();
            ProductListBox.ItemsSource = products;
        }
        private void InitializeProducts()
        {
            products = new List<Product>
            {
            };
        }

        string s = "";
        string s2 = "";
        string s3 = "";
        string s4 = "";
        string s5 = "";


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.s = Sos.Text;
        }
        private void TextBox_TextChanged2(object sender, TextChangedEventArgs e)
        {
            this.s2 = Sos_Копировать.Text;
        }
        private void TextBox_TextChanged3(object sender, TextChangedEventArgs e)
        {
            this.s3 = So.Text;
        }
        private void TextBox_TextChanged4(object sender, TextChangedEventArgs e)
        {
            this.s4 = So_Копировать.Text;
        }
        private void TextBox_TextChanged5(object sender, TextChangedEventArgs e)
        {
            this.s5 = So_Копировать1.Text;
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            Product newProduct = new Product
            {
                ima = this.s,
                Kakoi = this.s2,
                ProizBel = this.s3,
                Cena = this.s4,
                OcTaLoc = this.s5,
            };

            products.Add(newProduct);
            ProductListBox.Items.Refresh();
        }
    }
}



public class Product
{
    public string ima { get; set; }
    public string Kakoi { get; set; }
    public string ProizBel { get; set; }
    public string Cena { get; set; }
    public string OcTaLoc { get; set; }

    public override string ToString()
    {
        return $"{ima} - {Kakoi} - {ProizBel:C}- Цена: {Cena:C} - Остаток: {OcTaLoc}";
    }
}
