using BusinessPromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessPromotionEngine.Services
{
    public interface IBusinessPromotionEngineManager
    {
        /// <summary>
        ///  Get Final Price for List of Items
        /// </summary>
        /// <param name="itemOrder"></param>
        /// <returns></returns>
        int GetFinalPriceForItems(ItemOrder itemOrder);
    }
}
