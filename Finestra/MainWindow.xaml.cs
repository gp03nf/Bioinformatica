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

namespace Finestra
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
        private void txtfile2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtfile1.Text != "" && txtfile2.Text != "")
            {
                btnesegui.IsEnabled = true;
            }
            if (txtfile1.Text == "" || txtfile2.Text == "")
            {
                btnesegui.IsEnabled = false;
            }
        }

        private void txtfile1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtfile1.Text != "" && txtfile2.Text != "" && cmbscelta.SelectedIndex != -1)
            {
                btnesegui.IsEnabled = true;
            }
            if (txtfile1.Text == "" || txtfile2.Text == "" || cmbscelta.SelectedIndex == -1)
            {
                btnesegui.IsEnabled = false;
            }
        }

        private void btnesegui_Click(object sender, RoutedEventArgs e)
        {
            txtrisultato.Text = "";
            if(cmbscelta.SelectedItem == lunghezza)
            {
                txtrisultato.Text = BioinformaticaMetodi.Lunghezza(txtfile1.Text) + "\n" + BioinformaticaMetodi.Lunghezza(txtfile2.Text);
            }
            else if (cmbscelta.SelectedItem == errore)
            {
                txtrisultato.Text = BioinformaticaMetodi.PosizioneErrore(txtfile1.Text, txtfile2.Text).ToString();
            }
            else if (cmbscelta.SelectedItem == identico)
            {
                txtrisultato.Text = BioinformaticaMetodi.DNAidentico(txtfile1.Text, txtfile2.Text);
            }
            else if (cmbscelta.SelectedItem == diversi)
            {
                txtrisultato.Text = BioinformaticaMetodi.CaratteriDiversi(txtfile1.Text, txtfile2.Text).ToString();
            }
        }
    }
}
