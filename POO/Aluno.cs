using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace POO
{
    class Aluno
    {
        public string nome;
        public double nota1, nota2, nota3;

        public double SomarNotas()
        {
            return  nota1 + nota2 + nota3;

        }
        
        public bool Aprovado()
        {
            if(SomarNotas() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - SomarNotas();
            }
        }
    }
}
