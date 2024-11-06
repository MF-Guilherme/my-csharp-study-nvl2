using ExemploExplorando.Models;

Pessoa p1 = new Pessoa("Guilherme", "montenegro");
Pessoa p2 = new Pessoa("andressa", "borges");
Pessoa p3 = new Pessoa("Liz", "borges Montenegro", 17);

Curso c = new Curso();
c.Nome = "Inglês";
c.Alunos = new List<Pessoa>();
c.AdicionarAluno(p1);
c.AdicionarAluno(p2);
c.AdicionarAluno(p3);

c.ListarAlunos();
System.Console.WriteLine($"Total de alunos no curso = {c.ObterQuantidadeDeAlunosMatriculados()}");