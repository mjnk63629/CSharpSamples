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
using System.Windows.Shapes;

namespace dialog
{
    /// <summary>
    /// Interaction logic for DialogAddContact.xaml
    /// </summary>
    public partial class DialogAddContact : Window
    {
        public DialogAddContact()
        {
            InitializeComponent();
           

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        public string firstName
        {
            get { return textBoxFirstName.Text; }
        }

        public string lastName
        {
            get { return textBoxLastName.Text; }
        }

        public string number
        {
            get { return textBoxNumber.Text; }
        }
    }
}
