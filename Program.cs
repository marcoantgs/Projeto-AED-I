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

        }

        public static void Cadastro()
        {

            List<Presidiario> cela01 = new List<Presidiario>();
            List<Presidiario> cela02 = new List<Presidiario>();
            List<Presidiario> cela03 = new List<Presidiario>();

            Cela PP1 = new Cela();
            Cela PP2 = new Cela();
            Cela PP3 = new Cela();

            Presidio Xuri2 = new Presidio(PP1, PP2, PP3);

            Presidiario P1 = new Presidiario();
           
            int resposta = 2;
            while (resposta == 2)
            {
                Console.WriteLine("Opções de crimes:");
                Console.WriteLine(" 1 - Simples | 2 - Qualificado | 3 - Hediondo");
                Console.Write("Digite o crime cometido: ");
                int crime = int.Parse(Console.ReadLine());

                while (!P1.setCrime(crime))
                {
                    Console.WriteLine("ERRO! Opção inválida: 1 - Crime Simples | 2 - Qualificado | 3 - Hediondo");
                    Console.Write("Por favor, tente novamente: ");
                    crime = int.Parse(Console.ReadLine());
                }
                P1.setCrime(crime);

                if (P1.getCrime() == 1)
                {
                    while (!PP1.Verifica_cela1())
                    {
                        Console.WriteLine(" A cela esta cheia");
                        Console.WriteLine(" Aperte 1 - Menu principal | 2 - Sair");
                        resposta = int.Parse(Console.ReadLine());
                        if (resposta == 1)
                        {
                            Menu();
                        }
                        else
                        {
                            Console.WriteLine(" Sistema finalizado ");
                            break;

                        }
                    }
                }

                if (P1.getCrime() == 2)
                {
                    while (!PP1.Verifica_cela2())
                    {
                        Console.WriteLine(" A cela esta cheia");
                        Console.WriteLine(" Aperte 1 - Menu principal | 2 - Sair");
                        resposta = int.Parse(Console.ReadLine());
                        if (resposta == 1)
                        {
                            Menu();
                        }
                        else
                        {
                            Console.WriteLine(" Sistema finalizado ");
                            break;
                        }
                    }
                }

                if (P1.getCrime() == 3)
                {
                    while (!PP1.Verifica_cela3())
                    {
                        Console.WriteLine(" A cela esta cheia");
                        Console.WriteLine(" 1 - Menu principal | 2 - Sair");
                        resposta = int.Parse(Console.ReadLine());
                        if (resposta == 1)
                        {
                            Menu();
                        }
                        else
                        {
                            Console.WriteLine(" Sistema finalizado ");
                            break;
                        }
                    }
                }

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                while (!P1.setNome(nome))
                {
                    Console.Write("ERRO! Nome inválido.");
                    Console.WriteLine("Por favor, tente novamente: ");
                    nome = Console.ReadLine();
                }
                P1.setNome(nome);

                Console.Write("Número ID do detento, com 4 digitos): ");
                string cpf = Console.ReadLine();
                while (!P1.verificacpf_preso(cpf))
                {
                    Console.Write("ERRO! ID ja existente.");
                    Console.WriteLine("Por favor, tente novamente: ");
                    cpf = Console.ReadLine();
                }
                P1.verificacpf_preso(cpf);
                Data dat = new Data();
                Console.Write("Data de nascimento (dd/MM/AAAA): ");
                string datanascimento = Console.ReadLine();
                while (!dat.setData(datanascimento))
                {
                    Console.WriteLine("ERRO! Data de nascimento inválida.");
                    Console.Write("Por favor, tente novamente (dd/MM/AAAA): ");
                    datanascimento = Console.ReadLine();
                }
                Data nascimento = new Data(datanascimento);
                while (!P1.setData_nascimento(nascimento))
                {
                    Console.WriteLine("ERRO! Data de nascimento inválida, o detento é menor de idade.");
                    Console.Write("Por favor, tente novamente: ");
                    datanascimento = Console.ReadLine();
                    nascimento = new Data(datanascimento);
                }
                P1.setData_nascimento(nascimento);


                if (P1.getCrime() == 1)
                {
                    P1.setPeriodoReclusao(15);

                    cela01.Add(P1);

                }

                if (P1.getCrime() == 2)
                {
                    P1.setPeriodoReclusao(20);
                    cela02.Add(P1);

                }

                if (P1.getCrime() == 3)
                {
                    P1.setPeriodoReclusao(30);
                    cela03.Add(P1);
                }
                                                            
                PP1.set_preso(cela01);
                PP2.set_preso(cela02);
                PP3.set_preso(cela03);

               

                Xuri2.Cadastrar_presos();

                Console.WriteLine("Cadastrar novo preso? (1 - Sair | 2 - Sim | 3 - Menu principal):");
                resposta = int.Parse(Console.ReadLine());
                if (resposta == 3)
                {
                    Menu();
                }

            }

            foreach (var i in cela01)
            {
                Console.WriteLine(i);
            }

        }

        public static void Ver_arquivo()
        {
            int num = 1;
            while (num == 1)
            {
                Console.WriteLine("Digite o número da cela que queira ver:");
                Console.WriteLine("1 - Cela1 | 2 - Cela2 | 3 - Cela3 | 4 - Sair | 5 - Menu Principal:");
                int num1 = int.Parse(Console.ReadLine());
                if (num1 == 1 || num1 == 2 || num1 == 3)
                {
                    Presidio.Ver_Cela(num1);

                }
                else if (num1 == 4)
                {
                    Console.WriteLine("Sistema finalizado!");
                    break;

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
        }
        public static void Menu()
        {
            Console.WriteLine("_________________________________");
            Console.WriteLine();
            Console.WriteLine("Presídio de Xuri (Prison Control)");
            Console.WriteLine("_________________________________");
            Console.WriteLine();
            Console.WriteLine(">> Digite a opção desejada:");
            Console.WriteLine();
            Console.WriteLine(" 1 - Ver relatorios de cela, 2 - Cadastrar preso, 3 - Gerenciar Presos, 4 - Gerenciar Carcereiros, 5 - Sair ");
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                Ver_arquivo();
            }
            if (num == 2)
            {
                Cadastro();
            }
            if (num == 3)
            {
                CPresos();
            }

        }

        static void CPresos()
        {
           
            Presidio xuri4 = new Presidio();
            Console.WriteLine(" Digite o numero da cela: 1 - Crimes Simples, 2 - Crimes Qualificados, 3 - Crimes Hediondos");
            int cr = int.Parse(Console.ReadLine());

            if(cr == 1)
            {
                xuri4.Gerenciar1();
            }
            else if (cr == 2)
            {
                xuri4.Gerenciar2();
            }

            else if (cr == 3)
            {
                xuri4.Gerenciar3();
            }

            Console.WriteLine(" Digite: 1 - Menu principal / 2 - Sair");
            int numer = int.Parse(Console.ReadLine());

            if(numer == 1)
            {
                Menu();
            }
            else if (numer == 2)
            {
                Console.WriteLine("Sistema finalizado");
            }
           
        }


   
    }
}
