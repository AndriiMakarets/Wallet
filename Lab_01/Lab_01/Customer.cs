using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_01
{
    class Customer
    {
        
        private int _id;
        private string _lastName;
        private string _firstName;
        private string _email;
        public List<Wallet> _wallets;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public Customer(int id, string fname, string ldesc, string email)
        {
            _wallets = new List<Wallet>();
            _id = id;
            _firstName = fname;
            _lastName = ldesc;
            _email = email;

        }
        public Customer(int id)
        {
            _id = id;
            _wallets = new List<Wallet>();
        }

        public void AddWallet(int id)
        {
            _wallets.Add(new Wallet(id,_id));
        }
    }



}
