using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsOfTheSuppliers_IO2
{
    class Supplier
    {
        public string _name;
        public string _address;
        public List<Asset> _assetList;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public List<Asset> AssetList
        {
            get { return _assetList; }
            set { _assetList = value; }
        }

        public Supplier(string name, string address, List<Asset> asset)
        {
            Name = name;
            Address = address;
            AssetList = asset;
        }
    }
}
