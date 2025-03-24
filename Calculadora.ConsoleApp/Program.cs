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
                Console. Clear();
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

                if (opcao == "S")
                    break;

                else if (opcao == "5")
                {

                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("tabuada polishop a gás 4000");
                    Console.WriteLine("----------------------------------");

                    Console.Write("Digite o número desejado: ");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());

                    for (int contador = 1; contador<= 10; contador++)
                    {
                        int resultadomultiplicacao = numeroTabuada * contador;

                        string linhaDaTabuada = $"{numeroTabuada} x {contador} = {resultadomultiplicacao}";

                        Console.WriteLine(linhaDaTabuada);
                    }

                    Console.ReadLine();
                    continue;
                }

                else if (opcao == "6")
                {
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("historico polishop 5000");
                    Console.WriteLine("----------------------------------");

                    for (int contador = 0; contador < contadorHistorico; contador++)                 
                        Console.WriteLine(historicooperacao[contador]);
                    
                    Console.ReadLine();
                    continue;
                }
                 
                Console.WriteLine("----------------------------------");
                Console.WriteLine("digite o primeiro número: ");
                decimal primeironumero = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("digite o segundo número: ");              
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

                else if(opcao == "4")
                {

                    while (segundonumero == 0)
                    {
                        Console.Write("digite o segundo número novamente: ");
                        segundonumero = Convert.ToDecimal(Console.ReadLine());
                    }
                    resultado = primeironumero / segundonumero;
                    historicooperacao[contadorHistorico] = $"{primeironumero} / {segundonumero} = {resultado}";

                }             

                Console.WriteLine("----------------------------------");
                Console.WriteLine("resultado: " + resultado.ToString("F2"));
                Console.WriteLine("----------------------------------");

                Console.ReadLine();

            }
            

            

            
        }
    }
}
