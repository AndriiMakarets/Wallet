using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_01
{
    class Wallet
    {
        private static int InstanceCount;

        private int _id;
        private string _name;
        private double _initialBalance;
        private string _description;
        private Type _moneyCurrency;
        private int _customerId;
        private List<Transaction> _transactions;
        private double _currentBalance;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public double CurrentBalance
        {
            get { return _currentBalance; }
            set { _currentBalance = value; }
        }
        public double InitialBalance
        {
            get { return _initialBalance; }
            set { _initialBalance = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public Type MoneyCurrency
        {
            get { return _moneyCurrency; }
            set { _moneyCurrency = value; }
        }

        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        public Wallet(int id, int custId)
        {
            _id = id;
            _customerId = custId;
            _transactions = new List<Transaction>();
        }

        public Wallet(int id, string name, string desc, Type curr, int custId)
        {
            _id = id;
            _customerId = custId;
            _name = name;
            _description = desc;
            _moneyCurrency = curr;
            _transactions = new List<Transaction>();
        }

        public void AddTransaction(Transaction tr)
        {
            _transactions.Add(tr);
            _currentBalance += tr.MoneySum;
        }

        public void ShowTransactions(int from)
        {
            for (int i=from; i<from+10; i++)
            {
                _transactions[i].Show();
            }
        }

        public void ShowTransactions()
        {
            for (int i = 0; i <10; i++)
            {
                _transactions[i].Show();
            }
        }

        public void DeleteTransaction(int trId)
        {
           for(int i = 0; i < _transactions.Count; i++)
            {
                if (_transactions[i].Id == trId)
                    _transactions[i] = null;
            }
        }
    }
}
