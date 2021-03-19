using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    class Funcionarios
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salario { get; set; }

        public Funcionarios(int id, string name, double salario)
        {
            Id = id;
            Name = name;
            Salario = salario;
        }

    }
}
