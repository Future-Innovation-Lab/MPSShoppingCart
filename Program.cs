using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart online = new Cart();

            Item xbox = new Item();
            xbox.ItemName = "Xbox";
            xbox.ItemPrice = 3950.99M;
            online.AddItem(xbox);

            Item ps = new Item();
            ps.ItemName = "PS4";
            ps.ItemPrice = 5999.49M;
            online.AddItem(ps);

            string display = online.GetCartWithTotals();
            Console.WriteLine(display);
        }
    }
}
