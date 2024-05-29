namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        /*
            App para operações básicas de calculadora.
            Estou usando um exemplo bem simples apenas 
            para praticar os conceitos básicos da linguagem,
            como: variáveis, funções e classes. 

            Contexto do App:
            Crie uma calculadora que faça as operações básicas de
            somar, subtrair, multiplicar e dividir.
            - O sistema deve conter um menu para as operações;
            - O sistema deve sempre perguntar dois valores de entarda;
            - Após realizar o calculo, o sistema deve apresentar o resultado;
            - Ao final da operação o sistema deve voltar ao menu;
            - O sistema deve informar se o usuário digitou alguma opção inválida 
              e deve retornar ao menu; 
        */
        {
            // Gera variaveis e entra num loop para não sair do Menu
            bool continua = true;
            decimal numero1, numero2;
            Console.WriteLine("Bem vindo ao nosso App de Calculadora básica");
            while (continua)
            {
                Console.WriteLine("---- Menu  ----");
                Console.WriteLine("[1] - Somar");
                Console.WriteLine("[2] - Subtrair");
                Console.WriteLine("[3] - Multiplicar");
                Console.WriteLine("[4] - Dividir");
                Console.WriteLine("[5] - Sair do App");
                Console.WriteLine("Selecione a sua opção: ");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    ObterNumero(out numero1, out numero2);
                    Calculadora math = new Calculadora(numero1, numero2);
                    math.Somar();
                }
                else if (opcao == "2")
                {
                    ObterNumero(out numero1, out numero2);
                    Calculadora math = new Calculadora(numero1, numero2);
                    math.Subtrair();
                }
                else if (opcao == "3")
                {
                    ObterNumero(out numero1, out numero2);
                    Calculadora math = new Calculadora(numero1, numero2);
                    math.Multiplicar();
                }
                else if (opcao == "4")
                {
                    ObterNumero(out numero1, out numero2);
                    Calculadora math = new Calculadora(numero1, numero2);
                    math.Dividir();
                }
                else if (opcao == "5")
                {
                    Console.WriteLine("Saindo do App, Até breve!");
                    continua = false;
                }
                else
                {
                    Console.WriteLine("Insira uma opção válida!");
                }

            }
        }
        static void ObterNumero(out decimal n1, out decimal n2)
        /*
        Esse método serve para ler dois numeros de entrada e 
        deve permanecer num loop até o usuário digitar o numero
        válido*/
        {
            bool read_numero;
            do
            {
                Console.WriteLine("Digite o primeiro numero: ");
                string numero1 = Console.ReadLine();

                // converte a string para decimal 
                if (decimal.TryParse(numero1, out n1))
                {
                    read_numero = false;
                }
                else
                {
                    Console.WriteLine("Digite um valor válido e tente novamente!");
                    read_numero = true;
                }

            } while (read_numero);

            do
            {
                Console.WriteLine("Digite o segundo numero: ");
                string numero2 = Console.ReadLine();

                // converte a string para decimal 
                if (decimal.TryParse(numero2, out n2))
                {
                    read_numero = false;
                }
                else
                {
                    Console.WriteLine("Digite um valor válido e tente novamente!");
                    read_numero = true;
                }

            } while (read_numero);
        }
    }
}