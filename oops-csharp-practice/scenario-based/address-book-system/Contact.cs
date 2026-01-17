using System;

namespace address_book_system
{
    // UC-1 Encapsulated Contact Class
    public class Contact
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private string zip;
        private string phoneNumber;
        private string email;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        // UC-7 Duplicate Check (Person Name)
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Contact))
                return false;

            Contact other = (Contact)obj;

            return this.FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase)
                && this.LastName.Equals(other.LastName, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return "Name: " + FirstName + " " + LastName +
                   "\nAddress: " + Address +
                   "\nCity: " + City +
                   "\nState: " + State +
                   "\nZip: " + Zip +
                   "\nPhone: " + PhoneNumber +
                   "\nEmail: " + Email;
        }
    }
}
