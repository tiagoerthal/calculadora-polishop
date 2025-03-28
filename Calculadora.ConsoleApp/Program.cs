using System.ComponentModel.Design;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            string[] historicooperacao = new string[100];
            int contadorHistorico = 0;

            while (true)
            {

                string opcao = ExibirMenu();

                if (OpcaoSairFoiEscolhida(opcao))
                    break;

                else if (OpcaoTabuada(opcao))
                    ExibirTabuada();

                else if (OpcaoHistoricoFoiEscolhida(opcao))
                    ExibirHistoricoOperacoes(contadorHistorico, historicooperacao);

                else
                {                    
                   decimal resultado = RealizarCalculo(opcao, contadorHistorico, historicooperacao);

                    ExibirResultado(resultado);
                }
                
                Console.ReadLine();

            }

        }

        static string ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Calculadora inox polishop 2000");
            Console.WriteLine("----------------------------------");

            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Tabuada");
            Console.WriteLine("6 - Historico de operações");
            Console.WriteLine("S - Sair");
            Console.WriteLine("----------------------------------");

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            return opcao;
        }

        static bool OpcaoSairFoiEscolhida(string opcao)
        {
            bool opcaoFoiEscolhida = opcao == "S";

            return opcaoFoiEscolhida;               
        }

        static bool OpcaoTabuada(string opcao)
        {
            bool opcaoTabuadaFoiEsolhida = opcao == "5";

            return opcaoTabuadaFoiEsolhida;
        }

        static void ExibirTabuada()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("tabuada polishop a gás 4000");
            Console.WriteLine("----------------------------------");

            Console.Write("Digite o número desejado: ");
            int numeroTabuada = Convert.ToInt32(Console.ReadLine());

            for (int contador = 1; contador <= 10; contador++)
            {
                int resultadomultiplicacao = numeroTabuada * contador;

                string linhaDaTabuada = $"{numeroTabuada} x {contador} = {resultadomultiplicacao}";

                Console.WriteLine(linhaDaTabuada);
            }

            Console.ReadLine();
        }

        static bool OpcaoHistoricoFoiEscolhida(string opcao)
        {
            return opcao == "6";
        }

        static void ExibirHistoricoOperacoes(int contadorHistorico, string[] historicooperacao)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("historico polishop 5000");
            Console.WriteLine("----------------------------------");

            for (int contador = 0; contador < contadorHistorico; contador++)
                Console.WriteLine(historicooperacao[contador]);

            Console.ReadLine();
        }
        static decimal RealizarCalculo(string opcao, int contadorHistorico, string[] historicooperacao)
        {
            Console.WriteLine("----------------------------------");
            Console.Write("digite o primeiro número: ");
            decimal primeironumero = Convert.ToDecimal(Console.ReadLine());

            Console.Write("digite o segundo número: ");
            decimal segundonumero = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = 0.0m;

            if (opcao == "1")
            {
                resultado = primeironumero + segundonumero;
                historicooperacao[contadorHistorico] = $"{primeironumero} + {segundonumero} = {resultado}";
            }


            else if (opcao == "2")
            {
                resultado = primeironumero - segundonumero;
                historicooperacao[contadorHistorico] = $"{primeironumero} - {segundonumero} = {resultado}";
            }

            else if (opcao == "3")
            {
                resultado = primeironumero * segundonumero;
                historicooperacao[contadorHistorico] = $"{primeironumero} * {segundonumero} = {resultado}";
            }

            else if (opcao == "4")
            {

                while (segundonumero == 0)
                {
                    Console.Write("digite o segundo número novamente: ");
                    segundonumero = Convert.ToDecimal(Console.ReadLine());
                }
                resultado = primeironumero / segundonumero;
                historicooperacao[contadorHistorico] = $"{primeironumero} / {segundonumero} = {resultado}";
            }

            contadorHistorico++;

            return resultado;
        }

        static void ExibirResultado(decimal resultado)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("resultado: " + resultado.ToString("F2"));
            Console.WriteLine("----------------------------------");
        }
    }



}