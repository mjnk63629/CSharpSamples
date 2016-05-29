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

namespace binding_ComboBox_To_List
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Items item1=new Items();
            item1.Name = "hashem";
            Statics.Items.Add(item1);
            Items item2=new Items();
            item2.Name = "ghasem";
            Statics.Items.Add(item2);
            Items item3=new Items();
            item3.Name = "jafar";
            Statics.Items.Add(item3);
            Items item4=new Items();
            item4.Name = "mahmood";
            Statics.Items.Add(item4);

            foreach (Items items in Statics.Items)
            {
                string ItemStr = string.Format("Name:{0}", items.Name);

                listView.Items.Add(ItemStr);
            }
            comboBox.ItemsSource = listView.Items;


        }

    }
}
