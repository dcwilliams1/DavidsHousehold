using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EFModel = Household.SharedKernel.EntityFramework.Model;
using DomainModel = Household.Supplements.Domain.Model.Entity;

namespace Household.Supplements.Data.Repository
{
    public class MapperConfig
    {
        public static Mapper InitializeAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EFModel.SupplementPurchase, DomainModel.SupplementPurchase>();
            });

            var mapper = new Mapper(config);
            return mapper;
        }
    }
}
