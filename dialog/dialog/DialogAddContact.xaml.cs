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

        public event EventHandler ContactAdded;
        public event EventHandler<ContactArgs> ContactAddedCustom;

        public DialogAddContact()
        {
            InitializeComponent();
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

        private void ButtonAdd_OnClick(object sender, RoutedEventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string number = textBoxNumber.Text;


            Contact newContact=new Contact();
            newContact.FirsttName = firstName;
            newContact.LastName = lastName;
            newContact.Number = number;

            Statics.Contacts.Add(newContact);

            DialogResult = true;
        }

        private void ButtonCancel_OnClick(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void buttonAddWithEvent_Click(object sender, RoutedEventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string number = textBoxNumber.Text;


            Contact newContact = new Contact();
            newContact.FirsttName = firstName;
            newContact.LastName = lastName;
            newContact.Number = number;

            Statics.Contacts.Add(newContact);

            OnContactAdded();
        }

        private void buttonAddWithCustomEvent_Click(object sender, RoutedEventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string number = textBoxNumber.Text;


            Contact newContact = new Contact();
            newContact.FirsttName = firstName;
            newContact.LastName = lastName;
            newContact.Number = number;

            //Statics.Contacts.Add(newContact);

            //ContactArgs contactArgs=new ContactArgs(newContact);
            ContactArgs contactArgs=new ContactArgs();
            contactArgs.Contact = newContact;

            OnContactAddedCustom(contactArgs);
        }

        protected virtual void OnContactAdded()
        {
            ContactAdded?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnContactAddedCustom(ContactArgs e)
        {
            ContactAddedCustom?.Invoke(this, e);
        }
    }
}
