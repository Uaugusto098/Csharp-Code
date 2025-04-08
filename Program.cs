using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
     

        private static void EX1()
        {


            double n1, n2;
            Console.WriteLine("Numero 1:");
            n1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Numero 2:");
            n2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine($"A soma do numero: {n1} e o numero: {n2} \n é {n1 + n2}");

            Console.ReadKey();
            
        
        }

        private static void EX2()
        {
            double brl, taxa,soma;
            Console.Write($"Taxas de câmbio atuais para conversões em BRL: \n1 USD= 5,94BRL \n 1 EUR= 6,48BRL\n 1 GBP= 7,58BRL\n 1 JPY= 0,04BRL");

            Console.WriteLine($"\nDigite o valor da taxa na moeda desejada: ");
            taxa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDigite o valor em brl desejado: ");
            brl = Convert.ToDouble(Console.ReadLine());
            soma = brl / taxa;
            
            Console.Write($"A conversão de BRL para U$D é de : {soma} ");
            Convert.ToDouble(soma);
        }

        private static void EX3()
        {
            int idade;

            Console.WriteLine("Digite sua idade para a verificação de titulo: ");
                 idade = Convert.ToInt16(Console.ReadLine());



            if (idade >= 18)
            {
                Console.Write("Você foi aprovado para votar!!");
            }

            else if (idade < 18)
            {
                Console.Write("Não qualificado para votação (Menor de idade)");

            }
        }

        private static void EX4()
        {
            double numero1, numero2;

            Console.WriteLine("Digite o primeiro numero: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.Write($"O numero: {numero1} é maior ");
            }

            else if (numero1 < numero2)
            {
                Console.Write($"O numero: {numero2} é maior ");
            }

            else if (numero1 == numero2)
            {
                Console.Write($"Os numeros: {numero1} e  {numero2} são iguais ");
            }
        }



            private static void EX5()
        {
            int idade;
            String risco;

            Console.WriteLine("Digite sua idade para a verificação do seguro: ");
            idade = Convert.ToInt16(Console.ReadLine());

            if (idade >= 18 && idade <= 24)
            {

                Console.WriteLine("Digite o seu grupo de risco: ");
                risco = Convert.ToString(Console.ReadLine());

                if (risco == "7")
                {
                    Console.Write("Seu grupo de risco é baixo ");
                }
                else if (risco == "8")
                {
                    Console.Write("Seu grupo de risco é médio ");
                }
                else if (risco == "9")
                {
                    Console.Write("Seu grupo de risco é alto ");
                }


            }

            if (idade >= 25 && idade <= 40)
            {

                Console.WriteLine("Digite o seu grupo de risco: ");
                risco = Convert.ToString(Console.ReadLine());

                if (risco == "4")
                {
                    Console.Write("Seu grupo de risco é baixo ");
                }
                else if (risco == "5")
                {
                    Console.Write("Seu grupo de risco é médio ");
                }
                else if (risco == "6")
                {
                    Console.Write("Seu grupo de risco é alto ");
                }


            }

            if (idade >= 41 && idade <= 70)
            {

                Console.WriteLine("Digite o seu grupo de risco: ");
                risco = Convert.ToString(Console.ReadLine());

                if (risco == "1")
                {
                    Console.Write("Seu grupo de risco é baixo ");
                }
                else if (risco == "2")
                {
                    Console.Write("Seu grupo de risco é médio ");
                }
                else if (risco == "3")
                {
                    Console.Write("Seu grupo de risco é alto ");
                }


            }



        }
            



        





        //public static void grupoDeRisco()
        //{
        //    int idade;
        //    string risco;
        //    if (idade>=18 && idade<=24)
        //    {   
                
        //        Console.WriteLine("Digite o seu grupo de risco: ");
        //        risco= Convert.ToString(Console.ReadLine());

        //            if (risco=="7")
        //        {
        //            Console.Write("Seu grupo de risco é baixo ");
        //        }
        //            else if (risco=="8")
        //        {
        //            Console.Write("Seu grupo de risco é médio ");
        //        }
        //        else if (risco=="9")
        //        {
        //            Console.Write("Seu grupo de risco é alto ");
        //        }


        //    }

            

        //}














































        private static void Main(string[] args)
        {

            //EX1();
            //EX2();
            //EX3();
            //EX4();
            EX5();
            Console.ReadKey();
        }



    }
    }

