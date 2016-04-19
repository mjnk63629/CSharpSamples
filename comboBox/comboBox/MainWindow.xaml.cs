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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;

namespace comboBox
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


        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            comboBoxgender.Items.Add("Male");
            comboBoxgender.Items.Add("Female");
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            bool parseAge = false;
            bool parseYear = false;

            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            int age=0;
            int bornYear = 0;
            try
            {
                age = Convert.ToInt32(textBoxAge.Text);
            }
            catch (FormatException )
            {
                parseAge = true;
            }

            try
            {
                bornYear = Convert.ToInt32(textBoxBornYear.Text);
            }
            catch (FormatException )
            {
                parseYear = true;
            }
            
            string gender = comboBoxgender.SelectedItem.ToString();
            if (parseAge && parseYear)
            {
                textBoxBornYear.BorderBrush=Brushes.Red;
                textBoxAge.BorderBrush = Brushes.Red;
                imageAgeError.Visibility = Visibility.Visible;
                imageYearError.Visibility = Visibility.Visible;
                imageYearError.Source = new BitmapImage(new Uri("pack://application:,,/Resources/1.png"));
                imageAgeError.Source = new BitmapImage(new Uri("pack://application:,,/Resources/1.png"));
                MessageBox.Show("Please Inter Valid Age And Born Year","ERROR");
                return;
            }
            else if (parseYear)
            {
                textBoxBornYear.BorderBrush = Brushes.Red;
                imageYearError.Visibility = Visibility.Visible;
                imageYearError.Visibility = Visibility.Visible;
                imageYearError.Source = new BitmapImage(new Uri("pack://application:,,/Resources/1.png"));
                textBoxAge.BorderBrush = Brushes.Gray;
                imageAgeError.Visibility = Visibility.Hidden;
                MessageBox.Show("Please Inter Valid Born Year","ERROR");
                return;
            }
            else if (parseAge)
            {
                textBoxAge.BorderBrush = Brushes.Red;
                imageAgeError.Visibility = Visibility.Visible;
                imageAgeError.Source = new BitmapImage(new Uri("pack://application:,,/Resources/1.png"));
                textBoxBornYear.BorderBrush = Brushes.Gray;
                imageYearError.Visibility = Visibility.Hidden;
                MessageBox.Show("Please Inter Valid Age","ERROR");
                return;
            }
            textBoxBornYear.BorderBrush = Brushes.Gray;
            textBoxAge.BorderBrush = Brushes.Gray;
            imageAgeError.Visibility = Visibility.Hidden;
            imageYearError.Visibility = Visibility.Hidden;

            User newUser = new User();
            newUser.FirstName = firstName;
            newUser.LastName = lastName;
            newUser.Age = age;
            newUser.BornYear = bornYear;
            newUser.Gender = gender;

            
            if (gender == "Male")
            {
                windowJavad.Background = Brushes.Blue;

            }
            else if (gender=="Female")
            {
              
           windowJavad.Background = Brushes.Pink;
            }
            MessageBox.Show("sucsecfull", "suscec");
            textBoxBornYear.Clear();
            textBoxAge.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            comboBoxgender.SelectedIndex = 0;
            windowJavad.Background = Brushes.White;
        }
    }
}