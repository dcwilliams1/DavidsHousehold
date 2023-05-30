using AutoMapper;
using EFModel = Household.Data.EntityFramework.Model;
using DomainMode = Household.Domain.Model.Entities;

namespace Household.Application.Services
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
