﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson21.Shop
{
    public class Product
    {
        public string ProductName { get; set; }

        public decimal Cost { get; set; }

        public ProductCategory Category { get; set; }
    }
}
