using AutoMapper;
using MagicVilla_CouponAPI.Models;
using MagicVilla_CouponAPI.Models.DTO;

namespace MagicVilla_CouponAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Coupon, CouponCreateDTO>().ReverseMap();
            CreateMap<Coupon, CouponUpdateDTO>().ReverseMap();
            CreateMap<Coupon, CouponDTO>().ReverseMap();
            CreateMap<LocalUser, UserDTO>().ReverseMap();
            CreateMap<ApplicationUser, UserDTO>().ReverseMap();
        }
    }
}
