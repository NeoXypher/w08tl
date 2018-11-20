using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w08tl
{
	class w08t9
	{
	}

	class Invoice
	{
		string partNumber, partDesc;
		int quantity;
		double price;

		public Invoice(string NewPartNumber, string NewPartDesc, int NewQuantity, double NewPrice)
		{

		}

		public string PartNumber
		{
			get { return partNumber; }
			set { partNumber = value; }
		}

		public string PartDesc
		{
			get { return partDesc; }
			set { partDesc = value; }
		}

		public int Quantity
		{
			get { return quantity;  }
			set
			{
				if (value > 0)
				{
					quantity = value;
				}
				else
					quantity = 0;
			}
		}

		public double Price
		{
			get { return price; }
			set { price = value; }
		}

		public double getInvoiceAmount()
		{
			return Quantity * Price;
		}
	}
}
