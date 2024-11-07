using System.Globalization;
using ExemploExplorando.Models;


CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

double valorMonetario = 122657.84;

System.Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));







// Pessoa p1 = new Pessoa(nome: "Guilherme", sobrenome: "montenegro"); //posso explicitar o parâmetro ao passar tbm. Ex.: Pessoa(nome: "Guilherme")
// Pessoa p2 = new Pessoa("andressa", "borges");
// Pessoa p3 = new Pessoa(nome: "Liz", sobrenome: "borges Montenegro", idade: 17);

// Curso c = new Curso();
// c.Nome = "Inglês";
// c.Alunos = new List<Pessoa>();
// c.AdicionarAluno(p1);
// c.AdicionarAluno(p2);
// c.AdicionarAluno(p3);

// c.ListarAlunos();
// System.Console.WriteLine($"Total de alunos no curso = {c.ObterQuantidadeDeAlunosMatriculados()}");