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

namespace dialog
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
        Contact contact1= new Contact();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Contact contact1 = new Contact();
            contact1.FirsttName = "Mohamad Javad";
            contact1.LastName = "najafi";
            contact1.Number = "09111355643";

            Contact contact2 = new Contact();
            contact2.FirsttName = "Mahmood";
            contact2.LastName = "Ramzani";
            contact2.Number = "09113333007";

            Statics.Contacts.Add(contact1);
            Statics.Contacts.Add(contact2);

            foreach (Contact contact in Statics.Contacts)
            {
                string contactList = string.Format("First Name: {0},Last Name: {1},Number: {2}", contact.FirsttName,
                    contact.LastName, contact.Number);
                listViewContacts.Items.Add(contactList);
            }
        }

        private void buttonAddNewContact_Click(object sender, RoutedEventArgs e)
        {
            DialogAddContact winAddContact = new DialogAddContact();

            winAddContact.ContactAdded += WinAddContact_ContactAdded;


            //winAddContact.ContactAdded -= WinAddContact_ContactAdded;

           winAddContact.ContactAddedCustom += WinAddContact_ContactAddedCustom;

            //winAddContact.Show();
            winAddContact.ShowDialog();

            if (winAddContact.DialogResult == true)
            {
                // new contact added
                // we should refresh the listView

                listViewContacts.Items.Clear();

                foreach (Contact contact in Statics.Contacts)
                {
                    string contactList = string.Format("First Name: {0},Last Name: {1},Number: {2}", contact.FirsttName,
                        contact.LastName, contact.Number);
                    listViewContacts.Items.Add(contactList);
                }
            }
          
        }

        private void WinAddContact_ContactAddedCustom(object sender, ContactArgs e)
        {
            // first we should add new contact to database ==> Static.Contact
            // then referesh the listView Items

            Contact newContact = e.Contact;
            Statics.Contacts.Add(newContact);

            listViewContacts.Items.Clear();

            foreach (Contact contact in Statics.Contacts)
            {
                string contactList = string.Format("First Name: {0},Last Name: {1},Number: {2}", contact.FirsttName,
                    contact.LastName, contact.Number);
                listViewContacts.Items.Add(contactList);
            }
        }

        private void WinAddContact_ContactAdded(object sender, EventArgs e)
        {
            // we just need to refresh the listView Items

            listViewContacts.Items.Clear();

            foreach (Contact contact in Statics.Contacts)
            {
                string contactList = string.Format("First Name: {0},Last Name: {1},Number: {2}", contact.FirsttName,
                    contact.LastName, contact.Number);
                listViewContacts.Items.Add(contactList);
            }
        }
    }
}
