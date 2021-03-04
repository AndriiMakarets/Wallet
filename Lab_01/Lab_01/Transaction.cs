using System;
using System.Collections.Generic;
using System.Text;
//using System.Drawing;

namespace Lab_01
{
    class Transaction
    {
        private static int InstanceCount;

        private int _id;
        private double _moneySum;
        private string _category;
        private string _description;
        private Currency _moneyCurrency;
        private DateTime _transactionTime;
        private Object _fileOfTransaction;

        //До транзакції додатково можна прикріплювати файли (зображення або текстові).
        //використати bitmap?
        ////  List<Image> imageList = new List<Image>();
        ////  imageList.Add(Bitmap.FromFile(YourFilePath));


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public double MoneySum
        {
            get { return _moneySum; }
            set { _moneySum = value; }
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public Currency MoneyCurrency
        {
            get { return _moneyCurrency; }
            set { _moneyCurrency = value; }
        }

        public DateTime TransactionTime
        {
            get { return _transactionTime; }
            set { _transactionTime = value; }
        }

        public Object FileOfTransaction
        {
            get { return _fileOfTransaction; }
            set { _fileOfTransaction = value; }
        }

        public Transaction(int id)
        {
            _id = id;
        }

        public Transaction(int id, double moneySum, string category, string description, Currency moneyCurrency, Object file)
        {
            _id = id;
            _moneySum = moneySum;
            _category = category;
            _description = description;
            _moneyCurrency = moneyCurrency;
            _fileOfTransaction = file;
        }

        public void Show()
        {
            Console.Write(" Category " + _category + " Sum: " + _moneySum + " Currency " + _moneyCurrency +
                " Time: " + _transactionTime + " Description " + _description);
        }
    }
}