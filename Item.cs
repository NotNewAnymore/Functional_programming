using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_programming
{
	internal class Item
	{
		string _name;
		int _stock;
		double _price;

		public Item(string name, int stock, double price)
		{
			Name = name;
			Stock = stock;
			Price = price;
		}

		public string Name { get => _name; set => _name = value; }
		public int Stock { get => _stock; set => _stock = value; }
		public double Price { get => _price; set => _price = value; }
	}
}
