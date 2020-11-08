using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridgePattern
{
    class bridgeDesignPattern
    {
        public class webService : bridgeComponents
        {
            public void send(String messageType)
            {
                Console.WriteLine($"Sending {messageType} using Web service.");

            }
        }
        public class ThirdPartyUI : bridgeComponents
        { 
                public void send(String messageType)
                {
                    Console.WriteLine($"Sending {messageType} using third party UI service.");
                    
                }

            
        }
        public interface bridgeComponents
        {
            void send(String messageType);
        }
        public abstract class sendData
        {
            public bridgeComponents _bridgeComponents;
            public abstract void send();
        }
        public class sendEmail : sendData
        {
            public override void send()
            {
                _bridgeComponents.send("Email");
            }
        }
        public class sendSMS : sendData
        {
            public override void send()
            {
                _bridgeComponents.send("SMS");
            }
        }



        static void Main(string[] args)
        {
            sendData Data = new sendEmail();

            Data._bridgeComponents = new webService();
            Data.send();
            Data._bridgeComponents = new ThirdPartyUI();
            Data.send();


            sendData Data1 = new sendSMS();
            Data1._bridgeComponents = new webService();
            Data1.send();

            //sendData Data = new sendEmail();

            //sendData Data1 = new sendSMS();
            Data1._bridgeComponents = new ThirdPartyUI();
            Data1.send();
        }
    }
}
