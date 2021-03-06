﻿using System;
using System.Collections.Generic;

namespace Nyous_Api_EFcore.Domains
{
    public partial class Categoria
    {
        public Categoria()
        {
            Evento = new HashSet<Evento>();
        }

        public int IdCategoria { get; set; }
        public string Titulo { get; set; }

        public virtual ICollection<Evento> Evento { get; set; }
    }
}
