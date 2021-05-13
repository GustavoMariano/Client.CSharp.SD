using System;

namespace ClientCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ws = new Services.AbcBolinhasPortTypeClient();
            string opcao = "a";

            while (opcao != "S")
            {
                Console.Clear();

                Console.WriteLine("Digite 1 para verificar o CPF");
                Console.WriteLine("Digite 2 para verificar se o número é ímpar ou par");
                Console.WriteLine("Digite 3 para realizar uma operação matemática");                
                Console.WriteLine("Digite S para Sair");

                opcao = Console.ReadLine().ToUpper();

                Console.Clear();

                if (opcao == "S")
                {
                    Environment.Exit(0);
                }
                else if(opcao == "1")
                {
                    string cpf = "0";
                    Console.WriteLine("Digite o CPF que deseja verificar");
                    cpf = Console.ReadLine();

                    var verifica = ws.valida_CPF(cpf);

                    Console.WriteLine(verifica);
                    Console.ReadLine();                    
                }
                else if (opcao == "2")
                {
                    int numero = 0;
                    Console.WriteLine("Digite o número que deseja verificar");
                    numero = Convert.ToInt32(Console.ReadLine());

                    var verifica = ws.verifica_NumeroPar(numero);

                    Console.WriteLine(verifica);
                    Console.ReadLine();
                }
                else if (opcao == "3")
                {
                    int num1 = 0, num2 = 0;
                    string operador = "";
                    Console.WriteLine("Digite a operação que deseja realizar \n+ Para soma " +
                        "\n- Para subtração \n* Para multiplicação \n/ Para divisão ");
                    operador = Console.ReadLine();

                    Console.WriteLine("Digite o primeiro número: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite o segundo número: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    if (operador == "/" && num2 == 0 )
                    {
                        Console.WriteLine("Segundo número inválido, tente novamente!!");
                        Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        var verifica = ws.math_operation(operador, num1, num2);
                        Console.WriteLine(num1 + " " + operador + " " + num2 + " = " + " " + verifica);
                    }   
                    Console.ReadLine();
                }
            }
        }
    }
}
