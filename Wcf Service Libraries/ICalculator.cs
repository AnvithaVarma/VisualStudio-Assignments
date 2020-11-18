using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculator" in both code and config file together.
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        int sum(int num1, int num2);

        [OperationContract]
        int subtract(int num1, int num2);

        [OperationContract]
        int multiply(int num1, int num2);

        [OperationContract]
        int divide(int num1, int num2);
    }
}

[DataContract]
public class CompositeType
{
    bool boolvalue = true;
    String stringvalue = "Hello!";

    [DataMember]
    public bool Boolvalue
    {
        get { return boolvalue; }
        set { boolvalue = value; }

    }

    [DataMember]
    public string Stringvalue
    {
        get { return stringvalue; }
        set { stringvalue = value; }

    }
}
