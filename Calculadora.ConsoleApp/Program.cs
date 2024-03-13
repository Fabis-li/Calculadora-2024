namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Calculadora 2024");

                Console.WriteLine("Digite 1 para Adicionar");
                Console.WriteLine("Digite 2 para Subtrair");
                Console.WriteLine("Digite 3 para Multiplicar");
                Console.WriteLine("Digite 4 para Dividir");

                Console.WriteLine("Digite S para sair");
                
                string operacao = Console.ReadLine();

                if (operacao == "S")
                    break;

                Console.WriteLine("Digite o primeiro número");

                string primeiroNumeroString = "";

                primeiroNumeroString = Console.ReadLine();

                int primeiroNumero = Convert.ToInt32(primeiroNumeroString);                

                Console.WriteLine("Digite o segundo número");

                string segundoNumeroString = Console.ReadLine();

                int segundoNumero = Convert.ToInt32(segundoNumeroString);

                int resultado = 0;

                if(operacao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                }

                else if (operacao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                }

                else if (operacao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                }

                else if (operacao == "4")
                {
                    if (segundoNumero == 0)
                    {
                       while (segundoNumero == 0)
                        {
                            Console.WriteLine("Digite um número maior do que zero");
                            Console.ReadLine();  
                            segundoNumero =  Console.ReadLine();
                        }
                    }                   

                }

                Console.WriteLine("O resultado é: " + resultado);

                Console.ReadLine();               
            }

        }
    }
}
