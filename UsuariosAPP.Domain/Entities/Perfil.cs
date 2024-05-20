

namespace UsuariosAPP.Domain.Entities
{
    public class Perfil
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }

        #region Relacionamentos
        
        public List<Usuario> Usuarios { get; set; }

        #endregion
    }
}
