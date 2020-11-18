using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary2
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAge" in both code and config file together.
	[ServiceContract]
	public interface IAge
	{
		[OperationContract]

		int calculateYears(int day, int month, int year);
	
	}
}
