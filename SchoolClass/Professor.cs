using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolClass
{
    public class Professor : Pessoa
    {

        // Propriedade pública com getter e privado com setter
        public double Salario { get; private set; }
    
        // Construtor
        public Professor(string nome, int idade, double salario) : base(nome, idade)
        {
            SetSalario(salario);
        }  

        public void SetSalario(double salario)
        {
            if ( salario >= 0)
            {
                Salario = salario;
            } 
            else 
            {
                Salario = 0; // Poderia gerar um erro aqui
            }
        }
    }
}