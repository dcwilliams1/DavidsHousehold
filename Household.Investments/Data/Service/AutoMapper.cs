using AutoMapper;
using EFModel = Household.SharedKernel.EntityFramework.Model;
using DomainMode = Household.Investments.Domain.Model.Entity;

namespace Household.Investments.Data.Service
{
    static class AutoMapper
    {
        public static Mapper InitializeAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EFModel.tblAccount, DomainMode.Account>();
            });

            return new Mapper(config);
        }
    }
}