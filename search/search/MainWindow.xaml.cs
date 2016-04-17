using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace search
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
            Fruit fruit1=new Fruit();
            fruit1.FruitName = "Orange";
            fruit1.FruitColor = "Orange";
            fruit1.FruitSeason = "Winter";
            
            Fruit fruit2 = new Fruit();
            fruit2.FruitName = "Peach";
            fruit2.FruitColor = "Orange";
            fruit2.FruitSeason = "Summer";
            
            Fruit fruit3 = new Fruit();
            fruit3.FruitName = "Melon";
            fruit3.FruitColor = "Yello";
            fruit3.FruitSeason = "Spring";
            
            Fruit fruit4 = new Fruit();
            fruit4.FruitName = "WaterMelon";
            fruit4.FruitColor = "Green";
            fruit4.FruitSeason = "Summer";
            
            Fruit fruit5 = new Fruit();
            fruit5.FruitName = "Banana";
            fruit5.FruitColor = "Yello";
            fruit5.FruitSeason = "Summer";
            Statics.Fruits.Add(fruit1);
            Statics.Fruits.Add(fruit2);
            Statics.Fruits.Add(fruit3);
            Statics.Fruits.Add(fruit4);
            Statics.Fruits.Add(fruit5);

            foreach (Fruit fruit in Statics.Fruits)
            {
                string froutstr = string.Format("Fruit Name: {0},Fruit Color: {1},Fruit Season: {2}", fruit.FruitName,
                    fruit.FruitColor, fruit.FruitSeason);
                listViewFruits.Items.Add(froutstr);
            }
            {
                
            }


        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           listViewFruits.Items.Clear();
            
        }
    }
}
