using PruebaSD.Data.Repository;
using PruebaSD.Models.Dtos;
using PruebaSD.Models.Entities;

namespace PruebaSD.Domain.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _usuarioRepository;

        public UserService(IUserRepository userRepository)
        {
            _usuarioRepository = userRepository;
        }

        public async Task<List<UsuarioDto>> GetAll()
        {
            return await _usuarioRepository.GetAll();
        }
    }
}
