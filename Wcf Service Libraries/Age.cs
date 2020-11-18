using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary2
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Age" in both code and config file together.
	public class Age : IAge
	{
		public string GetData(int value)
		{
			return string.Format("You entered: {0}", value);
		}


		public int calculateYears(int day,int month,int year)
		{
			DateTime dt = new DateTime(year, month, day);
			int datetoyears = DateTime.Now.Subtract(dt).Days;
			datetoyears = datetoyears / 365;
			return datetoyears;
		}
	}
}
