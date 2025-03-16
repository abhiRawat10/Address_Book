using System;

namespace AddressBookSystem
{

    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }


        public Contact(string firstName, string lastName, string address, string city, string state, string zip, string phone, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;
        }

        public override bool Equals(object obj)
        {
            if (obj is Contact other)
            {
                return FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase) &&
                       LastName.Equals(other.LastName, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName.ToLower(), LastName.ToLower());
        }
    }

}