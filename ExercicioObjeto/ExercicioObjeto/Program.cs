using ConsoleApp1;
using System;
using System.Security.Cryptography.X509Certificates;



class Program
{
    private static void Main(string[] args)
    { //CÓDIGO ATUAL
        string opção;
        Aluno[] aluno = new Aluno[40];
        aluno[0] = new Aluno();
        aluno[1] = new Aluno();
        do
        {
            aluno[0] = aluno[0].entradaDeDados();
            aluno[1] = aluno[1].entradaDeDados();

            Console.WriteLine("Deseja continuar?:  ");
            opção = Console.ReadLine();
        }
        while (opção == "Sim");

        {

            Console.WriteLine("\nQual aluno deseja selecionar?(0 ou 1):");
            string seleção = Console.ReadLine();

            switch (seleção)
            {
                case "0":
                    aluno[0].mostrarDados();
                    break;
                case "1":
                    aluno[1].mostrarDados();
                    break;

            }

            Console.WriteLine("Deseja continuar?:  ");
            opção = Console.ReadLine();


            if (opção == "não")
            {
                Console.WriteLine("Sistema finalizado");



            }

        }











        //CÓDIGO ANTERIOR 2

        //ALUNO 0
        //Console.WriteLine("\nDigite seu nome: ");
        //aluno[0].nome = Console.ReadLine();
        //Console.WriteLine("\nDigite seu RA: ");
        //aluno[0].ra = Console.ReadLine();
        //Console.WriteLine("\nDigite seu email: ");
        //aluno[0].email = Console.ReadLine();
        //Console.WriteLine("\nDigite sua primeira nota: ");
        //aluno[0].nota1 = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("\nDigite sua segunda nota: ");
        //aluno[0].nota2 = Convert.ToDouble(Console.ReadLine());



        //ALUNO 1
        //Console.WriteLine("\nDigite seu nome: ");
        //aluno[1].nome = Console.ReadLine();
        //Console.WriteLine("\nDigite seu RA:");
        //aluno[1].ra = Console.ReadLine();
        //Console.WriteLine("\nDigite seu email: ");
        //aluno[1].email = Console.ReadLine();
        //Console.WriteLine("\nDigite sua primeira nota: ");
        //aluno[1].nota1 = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("\nDigite sua segunda nota: ");
        //aluno[1].nota2 = Convert.ToDouble(Console.ReadLine());









        //CÓDIGO ANTERIOR 1 

        //Aluno maria= new Aluno();

        // Console.WriteLine("Digite seu RA: ");
        // maria.ra=Console.ReadLine();
        // Console.WriteLine("Digite seu Nome: ");
        // maria.nome = Console.ReadLine();
        // Console.WriteLine("Digite seu EMAIL: ");
        // maria.email = Console.ReadLine();
        // Console.WriteLine("Digite sua primeira nota: ");
        // maria.nota1 = Convert.ToDouble(Console.ReadLine());
        // Console.WriteLine("Digite sua segunda nota: ");
        // maria.nota1 = Convert.ToDouble(Console.ReadLine());





        //Console.Write($"O RA de maria é: {maria.ra}");


















    }
}







