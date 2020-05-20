using System.Collections.Generic;
using BusinessPromotionEngine.Models;

namespace BusinessPromotionEngine.Services
{
    public class BusinessPromotionEngineManager : IBusinessPromotionEngineManager
    {      
        public static readonly Dictionary<string, int> ItemRates = new Dictionary<string,int> { { "A", 50 }, { "B",30 }, { "C", 20 }, { "D", 15 } };
        /// <summary>
        /// Get Final Price for Items
        /// </summary>
        /// <param name="itemOrder"></param>
        /// <returns></returns>
        public int GetFinalPriceForItems(ItemOrder itemOrder)
        {
            int finalPrice = 0;
            if (itemOrder != null)
            {
                if(itemOrder.A >= 0 && itemOrder.B >= 0 && itemOrder.C >= 0 && itemOrder.D >= 0)
                  finalPrice = GetCostForItemA(itemOrder.A) + GetCostForItemB(itemOrder.B) + GetCostForCandD(itemOrder.C, itemOrder.D);               

            }
            return finalPrice;
        }
               

        private int GetCostForItemA(int orderCount)
        {
            int cost = 0;
            int divisor = orderCount / 3;
            int remaining = orderCount % 3;
            cost = (divisor * 130) + (remaining * ItemRates["A"]);
            return cost;
        }

        private int GetCostForItemB(int orderCount)
        {
            int cost = 0;
            int divisor = orderCount / 2;
            int remaining = orderCount % 2;
            cost = (divisor * 45 )+ (remaining * ItemRates["B"]);
            return cost;
        }

        private int GetCostForCandD(int orderCountC,int orderCountD)
        {
            int cost = 0;
            int totalOrderCount = orderCountC + orderCountD ;

            int divisor = totalOrderCount / 2;     

            cost =( divisor * 30) + ((orderCountC - divisor) * ItemRates["C"] + (orderCountD - divisor) * ItemRates["D"]);
            return cost;
        }
    }
}
