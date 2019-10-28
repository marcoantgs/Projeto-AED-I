using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projeto_Presidio
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Ver_arquivo();
        }  
                                                      
        static void Menu()
        {
            int resposta = 2;
            while (resposta == 2)
            {
                Console.WriteLine("_________________________________");
                Console.WriteLine();
                Console.WriteLine("Presídio de Xuri (Prison Control)");
                Console.WriteLine("_________________________________");
                Console.WriteLine();
                Console.WriteLine(">> Cadastrar Detentos:");
                Console.WriteLine();

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                while (!Presidiario.setNome(nome))
                {
                    Console.Write("ERRO! Nome inválido.");
                    Console.WriteLine("Por favor, tente novamente: ");
                    nome = Console.ReadLine();
                }
                Presidiario.setNome(nome);

                Console.Write("Número do CPF com 4 dígitos (ID do detento): ");
                int cpf = int.Parse(Console.ReadLine());
                while (!Presidiario.setcpf_preso(cpf))
                {
                    Console.Write("ERRO! Número do CPF inválido.");
                    Console.WriteLine("Por favor, tente novamente: ");
                    cpf = int.Parse(Console.ReadLine());
                }
                Presidiario.setcpf_preso(cpf);

                Console.Write("Data de nascimento (dd/MM/AAAA): ");
                string datanascimento = Console.ReadLine();
                while (!Data.setDat(datanascimento))
                {
                    Console.WriteLine("ERRO! Data de nascimento inválida.");
                    Console.Write("Por favor, tente novamente (dd/MM/AAAA): ");
                    datanascimento = Console.ReadLine();
                }
                Data nascimento = new Data(datanascimento);
                while (!Presidiario.setData_nascimento(nascimento))
                {
                    Console.WriteLine("ERRO! Data de nascimento inválida, o detento é menor de idade.");
                    Console.Write("Por favor, tente novamente: ");
                    datanascimento = Console.ReadLine();
                    nascimento = new Data(datanascimento);
                }
                Presidiario.setData_nascimento(nascimento);

                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine());
                while (!Presidiario.setIdade(idade))
                {
                    Console.WriteLine("ERRO! A idade não confere com a data de nascimento.");
                    Console.Write("Por favor, tente novamente: ");
                    idade = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Opções de crimes:");
                Console.WriteLine("Roubo, Assalto | Sequestro, Assassinato | Pedofilia, Feminicídio");
                Console.Write("Digite o crime cometido: ");
                string crime = Console.ReadLine();

                while (!Presidiario.setCrime(crime))
                {
                    Console.WriteLine("ERRO! Opção inválida. Roubo, Assalto | Sequestro, Assassinato | Pedofilia, Feminicídio");
                    Console.Write("Por favor, tente novamente: ");
                    crime = Console.ReadLine();
                }
                Presidiario.setCrime(crime);

                Console.Write("Data de entrada do detento (dd/MM/AAAA): ");
                string data1 = Console.ReadLine();
                while (!Data.setDat(data1))
                {
                    Console.WriteLine("ERRO! Data de entrada inválida.");
                    Console.Write("Por favor, tente novamente (dd/MM/AAAA): ");
                    data1 = Console.ReadLine();

                }
                Data data_entrada = new Data(data1);


                Console.Write("Data de saída do detento (dd/MM/AAAA): ");
                string data2 = Console.ReadLine();
                while (!Data.setDat(data2))
                {
                    Console.WriteLine("ERRO! Data de entrada inválida.");
                    Console.Write("Por favor, tente novamente (dd/MM/AAAA): ");
                    data2 = Console.ReadLine();
                }
                Data data_saida = new Data(data2);
                while (data_saida.Maior(data_entrada) == false)
                {
                    Console.WriteLine("ERRO! Data de saída inválida.");
                    Console.Write("Por favor, tente novamente (dd/MM/AAAA): ");
                    data2 = Console.ReadLine();
                    data_saida = new Data(data2);
                    while (!Data.setDat(data2))
                    {
                        Console.WriteLine("ERRO! Data de saída inválida.");
                        Console.Write("Por favor, tente novamente (dd/MM/AAAA): ");
                        data2 = Console.ReadLine();
                    }
                }
                Pena Periodo = new Pena(data_entrada, data_saida);
                Presidiario.setTempo_reclusao(Periodo);

                List<Presidiario> cela01 = new List<Presidiario>();
                List<Presidiario> cela02 = new List<Presidiario>();
                List<Presidiario> cela03 = new List<Presidiario>();

                switch (Presidiario.getCrime())
                {
                    case "Roubo":
                    case "Assalto":
                        cela01.Add(new Presidiario());
                        break;
                    case "Sequestro":
                    case "Assassinato":
                        cela02.Add(new Presidiario());
                        break;
                    case "Pedofilia":
                    case "Feminicídio":
                        cela03.Add(new Presidiario());
                        break;
                    default:
                        break;

                }

                Presidio Xuri2 = new Presidio(cela01, cela02, cela03);
                Presidio.Cadastrar_presos();
                Console.WriteLine("Cadastrar novo preso? (1 - Não | 2 - Sim):");
                resposta = int.Parse(Console.ReadLine());
            }
        }

        static void Ver_arquivo()
        {
            Console.WriteLine("Ver arquivo? (1 - Sim | 2 - Não):");
            int num = int.Parse(Console.ReadLine());
            while (num == 1)
            {
                Console.WriteLine("Digite o número da cela que queira ver:");
                Console.WriteLine("1 - Cela1 | 2 - Cela2 | 3 - Cela3 | 4 - Sair | 5 - Menu cadastro:");
                int num1 = int.Parse(Console.ReadLine());
                if (num1 == 1 || num1 == 2 || num1 == 3)
                {
                    Presidio.Ver_Cela(num1);

                }
                else if (num1 == 4)
                {
                    num = 2;
                    
                }
                else if (num1 == 5)
                {
                    Menu();
                }
                else
                {
                    Console.WriteLine("ERRO! Opção inválida. Por favor, tente novamente:");
                    Console.WriteLine("Digite 1 - Cela1 | 2 - Cela2 | 3 - Cela3 | 4 - Sair | 5 - Menu cadastro");
                    num1 = int.Parse(Console.ReadLine());
                }
            }
            if (num == 2)
            {
                Console.WriteLine("Sistema finalizado!");
            }
            else
            {
                Console.WriteLine("ERRO! Opção inválida. Por favor, tente novamente:");
                Console.WriteLine("1 - Sim | 2 - Sair");
                num = int.Parse(Console.ReadLine());
            }
        }

    }
}






    

          
 

      
   

