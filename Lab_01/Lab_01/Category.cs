using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab_01
{
    public class Category
    {
        private static int InstanceCount;

        private int _id;
        private string _name;
        private string _description;
        private string _colore;
        private Object? _icon;


        public int ID
        {
            get { return _id; }
            set { _id = value; }
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
        public string Colore
        {
            get { return _colore; }
            set { _colore = value; }
        }
        public Object? Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }

        public Category(int id)
        {
            _id = id;
        }

        public Category(int id, string name, string desc, string col, Object ic)
        {
            _id = id;
            _name = name;
            _description = desc;
            _colore = col;
            _icon = ic;

        }


    }
}