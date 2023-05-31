using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Household.Supplements.Domain.Model.Entity;
using Household.Supplements.Data.Repository;
using Household.Application.Service.Interface;
using Household.SharedKernel.EntityFramework;
using Microsoft.Extensions.Logging;

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
    }
}