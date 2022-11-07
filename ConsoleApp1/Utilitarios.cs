using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class Utilitarios
    {

        public static double SomarDois(double n01, double n02)
        {
            return n01 + n02;
        }

        public static double SubtrairDois(double n01, double n02)
        {
            return n01 - n02;
        }
        public static double DividirDois(double n01, double n02)
        {
            return n01 / n02;
        }

        public static double MultiplicarDois(double n01, double n02)
        {
            return n01 * n02;
        }


        public static double RetornarNumeroDoubleDif0(string msgSolicitacao, string msgErro)
        {
            string numeroStr = "";
            double numero = 0;
            while (true)
            {
                Console.WriteLine(msgSolicitacao);
                numeroStr = Console.ReadLine();

                if (!double.TryParse(numeroStr, out numero))
                {
                    Console.WriteLine(msgErro);
                }
                if (numero == 0)
                {
                    Console.WriteLine("Número não pode ser zero");
                }
                else
                {
                    break;
                }
            }

            return numero;
        }


        public static double RetornarNumeroDouble(string msgSolicitacao, string msgErro)
        {
            string numeroStr = "";
            double numero = 0;
            while (true)
            {
                Console.WriteLine(msgSolicitacao);
                numeroStr = Console.ReadLine();

                if (!double.TryParse(numeroStr, out numero))
                {
                    Console.WriteLine(msgErro);
                }

                else
                {
                    break;
                }
            }

            return numero;
        }
       

        public static void SomarDoisDigitados()
        {
            Console.WriteLine("Soma entre dois números");
            double n1 = RetornarNumeroDouble("Digite o 01º número", "Erro, digite um valor valido");
            double n2 = RetornarNumeroDouble("Digite o 02º número", "Erro, digite um valor valido");
            double resultado = Utilitarios.SomarDois(n1, n2);

            Console.WriteLine($"Resultado de {n1} + {n2} é:{resultado}");
            
        }
        public static void SubtrairDoisDigitados()
        {
            Console.WriteLine("Subtração entre dois números");
            double n1 = RetornarNumeroDouble("Digite o 01º número", "Erro, digite um valor valido");
            double n2 = RetornarNumeroDouble("Digite o 02º número", "Erro, digite um valor valido");
            double resultado = Utilitarios.SubtrairDois(n1, n2);
            Console.WriteLine($"Resultado de {n1} - {n2} é:{resultado}");
            
        }

        public static void DividirDoisDigitados()
        {
            Console.WriteLine("Divivão entre dois números");
            double n1 = RetornarNumeroDouble("Digite o 01º número", "Erro, digite um valor valido");
            double n2 = RetornarNumeroDoubleDif0("Digite o 02º número", "Erro, digite um valor valido");
            double resultado = Utilitarios.SubtrairDois(n1, n2);
            Console.WriteLine($"Resultado de {n1} / {n2} é:{resultado}");
            
        }
        public static void MultiplicarDoisDigitados()
        {
            Console.WriteLine("Multiplicação entre dois números");
            double n1 = RetornarNumeroDouble("Digite o 01º número", "Erro, digite um valor valido");
            double n2 = RetornarNumeroDouble("Digite o 02º número", "Erro, digite um valor valido");
            double resultado = Utilitarios.MultiplicarDois(n1, n2);
            Console.WriteLine($"Resultado de {n1} * {n2} é:{resultado}");
        }

    }
}
