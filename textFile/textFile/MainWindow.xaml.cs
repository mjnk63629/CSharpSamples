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

namespace textFile
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string info = textBoxInfo.Text;

            string filePath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "textFile.txt");


            if (!File.Exists(filePath))
            {
                StreamWriter tw= File.CreateText(filePath);
                //TextWriter tw = new StreamWriter(filePath);
                tw.WriteLine(info);
                tw.Close();
                MessageBox.Show("Text Box Created And Your Text sucessfuly written");
            }
            else
            {
                TextWriter tw = new StreamWriter(filePath,true);
                tw.WriteLine(info);
                tw.Close();
                MessageBox.Show("Your Text was written in an Existing file successfuly");
            }



            
        }
    }
}
