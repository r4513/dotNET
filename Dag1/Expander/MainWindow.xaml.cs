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

namespace Expander
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

        private void onAddButtonAction(object sender, RoutedEventArgs e)
        {
            Service.list.Add(new Person
            {
                Cpr = "000000",
                FirstName = nameTextBox.Text,
                LastName = "",
                YearOfBirth = -1
            });
        }

        private void Start(object sender, RoutedEventArgs e)
        {
            lBoxPersons.ItemsSource = Service.list;
            lBoxPersons.DisplayMemberPath = "Cpr";
        }

        private void lBoxPersonsSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Person p = (Person)lBoxPersons.SelectedItem;
            nameTextBox.Text = p.FirstName;
        }

        private void onCloseBtnAction(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Sure you want to exit this awesome game?", "Stopping", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.No)
            {
                return;
            }

        }

        private void closingEvent(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Sure you want to exit this awesome game?", "Stopping", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
