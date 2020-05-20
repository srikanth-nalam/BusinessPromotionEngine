using System;
using BusinessPromotionEngine.Models;
using BusinessPromotionEngine.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BusinessPromotionEngine.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class BusinessPromotionEngineController : ControllerBase
    {
        private readonly ILogger<BusinessPromotionEngineController> _logger;
        private readonly IBusinessPromotionEngineManager _businessPromotionManager;


        public BusinessPromotionEngineController(IBusinessPromotionEngineManager businessPromotionManager,ILogger<BusinessPromotionEngineController> logger)
        {
            _logger = logger;
            _businessPromotionManager = businessPromotionManager;
        }

        [HttpPost]
        public ActionResult GetFinalPriceForItems([FromBody] ItemOrder itemOrders)
        {
            try
            {
                _logger.LogInformation("GetFinalPriceForItems() execution is initiated..");
                if (itemOrders != null)
                {
                    var response = _businessPromotionManager.GetFinalPriceForItems(itemOrders);
                    _logger.LogInformation("GetFinalPriceForItems() execution is completed..");
                    return Ok(response);
                }
                else
                {
                    _logger.LogInformation("GetFinalPriceForItems() execution is completed..");
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                _logger.LogInformation("GetFinalPriceForItems() execution throwed an exception..");
                return StatusCode(500,ex.Message);
            }
        }
    
        

        
    }
}
