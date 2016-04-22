using System;
using System.Collections.Generic;
using System.IO;
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

namespace eventTestProject
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

        private string filePath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "text.txt");

        private void Window_Loaded(object sender, RoutedEventArgs e)
                
                

        {
            if (!File.Exists(filePath))
            {
                System.IO.StreamWriter tw = File.CreateText(filePath);
                tw.Close();
                
            }
            else
            {
                textBoxReadText.Text = File.ReadAllText(filePath);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            editText editTextwin = new editText();
            editTextwin.Show();
            editTextwin.textAdded += EditTextwin_textAdded;
            

        }

        private void EditTextwin_textAdded(object sender, EventArgs e)
        {
            textBoxReadText.Text = File.ReadAllText(filePath);
        }
    }
}
