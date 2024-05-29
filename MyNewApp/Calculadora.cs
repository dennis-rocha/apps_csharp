namespace MyNewApp
{
    public class Calculadora
    /*
    Classe básica para as operações de adição, subtração, multiplicação e divisão.
    Criei a classe com construtor para exercitar essa ação.
    */
    {
        private decimal n1;
        private decimal n2;

        public Calculadora(decimal n1, decimal n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public void Somar() 
        {
            Console.WriteLine("O resultado da adição é: " + (n1 + n2));
        }

        public void Subtrair() 
        {
            Console.WriteLine("O resultado da subtração é: " + (n1-n2));
        }

        public void Multiplicar() 
        {
            Console.WriteLine("O resultado da multiplicação é: " + (n1*n2));
        }

        public void Dividir() 
        {
            Console.WriteLine("O resultado da divisão é: " + (n1/n2));
        }
    }
}