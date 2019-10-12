using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Product
    {
        string name;
        double price;
        Weigth weigthProduct;
        Color colorProduct;
        //Constructor for Product
        public Product() {}
        public Product(string n, double p, double w, string c)
        {
            weigthProduct = new Weigth(w);
            colorProduct = new Color(c);
            name = n;
            price = p;
        }
        public string getColor()
        {
            return colorProduct.getC();
        }
        public double getWeigth()
        {
            return weigthProduct.getW();
        }
        public string getName()
        {
            return name;
        }
        public double getPrice()
        {
            return price;
        }
    }
    class Weigth : Product
    {
        private double pr_weigth;
        public Weigth(double w)
        {
            pr_weigth = w;
        }
        public double getW()
        {
            return weigth;
        }
        public double weigth
        {
            get { return pr_weigth; }
            set { pr_weigth = value < 0 ? -value : value; }
        }
    }
    class Color : Product
    {
        private string pr_color;
        public Color(string c)
        {
            pr_color = c;
        }
        public string getC()
        {
            return color;
        }
        public string color
        {
            get { return pr_color; }
            set { pr_color = value.Length > 10 ? value.Substring(0, 9) : value; }
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
            double total = 0;
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
            Product p1 = new Product("Cola", 15.9,1.5,"Black");
            Product p2 = new Product("Pepsi-Cola", 16,1.4,"Blue");
            Product p3 = new Product("Milk", 26,1,"White");
            Product p4 = new Product("Bread", 12.4,0.5,"Brown");
            Product p5 = new Product("Butter", 35,0.3,"Yellow");
            Cart cart = new Cart();
            cart.addProduct(p1);
            cart.addProduct(p2);
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