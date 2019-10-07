using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Product
    {
        protected string name, color;
        protected int price;
        protected double weigth;
        public Product(string name, int price, string color,double weigth)
        {
            this.name = name;
            this.price = price;
            this.weigth = weigth;
            this.color = color;
        }
        public string getName()
        {
            return name;
        }
        public int getPrice()
        {
            return price;
        }
        public string getColor()
        {
            return color;
        }
        public double getWeigth()
        {
            return weigth;
        }
    }
    class Cart
    {
        Product[] products = new Product[10];
        public void addProduct(Product product)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] == null)
                {
                    products[i] = product;
                    break;
                }
            }
        }
        public void removeProduct(string name)
        {
            for(int i = 0; i < products.Length; i++)
            {
                if (products[i].getName() == name)
                {
                    products[i] = null;
                    break;
                }
            }
        }
        public void showCart()
        {
            Console.WriteLine("CART:");
            int total = 0;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] != null)
                {
                    Console.WriteLine("\t" + products[i].getName() + " : " + products[i].getPrice() + "\tcolor:" + products[i].getColor() + "\tweigth:" + products[i].getWeigth());
                    total += products[i].getPrice();
                }
            }
            Console.WriteLine("CART TOTAL: " + total);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("Coca-Cola", 15, "Black",1.5);
            Product p2 = new Product("Pepsi-Cola", 16,"Grey",1.5);
            Product p3 = new Product("Milk", 26,"White", 1);
            Product p4 = new Product("Bread", 12,"Brown",0.5);
            Product p5 = new Product("Butter", 35,"Yellow",0.2);
            Cart cart = new Cart();
            cart.addProduct(p1);
            cart.addProduct(p3);
            cart.addProduct(p4);
            cart.addProduct(p5);
            cart.showCart();
            Console.WriteLine("Enter the name of the product you want to remove ");
            cart.removeProduct(Console.ReadLine());
            cart.showCart();
            Console.ReadKey();
        }
    }
}