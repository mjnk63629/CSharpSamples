using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
using System.IO;

namespace eventTestProject
{
    /// <summary>
    /// Interaction logic for editText.xaml
    /// </summary>
    public partial class editText : Window
    {
        public editText()
        {
            InitializeComponent();
        }
        
        public event EventHandler textAdded;

        

        protected virtual void OnTextAdded()
        {
            textAdded?.Invoke(this, EventArgs.Empty);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string textBoxContent = textBoxEditText.Text;
            string filePath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "text.txt");
            TextWriter tw = new StreamWriter(filePath,true);
            tw.WriteLine(textBoxContent);
            tw.Close();
            OnTextAdded();
            this.Close();
        }
    }
}
