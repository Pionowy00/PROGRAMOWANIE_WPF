
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
using System.Text.RegularExpressions; // Biblioteka do obsługi wyrażeń regularnych

namespace asdf
{
    /// <summary>
    /// Klasa obsługująca główne okno aplikacji.
    /// </summary>
    public partial class MainWindow : Window
    {
        // Zmienna przechowująca aktualną wartość licznika.
        // Początkowo licznik ma wartość 0.
        private int count = 0;

        // Konstruktor głównego okna aplikacji.
        public MainWindow()
        {
            // Inicjalizuje elementy interfejsu z pliku MainWindow.xaml.
            InitializeComponent();
        }

        // Metoda wywoływana po kliknięciu przycisku zwiększania licznika.
        private void IncrementBtn_Click(object sender, RoutedEventArgs e)
        {
            // Zwiększa wartość licznika o 1.
            count++;

            // Wyświetla aktualną wartość licznika w elemencie CounterBlock.
            count.ToString(); // Konwersja liczby na tekst
            CounterBlock.Text = count.ToString();
        }

        // Metoda wywoływana po kliknięciu przycisku zmniejszania licznika.
        private void DecrementBtn_Click(object sender, RoutedEventArgs e)
        {
            // Zmniejsza wartość licznika o 1.
            count--;

            // Aktualizuje tekst wyświetlany na ekranie.
            CounterBlock.Text = count.ToString();
        }

        // Metoda wywoływana po kliknięciu przycisku resetowania.
        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            // Ustawia wartość licznika na 0.
            count = 0;

            // Wyświetla wyzerowany licznik.
            CounterBlock.Text = count.ToString();
        }

        // Metoda sprawdzająca, czy wpisywany znak jest cyfrą.
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            // Wyrażenie regularne [^0-9]+ wykrywa znaki inne niż cyfry od 0 do 9.
            Regex regex = new Regex("[^0-9]+");

            // Jeśli wpisywany tekst zawiera niedozwolone znaki,
            // ustawienie e.Handled = true blokuje ich wprowadzenie.
            e.Handled = regex.IsMatch(e.Text);
        }

        // Metoda wywoływana po kliknięciu przycisku
        // zwiększania licznika o wartość podaną przez użytkownika.
        private void CustomIncrementBtn_Click(object sender, RoutedEventArgs e)
        {
            // Pobiera tekst z pola NumberTextBox i konwertuje go na liczbę całkowitą.
            // Następnie dodaje tę liczbę do aktualnej wartości licznika.
            count += int.Parse(NumberTextBox.Text);

            // Aktualizuje wyświetlaną wartość licznika.
            CounterBlock.Text = count.ToString();
        }

        // Metoda wywoływana po kliknięciu przycisku
        // zmniejszania licznika o wartość podaną przez użytkownika.
        private void CustomDecrementBtn_Click(object sender, RoutedEventArgs e)
        {
            // Pobiera liczbę z pola NumberTextBox i odejmuje ją od licznika.
            count -= int.Parse(NumberTextBox.Text);

            // Aktualizuje wyświetlaną wartość licznika.
            CounterBlock.Text = count.ToString();
        }
    }
}