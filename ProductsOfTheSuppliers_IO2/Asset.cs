using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsOfTheSuppliers_IO2
{
    class Asset
    {
        public string _name;
        public string _serial;
        public DateTime _purchaseDate;
        public double _cost;

        public string Name
        {
            get { return _name;}
            set { _name = value; }
        }

        public string Serial
        {
            get { return _serial; }
            set { _serial = value; }
        }

        public DateTime PurchaseDate
        {
            get { return _purchaseDate; }
            set { _purchaseDate = value; }
        }

        public double Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public Asset(string name, string serial, DateTime puchaseDate, double cost)
        {
            Name = name;
            Serial = serial;
            PurchaseDate = puchaseDate;
            Cost = cost;
        }

    }
}
