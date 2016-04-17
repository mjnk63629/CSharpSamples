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
<<<<<<< HEAD
            int age = Convert.ToInt32(textBoxAge.Text);
            int bornYear = Convert.ToInt32(textBoxBornYear.Text);
=======
            int age=0;
            int bornYear = 0;
            try
            {
                age = Convert.ToInt32(textBoxAge.Text);
            }
            catch (FormatException ex)
            {
                parseAge = true;
            }

            try
            {
                bornYear = Convert.ToInt32(textBoxBornYear.Text);
            }
            catch (FormatException ex)
            {
                parseYear = true;
            }


>>>>>>> 4d47f546c4f542bf0a98d73becba92744111943e
            
            //string gender = comboBoxgender.Text;

            string gender = comboBoxgender.SelectedItem.ToString();


            if (parseAge && parseYear)
            {
                MessageBox.Show("Hardo");
                return;
            }
            else if (parseYear)
            {
                MessageBox.Show("Year");
                return;
            }
            else if (parseAge)
            {
                MessageBox.Show("Age");
                return;
            }

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
        }
    }
}