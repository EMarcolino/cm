using System;
using System.Collections.Generic;

#nullable disable

namespace senai_Roman_webAPI.Domains
{
    public partial class Situacao
    {
        public Situacao()
        {
            Projetos = new HashSet<Projeto>();
        }

        public int IdSituacao { get; set; }
        public string NomeSituacao { get; set; }

        public virtual ICollection<Projeto> Projetos { get; set; }
    }
}
