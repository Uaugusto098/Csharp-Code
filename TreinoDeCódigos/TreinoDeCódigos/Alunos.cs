using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoDeCódigos
{
    internal class Alunos
    {

        public string nome,RA;
        public int idade;

        
        public void cadastroDoAluno()
        {
           


            Console.WriteLine("Digite seu nome: ");
            nome=Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu RA: ");
            RA = Convert.ToString(Console.ReadLine());



            
        }

        public void tabelaDoAluno()
        {
           
            Console.WriteLine($"\nAluno: {nome}\nIdade: {idade}\nRA: {RA}");
        }

    }
}
