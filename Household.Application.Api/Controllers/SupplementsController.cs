using Microsoft.AspNetCore.Mvc;
using Household.Domain.Model.Entities;
using Household.Domain.Model.DataInterface;
using Household.Data.Services;
using Household.Data.EntityFramework.Repositories;

namespace Household.Application.Api.Controllers
{
    [ApiController]
    [Route("api")]
    public class SupplementsController : ControllerBase
    {

        private readonly ILogger<SupplementsController> _logger;
        private readonly ISupplementData _supplementService;

        public SupplementsController(ISupplementData supplementService, ILogger<SupplementsController> logger)
        {
            _logger = logger;
            _supplementService = supplementService;
            var context = new FinanceDbContext();
            var repo = new SupplementRepository(context);
        }

        [HttpGet(Name = "GetSupplementPurchases")]
        [Route("/supplementPurchases")]
        public List<SupplementPurchase> GetSupplementPurchases()
        {
            return _supplementService.GetSupplementPurchases();
        }
    }
}