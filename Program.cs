﻿using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Xml;
using ExemploExplorando.Models;


Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

System.Console.WriteLine($"Removendo o elemento {fila.Dequeue()} da fila");
fila.Enqueue(12);

foreach (int item in fila)
{
    Console.WriteLine(item);
}
















// new ExemploExcecao().Metodo1();
















// try {    
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach(string linha in linhas){
//         System.Console.WriteLine(linha);
//     }
// } catch (FileNotFoundException ex) {
    
//     System.Console.WriteLine($"Arquivo não encontrado. {ex.Message}");;
// } catch (DirectoryNotFoundException ex) {
    
//     System.Console.WriteLine($"Diretório não encontrado. {ex.Message}");;
// } catch (Exception ex) {
    
//     System.Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");;
// } finally {
//     System.Console.WriteLine("Cheguei aqui com ou sem erro");
// }






// DateTime data = DateTime.Now;

// System.Console.WriteLine(data);
// System.Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); //data formatada da forma que eu quero
// System.Console.WriteLine(data.ToShortDateString()); //somente a data
// System.Console.WriteLine(data.ToShortTimeString()); //somente a hora


















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// double valorMonetario = 122657.84;
// System.Console.WriteLine(valorMonetario.ToString("F4"));

// double porcentagem = .3524;
// System.Console.WriteLine(porcentagem.ToString("P"));

// long numero = 11122233388;
// System.Console.WriteLine(numero.ToString("###-###-###-##"));




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