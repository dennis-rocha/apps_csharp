namespace SchoolClass
{
    public class Aluno : Pessoa
    {
        // Propriedade pública com getter e privado com setter
        public double Nota { get; private set; }
        
        // Construtor
        public Aluno(string nome, int idade, double nota) : base(nome, idade)
        {
            SetNota(nota);
        }

        public void SetNota(double nota)
        {
            if ( nota >= 0 & nota <= 10 )
            {
                Nota = nota;
            } 
            else 
            {
                Nota = 0; // Poderia gerar um erro aqui
            }
        }
    }
}