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
using Metodi;

namespace Schermata
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

        private void btnEsegui_Click(object sender, RoutedEventArgs e)
        {
            if (combobox.SelectedIndex == 0)
            {
                int lunghezza1 = BioinformaticaMetodi.Lunghezza(file1txt.Text);
                int lunghezza2 = BioinformaticaMetodi.Lunghezza(file2txt.Text);
                risultato.Content = $"{lunghezza1}\n{lunghezza2}";
            }
        }
    }
}
