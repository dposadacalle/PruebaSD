using PruebaSD.Models.Dtos;
using PruebaSD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSD.Domain.Services
{
    public interface IUserService
    {
        Task<List<UsuarioDto>> GetAll();
    }
}
