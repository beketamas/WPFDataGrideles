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
using Microsoft.Win32;
using System.IO;


namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Nyelv> ujLista = new List<Nyelv>();
        public MainWindow()
        {
            InitializeComponent();

            //throw new NotImplementedException();
        }
        public List<string> elemek()
        {
            return Enum.GetNames(typeof(nyelvCsalad)).ToList();
        }

        private void tabControl_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbNyelvCsalad.ItemsSource = elemek();
            dataGrid.ItemsSource = ujLista;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string xy = cmbNyelvCsalad.SelectedItem.ToString();
            nyelvCsalad a;
            Enum.TryParse(xy, out a);

            ujLista.Add(new Nyelv(txtbNev.Text.ToString(), a, true, Convert.ToInt32(txtbMegjelenes.Text), false,
            Convert.ToInt32(slNepszeruseg.Value)));
            dataGrid.Items.Refresh();

        }
    }
}