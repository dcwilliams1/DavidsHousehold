using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Household.Supplements.Domain.Model.Entity;
using Household.Supplements.Data.Repository;
using Household.Application.Service.Interface;
using Household.SharedKernel.EntityFramework;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace Household.Application.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class SupplementsController : ControllerBase
    {

        private readonly ILogger<SupplementsController> _logger;
        private readonly ISupplementService _supplementService;

        public SupplementsController(ISupplementService supplementService, ILogger<SupplementsController> logger)
        {
            _logger = logger;
            _supplementService = supplementService;
            var context = new FinanceDbContext("Server=(localdb)\\mssqllocaldb;Database=Finance;Trusted_Connection=True;MultipleActiveResultSets=true");
            var repo = new SupplementRepository(context);
        }

        [HttpGet]
        public List<SupplementPurchase> GetSupplementPurchases()
        {
            return _supplementService.GetSupplementPurchases();
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public IActionResult AddSupplementPurchases(SupplementPurchase purchase)
        {
            _supplementService.AddSupplementPurchase(purchase);
            return Ok();
        }
    }
}

//https://learn.microsoft.com/en-us/aspnet/core/web-api/action-return-types?view=aspnetcore-5.0
//https://learn.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-5.0