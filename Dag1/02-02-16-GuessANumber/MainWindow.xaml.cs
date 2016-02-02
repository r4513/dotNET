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

namespace _02_02_16_GuessANumber
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random;
        private int targetNumber;
        private bool running;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Start();
        }

        private void onGuessButtonAction(object sender, RoutedEventArgs e)
        {
            int guessedNumber = (int)Int32.Parse(guessTextBox.Text);
            if (this.targetNumber == guessedNumber)
            {
                resultLabel.Content = "Correct!";
                this.targetNumber = random.Next(1, 101);
                guessButton.IsEnabled = false;
                tryAgainButton.IsEnabled = true;
                this.running = false;
            }
            else
            {
                if (this.targetNumber > guessedNumber)
                {
                    resultLabel.Content = "Too low! Try again!";
                }else if (this.targetNumber < guessedNumber)
                {
                    resultLabel.Content = "Too hight! Try again!";
                }
            }
            guessTextBox.Focus();
            guessTextBox.SelectAll();
        }

        public void Start()
        {
            this.random = new Random();
            this.targetNumber = random.Next(1, 101);
            guessButton.IsEnabled = true;
            tryAgainButton.IsEnabled = false;
            guessTextBox.Focus();
            guessTextBox.SelectAll();
            Console.WriteLine(this.targetNumber);
            running = true;
        }

        private void onTryAgainButtonAction(object sender, RoutedEventArgs e)
        {
            Start();
        }

        private void checkDigit(object sender, TextCompositionEventArgs e)
        {
            if (!System.Char.IsDigit(e.Text.ElementAt(e.Text.Length - 1)))
            {
                e.Handled = true;
            }

        }

        private void closingEvent(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(running == true)
            {
                MessageBoxResult result = MessageBox.Show("Sure you want to exit this awesome game?", "Stopping", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
