using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comboBox
{

        class User
        {
            private string _firstName;
            private string _lastName;
            private int _age;
            private int _bornYear;
            private string _gender;

            public User()
            {

            }

            public User(string firstName, string lastName, int age, int bornYear, string gender)
            {

            }


            public string FirstName
            {
                get { return _firstName; }
                set { _firstName = value; }
            }

            public string LastName
            {
                get { return _lastName; }
                set { _lastName = value; }
            }

            public int Age
            {
                get { return _age; }
                set { _age = value; }
            }

            public int BornYear
            {
                get { return _bornYear; }
                set { _bornYear = value; }
            }

            public string Gender
            {
                get { return _gender; }
                set { _gender = value; }
            }
        }
    }

