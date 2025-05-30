using System.Windows;
using System.Windows.Controls;

namespace WpfAdmin.Pages
{
    public partial class LoginPage : Page
    {
        private readonly MainWindow _mainWindow;

        public LoginPage(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string gebruiker = txtGebruikersnaam.Text;
            string wachtwoord = txtWachtwoord.Password;

            if (gebruiker == "admin" && wachtwoord == "admin")
            {
                _mainWindow.LoginGeslaagd();
            }
            else
            {
                MessageBox.Show("Onjuiste gebruikersnaam of wachtwoord.", "Fout", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
