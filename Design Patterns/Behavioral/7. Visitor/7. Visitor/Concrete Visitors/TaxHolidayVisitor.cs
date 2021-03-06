﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Visitor
{
	// Concrete Visitor Class
	public class TaxHolidayVisitor : Visitor
	{

		// This is created so that each item is sent to the
		// right version of visit() which is required by the
		// Visitor interface and defined below
		public TaxHolidayVisitor()
		{
		}


		// Calculates total price based on this being taxed
		// as a liquor item
		public double Visit(Liquor liquorItem)
		{
			Console.WriteLine("Liquor Item: Price with Tax");
			return liquorItem.GetPrice() * 1.10;
		}


		// Calculates total price based on this being taxed
		// as a tobacco item
		public double Visit(Tobacco tobaccoItem)
		{
			Console.WriteLine("Tobacco Item: Price with Tax");
			return (tobaccoItem.GetPrice() * 1.30);
			
		}


		// Calculates total price based on this being taxed
		// as a necessity item
		public double Visit(Necessity necessityItem)
		{
			Console.WriteLine("Necessity Item: Price with Tax");
			return necessityItem.GetPrice();
		}

	}
}
