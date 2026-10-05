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

namespace Rezervace
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Movie movie;
        Customer customer;
        Rezervation rezervation;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = txtMovie.Text;
                double price = double.Parse(txtPrice.Text);
                string customerName = txtCustomer.Text;
                int age = int.Parse(txtAge.Text);

                movie = new Movie(name, price);
                customer = new Customer(customerName, age);


                rezervation = new Rezervation(customer, movie);

                txtResult.Text = rezervation.CalculatePrice().ToString();

                /*
                MessageBox.Show(movie.GetName());
                MessageBox.Show(movie.GetPrice().ToString());
                
                movie.Name = "qwerty";
                
                MessageBox.Show(movie.Name);

                */

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}