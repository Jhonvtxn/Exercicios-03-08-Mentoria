using System;

namespace PrimeirosPassos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(
                "Digite 1 para Calculo do IMC.\n" +
                "Digite 2 para Procurar anos BISSEXTOS.\n" +
                "Digite 3 para calcular RAIZ CUBICA de um Numero.\n" +
                "Digite 4 para Calculo do MMC.\n" +
                "Digite 5 para Calculo da duração do Jogo.\n ");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Exercicio1();
                    break;
                case 2:
                    Exercicio2();
                    break;
                case 3:
                    Exercicio3();
                    break;
                case 4:
                    Exercicio4();
                    break;
                case 5:
                    Exercicio5();
                    break;
                default:
                    Console.WriteLine("Opcao invalida.");
                    break;
            }
        }
        public static bool Exercicio1()
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Insira nome aluno: ");
                var nomeAluno = Console.ReadLine();

                Console.WriteLine("Insira idade: ");
                var idadeAluno = Console.ReadLine();
                int idade = Convert.ToInt32(idadeAluno);

                Console.WriteLine("Insira altura: ");
                var alturaAluno = Console.ReadLine();
                var altura = Convert.ToDouble(alturaAluno);

                Console.WriteLine("Insira peso: ");
                var pesoAluno = Console.ReadLine();
                var peso = Convert.ToDouble(pesoAluno);

                double imc = peso / (altura * altura);
                Console.WriteLine($"{nomeAluno} - imc {imc}");
            }

            return true;
        }

        public static bool Exercicio2()
        {
            Console.Write("Ano inicial: ");
            var anoInicial = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ano final: ");
            var anoFinal = Convert.ToInt32(Console.ReadLine());

            for (int i = anoInicial; i <= anoFinal; i++)
            {
                if (i % 4 == 0)
                {
                    Console.Write($"{i} é Bissexto.\n");
                }
                else
                {
                    Console.Write($"{i} não é Bissexto. \n");
                }
            }
            return true;
        }
        public static bool Exercicio3()
        {
            Console.Write("Insira o valor: ");
            var numero = Convert.ToDouble(Console.ReadLine());
            var cubica = Math.Pow(numero, 1.0 / 3.0);
            Console.Write($"Raiz cubica de {numero} = {cubica}");

            return true;
        }
        public static bool Exercicio4()
        {
            Console.Write("Digite o primeiro valor: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int aux = num1;
            int aux1 = num2;

            while (aux1 != 0)
            {
                int resposta = aux % aux1;
                aux = aux1;
                aux1 = resposta;
            }
            var resultado = num1 * (num2 / aux);
            Console.Write($"resultado: {resultado}");
            return true;
        }
        public static bool Exercicio5()
        {
            int Hora = 0;
            int minutos = 0;
            Console.WriteLine("Hora(s) inicial: ");
            int horaInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Minuto inicial: ");
            int minInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("horas final: ");
            int horaFinal = int.Parse(Console.ReadLine());
            Console.WriteLine("Minuto final: ");
            int minFinal = int.Parse(Console.ReadLine());


            if ((horaFinal > horaInicial && minFinal >= minInicial) ||
                (horaFinal >= horaInicial && minFinal > minInicial))
            {
                Hora = horaFinal - horaInicial;
                minutos = minFinal - minInicial;
            }
            else if (horaFinal == horaInicial && minFinal == minInicial)
            {
                Hora = 24;
                minutos = 0;
            }
            else if (horaFinal == horaInicial && minFinal < minInicial)
            {
                Hora = 23;
                minutos = minFinal + (60 - minInicial);
            }
            else if (horaFinal > horaInicial && minFinal < minInicial)
            {
                Hora = horaFinal - horaInicial - 1;
                minutos = minFinal + (60 - minInicial);
            }
            else if (horaFinal < horaInicial && minFinal < minInicial)
            {
                Hora = horaFinal + (24 - horaInicial) - 1;
                minutos = minFinal + (60 - minInicial);
            }
            else if (horaFinal < horaInicial && minFinal >= minInicial)
            {
                Hora = horaFinal + (24 - horaInicial);
                minutos = minFinal - minInicial;
            }
            Console.WriteLine($"a duração foi de {Hora}:{minutos}");
            Console.ReadLine();
            return true;
        }
    }
}