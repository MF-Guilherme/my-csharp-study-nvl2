using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();

p1.Nome = "Guilherme";
p1.Idade = 33;
p1.Apresentar();
System.Console.WriteLine();
p2.Nome = "";
p2.Idade = 28;
p2.Apresentar();