using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_OO
{
    class Restaurant
    {
        private string _name;   // alakriipsuga nimetatakse privaatseid muutujaid
        private string _address;
        public Restaurant(string name, string address)
        {
            this._name = name;
            this._address = address;
        }
        public Receipt GetReceipt(Tab tab)
        {
            return new Receipt(_name, _address);
        }
    }
    class Tab
    {
        public IEnumerable<double> Entries { get; internal set; }
        public void Add(double price)
        {
            Entries.Add(price);
        }

    }
    class Receipt
    {
        private string _restaurantName;
        private string _restaurantAddress;
        private Tab _tab;

        public Receipt(string restaurantName, string restaurantAddress, Tab tab)
        {
            this._restaurantName = restaurantName;
            this._restaurantAddress = restaurantAddress;
            this._tab = tab;
        }
        public override string ToString()
        {
            var str = new StringBuilder();
            foreach (var entry in _tab.Entries)
            {
                str.AppendLine($"Price of food item: {entry}");
            }
            
            str.AppendLine($"SubTotal: €{_tab.Entries.Sum()}");
            str.AppendLine($"15% Gratuity: €{_tab.Entries} ");
            str.AppendLine($"Total: €{_tab.Entries} ");
            return str.ToString();
        }

    }
    class Program
    {
        public void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Restaurant restaraunt = new Restaurant("Taco Palenque", "1200 Main ST.");

            Tab tab = new Tab();

            tab.Add(7.99);
            tab.Add(6.55);
            tab.Add(2.345);

            Receipt receipt = restaraunt.GetReceipt(tab);

            Console.Write(receipt);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        
    }
}
