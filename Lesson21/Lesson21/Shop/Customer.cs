using System;
using System.Collections.Generic;

namespace Lesson21.Shop
{
    public class Customer
    {
        public string Name { get; set; }

        public void GotNewGoods(object sender, GoodsInfoEventArgs goodInfo)
        {
            Console.WriteLine($"The product was recieved: {goodInfo.ProductName}; cost {goodInfo.Cost} by {Name}");
        }

        public void GoodsProcessing(object sender, GoodsInfoEventArgs goodInfo)
        {
            Console.WriteLine($"Hi {Name} from second handler!!");
        }

        
    }
}
