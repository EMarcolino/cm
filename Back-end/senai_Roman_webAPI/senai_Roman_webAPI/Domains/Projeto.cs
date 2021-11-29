using System;
using System.Collections.Generic;

#nullable disable

namespace senai_Roman_webAPI.Domains
{
    public partial class Projeto
    {
        public int IdProjeto { get; set; }
        public int? IdTema { get; set; }
        public int? IdSituacao { get; set; }
        public string NomeProjeto { get; set; }
        public string DescricaoProjeto { get; set; }

        public virtual Situacao IdSituacaoNavigation { get; set; }
        public virtual Tema IdTemaNavigation { get; set; }
    }
}
