using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tms.MysticShop.Model.Models;
using Tms.MysticShop.Web.Models;

namespace Tms.MysticShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<BillDetail, BillDetailViewModel>();
            Mapper.CreateMap<Bill, BillViewModel>();
            Mapper.CreateMap<Category, CategoryViewModel>();
            Mapper.CreateMap<Color, ColorViewModel>();
            Mapper.CreateMap<Image, ImageViewModel>();
            Mapper.CreateMap<ProductDetail, ProductDetailViewModel>();
            Mapper.CreateMap<Product, ProductViewModel>();
            Mapper.CreateMap<Size, SizeViewModel>();
            Mapper.CreateMap<UserRole, UserRoleViewModel>();
            Mapper.CreateMap<User, UserViewModel>();
        }
    }
}