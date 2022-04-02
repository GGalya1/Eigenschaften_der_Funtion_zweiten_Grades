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

namespace WpfAufgabe1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Knopf_Click(object sender, RoutedEventArgs e)
        {
            QuadratischeFunktion f = new QuadratischeFunktion(Convert.ToDouble(Argument1.Text), Convert.ToDouble(Argument2.Text), Convert.ToDouble(Argument3.Text));
            Ausgabe.Text = f.GibWerte();
            Ausgabe.Text = f.NullstellenBerechen();
        }
    }
}
