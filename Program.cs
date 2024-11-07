using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Xml;
using ExemploExplorando.Models;



LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    System.Console.WriteLine("Quantidade de linhas: " + quantidadeLinhas);
    foreach (string linha in linhasArquivo)
    {
        System.Console.WriteLine(linha);
    }
}
else
{
    System.Console.WriteLine("Não foi possível ler o arquivo");
}















// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Guilherme", "Montenegro", 1.69M); // forma mais indicada

// ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Guilherme", "Montenegro", 1.69M); // outra forma de criar uma tupla
// var outroExemploTuplaCreate = Tuple.Create(1, "Guilherme", "Montenegro", 1.69M);// outra forma de criar uma tupla


// System.Console.WriteLine($"Id = {tupla.Item1}");
// System.Console.WriteLine($"Nome = {tupla.Item2}");
// System.Console.WriteLine($"Sobrenome = {tupla.Item3}");
// System.Console.WriteLine($"Altura = {tupla.Item4}");
















// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// foreach (var item in estados)
// {
//     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// foreach (var item in estados.Keys) // pegando todas as chaves do dicionario (.Values para pegar os valores) 
// {   
//     System.Console.WriteLine(item);
// }

// estados.Remove("BA"); // removendo

// estados["SP"] = "Valor alterado"; // alterando o valor

// System.Console.WriteLine(estados["SP"]); // pegando o valor de uma chave específica

// Console.WriteLine(estados.ContainsKey("BA")); // verifica se a chave já existe no dicionário





// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     System.Console.WriteLine(item);
// }

// System.Console.WriteLine($"Removendo o elemento {pilha.Pop()} do topo da pilha");


// foreach(int item in pilha)
// {
//     System.Console.WriteLine(item);
// }


















// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// System.Console.WriteLine($"Removendo o elemento {fila.Dequeue()} da fila");
// fila.Enqueue(12);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }
















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