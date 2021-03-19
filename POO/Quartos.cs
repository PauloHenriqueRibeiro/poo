﻿using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    class Quartos
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Quartos(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public override string ToString()
        {
            return Nome + " , " + Email;
        }

    }
}
