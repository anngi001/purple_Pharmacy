﻿using product.Domain;
using purple_Pharmacy.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace purple_Pharmacy.Services
{
    public static class ProductoService
    {
        public static List<Product> GetProducts()
        {
            var products = ApiHelper.Get<ResponseProducts>("/product/get/all");
            return products.products;
        }
    }
}
