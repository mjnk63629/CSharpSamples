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

namespace WpfApplication1
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

        private void buttonShow_Click(object sender, RoutedEventArgs e)
        {
            string name = textBoxName.Text;
            MessageBox.Show(name + " Jan khosh omadi");

            string currentuser = textBoxName.Text;
            textBoxcurrentuser.Text = currentuser;
        }

        private void buttonLogOut_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Log Out Sucsessful");
            textBoxcurrentuser.Text = "Not Loged in";
        }
    }
}
