using PruebaSD.Data.DataContext;
using PruebaSD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSD.Data.SeedDB
{
    public class DataSeeder
    {
        private readonly DataContextDB _dataContextDB;

        public DataSeeder(DataContextDB dataContextDB)
        {
            _dataContextDB = dataContextDB;       
        }

        public void Seed()
        {
            if (!_dataContextDB.Usuario.Any())
            {
                List<Usuario> usuarios = new List<Usuario>()
                {
                    new Usuario()
                    {
                        Apellido="Posada",
                        Nombre = "Daniel"
                    },
                    new Usuario()
                    {
                        Apellido="Cardona",
                        Nombre = "Luisa"
                    },
                    new Usuario()
                    {
                        Apellido="Garces",
                        Nombre = "Maria"
                    },
                    new Usuario()
                    {
                        Apellido="Vanessa",
                        Nombre = "ruiz"
                    },
                    new Usuario()
                    {
                        Apellido="Zuluaga",
                        Nombre = "Jesus albeiro"
                    },
                };

                _dataContextDB.Usuario.AddRange(usuarios);
                _dataContextDB.SaveChanges();
            }
        }
    }
}
