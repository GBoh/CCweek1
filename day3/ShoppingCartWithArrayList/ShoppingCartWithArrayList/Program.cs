using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartWithArrayList
{

    public class ShoppingCart
    {
        ArrayList cart = new ArrayList();

        //public static int AddItem(string name, int id, decimal price)
        public static int AddItem(ShoppingCartItem item)
        {

            return item.Id;
        }

        public static void RemoveItem(int itemID)
        {

        }

        public static void ListItems(ArrayList cart)
        {
            foreach (var item in cart)
            {
                Console.WriteLine(item);
            }
        }

    }

    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var cart = new ArrayList();

            //ShoppingCart.AddItem("Hat", 1234, 2.99m);
            //ShoppingCart.AddItem("Cat", 4321, 100.00m);
            //ShoppingCart.AddItem("Bat", 9876, 5.00m);
            ShoppingCart.AddItem(ShoppingCartItem);

            Console.WriteLine("Your cart contains");
            //ShoppingCart.ListItems(cart);


            Console.ReadLine();
        }
    }
}
