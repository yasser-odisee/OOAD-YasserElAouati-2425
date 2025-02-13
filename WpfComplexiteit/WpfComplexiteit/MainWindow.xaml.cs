namespace WPFComplexiteit
{
    using System;
    using System.Windows;

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAnalyseer_Click(object sender, RoutedEventArgs e)
        {
            string input;

            do
            {
                input = txtInput.Text.Trim();

                if (string.IsNullOrEmpty(input))
                {
                    txtResult.Text = "Geen invoer, probeer opnieuw.";
                    return;
                }

                txtResult.Text = $"""
                    aantal karakters: {ComplexiteitBerekening.TelKarakters(input)}
                    aantal lettergrepen: {ComplexiteitBerekening.TelLettergrepen(input)}
                    complexiteit: {ComplexiteitBerekening.BerekenComplexiteit(input)}
                    """;

            } while (string.IsNullOrWhiteSpace(input));
        }
    }
}

namespace WPFComplexiteit
{
    public static class ComplexiteitBerekening
    {
        public static int TelKarakters(string woord) => woord.Length;

        public static int TelLettergrepen(string woord)
        {
            string klinkers = "aeiouyAEIOUY";
            int count = 0;
            bool vorigeWasKlinker = false;

            foreach (char c in woord)
            {
                if (klinkers.Contains(c))
                {
                    if (!vorigeWasKlinker) count++;
                    vorigeWasKlinker = true;
                }
                else vorigeWasKlinker = false;
            }
            return count > 0 ? count : 1;
        }

        public static double BerekenComplexiteit(string woord)
        {
            int karakters = TelKarakters(woord);
            int lettergrepen = TelLettergrepen(woord);
            return Math.Round((double)karakters / lettergrepen, 1);
        }
    }
}
