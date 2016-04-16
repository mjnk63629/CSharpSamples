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
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            int age = Convert.ToInt32(textBoxAge.Text);
            int bornYear = Convert.ToInt32(textBoxBornYear.Text);
            string gender = comboBoxgender.Text;

            User newUser = new User();
            newUser.FirstName = firstName;
            newUser.LastName = lastName;
            newUser.Age = age;
            newUser.BornYear = bornYear;
            newUser.Gender = gender;

            string genderTest = comboBoxgender.Text;

            if (genderTest == "Male")
            {
                windowJavad.Background = Brushes.Blue;

            }
            else
            {
                windowJavad.Background = Brushes.Pink;
            }
        }
    }
}