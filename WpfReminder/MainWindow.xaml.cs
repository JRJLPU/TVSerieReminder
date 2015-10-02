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

namespace WpfReminder
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

        private void SerieKnap_Click(object sender, RoutedEventArgs e)
        {
            WpfReference.Service1Client client = new WpfReference.Service1Client();

            List<KeyValuePair<string, int>> Allseries = client.GetAllSeries().ToList();
            Listbox.ItemsSource = Allseries;
        }

        private void AirtimeKnap_Click(object sender, RoutedEventArgs e)
        {
            WpfReference.Service1Client client = new WpfReference.Service1Client();
            var remaining = client.Timer(EpisodeNavn.Text, SerieNavn.Text);
            AirtimeResult.Text = remaining;            
        }

    }
}
