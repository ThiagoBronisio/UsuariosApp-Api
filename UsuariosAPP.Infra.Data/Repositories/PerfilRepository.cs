using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosAPP.Domain.Entities;
using UsuariosAPP.Domain.Interfaces.Repositories;
using UsuariosAPP.Infra.Data.Contexts;

namespace UsuariosAPP.Infra.Data.Repositories
{
    public class PerfilRepository : IPerfilRepository
    {
        public Perfil? GetByNome(string nome)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Set<Perfil>()
                    .Where(p => p.Nome.Equals(nome))
                    .FirstOrDefault();
            }
        }
    }
}
