using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista7PROG
{
    internal class Program
    {
        public static void Exercicio1()
        {


            int numdeprod, prec, tot = 0;

            while (true)
            {
                Console.WriteLine("digite 0 para parar o programa");
                Console.WriteLine("qual a quantidade desse produto ");
                numdeprod = int.Parse(Console.ReadLine());
                if (numdeprod == 0)
                {
                    break;
                }
                Console.WriteLine("qual o preço do produto: ");
                prec = int.Parse(Console.ReadLine());

                tot = prec * numdeprod + tot;

                if (tot == 0)
                {
                    break;
                }





            }
            Console.WriteLine("o valor total vai igual a:" + tot);
            Console.ReadKey();





        }
        public static void Exercicio2()
        {

            string nome, nomeMenor = "", nomeMaior = "";
            int numItens, parada = 2;
            float valor, maiorValor, menorValor;

            maiorValor = float.MinValue;
            menorValor = float.MaxValue;

            while (parada != 1)
            {
                Console.WriteLine("Qual o nome do pruduto");
                nome = Console.ReadLine();

                Console.WriteLine("Qual a quantidade de produtos");
                numItens = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual o preço do produto");
                valor = float.Parse(Console.ReadLine());

                float total = numItens * valor;
                if (total > maiorValor)
                {
                    maiorValor = total;
                    nomeMaior = nome;
                }

                if (total < menorValor)
                {
                    menorValor = total;
                    nomeMenor = nome;
                }
                Console.WriteLine("Digite 1 para SAIR ou 2 para continuar");
                parada = int.Parse(Console.ReadLine());


            }
            Console.WriteLine("Maior quantia investida {0} no produto {1} ", maiorValor, nomeMaior);
            Console.WriteLine("Menor quantia investida {0} no produto {1} ", menorValor, nomeMenor);
            Console.ReadKey();
        }
        public static void Exercicio3()
        {
            int somaPesoAvaliacoes = 0, totalAvaliacoes, pesoAvaliacao;

            Console.WriteLine("Informe o total de avaliações do bimestre:");
            totalAvaliacoes = int.Parse(Console.ReadLine());

            if (totalAvaliacoes <= 0)
                Console.WriteLine("Número de avaliações inválido!");
            int i = 0;
            while (i < totalAvaliacoes)
            {
                Console.WriteLine("Infome o peso da avalição {0}", i + 1);
                pesoAvaliacao = int.Parse(Console.ReadLine());

                somaPesoAvaliacoes += pesoAvaliacao;
                i++;
            }

            if (somaPesoAvaliacoes < 100)
                Console.WriteLine("O peso das avalições é Insuficiente!");
            else if (somaPesoAvaliacoes > 100)
                Console.WriteLine("O peso das avaliações é Excedente!");
            else
                Console.WriteLine("O peso das avaliações é Adequado.");
            Console.ReadKey();
        }
        public static void Exercicio4()
        {
            string estado;

            Console.WriteLine("qual a sigla do estado");

            estado = Console.ReadLine();

            switch (estado)

            {

                case "AC":

                    Console.WriteLine("o estado é Acre");

                    break;

                case "AL":

                    Console.WriteLine("o estado é Alagoas");

                    break;

                case "AP":

                    Console.WriteLine("o estado é Amapá");

                    break;

                case "AM":

                    Console.WriteLine("o estado é Amazonas");

                    break;

                case "BA":

                    Console.WriteLine("o estado é Bahia");

                    break;

                case "CE":

                    Console.WriteLine("o estado é Ceará");

                    break;

                case "DF":

                    Console.WriteLine("Distrito Federal não é um estado, mas sim uma uniudade autônoma");

                    break;

                case "ES":

                    Console.WriteLine("o estado é Espírito Santo");

                    break;

                case "GO":

                    Console.WriteLine("o estado é Goiás");

                    break;

                case "MA":

                    Console.WriteLine("o estado é Maranhão");

                    break;

                case "MT":

                    Console.WriteLine("o estado é Mato Grosso");

                    break;

                case "MS":

                    Console.WriteLine("o estado é Mato Grosso do Sul");

                    break;

                case "MG":

                    Console.WriteLine("o estado é Minas Gerais");

                    break;

                case "PA":

                    Console.WriteLine("o estado é Pará");

                    break;

                case "PB":

                    Console.WriteLine("o estado é Paraíba");

                    break;

                case "PR":

                    Console.WriteLine("o estado é Paraná");

                    break;

                case "PE":

                    Console.WriteLine("o estado é Pernambuco");

                    break;

                case "PI":

                    Console.WriteLine("o estado é Piauí");

                    break;

                case "RJ":

                    Console.WriteLine("o estado é Rio de Janeiro");

                    break;

                case "RN":

                    Console.WriteLine("o estado é Rio Grande do Norte");

                    break;

                case "RS":

                    Console.WriteLine("o estado é Rio Grande do Sul");

                    break;

                case "RO":

                    Console.WriteLine("o estado é Rondônia");

                    break;

                case "RR":

                    Console.WriteLine("o estado é Roraima");

                    break;

                case "SC":

                    Console.WriteLine("o estado é Santa Catarina");

                    break;

                case "SP":

                    Console.WriteLine("o estado é São Paulo");

                    break;

                case "SE":

                    Console.WriteLine("o estado é Sergipe");

                    break;

                case "TO":

                    Console.WriteLine("o estado é Tocantins");

                    break;

                default:

                    Console.WriteLine("nao existe estado com essa sigla");

                    break;

            }
            Console.ReadKey();
        }
        public static void Exercicio5()
        {
            int mes, dia;
            string estacaoDoAno = "";
            Console.WriteLine("1 - Janeiro");
            Console.WriteLine("2 - Fevereiro");
            Console.WriteLine("3 - Marco");
            Console.WriteLine("4 - Abril");
            Console.WriteLine("5 - Maio");
            Console.WriteLine("6 - Junho");
            Console.WriteLine("7 - Julho");
            Console.WriteLine("8 - Agosto");
            Console.WriteLine("9 - Setembro");
            Console.WriteLine("10 - Outubro");
            Console.WriteLine("11 - Novembro");
            Console.WriteLine("12 - Dezembro");

            Console.WriteLine("Qual o mes ? ");
            mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                case 2:
                    estacaoDoAno = "Verao";
                    break;
                case 3:
                    Console.WriteLine("Informe o dia do mês:");
                    dia = int.Parse(Console.ReadLine());

                    if (dia < 21) estacaoDoAno = "Verao";
                    else estacaoDoAno = "Outono";
                    break;

                case 4:
                case 5:
                    estacaoDoAno = "Outono";
                    break;
                case 6:
                    Console.WriteLine("Informe o dia do mês:");
                    dia = int.Parse(Console.ReadLine());

                    if (dia >= 21) estacaoDoAno = "Inverno";
                    else estacaoDoAno = "Outono";
                    break;
                case 7:
                case 8:
                    estacaoDoAno = "Inverno";
                    break;
                case 9:
                    Console.WriteLine("Informe o dia do mês:");
                    dia = int.Parse(Console.ReadLine());

                    if (dia >= 23) estacaoDoAno = "Primavera";
                    else estacaoDoAno = "Inverno";
                    break;
                case 10:
                case 11:
                    estacaoDoAno = "Primavera";
                    break;
                case 12:
                    Console.WriteLine("Informe o dia do mês:");
                    dia = int.Parse(Console.ReadLine());

                    if (dia >= 22) estacaoDoAno = "Verao";
                    else estacaoDoAno = "Primavera";
                    break;
            }
            Console.WriteLine("A estacao do ano é {0}", estacaoDoAno);
            Console.ReadKey();
        }
        public static void Exercicio6()
        {
            double alt, kg, imc;

            Console.WriteLine("Digite sua altura (em metros): ");

            alt = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso (em kilos): ");

            kg = double.Parse(Console.ReadLine());

            imc = kg / (alt * alt);

            if (imc < 18.5)

            {

                Console.WriteLine("você está abaixo do peso");



            }

            if (imc >= 18.5 && imc <= 24.9)

            {

                Console.WriteLine("você está no peso comum");



            }

            if (imc >= 25 && imc <= 29.9)

            {

                Console.WriteLine("você está acima do peso");



            }

            if (imc >= 30 && imc < 34.9)

            {

                Console.WriteLine("você está com obesidade grau 1");



            }

            if (imc >= 35 && imc < 39.9)

            {

                Console.WriteLine("você está com obesidade grau 2");



            }

            if (imc >= 40)

            {

                Console.WriteLine("você está com obesidade grau 3");



            }
            Console.ReadKey();
        }
        public static void Exercicio7()
        {
            int num;

            Console.WriteLine("digite um numero");

            num = int.Parse(Console.ReadLine());
            int b = 1;
            while (b < num)

            {
                b++;
                if (num % b == 0)

                    Console.WriteLine(b);

                else

                    b++;

            }
            Console.ReadKey();

        }

        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("=========MENU===========");
                Console.WriteLine("para SAIR DIGITE - 0 ");
                Console.WriteLine("EXERCICIO 1 ");
                Console.WriteLine("EXERCICIO 2 ");
                Console.WriteLine("EXERCICIO 3 ");
                Console.WriteLine("EXERCICIO 4 ");
                Console.WriteLine("EXERCICIO 5 ");
                Console.WriteLine("EXERCICIO 6 ");
                Console.WriteLine("EXERCICIO 7 ");
                Console.WriteLine("===========================");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("obrigado por usar");
                        break;

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
                    case 6:
                        Exercicio5();
                        break;
                    case 7:
                        Exercicio5();
                        break;


                    default:
                        Console.WriteLine("essa opção não existe");
                        break;
                }
                Console.ReadKey();











            } while (opcao != 0);



        }
    }
}
