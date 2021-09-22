using System;
using System.Collections.Generic;
using System.Linq;
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
using WpfApplication1;
using NormasJuego;
using WpfApplication2;

namespace WpfApplication1
{

    public partial class MainWindow : Window
    {


        Rectangle[,] casillas; // Matriz donde guardaremos todos los rectangulos para poder recorrerlos
        int x;  //columnas
        int y;  //filas
        Malla matriz_celdas= new Malla();
      // Malla matriz_espejo = new Malla();
       
      

        public MainWindow()
        {
            InitializeComponent();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e) // mostrar reglas
        {

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e) // guardar fichero
        {

        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e) // cargar fichero
        {

        }

        private void rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Rectangle a = (Rectangle)sender;
            a.Fill = new SolidColorBrush(Colors.Black);
            Point p = (Point)a.Tag;
            matriz_celdas.SetVidaDeCelda(Convert.ToInt32(p.Y), Convert.ToInt32(p.X), true);
            
          

        } // pintar de negro las seleccionadas


        private void button3_Click(object sender, RoutedEventArgs e) // crear rejilla
        {
            button1.IsEnabled = true;
            try
            {
                x = Convert.ToInt32(TextBoxX.Text);
                y = Convert.ToInt32(TextBoxY.Text);
                matriz_celdas.SetNumeroDeFilasYColumnas(y, x);  // es crea matriu i somple de cell
            }
            catch
            {
                x = 10;
                y=10;
                matriz_celdas.SetNumeroDeFilasYColumnas(y, x);
            }
                     
         

            casillas = new Rectangle[y, x];

            canvas1.Height = y * 15;
            canvas1.Width = x * 15;

            // Bucle para crear los rectangulos
            for (int i = 0; i < y; i++)
                for (int j = 0; j < x; j++)
                {
                    Rectangle b = new Rectangle();
                    b.Width = 15;
                    b.Height = 15;
                    b.Fill = new SolidColorBrush(Colors.Gray);
                    b.StrokeThickness = 0.5;
                    b.Stroke = Brushes.Black;
                    canvas1.Children.Add(b);

                    // Posicion del cuadrado
                    Canvas.SetTop(b, (i - 1) * 15);
                    Canvas.SetLeft(b, (j - 1) * 15);
                    b.Tag = new Point(i, j);

                    b.MouseDown += new MouseButtonEventHandler(rectangle_MouseDown);

                    casillas[j, i] = b;
                }



        }

        private void button1_Click(object sender, RoutedEventArgs e) // simular paso a paso
        {


            matriz_celdas.MallaFutura(); // actualizamos

            // volvemos a pintar los rectangulos
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
 
                    if (matriz_celdas.DameElEstadoDe(j,i) == false)
                    { casillas[j, i].Fill = new SolidColorBrush(Colors.Gray); }
                    if (matriz_celdas.DameElEstadoDe(j, i) == true)
                    { casillas[j, i].Fill = new SolidColorBrush(Colors.Black); }

                }
            }


        }
    }
}

