﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco.Usuarios
{
    public class Cliente
    {
        public string Nome { get; set; }

        public Cliente() {}
        public Cliente(string nome)
        {
            this.Nome = nome;
        }
    }
}
