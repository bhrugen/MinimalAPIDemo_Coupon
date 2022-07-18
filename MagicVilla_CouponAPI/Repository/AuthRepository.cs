using AutoMapper;
using MagicVilla_CouponAPI.Data;
using MagicVilla_CouponAPI.Models;
using MagicVilla_CouponAPI.Models.DTO;
using MagicVilla_CouponAPI.Repository.IRepository;

namespace MagicVilla_CouponAPI.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public AuthRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public bool IsUniqueUser(string username)
        {
            var user = _db.LocalUsers.FirstOrDefault(x => x.UserName == username);

            // return null if user not found
            if (user == null)
                return true;

            return false;
        }

        public Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDTO> Register(RegisterationRequestDTO requestDTO)
        {
            LocalUser userObj = new()
            {
                UserName = requestDTO.UserName,
                Password = requestDTO.Password,
                Name = requestDTO.Name,
                Role = "admin"
            };
            _db.LocalUsers.Add(userObj);
            _db.SaveChanges();
            userObj.Password = "";
            return _mapper.Map<UserDTO>(userObj);
        }
    }
}
