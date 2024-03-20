namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string opcao = MostrarMenu();

                if (OpcaoSaidaSelecionada(opcao))
                    break;

                else if(OpcaoInvalida(opcao))
                {
                    ExibirMensagemErro();
                    continue;
                }
                else
                {
                    RealizarCalculo(opcao);
                }                     
            }

            static string MostrarMenu()
            {
                Console.Clear();

                Console.WriteLine("Calculadora 2024\n");

                Console.WriteLine("Digite 1 para Adicionar");
                Console.WriteLine("Digite 2 para Subtrair");
                Console.WriteLine("Digite 3 para Multiplicar");
                Console.WriteLine("Digite 4 para Dividir");

                Console.WriteLine("Digite S para sair");

                string operacao = Console.ReadLine();

                return operacao;
            }

            static bool OpcaoSaidaSelecionada(string  opcao)
            {
                bool opcaoSaidaSelecionada = opcao == "S" || opcao == "s";

                return opcaoSaidaSelecionada;
            }

            static bool OpcaoInvalida(string opcao)
            {
                bool opcaoInvalida = opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "S" && opcao != "s";

                return opcaoInvalida;
            }

            static void ExibirMensagemErro()
            {
                Console.WriteLine("Operacao invalida");
                Console.ReadLine();
            }           

            static void RealizarCalculo(String opcao)
            {             

                double primeiroNumero = ObterNumeroDouble("Digite o primeiro número:");

                double segundoNumero = ObterNumeroDouble("Digite o segundo número:");

                double resultado = 0;

                switch (opcao)
                {
                    case "1":
                        resultado = primeiroNumero + segundoNumero;
                        break;

                    case "2":
                        resultado = primeiroNumero - segundoNumero;
                        break;

                    case "3":
                        resultado = primeiroNumero * segundoNumero;
                        break;

                    case "4":
                        while (segundoNumero == 0)
                        {
                            Console.WriteLine("Digite um numero maior que zero");
                            segundoNumero = Convert.ToDouble(Console.ReadLine());
                        }
                        resultado = primeiroNumero / segundoNumero;
                        break;
                }
                ExibirResultado(resultado);
            }

            static double ObterNumeroDouble(string texto)
            {
                Console.WriteLine(texto);
                double numeroDigitado = Convert.ToDouble(Console.ReadLine());

                return numeroDigitado;
            }

            static void ExibirResultado(double resultado)
            {
                Console.WriteLine("O resultado é: " + resultado);

                Console.ReadLine();
            }
        }
    }
}
