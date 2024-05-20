using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosAPP.Domain.Entities;

namespace UsuariosAPP.Domain.Interfaces.Services
{
    public interface IUsuarioDomainService
    {
        //Método para realização da conta do úsuario
        void CriarConta(Usuario usuario);

        //Método para realizar a autenticação da conta do úsuario
        Usuario? Autenticar(string email, string senha);
    }
}
