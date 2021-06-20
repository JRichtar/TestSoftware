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

namespace TestSoftware
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Test.TestList();
            Test t = new Test();
            DataContext = t;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Tests.SelectedItem = 0;
        }

        private void Tests_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Test te = (Test)((sender as ListView).SelectedItem);
            DataContext = te;
        }

        private void AddTestButton_Click(object sender, RoutedEventArgs e)
        {
            TestEdit te = new TestEdit();
            te.ShowDialog();
        }





        private void CheckTest_Click(object sender, RoutedEventArgs e)
        {
            int counter = 0;

            if (Odpoved1A.IsChecked == true)
            {
                counter ++;
                Odpoved1A.Foreground = Brushes.Green;
            }
            else
            if (Odpoved1B.IsChecked == true)
            {
                Odpoved1B.Foreground = Brushes.Red;
                Odpoved1A.Foreground = Brushes.Green;
            }
            else
            if (Odpoved1C.IsChecked == true)
            {
                Odpoved1C.Foreground = Brushes.Red;
                Odpoved1A.Foreground = Brushes.Green;
            }
            else
            if (Odpoved1D.IsChecked == true)
            {
                Odpoved1D.Foreground = Brushes.Red;
                Odpoved1A.Foreground = Brushes.Green;
            }

            if (Odpoved2A.IsChecked == true)
            {
                Odpoved2B.Foreground = Brushes.Green;
                Odpoved2A.Foreground = Brushes.Red;
            }
            else
            if (Odpoved2B.IsChecked == true)
            {
                counter++;
                Odpoved2B.Foreground = Brushes.Green;
            }
            else
            if (Odpoved2C.IsChecked == true)
            {
                Odpoved2C.Foreground = Brushes.Red;
                Odpoved2B.Foreground = Brushes.Green;
            }
            else
            if (Odpoved2D.IsChecked == true)
            {
                Odpoved2D.Foreground = Brushes.Red;
                Odpoved2B.Foreground = Brushes.Green;
            }

            if (Odpoved3A.IsChecked == true)
            {
                Odpoved3A.Foreground = Brushes.Red;
                Odpoved3C.Foreground = Brushes.Green;
            }
            else
            if (Odpoved3B.IsChecked == true)
            {
                Odpoved3B.Foreground = Brushes.Red;
                Odpoved3C.Foreground = Brushes.Green;
            }
            else
            if (Odpoved3C.IsChecked == true)
            {
                counter++;
                Odpoved3C.Foreground = Brushes.Green;
            }
            else
            if (Odpoved3D.IsChecked == true)
            {
                Odpoved3D.Foreground = Brushes.Red;
                Odpoved3C.Foreground = Brushes.Green;
            }

            if (Odpoved4A.IsChecked == true)
            {
                Odpoved4D.Foreground = Brushes.Green;
                Odpoved4A.Foreground = Brushes.Red;
            }
            else
            if (Odpoved4B.IsChecked == true)
            {
                Odpoved4B.Foreground = Brushes.Red;
                Odpoved4D.Foreground = Brushes.Green;
            }
            else
            if (Odpoved4C.IsChecked == true)
            {
                Odpoved4C.Foreground = Brushes.Red;
                Odpoved4D.Foreground = Brushes.Green;
            }
            else
            if (Odpoved4D.IsChecked == true)
            {
                counter++;
                Odpoved4D.Foreground = Brushes.Green;
            }

            MessageBox.Show("Správné odpovědi: " + counter + "/4", "Výsledek testu");
        }

        private void Tests_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Test ti = (Test)((sender as ListView).SelectedItem);
            TestEdit te = new TestEdit();
            te.ShowDialog();
        }

        private void Odpoved1A_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RestartButton_Click(object sender, RoutedEventArgs e)
        {
            Odpoved1A.Foreground = Brushes.Black;
            Odpoved1B.Foreground = Brushes.Black;
            Odpoved1C.Foreground = Brushes.Black;
            Odpoved1D.Foreground = Brushes.Black;
            Odpoved2A.Foreground = Brushes.Black;
            Odpoved2B.Foreground = Brushes.Black;
            Odpoved2C.Foreground = Brushes.Black;
            Odpoved2D.Foreground = Brushes.Black;
            Odpoved3A.Foreground = Brushes.Black;
            Odpoved3B.Foreground = Brushes.Black;
            Odpoved3C.Foreground = Brushes.Black;
            Odpoved3D.Foreground = Brushes.Black;
            Odpoved4A.Foreground = Brushes.Black;
            Odpoved4B.Foreground = Brushes.Black;
            Odpoved4C.Foreground = Brushes.Black;
            Odpoved4D.Foreground = Brushes.Black;
        }
    }
}
