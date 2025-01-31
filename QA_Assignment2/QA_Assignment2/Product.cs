using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Assignment2
{
    public class Product
    {
        
        public int productId; 
        public double price; 
        public int stock; 
        public string name; 

        public Product(int productId, double price, int stock, string name)
        {
            this.productId = productId;
            this.price = price;
            this.stock = stock;
            this.name = name;
        }

        

        public string GetProductId(int productId)
        {

            if (productId <= 4)
            {
                return "Invalid";
            }
            if (productId >= 5 & productId <= 50000)
            {

                return "Valid";

            }
            if(productId > 50000) 
            {
                return "Invalid";
            }
            else
                return "Invalid";
        }

    }
}
