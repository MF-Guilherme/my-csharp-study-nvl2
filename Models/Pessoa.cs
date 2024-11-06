using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome;

        public string Nome 
        { 
            get 
            {
                return _nome.ToUpper();
            } 
            set 
            {
                 if (value == "") //precisa ser a variavel "value"
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value; //se passar...
            } 
        }

        public int Idade { get; set; }

        public void Apresentar(){
            System.Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}