using System;
using System.Collections.Generic;
using System.Text;

namespace davaleba8
{
    internal class Student
    {
		private string _name;

		public string Name
		{
			get { return _name; }
			set
			{
                if (string.IsNullOrWhiteSpace(value))
                { 
                   throw new ArgumentException("saxeli araa sheyvanili");
                }
				  _name = value; 
			}
		}

        private string _surname;

        public string Surname
        {
            get { return _surname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("gvari araa sheyvanili");
                }
                _surname = value;
            }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if  (value < 16 || value > 100)
                {
                    throw new ArgumentException("asaki araa sheyvanili");
                }
                _age = value;
            }
        }

        private string _gmail;

        public string Gmail
        {
            get { return _gmail; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.Contains("@"))
                {
                    throw new ArgumentException("gmail araa sheyvanili");
                }
                _gmail = value;
            }
        }


        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length != 9)
                {
                    throw new ArgumentException("nomeri araa sheyvanili");
                }
                _phone = value;
            }
        }

        private int _course;

        public int Course
        {
            get { return _course; }
            set
            {
                if (value < 1 || value > 4)
                {
                    throw new ArgumentException("course araa sheyvanili");
                }
                _course = value;
            }
        }

        private string _city;

        public string City
        {
            get { return _city; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("qalaqi araa sheyvanili");
                }
                _city = value;
            }
        }
        private string _address;

        public string Address
        {
            get { return _address; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("misamarti araa sheyvanili");
                }
                _address = value;
            }
        }

        private string _country;

        public string Country
        {
            get { return _country; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("qveyana araa sheyvanili");
                }
                _country = value;
            }
        }

        private string _specialty;

        public string Specialty
        {
            get { return _specialty; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("specialty araa sheyvanili");
                }
                _specialty = value;
            }
        }

    }
}
