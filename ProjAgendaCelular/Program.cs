using System;
using System.Collections.Generic;

namespace ProjAgendaCelular
{
    internal class Program
    {

        static int Menu()
        {
            int opc;
            Console.WriteLine("1 - Adicionar");
            Console.WriteLine("2 - Remover");
            Console.WriteLine("3 - Buscar");
            Console.WriteLine("4 - Editar");
            Console.WriteLine("5 - Imprimir Contatos");
            Console.WriteLine("6 - Imprimir Contato Único");
            return opc = int.Parse(Console.ReadLine());
        }
        static Pessoa AdicionarContato()
        {
            Pessoa contato = new();
            Console.Write("\nNome: ");
            string nome = Console.ReadLine();
            Console.Write("\nTelefone: ");
            string telefone = Console.ReadLine();
            Console.Write("\nEmail: ");
            string email = Console.ReadLine();
            Console.Write("\nAniversario: ");
            DateTime aniversario = DateTime.Parse(Console.ReadLine());

            contato.CadastrarPessoa(nome, telefone, email, aniversario);
            //agendaContatos.Add(contato);

            return contato;
        }
        static void RemoverContato(List<Pessoa> agendaContato)
        {
            Console.Write("Informe o nome: ");
            string nome = Console.ReadLine();
            Pessoa p = BuscarContato(agendaContato, nome);
            agendaContato.Remove(p);
        }
        static Pessoa BuscarContato(List<Pessoa> agendaContato, string n)
        {
            bool achei = false;
            Pessoa p = new Pessoa();
            foreach (Pessoa item in agendaContato)
            {
                if(item.Nome == n)
                {
                    achei = true;
                    p = item;
                    return p;
                 }
            }
            if (achei)
            {
                Console.WriteLine("Pessoa não encontrada");
                
            }
            return p;
        }
        static void EditarContato(List<Pessoa> agendaContato)
        {
            Console.WriteLine("Informe o nome para busca: ");
            string nome = Console.ReadLine();
            Pessoa p = BuscarContato(agendaContato,nome);
            Console.WriteLine("1 - Editar Nome");
            Console.WriteLine("2 - Editar Email");
            Console.WriteLine("3 - Editar Telefone");
            Console.WriteLine("4 - Editar Aniversario");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1: Console.WriteLine("Informe o NOVO nome:");
                        nome = Console.ReadLine();
                        p.Nome = nome;
                    break;

                case 2:
                    Console.WriteLine("Informe o NOVO email:");
                    string email = Console.ReadLine();
                    p.Email = email;
                    break;

                case 3:
                    Console.WriteLine("Informe o NOVO Telefone:");
                    string telefone = Console.ReadLine();
                    p.Telefone = telefone;
                    break;

                case 4:
                    Console.WriteLine("Informe o NOVO Aniversario:");
                    DateTime dt = DateTime.Parse(Console.ReadLine());
                    p.Aniversario = dt;
                    break;

                default:
                    break;
            }
        }
        static void ImprimirContatos(List<Pessoa> agendaContato)
        {
            //for(int i = 0; i < agendaContato.Count; i++)
            //{
            //    Pessoa p = agendaContato[i];
            //    Console.WriteLine(p.ToString());
            //}

            foreach (Pessoa item in agendaContato)
            {
                ImprimirContato(item);
            }
        }
        static void ImprimirContato(Pessoa contato)
        {
            Console.WriteLine(contato.ToString());
        }
        static void Main(string[] args)
        {
            List<Pessoa> agendaContatos = new List<Pessoa>();
            Console.WriteLine("Agenda de Contatos\n");
            int op = 0;
            Pessoa contato = new();
            do
            {
                op = Menu();
                switch (op)
                {
                    case 1:
                        contato = AdicionarContato();
                        agendaContatos.Add(contato);
                        break;

                    case 2:
                        RemoverContato(agendaContatos);
                        break;

                    case 3:
                        Console.WriteLine("Informe o nome para busca: ");
                        string nome = Console.ReadLine();
                        BuscarContato(agendaContatos, nome);
                        break;

                    case 4:
                        EditarContato(agendaContatos);
                        break;

                    case 5:
                        ImprimirContatos(agendaContatos);
                        break;

                    case 6:
                        Console.WriteLine("Informe o nome para busca: ");
                        nome = Console.ReadLine();
                        //Pessoa b = BuscarContato(agendaContatos, nome);
                        //ImprimirContato(b);
                        ImprimirContato(BuscarContato(agendaContatos, nome));
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            }while(true);
        }
    }
}
