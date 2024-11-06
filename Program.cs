using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();
Pessoa p3 = new Pessoa();

p1.Nome = "Guilherme";
p1.Sobrenome = "montenegro";
p1.Idade = 33;

p2.Nome = "andressa";
p2.Sobrenome = "borges";
p2.Idade = 28;

p3.Nome = "Liz";
p3.Sobrenome = "borges monTenegro";
p3.Idade = 18;

Curso c = new Curso();
c.Nome = "Inglês";
c.Alunos = new List<Pessoa>();
c.AdicionarAluno(p1);
c.AdicionarAluno(p2);
c.AdicionarAluno(p3);

c.ListarAlunos();
System.Console.WriteLine($"Total de alunos no curso = {c.ObterQuantidadeDeAlunosMatriculados()}");