using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pessoasClasse
{
    class people
    {
        private string name;
        private int idade;
        private string cpf;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public people()
        {
        }

        public people(string name, int idade)
        {
            this.name = name;
            this.idade = idade;
        }

        public people(string name, int idade, string cpf)
        {
            this.name = name;
            this.idade = idade;
            this.cpf = cpf;
        }

        public virtual void exibirDados()
        {
            Console.WriteLine($"Nome:{name}\nIdade:{idade}\nCPF:{cpf}");
        }
    }
}