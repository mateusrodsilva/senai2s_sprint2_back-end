﻿using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webapi.Domains
{
    public partial class Classe
    {
        public Classe()
        {
            Personagems = new HashSet<Personagem>();
        }

        public int IdClasse { get; set; }
        public string Classe1 { get; set; }

        public virtual ICollection<Personagem> Personagems { get; set; }
    }
}
