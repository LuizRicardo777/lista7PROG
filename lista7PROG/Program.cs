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
            Console.WriteLine("exercicio 1 =)");
        }
        public static void Exercicio2()
        {
            Console.WriteLine("exercicio 2 =)");
        }
        public static void Exercicio3()
        {
            Console.WriteLine("exercicio 3 =)");
        }
        public static void Exercicio4()
        {
            Console.WriteLine("exercicio 4 =)");
        } 
        public static void Exercicio5()
        {
            Console.WriteLine("exercicio 5 =)");
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
                Console.WriteLine("===========================");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0: Console.WriteLine("obrigado por usar");
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


                    default:
                        Console.WriteLine("essa opção não existe");
                        break;
                }
                Console.ReadKey();











            } while (opcao !=0);



        }
    }
}
