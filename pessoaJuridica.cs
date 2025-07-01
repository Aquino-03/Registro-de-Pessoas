using pessoasClasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pjuridicaClasse
{
    class Pjuridica : people
    {
        private string cnpj;
        public Pjuridica()
        {
        }

        public Pjuridica(string cnpj, string name, int idade) : base(name, idade)
        {
            this.cnpj = cnpj;
        }

        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public override void exibirDados()
        {
            Console.WriteLine($"Nome:{Name}\nIdade:{Idade}\nCNPJ: {cnpj}");
        }
    }
}

