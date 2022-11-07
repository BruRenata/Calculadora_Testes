using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;



namespace TestesUnitarios
{
    class TestesUnitarios
    {
        public static void TestarSomar_1_1_retornar_2()
        {
            double resultado = Utilitarios.SomarDois(1, 1);
            if (resultado == 2)
            {
                Console.WriteLine($"Teste de Soma: Passou: 1 + 1 = {resultado}");
            }
            else
            {
                Console.WriteLine($"Teste de Soma: Não Passou: 1 + 1 = {resultado}");
            }

        }

        public static void TestarSubtrair_1_1_retornar_0()
        {
            double resultado = Utilitarios.SubtrairDois(1, 1);
            if (resultado == 0)
            {
                Console.WriteLine($"Teste de Subtração: Passou: 1 - 1 = {resultado}");
            }
            else
            {
                Console.WriteLine($"Teste de Subtração: Não Passou: 1 - 1 = {resultado}");
                Console.WriteLine($"Esperado 0");
            }

        }

        public static void TestarDividir_10_2_retornar_5()
        {
            double resultado = Utilitarios.DividirDois(10, 2);
            if (resultado == 5)
            {
                Console.WriteLine($"Teste de Dividir: Passou: 10 / 2 = {resultado}");
            }
            else
            {
                Console.WriteLine($"Teste de Dividir: Não Passou: 10 / 2 = {resultado}");
                Console.WriteLine($"Esperado 5");
            }

        }

        public static void TestarMultiplicar_2_2_retornar_4()
        {
            double resultado = Utilitarios.MultiplicarDois(2, 2);
            if (resultado == 4)
            {
                Console.WriteLine($"Teste de Multiplicar: Passou: 2 * 2 = {resultado}");
            }
            else
            {
                Console.WriteLine($"Teste de Multiplicar: Não Passou: 2 * 2 = {resultado}");
                Console.WriteLine($"Esperado 4");
            }

        }
    }
}
