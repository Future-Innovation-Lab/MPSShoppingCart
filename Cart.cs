using System.Collections.Generic;
using System.Text;

namespace Shopping
{
 public class Cart
 {
     private List<Item> Items;

    public Cart()
    {
        Items = new List<Item>();
    }

    public void AddItem(Item item)
    {
        Items.Add(item);
    }

     public string GetCartWithTotals()
     {
         StringBuilder builder = new StringBuilder();

         decimal subTotal = Calculation.CalculateSubTotal(Items);
         decimal subTotalWithVat = Calculation.CalculateWithVat(Items);

         foreach(Item item in Items)  
         {
             builder.AppendLine(item.ItemName + " " + item.ItemPrice.ToString("N2"));
         } 

             builder.AppendLine("Sub Total:   " + subTotal.ToString("N2"));
             builder.AppendLine("With VAT:   " + subTotalWithVat.ToString("N2"));

         return builder.ToString();
     }
 }

}