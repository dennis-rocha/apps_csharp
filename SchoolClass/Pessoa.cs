namespace SchoolClass
{
    public abstract class Pessoa
    /*
    Classe abstrata que impede a instanciação direta desta classe,
    permitindo apenas a instanciação das classes filhas.*/
    {
        // Propriedades públicas de somente leitura
        public string Nome {get;}
        public int Idade {get;}

        // Construtor da classe Pessoa        
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}