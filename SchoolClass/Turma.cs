namespace SchoolClass
{
    public class Turma
    {
        // Propriedades públicas para getter e privada para setter
        public List<Aluno> Alunos { get;}
        public Professor Professor { get; private set; }
        public string Nome { get; }


        // Construtores para turma
        public Turma(string nome)
        {
            Nome = nome;
            Alunos = new List<Aluno>();
        }

        public Turma(string nome, Professor professor)
        {
            Nome = nome;
            Professor = professor;
            Alunos = new List<Aluno>();
        }

        // Método para adicionar os alunos
        public void addAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }

        // Método para adicionar o professor
        public void addProfessor(Professor professor)
        {
            Professor = professor;
        }

        // Método para vizualizar a turma
        public void vizualizarTurma()
        {
            Console.WriteLine("Turma: " + Nome);
            Console.WriteLine("Nome do professor: " + Professor.Nome + "\n");
            Console.WriteLine("Nome - idade - nota");
            foreach (Aluno aluno in Alunos){
                Console.WriteLine($"{aluno.Nome} - {aluno.Idade} - {aluno.Nota}");
            }
        }
    }
}