using AutoMapper;
using EFModel = Household.SharedKernel.EntityFramework.Model;
using DomainMode = Household.Supplements.Domain.Model.Entity;

namespace Household.Supplements.Data.Service
{
    static class AutoMapper
    {
        public static Mapper InitializeAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EFModel.SupplementPurchase, DomainMode.SupplementPurchase>();
            });

            return new Mapper(config);
        }
    }
}