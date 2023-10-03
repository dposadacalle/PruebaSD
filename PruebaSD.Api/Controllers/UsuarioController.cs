using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaSD.Domain.Services;
using PruebaSD.Models.Dtos;
using PruebaSD.Models.Entities;

namespace PruebaSD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsuarioController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetAllUsers")]
        public  async Task<ActionResult<List<UsuarioDto>>> GetAll()
        {
            var usuarios = await _userService.GetAll();
            if(usuarios.Count == 0)
            {
                return NotFound();
            }
            return usuarios;
        }
    }
}
