using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAgendaCelular
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime Aniversario { get; set; }

        public Pessoa()
        { 
        
        }
        public Pessoa CadastrarPessoa(string n, string t, string e, DateTime a)
        {
            Pessoa p = new Pessoa();

            Nome = n;
            Telefone = t;
            Email = e;
            Aniversario = a;

            return p;
        }

        public override string ToString()
        {
            return "\nNome: " +Nome+ "\nTelefone: " + Telefone+ "\nEmail: " + Email+ "\nAniversário: " + Aniversario.ToShortDateString();
        }

    }
}
