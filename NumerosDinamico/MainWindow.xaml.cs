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

namespace Numeros
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            const int NUMERO_FILAS = 3;
            const int NUMERO_COLUMNAS = 3;
            Grid grid = (Grid)this.Content;
            for (int i = 0; i < NUMERO_FILAS; i++)
            {
                for (int j = 0; j < NUMERO_COLUMNAS; j++)
                {
                    Button b = new Button();
                    grid.Children.Add(b);
                    Grid.SetRow(b, i + 1);
                    Grid.SetColumn(b, j);
                    b.Margin = new Thickness(5);
                    b.Click += NumeroButtonClick;
                    Viewbox viewbox = new Viewbox();
                    b.Content = viewbox;
                    TextBlock textBlock = new TextBlock();
                    textBlock.Text = $"{i * 3 + j + 1}";
                    viewbox.Child = textBlock;
                }
            }
        }

        private void NumeroButtonClick(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            Viewbox vb = (Viewbox)b.Content;
            TextBlock tb = (TextBlock)vb.Child;
            NumerosTextBlock.Text += tb.Text;
        }
    }
}
