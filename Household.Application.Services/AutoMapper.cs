using AutoMapper;
using EFModel = Household.SharedKernel.EntityFramework.Model;
using DomainModel = Household.SharedKernel.Domain.Model.Entity;
using Household.Supplements.Domain.Model.Entity;

namespace Household.Application.Services
{
    static class AutoMapper
    {
        public static Mapper InitializeAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EFModel.SupplementPurchase, SupplementPurchase>();
            });

            return new Mapper(config);
        }
    }
}
