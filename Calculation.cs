using System.Collections.Generic;
namespace Shopping
{
    public class Calculation
    {
        public static decimal CalculateSubTotal(List<Item> calculationItems)
        {
            decimal total = 0;
           foreach(Item item in calculationItems)
           {
               total += item.ItemPrice;
           }     

            return total;


           /* int index=0;
            while(index < calculationItems.Count)
            {
                Item item = calculationItems[index];
                //item.ItemPrice

                index++;
            }
*/
            /*
            for (int index=0;index < calculationItems.Count;index++)
            {
                Item item = calculationItems[index];
                item.ItemPrice
            }
            */



        }

        public static decimal CalculateWithVat(List<Item> calculationItems)
        {
            decimal subTotal = CalculateSubTotal(calculationItems);
            return subTotal * ((100 + Tax.VatAmount) / 100);
        }


    }
}