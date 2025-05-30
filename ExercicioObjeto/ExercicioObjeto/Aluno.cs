using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Aluno
    {
        //Atributos
        public String ra;
        public String nome;
        public String email;
        public double nota1;
        public double nota2;
        public double media;





        public void mostrarDados()
        {
            media = (nota1 + nota2) / 2;

            Console.WriteLine($"             \nAluno: {this.nome}");
            Console.WriteLine($"ra: {this.ra}");
            Console.WriteLine($"email: {this.email}");
            Console.WriteLine($"nota1: {this.nota1}");
            Console.WriteLine($"nota2: {this.nota2}");
            Console.WriteLine($"Média: {this.media}");


        }

        //public Aluno(string ra,string nome,string email,double nota1,double nota2,double media)
        //{
        //    this.ra = ra;
        //    this.nome = nome;
        //    this.email = email;
        //    this.nota1 = nota1;
        //    this.nota2 = nota2;
        //    this.media = media;

        //}


        public Aluno entradaDeDados()
        {
            Aluno alunos = new Aluno();

            Console.WriteLine("\nDigite seu nome: ");
            alunos.nome = Console.ReadLine();
            Console.WriteLine("\nDigite seu RA: ");
            alunos.ra = Console.ReadLine();
            Console.WriteLine("\nDigite seu email: ");
            alunos.email = Console.ReadLine();
            Console.WriteLine("\nDigite sua primeira nota: ");
            alunos.nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDigite sua segunda nota: ");
            alunos.nota2 = Convert.ToDouble(Console.ReadLine());

            return alunos;
        }











    }
}
