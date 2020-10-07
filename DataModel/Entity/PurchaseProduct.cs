﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookShoppingApp.DataModel.Entity
{
    class PurchaseProduct
    {
        private int id;
        private Product product;
        private int quantity;

        public PurchaseProduct()
        {
        }
        public PurchaseProduct(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }

        public int Id { get => id; set => id = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public Product Product { get => product; set => product = value; }

        public override string ToString()
        {
            return product.ToString() +
                String.Format("{0,-15} | {1,-10}", "Quantity: ", Quantity + "\n") +
                "---\n";

        }
    }
}
