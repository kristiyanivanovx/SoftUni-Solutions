﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Peripherals
{
	class Monitor : Peripheral
	{
		public Monitor(int id, string manufacturer, string model, decimal price, double overallPerformance, string connectionType)
			: base(id, manufacturer, model, price, overallPerformance, connectionType)
		{

		}
	}
}
