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

namespace VacanzeTepsit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btncalcola_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(txtnumero.Text);
            lblbinario.Content = $"binario = {Convert.ToString(a, 2)}";
            lblbinarioopposto.Content = $"binario inverso={Convert.ToString(-a, 2)}";
            int b = a - 1;
            int c = a + 1;
            lblsomma.Content = $"binario+1 = {Convert.ToString(c, 2)}";
            lblsottrazione.Content = $"binario-1 = {Convert.ToString(b, 2)}";

        }
    }
}
