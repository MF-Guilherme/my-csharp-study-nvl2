using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome)
        {

        }

        public Pessoa(string nome, string sobrenome, int idade)
        {
            
        }
        private string _nome;
        private int _idade;

        public string Nome 
        { 
            get => _nome.ToUpper();
            
            set 
            {
                 if (value == "") //precisa ser a variavel "value"
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value; //se passar...
            } 
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade 
        { 

            get => _idade; 
            
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa");
                }

                _idade = value;
            } 
        }

        public void Apresentar(){
            System.Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos.");
        }
    }
}