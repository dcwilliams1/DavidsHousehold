using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Household.Domain.Model.Entities;
using Household.Data.Services;

namespace Household.Application.Api.Controllers
{
    [Route("api/supplements")]
    public class SupplementsController : Controller
    {
        [HttpPost]
        public ActionResult AddSupplementPurchase(SupplementPurchase supplementPurchase)
        {
            var supplementService = new SupplementService();
            try
            {
                supplementService.AddSupplementPurchase(supplementPurchase);
                return Ok();
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
