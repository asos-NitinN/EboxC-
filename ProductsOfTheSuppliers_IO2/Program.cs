using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProductsOfTheSuppliers_IO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of assets");
            var n = Convert.ToInt32(Console.ReadLine());
            
            List<Asset> assets = new List<Asset>(n);

            Supplier[] suppliers = new Supplier[n];

            Console.WriteLine("Enter the asset details and supplier details");
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(',');
                assets = new List<Asset>()
                {
                    new Asset(input[0], input[1], Convert.ToDateTime(input[2]), Convert.ToDouble(input[3]))

                };

                suppliers[i] = new Supplier(input[4], input[5], assets);
                

            }

            var groupedList = suppliers.GroupBy(x => x.Name).Select(y => y.ToList()).ToList();

            using (StreamWriter sw = new StreamWriter("output.csv"))
            {
                var total = groupedList.Count;
                for (int i = 0; i < total; i++)
                {
                    var g = groupedList[i].Count;
                    if (g > 1)
                    {
                        sw.WriteLine("|" + groupedList[i][0].Name + "|" + groupedList[i][0].Address + "|");
                        for (int j = 0; j < g; j++)
                        {
                            sw.WriteLine(groupedList[i][g].AssetList[0].Name + "," + groupedList[i][g].AssetList[0].Serial + ","+ groupedList[i][g].AssetList[0].PurchaseDate +","+ groupedList[i][g].AssetList[0].Cost);
                        }
                        
                    }
                    else
                    {
                        sw.WriteLine("|" + groupedList[i][0].Name + "|" + groupedList[i][0].Address + "|");
                       
                       sw.WriteLine(groupedList[i][0].AssetList[0].Name + "," + groupedList[i][0].AssetList[0].Serial + "," + groupedList[i][0].AssetList[0].PurchaseDate + "," + groupedList[i][0].AssetList[0].Cost);
                        
                    }
                }
            }

        }
    }
}
