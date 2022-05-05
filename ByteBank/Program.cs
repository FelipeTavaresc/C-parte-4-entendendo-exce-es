using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(0, 0);
            }
            catch (ArgumentException ex)
            {
                if (ex.ParamName == "numero")
                {
                }

                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine("Ocorreu um exceçao do tipo ArgumentException");
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }

        // Teste com a cadeia de chamada:
        // Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
                throw;
            }
        }
    }
}
