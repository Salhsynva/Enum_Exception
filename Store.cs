using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Store
    {
        public Product[] Products = new Product[0];

        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }

        public Product[] RemoveProductByNo(int no)
        {
            Product[] newProducts = new Product[0];
            foreach (var pr in Products)
            {
                if (!(pr.No == no))
                {
                    Array.Resize(ref newProducts, newProducts.Length + 1);
                    newProducts[newProducts.Length - 1] = pr;
                }
            }
            Products = newProducts;
            return Products;
        }

        public Product[] FilterProductsByType(ProductType productType)
        {
            Product[] newProducts = new Product[0];
            foreach (var pr in Products)
            {
                if (pr.Type == productType)
                {
                    Array.Resize(ref newProducts, newProducts.Length + 1);
                    newProducts[newProducts.Length - 1] = pr;
                }
            }
            return newProducts;
        }

        public Product[] FilterProductsByName(string name)
        {
            Product[] newProducts = new Product[0];
            foreach (var pr in Products)
            {
                if (pr.Name.ToLower().Contains(name.ToLower()))
                {
                    Array.Resize(ref newProducts, newProducts.Length + 1);
                    newProducts[newProducts.Length - 1] = pr;
                }
            }
            return newProducts;
        }

    }
}
