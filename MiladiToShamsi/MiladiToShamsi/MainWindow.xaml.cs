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
using System.Globalization;
using System.Security.Cryptography.X509Certificates;


namespace MiladiToShamsi
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
        

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            //miladiToShamsi
            GridMIladiToShamsi.Visibility = Visibility.Visible;
            GridShamsiToMIladi.Visibility = Visibility.Hidden;


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GridMIladiToShamsi.Visibility = Visibility.Hidden;
            GridShamsiToMIladi.Visibility = Visibility.Hidden;
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            //shamsiToMiladi
            GridMIladiToShamsi.Visibility = Visibility.Hidden;
            GridShamsiToMIladi.Visibility = Visibility.Visible;
        }
        
        private void buttonMilToSha_Click(object sender, RoutedEventArgs e)
        {
            bool parsYear = false;
            bool parsMonth = false;
            bool parsDay = false;

            Date getDate = new Date();
            getDate.Year = 0;
            getDate.Month = 0;
            getDate.Day = 0;
            try
            {
                getDate.Year = Convert.ToInt32(textBoxMilYear.Text);
            }
            catch (FormatException)
            {
                parsYear = true;
            }
            try
            {
                getDate.Month = Convert.ToInt32(textBoxMilMonth.Text);
            }
            catch (FormatException)
            {
                parsMonth = true;
            }
            try
            {
                getDate.Day = Convert.ToInt32(textBoxMilDay.Text);
            }
            catch (FormatException)
            {
                parsDay = true;
            }
            if (parsYear && parsMonth && parsDay)
            {
                textBoxMilYear.BorderBrush = Brushes.Red;
                textBoxMilMonth.BorderBrush = Brushes.Red;
                textBoxMilDay.BorderBrush = Brushes.Red;
                MessageBox.Show("لطفا تاریخ را به صورت صحیح (عددی) وارد نمائید.", "Error");
                return;
            }
            if (parsYear && parsMonth)
            {
                textBoxMilYear.BorderBrush = Brushes.Red;
                textBoxMilMonth.BorderBrush = Brushes.Red;
                textBoxMilDay.BorderBrush = Brushes.Gray;
                MessageBox.Show("لطفا سال و ماه را به صورت صحیح (عددی) وارد نمائید.", "Error");
                return;
            }
            if (parsYear && parsDay)
            {
                textBoxMilYear.BorderBrush = Brushes.Red;
                textBoxMilMonth.BorderBrush = Brushes.Gray;
                textBoxMilDay.BorderBrush = Brushes.Red;
                MessageBox.Show("لطفا سال و روز را به صورت صحیح (عددی) وارد نمائید.", "Error");
                return;
            }
            if (parsMonth && parsDay)
            {
                textBoxMilYear.BorderBrush = Brushes.Gray;
                textBoxMilMonth.BorderBrush = Brushes.Red;
                textBoxMilDay.BorderBrush = Brushes.Red;
                MessageBox.Show("لطفا ماه و روز را به صورت صحیح (عددی) وارد نمائید.", "Error");
                return;
            }

            else if (parsYear)
            {
                textBoxMilYear.BorderBrush = Brushes.Red;
                textBoxMilMonth.BorderBrush = Brushes.Gray;
                textBoxMilDay.BorderBrush = Brushes.Gray;
                MessageBox.Show("لطفا سال را به صورت صحیح (عددی) وارد نمائید.", "Error");
                return;
            }
            else if (parsMonth)
            {
                textBoxMilYear.BorderBrush = Brushes.Gray;
                textBoxMilMonth.BorderBrush = Brushes.Red;
                textBoxMilDay.BorderBrush = Brushes.Gray;
                MessageBox.Show("لطفا ماه را به صورت صحیح (عددی) وارد نمائید.", "Error");
                return;
            }
            else if (parsDay)
            {
                textBoxMilYear.BorderBrush = Brushes.Gray;
                textBoxMilMonth.BorderBrush = Brushes.Gray;
                textBoxMilDay.BorderBrush = Brushes.Red;
                MessageBox.Show("لطفا روز را به صورت صحیح (عددی) وارد نمائید.", "Error");
                return;
            }
            if (getDate.Year < 1000)
            {
                textBoxMilYear.BorderBrush = Brushes.Red;
                textBoxMilMonth.BorderBrush = Brushes.Gray;
                textBoxMilDay.BorderBrush = Brushes.Gray;
                MessageBox.Show("لطفا سال را بصورت یک عدد چهار رقمی وارد کنید", "Error");
                return;
            }
            textBoxMilYear.BorderBrush = Brushes.Gray;
            textBoxMilMonth.BorderBrush = Brushes.Gray;
            textBoxMilDay.BorderBrush = Brushes.Gray;
            DateTime date = new DateTime(getDate.Year,getDate.Month,getDate.Day);
            PersianCalendar pc = new PersianCalendar();
            textBoxToShamsi.Text =
                (string.Format("{0}/{1}/{2}", pc.GetYear(date), pc.GetMonth(date),
                    pc.GetDayOfMonth(date)));
            }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            bool parsYear = false;
            bool parsMonth = false;
            bool parsDay = false;
            
            Date getDate = new Date();
            getDate.Year = 0;
            getDate.Month = 0;
            getDate.Day = 0;
            try
            {
                getDate.Year = Convert.ToInt32(textBoxShaYear.Text);
            }
            catch (FormatException)
            {
                parsYear = true;
            }
            try
            {
                getDate.Month = Convert.ToInt32(textBoxShaMonth.Text);
            }
            catch (FormatException)
            {
                parsMonth = true;
            }
            try
            {
                getDate.Day = Convert.ToInt32(textBoxShaDay.Text);
            }
            catch (FormatException)
            {
                parsDay = true;
            }
            if (parsYear && parsMonth && parsDay)
            {
                textBoxShaYear.BorderBrush = Brushes.Red;
                textBoxShaMonth.BorderBrush = Brushes.Red;
                textBoxShaDay.BorderBrush = Brushes.Red;
                MessageBox.Show("لطفا تاریخ را به صورت صحیح (عددی) وارد نمائید.", "Error");
                return;
            }
            if (parsYear && parsMonth)
            {
                textBoxShaYear.BorderBrush = Brushes.Red;
                textBoxShaMonth.BorderBrush = Brushes.Red;
                textBoxShaDay.BorderBrush = Brushes.Gray;
                MessageBox.Show("لطفا سال و ماه را به صورت صحیح (عددی) وارد نمائید.", "Error");
                return;
            }
            if (parsYear && parsDay)
            {
                textBoxShaYear.BorderBrush = Brushes.Red;
                textBoxShaMonth.BorderBrush = Brushes.Gray;
                textBoxShaDay.BorderBrush = Brushes.Red;
                MessageBox.Show("لطفا سال و روز را به صورت صحیح (عددی) وارد نمائید.", "Error");
                return;
            }
            if (parsMonth && parsDay)
            {
                textBoxShaYear.BorderBrush = Brushes.Gray;
                textBoxShaMonth.BorderBrush = Brushes.Red;
                textBoxShaDay.BorderBrush = Brushes.Red;
                MessageBox.Show("لطفا ماه و روز را به صورت صحیح (عددی) وارد نمائید.", "Error");
                return;
            }

            else if (parsYear)
            {
                textBoxShaYear.BorderBrush = Brushes.Red;
                textBoxShaMonth.BorderBrush = Brushes.Gray;
                textBoxShaDay.BorderBrush = Brushes.Gray;
                MessageBox.Show("لطفا سال را به صورت صحیح (عددی) وارد نمائید.", "Error");
                return;
            }
            else if (parsMonth)
            {
                textBoxShaYear.BorderBrush = Brushes.Gray;
                textBoxShaMonth.BorderBrush = Brushes.Red;
                textBoxShaDay.BorderBrush = Brushes.Gray;
                MessageBox.Show("لطفا ماه را به صورت صحیح (عددی) وارد نمائید.", "Error");
                return;
            }
            else if (parsDay)
            {
                textBoxShaYear.BorderBrush = Brushes.Gray;
                textBoxShaMonth.BorderBrush = Brushes.Gray;
                textBoxShaDay.BorderBrush = Brushes.Red;
                MessageBox.Show("لطفا روز را به صورت صحیح (عددی) وارد نمائید.", "Error");
                return;
            }
            if (getDate.Year < 1000)
            {
                textBoxShaYear.BorderBrush = Brushes.Red;
                textBoxShaMonth.BorderBrush = Brushes.Gray;
                textBoxShaDay.BorderBrush = Brushes.Gray;
                MessageBox.Show("لطفا سال را بصورت یک عدد چهار رقمی وارد کنید", "Error");
                return;
           }
            textBoxShaYear.BorderBrush = Brushes.Gray;
            textBoxShaMonth.BorderBrush = Brushes.Gray;
            textBoxShaDay.BorderBrush = Brushes.Gray;
            PersianCalendar pc = new PersianCalendar();
            if (pc.IsLeapYear(getDate.Year) == false && getDate.Month ==12 && getDate.Day > 29)
            {
                textBoxShaYear.BorderBrush = Brushes.Gray;
                textBoxShaMonth.BorderBrush = Brushes.Gray;
                textBoxShaDay.BorderBrush = Brushes.Red;
                MessageBox.Show("در سالهای غیر کبیسه روزهای ماه اسفند نمی تواند بیشتر از 29 روز باشد", "Error");
                return;
            }
            DateTime date = new DateTime(getDate.Year,getDate.Month,getDate.Day, pc);
            textBoxToMiladi.Text =
                (string.Format("{0}/{1}/{2}", date.Year, date.Month,
                    date.Day));
            

        }
    }
}
