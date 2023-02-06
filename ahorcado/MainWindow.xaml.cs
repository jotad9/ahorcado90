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
        StringBuilder laPalabra;//Va a ser la palabra sacada del array 
        Boolean letraAcertada;
        int fallos = 0;
        String[] palabras = { "sol", "palabra", "gracioso", "estupendo", "increible", "carpintero", "calor" };
        String palabraConApostrofes;//esta palabra la voy a usar como medio para ir pasandoselo al label
        int numeroDeLetras;
        char elCaracter;

        public MainWindow()
        {

            InitializeComponent();
            Encriptar();
        }

        public void Encriptar()
        {

            Random random = new Random();
            int numRandom = random.Next(0, 6);
            char[] chars = palabras[numRandom].ToCharArray();
            laPalabra = new StringBuilder(palabras[numRandom]);
            numeroDeLetras = chars.Length;
            for (int x = 0; x < numeroDeLetras; x++)
            {
                palabraConApostrofes += "*";
            }
            palabraEncriptada.Content = palabraConApostrofes;

        }
        public void desencriptar()
        {
            StringBuilder nuevaPalabra = new StringBuilder(palabraEncriptada.Content.ToString());
            for (int x = 0; x < numeroDeLetras; x++)
            {
                if (laPalabra[x].Equals(elCaracter))
                {
                    nuevaPalabra[x] = elCaracter;
                    letraAcertada = true;
                }
                palabraEncriptada.Content = nuevaPalabra;

            }
            if (letraAcertada == false)
            {
                fallos++;
                dibujo();

            }
            letraAcertada = false;


        }
        public void dibujo()
        {

            switch (fallos)
            {
                case 1:

                    primera.Visibility = Visibility.Visible;
                    break;

                case 2:
                    segunda.Visibility = Visibility.Visible;
                    primera.Visibility = Visibility.Collapsed;
                    break;
                case 3:
                    tercera.Visibility = Visibility.Visible;
                    segunda.Visibility = Visibility.Collapsed;
                    break;
                case 4:
                    cuarta.Visibility = Visibility.Visible;
                    tercera.Visibility = Visibility.Collapsed;
                    break;
                case 5:
                    quinta.Visibility = Visibility.Visible;
                    cuarta.Visibility = Visibility.Collapsed;
                    break;


            }
        }

        private void a_Click(object sender, RoutedEventArgs e)
        {

            elCaracter = 'a';
            desencriptar();
            a.IsEnabled = false;
        }

        private void b_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'b';
            desencriptar();
            a.IsEnabled = false;
        }

        private void c_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'c';
            desencriptar();
            a.IsEnabled = false;
        }

        private void d_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'd';
            desencriptar();
            a.IsEnabled = false;
        }

        private void e_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'e';
            desencriptar();
            a.IsEnabled = false;
        }

        private void f_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'f';
            desencriptar();
            a.IsEnabled = false;
        }

        private void g_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'g';
            desencriptar();
            a.IsEnabled = false;
        }

        private void h_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'h';
            desencriptar();
            a.IsEnabled = false;
        }

        private void i_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'i';
            desencriptar();
            a.IsEnabled = false;
        }

        private void j_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'j';
            desencriptar();
            a.IsEnabled = false;
        }

        private void k_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'k';
            desencriptar();
            a.IsEnabled = false;
        }

        private void l_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'l';
            desencriptar();
            a.IsEnabled = false;
        }

        private void m_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'm';
            desencriptar();
            a.IsEnabled = false;
        }

        private void n_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'n';
            desencriptar();
            a.IsEnabled = false;
        }

        private void o_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'o';
            desencriptar();
            a.IsEnabled = false;
        }

        private void p_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'p';
            desencriptar();
            a.IsEnabled = false;
        }

        private void q_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'q';
            desencriptar();
            a.IsEnabled = false;
        }

        private void r_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'r';
            desencriptar();
            a.IsEnabled = false;
        }

        private void s_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 's';
            desencriptar();
            a.IsEnabled = false;
        }

        private void t_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 't';
            desencriptar();
            a.IsEnabled = false;
        }

        private void u_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'u';
            desencriptar();
            a.IsEnabled = false;
        }

        private void v_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'v';
            desencriptar();
            a.IsEnabled = false;
        }

        private void x_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'x';
            desencriptar();
            a.IsEnabled = false;
        }



        private void y_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'y';
            desencriptar();
            a.IsEnabled = false;
        }

        private void z_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'z';
            desencriptar();
            a.IsEnabled = false;
        }

        private void w_click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'w';
            desencriptar();
            a.IsEnabled = false;

        }

        private void a_MouseEnter(object sender, MouseEventArgs e)
        {
            a.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");
        }

        private void a_MouseLeave(object sender, MouseEventArgs e)
        {
            a.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }
        private void b_MouseEnter(object sender, MouseEventArgs e)
        {
            b.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");
        }

        private void b_MouseLeave(object sender, MouseEventArgs e)
        {
            b.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }
        private void c_MouseEnter(object sender, MouseEventArgs e)
        {
            c.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");
        }

        private void c_MouseLeave(object sender, MouseEventArgs e)
        {
            c.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }
        private void d_MouseEnter(object sender, MouseEventArgs e)
        {
            d.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");
        }

        private void d_MouseLeave(object sender, MouseEventArgs e)
        {
            d.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }
        private void e_MouseEnter(object sender, MouseEventArgs e)
        {
        }

        private void e_MouseLeave(object sender, MouseEventArgs e)
        {
        }

        private void g_MouseEnter(object sender, MouseEventArgs e)
        {
            g.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");
        }

        private void g_MouseLeave(object sender, MouseEventArgs e)
        {
            g.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }

        private void f_MouseEnter_1(object sender, MouseEventArgs e)
        {
            f.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");

        }

        private void f_MouseLeave_1(object sender, MouseEventArgs e)
        {
            f.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }

        private void h_MouseEnter(object sender, MouseEventArgs e)
        {
            h.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");
        }

        private void h_MouseLeave(object sender, MouseEventArgs e)
        {
            h.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }

        private void i_MouseEnter(object sender, MouseEventArgs e)
        {
            i.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");
        }

        private void i_MouseLeave(object sender, MouseEventArgs e)
        {
            i.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }

        private void j_MouseEnter(object sender, MouseEventArgs e)
        {
            j.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");
        }

        private void j_MouseLeave(object sender, MouseEventArgs e)
        {
            j.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");

        }

        private void k_MouseEnter(object sender, MouseEventArgs e)
        {
            k.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");
        }

        private void k_MouseLeave(object sender, MouseEventArgs e)
        {
            k.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }

        private void l_MouseEnter(object sender, MouseEventArgs e)
        {
            l.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");
        }

        private void l_MouseLeave(object sender, MouseEventArgs e)
        {
            l.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }

        private void m_MouseEnter(object sender, MouseEventArgs e)
        {
            m.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");
        }

        private void m_MouseLeave(object sender, MouseEventArgs e)
        {
            m.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }

        private void n_MouseEnter(object sender, MouseEventArgs e)
        {
            n.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");
        }

        private void n_MouseLeave(object sender, MouseEventArgs e)
        {
            n.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }

        private void o_MouseEnter(object sender, MouseEventArgs e)
        {
            o.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");
        }

        private void o_MouseLeave(object sender, MouseEventArgs e)
        {
            o.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }

        private void p_MouseEnter(object sender, MouseEventArgs e)
        {
            p.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");
        }

        private void p_MouseLeave(object sender, MouseEventArgs e)
        {
            p.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }

        private void q_MouseEnter(object sender, MouseEventArgs e)
        {
            q.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");
        }

        private void q_MouseLeave(object sender, MouseEventArgs e)
        {
            q.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }

        private void r_MouseEnter(object sender, MouseEventArgs e)
        {
            r.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");

        }

        private void r_MouseLeave(object sender, MouseEventArgs e)
        {
            r.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }

        private void s_MouseEnter(object sender, MouseEventArgs e)
        {
            s.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");
        }

        private void s_MouseLeave(object sender, MouseEventArgs e)
        {
            s.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }

        private void t_MouseEnter(object sender, MouseEventArgs e)
        {
            t.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");
        }

        private void t_MouseLeave(object sender, MouseEventArgs e)
        {
            t.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }

        private void u_MouseEnter(object sender, MouseEventArgs e)
        {
            u.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");
        }

        private void u_MouseLeave(object sender, MouseEventArgs e)
        {
            u.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }

        private void v_MouseEnter(object sender, MouseEventArgs e)
        {
            v.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");
        }

        private void v_MouseLeave(object sender, MouseEventArgs e)
        {
            v.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }

        private void w_MouseEnter(object sender, MouseEventArgs e)
        {
            w.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");
        }

        private void w_MouseLeave(object sender, MouseEventArgs e)
        {
            w.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }

        private void x_MouseEnter(object sender, MouseEventArgs e)
        {
            x.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");
        }

        private void x_MouseLeave(object sender, MouseEventArgs e)
        {
            x.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }

        private void y_MouseEnter(object sender, MouseEventArgs e)
        {
            y.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");
        }

        private void y_MouseLeave(object sender, MouseEventArgs e)
        {
            y.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }

        private void z_MouseEnter(object sender, MouseEventArgs e)
        {
            z.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");
        }

        private void z_MouseLeave(object sender, MouseEventArgs e)
        {
            z.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");

        }
    }
}
