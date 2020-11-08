using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abstractFactoryExample.abstractProducts;

namespace abstractFactoryExample
{
    abstract class clothesFactory
    {
        public abstract Shirt CreateShirt();

        public abstract Trousers CreateTrousers();
    }
}
