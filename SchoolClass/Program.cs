namespace SchoolClass
{
    class Program
    {
        static void Main(string[] args)
        /*
        Programa para realizar o gerenciamento de turma
        O sistema foi criado com o intuito de exercitar 
        os conceitos de programação orientada a objetos 
        em C#. 

        O sistema deve atender os seguintes requisitos:
        - O sistema deve cadastrar uma turma contendo 
          pelo menos um professor e três alunos.
        - O sistema deve usar herança.
        - O sistema deve usar polimorfismo. 
        - O sistema deve implementar construtores.
        - O sistema deve implementar getter e setter.
        */
        {
            // Cria a turma
            Turma turma = new Turma("Desenvolvimento de Sistemas");

            // Cria o Professor
            Professor professor = new Professor("Turano",37,2359);

            // Cria os alunos
            Aluno aluno1 = new Aluno("Fulano",16,10);
            Aluno aluno2 = new Aluno("Beltrano",22,9);
            Aluno aluno3 = new Aluno("Ciclano",19,7.5);

            // Realiza o cadastramento da turma
            turma.addProfessor(professor);
            turma.addAluno(aluno1);
            turma.addAluno(aluno2);
            turma.addAluno(aluno3);
            
            // Vizualiza a turma
            turma.vizualizarTurma();
        }
    }
}