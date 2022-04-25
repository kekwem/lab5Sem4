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

namespace Sem4Lab5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_dodaj_Click(object sender, RoutedEventArgs e)
        {
            double cena;
            if (String.IsNullOrEmpty(imieTextBox.Text) || String.IsNullOrEmpty(nazwiskoTextBox.Text) ||
                String.IsNullOrEmpty(cenaTextBox.Text))
            {
                MessageBox.Show("Brak wprowadzacych danych!");
            }
            else if (!Double.TryParse(cenaTextBox.Text, out cena))
            {
                MessageBox.Show("Trzeba wpisac liczbe!");
            }
            else if (kalend_wyp.SelectedDate == null || kalend_zwrot.SelectedDate == null)
            {
                MessageBox.Show("Wybierz daty wypozyczenia!");
            }
            else
            {
                if (kalend_wyp.SelectedDate > kalend_zwrot.SelectedDate || kalend_wyp.SelectedDate < kalend_wyp.DisplayDate ||
                    kalend_zwrot.SelectedDate < kalend_wyp.DisplayDate)
                {
                    MessageBox.Show("Prawidlowo wybierz dayu!");
                }
                else
                {
                    DateTime dt1 =  kalend_wyp.SelectedDate.Value;
                    DateTime dt2 = kalend_zwrot.SelectedDate.Value;
                    Wypozyczenie wypozyczenie = new Wypozyczenie(imieTextBox.Text, nazwiskoTextBox.Text, cena,
                        kaskBox.IsChecked.Value, gogleBox.IsChecked.Value, kijkiBox.IsChecked.Value, ((dt2-dt1).Days)+1);
                    lista_osob.Items.Add(wypozyczenie);
                }
            }
            
        }

        private void button_usun_Click(object sender, RoutedEventArgs e)
        {
            if (lista_osob.Items.IsEmpty)
            {
                MessageBox.Show("Brak zapisow w liscie!");
            }
            else if (lista_osob.SelectedItems.Count==0)
            {
                MessageBox.Show("Wybierz zapis ktory chcesz usunac!");
            }
            else
            {
                lista_osob.Items.RemoveAt(lista_osob.SelectedIndex);
            }
        }
    }
}
