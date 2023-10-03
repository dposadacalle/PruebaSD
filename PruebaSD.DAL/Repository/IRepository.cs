using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSD.Data.Repository
{
    public interface IRepository<TEntityModel> where TEntityModel : class
    {
        Task<TEntityModel> ObtenerUsuarios();
    }
}
