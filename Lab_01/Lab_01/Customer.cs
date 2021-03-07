﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_01
{
    class Customer
    {
        private Guid _guid;
        private string _lastName;
        private string _firstName;
        private string _email;
        private List<Wallet> _wallets;
        private List<UnchangeableWallet> _friendWallets;
        private List<Category> _categories;


        public Guid Guid
        {
            get { return _guid; }
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
        
        public Customer(Guid guid, string fname, string ldesc, string email)
        {
            _wallets = new List<Wallet>();
            _guid = guid;
            _firstName = fname;
            _lastName = ldesc;
            _email = email;

        }
        public Customer()
        {
            _guid = Guid.NewGuid();
            _wallets = new List<Wallet>();
        }
        private List<UnchangeableWallet> FriendWallets{get; set;}

        public void AddWallet()
        {
            _wallets.Add(new Wallet(_guid));
        }

        public void AddFriend(Customer fr, Wallet wallet)
        {
            fr.FriendWallets.Add(wallet);
        }

        public void CreateCategory()
        {
           string name, description, colore;
           name = Console.ReadLine();
           description = Console.ReadLine();
           colore = Console.ReadLine();
           _categories.Add(new Category(Guid.NewGuid(), name, description, colore));
        }

        public void AddCategoryToWallet(Wallet wallet Category category)
        {
         wallet.Categories.Add(category);
        }
    }
}
