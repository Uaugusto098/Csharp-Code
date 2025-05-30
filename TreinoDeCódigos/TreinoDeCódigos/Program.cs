
using System.Collections.Immutable;
using TreinoDeCódigos;

Alunos cadastro1=new Alunos();
cadastro1.cadastroDoAluno();
cadastro1.tabelaDoAluno();

Alunos cadastro2 = new Alunos();
cadastro2.cadastroDoAluno();



List<Alunos> cadastroI = new  List<Alunos>();

cadastroI.Add(cadastro1);
cadastroI.Add(cadastro2);


Console.WriteLine($"\n{cadastroI[0].nome} \n{cadastroI[0].idade} \n{cadastroI[0].RA}");
Console.WriteLine($"\n{cadastroI[1].nome} \n{cadastroI[1].idade} \n{cadastroI[1].RA}");



