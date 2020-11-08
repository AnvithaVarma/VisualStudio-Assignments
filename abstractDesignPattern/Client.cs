using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abstractFactoryExample.abstractProducts;

namespace abstractFactoryExample
{
    class Client
    {
        private readonly Shirt _shirt;
        private readonly Trousers _trousers;

        public Client(clothesFactory factory)
        {
            _shirt = factory.CreateShirt();
            _trousers = factory.CreateTrousers();
        }

        public string DescribeYourClothes()
        {
            return ($"Today i dressed in: {_shirt.GetType().Name} and {_trousers.GetType().Name}");
        }

    }
}
