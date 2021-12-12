using AutoMapper;
using Roommate.DB.Entities;
using Roommate.Model.Product;
using Roommate.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roommate.API.Infrastructure
{
    public class MappingProfile:Profile
    {
        //Burada kısaca api tarafında oluşturulan Mapping Profile ile, db verisi ile view modelleri mapliyoruz.
        //Bir constructor açıp içinde mapping yapıyoruz.
        public MappingProfile()
        {
            CreateMap<UserViewModel, User>();
            CreateMap<User, UserViewModel>();

            CreateMap<User, LoginViewModel>();
            CreateMap<LoginViewModel, User>();

            CreateMap<Product, ProductViewModel>();
            CreateMap<ProductViewModel, Product>();

            CreateMap<Product, ListViewModel>();
            CreateMap<ListViewModel, Product>();

            CreateMap<Product, UpdateViewModel>();
            CreateMap<UpdateViewModel, Product>();
        }

    }
}
