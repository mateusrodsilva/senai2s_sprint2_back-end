﻿using System;
using System.Collections.Generic;

#nullable disable

namespace senai.spmedicalgroup.webapi.Domains
{
    public partial class Clinica
    {
        public Clinica()
        {
            Medicos = new HashSet<Medico>();
        }

        public int IdClinica { get; set; }
        public string NomeClinica { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string EnderecoClinica { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }
    }
}
