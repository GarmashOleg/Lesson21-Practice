﻿using System;
using System.Collections.Generic;

namespace Lesson21.Shop
{
    public class OnlineShop
    {
        private IList<Product> products = new List<Product>();

        public event EventHandler<GoodsInfoEventArgs> NewProductRecieved = delegate { };

        public delegate decimal MyDelegate(decimal i);
        
        public event MyDelegate TestEvent;

        public void GoodRecieving(Product product)
        {
            products.Add(product);
            NewProductRecieved(null, new GoodsInfoEventArgs() { Cost = product.Cost, ProductName = product.ProductName });
            TestEvent?.Invoke(product.Cost);
        }

    }
}