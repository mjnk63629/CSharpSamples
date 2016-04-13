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

namespace Cars
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
            User user1=new User();
            user1.FirstName = "Javad";
            user1.LastName = "Najafi";
            user1.Age = 31;
            user1.UserName = "mjnk";
            user1.Password = "12345";

            Statics.Users.Add(user1);

            User user2=new User("mhdr","22222","Mahmood","Ramzani",30);
            Statics.Users.Add(user2);

            Car car1=new Car();
            car1.CarNo = "1234H76";
            car1.Model = "BMW";
            car1.Year = 2009;

            Car car2=new Car();
            car2.CarNo = "765G12";
            car2.Model = "Peykan";
            car2.Year = 1976;

            Statics.Cars.Add(car1);
            Statics.Cars.Add(car2);

        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            string userName = textBoxUserName.Text;
            string password = passwordBoxPassword.Password;

            bool showEmptyInfo = false;

            if (userName == "")
            {
                showEmptyInfo = true;
            }

            if (password == "")
            {
                showEmptyInfo = true;
            }

            if (showEmptyInfo)
            {
                MessageBox.Show("Username or Password is empty","Error");
                return;
            }

            foreach (User user in Statics.Users)
            {
                if (user.UserName == userName && user.Password == password)
                {
                    //labelWelcome.Content = "Welcome " + user.FirstName + " " + user.LastName;
                    labelWelcome.Content = string.Format("Welcome {0} {1}", user.FirstName, user.LastName);

                    foreach (Car car in Statics.Cars)
                    {
                        string carStr = string.Format("Car Number: {0}, Model: {1}, Year: {2}", car.CarNo, car.Model,
                            car.Year);

                        listViewCars.Items.Add(carStr);
                    }

                    GridAddNewCar.Visibility=Visibility.Visible;
                }
            }
        }

        private void buttonSubmit_Click(object sender, RoutedEventArgs e)
        {
            string model = textBoxModel.Text;
            string carNumber = textBoxCarNumber.Text;
            int year = Convert.ToInt32(textBoxYear.Text);


            Car newCar=new Car();
            newCar.Model = model;
            newCar.CarNo = carNumber;
            newCar.Year = year;

            Statics.Cars.Add(newCar);

            textBoxModel.Text = "";
            textBoxCarNumber.Text = "";
            textBoxYear.Text = "";

            MessageBox.Show("New Car Added");

            string carStr = string.Format("Car Number: {0}, Model: {1}, Year: {2}", newCar.CarNo, newCar.Model,
                            newCar.Year);

            //listViewCars.Items.Clear();
            listViewCars.Items.Add(carStr);
        }
    }
}
