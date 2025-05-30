using System.Windows;
using System.Windows.Controls;

namespace WpfAdmin.Pages
{
    public partial class PersoonBewerken : Page
    {
        public PersoonBewerken()
        {
            InitializeComponent();
        }

        private void BtnOpslaan_Click(object sender, RoutedEventArgs e)
        {
            Person persoon = new Person
            {
                Voornaam = VoornaamBox.Text,
                Achternaam = AchternaamBox.Text,
                Email = EmailBox.Text,
                Wachtwoord = WachtwoordBox.Password,
                Rol = (RolBox.SelectedItem as ComboBoxItem)?.Content.ToString()
            };

            // Nu tijdelijk MessageBox
            MessageBox.Show("Persoon opgeslagen:\n" +
                            $"{persoon.Voornaam} {persoon.Achternaam} ({persoon.Rol})");

            // Terug naar overzichtpagina (hier: PersonenOverzichtPage of leeg)
            // this.NavigationService.Navigate(new PersonenOverzichtPage());
            this.NavigationService.GoBack(); // Of iets anders
        }
    }

    // Dummy Person class als voorbeeld, vervang met jouw echte model
    public class Person
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Email { get; set; }
        public string Wachtwoord { get; set; }
        public string Rol { get; set; }
    }
}
