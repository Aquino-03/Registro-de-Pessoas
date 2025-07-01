using System;
using System.Numerics;
using System.Xml.Linq;
using pjuridicaClasse;
using pessoasClasse;
namespace pessoa
{
    class program
    {
        static void Main(string[] args)
        {
            // Variáveis para armazenar os dados
            string name;
            int idade;
            string cpf;
            string cnpj;
            // Variáveis para controle de fluxo
            int resposta;
            bool sair = false;
            //Instanciando as variáveis de controle
            List<people> RepositorioF = new List<people>();
            List<Pjuridica> RepositorioJ = new List<Pjuridica>();
            while (sair != true)
            {
                Console.WriteLine("---------------------REGISTRO----------------------");
                Console.WriteLine("[1]Cadastrar [2]Listar [3]Editar [4]Excluir [5]Sair");
                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Pessoa Física ou Jurídica:");
                        string categoriaFJ = Console.ReadLine();

                        Console.WriteLine("Quantidade de Registros:");
                        resposta = int.Parse(Console.ReadLine());

                        Console.Clear();

                        if (categoriaFJ.ToLower() == "jurídica")
                        {
                            for (int i = 0; i < resposta; i++)
                            {
                                Console.WriteLine("Razão Social:");
                                name = Console.ReadLine();
                                Console.WriteLine("Anos de Existência:");
                                idade = int.Parse(Console.ReadLine());
                                Console.WriteLine("CNPJ:");
                                cnpj = Console.ReadLine();
                                int cnpjCount = cnpj.Length;
                                if (cnpjCount != 14)
                                {
                                    Console.WriteLine("\nCNPJ inválido.\nDeve conter 14 dígitos.\n");
                                    i--; // Decrementa o contador para tentar novamente
                                    continue; // Pula para a próxima iteração do loop
                                }
                                RepositorioJ.Add(new Pjuridica(cnpj, name, idade));
                                Console.Clear();
                            }
                        }
                        else if (categoriaFJ.ToLower() == "física")
                        {
                            for (int i = 0; i < resposta; i++)
                            {
                                Console.WriteLine("Nome completo:");
                                name = Console.ReadLine();
                                Console.WriteLine("Idade:");
                                try
                                {
                                    idade = int.Parse(Console.ReadLine());
                                    Console.WriteLine("CPF:");

                                    cpf = Console.ReadLine();
                                    int cpfCount = cpf.Length;
                                    if (cpfCount != 11)
                                    {
                                        Console.WriteLine("\nCPF inválido.\nDeve conter 11 dígitos.\n");
                                        i--; // Decrementa o contador para tentar novamente
                                        continue; // Pula para a próxima iteração do loop
                                    }
                                    RepositorioF.Add(new people(name, idade, cpf));
                                    Console.Clear();
                                }
                                catch (FormatException fe)
                                {
                                    Console.WriteLine("Deve ser inserido apenas números");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Categoria inválida. Por favor, insira 'jurídica' ou 'física'.\n");
                        }
                        break;
                    case 2:
                        if (RepositorioJ.Count != 0) // Verifica se a lista de pessoas jurídicas está vazia
                        {
                            Console.WriteLine("Pessoas Jurídicas\n");
                            foreach (var juridicPerson in RepositorioJ)
                            {
                                juridicPerson.exibirDados(); // Exibe os dados da pessoa jurídica
                                Console.WriteLine("\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nenhuma pessoa jurídica cadastrada.\n");
                        }
                        if (RepositorioF.Count != 0) // Verifica se a lista de pessoas fisicas está vazia
                        {
                            Console.WriteLine("Pessoas Físicas\n");
                            foreach (var person in RepositorioF)
                            {
                                person.exibirDados();// Exibe os dados da pessoa física
                                Console.WriteLine("\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nenhuma pessoa física cadastrada.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Deseja editar o registro de uma pessoa Física ou Jurídica:");
                        categoriaFJ = Console.ReadLine();
                        if (categoriaFJ.ToLower() == "jurídica")
                        {
                            Console.WriteLine("CNPJ:");
                            string buscaPessoaFJ = Console.ReadLine();
                            foreach (var busca in RepositorioJ)
                            {
                                if (busca.Cnpj == buscaPessoaFJ)
                                {
                                    Console.WriteLine("Nome:");
                                    busca.Name = name = Console.ReadLine();
                                    Console.WriteLine("Tempo de Existencia:");
                                    busca.Idade = idade = int.Parse(Console.ReadLine());
                                    Console.WriteLine("CNPJ:");
                                    busca.Cnpj = cnpj = Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("CNPJ não encontrado.");
                                }
                            }
                        }
                        else if (categoriaFJ.ToLower() == "física")
                        {
                            Console.WriteLine("CPF:");
                            string buscaPessoaFJ = Console.ReadLine();
                            foreach (var busca in RepositorioF)
                            {
                                if (busca.Cpf == buscaPessoaFJ)
                                {
                                    Console.WriteLine("Nome:");
                                    busca.Name = name = Console.ReadLine();
                                    Console.WriteLine("Idade:");
                                    busca.Idade = idade = int.Parse(Console.ReadLine());
                                    Console.WriteLine("CPF:");
                                    busca.Cpf = cpf = Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("CPF não encontrado.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Categoria inválida. Por favor, insira 'jurídica' ou 'física'.\n");
                        }
                        break;
                    case 4:
                        Console.WriteLine("CPF ou CNPJ");
                        string buscaPessoa = Console.ReadLine();
                        if (buscaPessoa == "cpf")
                        {
                            Console.WriteLine("CPF:");
                            cpf = Console.ReadLine();
                            foreach (var buscaPessoaF in RepositorioF)
                            {
                                if (buscaPessoaF.Cpf == cpf)
                                {
                                    RepositorioF.Remove(buscaPessoaF);
                                    Console.WriteLine("Removido com sucesso.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("CPF não encontrado.");
                                }
                            }
                        }
                        else if (buscaPessoa == "cnpj")
                        {
                            Console.WriteLine("CNPJ:");
                            cnpj = Console.ReadLine();
                            foreach (var buscaPessoaJ in RepositorioJ)
                            {
                                if (buscaPessoaJ.Cnpj == cnpj)
                                {
                                    RepositorioJ.Remove(buscaPessoaJ);
                                    Console.WriteLine("Removido com sucesso.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("CNPJ não encontrado.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Categoria inválida. Por favor, insira 'cpf' ou 'cnpj'.\n");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Encerrando...");
                        sair = true;
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}



