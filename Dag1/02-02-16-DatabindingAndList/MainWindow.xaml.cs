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

namespace _02_02_16_DatabindingAndList
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
                Cpr = "12995",
                FirstName = "Adam",
                LastName = "Andersen",
                YearOfBirth = 2011
            });
        }

        private void onDeleteFirstButtonAction(object sender, RoutedEventArgs e)
        {
            Person p = (Person)lBoxPersons.SelectedItem;
            p.FirstName = "";
        }

        private void onDeleteLastButtonAction(object sender, RoutedEventArgs e)
        {
            Person p = (Person)lBoxPersons.SelectedItem;
            p.LastName = "";
        }

        private void Start(object sender, RoutedEventArgs e)
        {
            lBoxPersons.ItemsSource = Service.list;
            lBoxPersons.DisplayMemberPath = "Cpr";
        }

        private void lBoxPersonsSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Person p = (Person) lBoxPersons.SelectedItem;
            tBoxFirstName.Text = p.FirstName;
            tBoxLastName.Text = p.LastName;
            tBoxYear.Text = "" + p.YearOfBirth;
        }
    }
}
