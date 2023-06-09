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
    public class MapperConfig : Profile
    {
        public static Mapper InitializeAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EFModel.Supplement, DomainModel.Supplement>()
                .AfterMap((src, dest) => dest.Strength = src.ProductSupplements.Where(ps => ps.SupplementId == src.Id).FirstOrDefault().StrengthMg)
                .AfterMap((src, dest) => dest.Dose = src.ProductSupplements.Where(ps => ps.SupplementId == src.Id).FirstOrDefault().Dose);

                cfg.CreateMap<EFModel.Company, DomainModel.Company>();

                cfg.CreateMap<EFModel.Product, DomainModel.Product>()
                .ForMember(dest => dest.ItemCount, act => act.MapFrom(src => src.Count))
                .ForMember(dest => dest.Supplements, act => act.MapFrom(src => src.ProductSupplements.Select(ps => ps.Supplement).ToList()));

                cfg.CreateMap<EFModel.SupplementPurchase, DomainModel.SupplementPurchase>()
                .ForMember(dest => dest.Date, act => act.MapFrom(src => src.PurchaseDate))
                .ForMember(dest => dest.Product, act => act.MapFrom(src => src.Product));
            });

            var mapper = new Mapper(config);
            return mapper;
        }
    }
}

//https://stackoverflow.com/questions/28407392/automapper-many-to-many-mapping