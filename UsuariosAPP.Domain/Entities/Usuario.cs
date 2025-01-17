﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosAPP.Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public DateTime? DataHoraCadastro { get; set; }

        public Guid PerfilId { get; set; }

        public Perfil?  Perfil { get; set; }
    }
}
