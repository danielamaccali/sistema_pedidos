using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using exercEnum.Entities;

namespace exercEnum.Entities
{
    class OrderItem
    {
        double _price;
        int _quantity;
        Product _product;

        public OrderItem()
        {
        }
        public OrderItem(double price, int quantity, Product product)
        {
            _price = price;            
            _quantity = quantity;
            _product = product;
        }
       
        public int Getquantity()
        {
            return _quantity;
        }

        public int Setquantity()
        {
            return _quantity;
        }
        
        public double Getprice()
        {
            return _price;
        }

        public double Setprice()
        {
            return _price;
        }

        public Product GetProduct()
        {
            return _product;
        }

        public Product SetProduct()
        {
            return _product;
        }

        public double subTotal()
        {
            return _price * _quantity;
        }

        public override string ToString()
        {
            return $"{_product.Name}, {_product.Price}, Quantity: {_quantity}, Subtotal: {subTotal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
