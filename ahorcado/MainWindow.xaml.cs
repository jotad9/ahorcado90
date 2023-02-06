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

namespace ahorcado
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {

            InitializeComponent();
        }
        private void cambiarColorEntrar(object sender, MouseEventArgs e)
        {
            ((Button)sender).Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");
        }
        private void cambiarColorSalir(object sender, MouseEventArgs e)
        {
            ((Button)sender).Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 ventana = new Window1();
            ventana.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

    }
}
