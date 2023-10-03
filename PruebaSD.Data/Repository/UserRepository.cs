using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PruebaSD.Data.DataContext;
using PruebaSD.Models.Dtos;
using PruebaSD.Models.Entities;

namespace PruebaSD.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContextDB _dataContext;

        public UserRepository(DataContextDB dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<UsuarioDto>> GetAll()
        {
            List<UsuarioDto>? usuarios = new();
            try
            {
                usuarios = await _dataContext.Usuario
                    .Select(usuario => new UsuarioDto
                    {
                        Id = usuario.UsuId,
                        Nombre = $"{usuario.Nombre} {usuario.Apellido}",
                    }).ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return usuarios;
        }
    }
}
