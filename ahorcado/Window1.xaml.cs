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
using System.Windows.Shapes;

namespace ahorcado
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        StringBuilder laPalabra;//Va a ser la palabra sacada del array 
        Boolean letraAcertada;
        int fallos = 0;
        String[] palabras = { "sol", "palabra", "gracioso", "estupendo", "increible", "carpintero", "calor" };
        String palabraConApostrofes;//esta palabra la voy a usar como medio para ir pasandoselo al label
        int numeroDeLetras;
        char elCaracter;

        public Window1()
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
            
            if (laPalabra.Equals(nuevaPalabra))
            {
                Window3 ventana = new Window3();
                ventana.Show();
                Hide();
            }


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

                    Window2 ventana = new Window2();
                    ventana.Show();
                    this.Close();
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
            b.IsEnabled = false;
        }

        private void c_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'c';
            desencriptar();
            c.IsEnabled = false;
        }

        private void d_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'd';
            desencriptar();
            d.IsEnabled = false;
        }

        private void e_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'e';
            desencriptar();
           
        }

        private void f_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'f';
            desencriptar();
            f.IsEnabled = false;
        }

        private void g_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'g';
            desencriptar();
            g.IsEnabled = false;
        }

        private void h_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'h';
            desencriptar();
            h.IsEnabled = false;
        }

        private void i_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'i';
            desencriptar();
            i.IsEnabled = false;
        }

        private void j_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'j';
            desencriptar();
            j.IsEnabled = false;
        }

        private void k_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'k';
            desencriptar();
            k.IsEnabled = false;
        }

        private void l_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'l';
            desencriptar();
            l.IsEnabled = false;
        }

        private void m_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'm';
            desencriptar();
            m.IsEnabled = false;
        }

        private void n_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'n';
            desencriptar();
            n.IsEnabled = false;
        }

        private void o_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'o';
            desencriptar();
            o.IsEnabled = false;
        }

        private void p_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'p';
            desencriptar();
            p.IsEnabled = false;
        }

        private void q_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'q';
            desencriptar();
            q.IsEnabled = false;
        }

        private void r_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'r';
            desencriptar();
            r.IsEnabled = false;
        }

        private void s_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 's';
            desencriptar();
            s.IsEnabled = false;
        }

        private void t_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 't';
            desencriptar();
            t.IsEnabled = false;
        }

        private void u_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'u';
            desencriptar();
            u.IsEnabled = false;
        }

        private void v_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'v';
            desencriptar();
            v.IsEnabled = false;
        }

        private void x_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'x';
            desencriptar();
            x.IsEnabled = false;
        }



        private void y_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'y';
            desencriptar();
            y.IsEnabled = false;
        }

        private void z_Click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'z';
            desencriptar();
            z.IsEnabled = false;
        }

        private void w_click(object sender, RoutedEventArgs e)
        {
            elCaracter = 'w';
            desencriptar();
            w.IsEnabled = false;

        }

        private void cambiarColorEntrar(object sender, MouseEventArgs e)
        {
            ((Button)sender).Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#BBBBBB");
        }
        private void cambiarColorSalir(object sender, MouseEventArgs e)
        {
            ((Button)sender).Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFDDDDDD");
        }
    }
}
