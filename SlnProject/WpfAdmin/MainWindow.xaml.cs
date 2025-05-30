using System.Windows;
using WpfAdmin.Pages;

namespace WpfAdmin
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            NavPanel.Visibility = Visibility.Collapsed;
            MainFrame.Navigate(new LoginPage(this));
        }

        public void LoginGeslaagd()
        {
            NavPanel.Visibility = Visibility.Visible;

            // Na login navigeren we eerst naar een lege pagina of welkom pagina
            MainFrame.Content = null; // Of maak een welkomspagina als je wil
        }

        private void BtnPersonen_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PersoonBewerken());
        }

        private void BtnUitloggen_Click(object sender, RoutedEventArgs e)
        {
            NavPanel.Visibility = Visibility.Collapsed;
            MainFrame.Navigate(new LoginPage(this));
        }
    }
}
