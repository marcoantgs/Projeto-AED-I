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
            int resposta = 2;
            while (resposta == 2)
            {
                
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Cadastrar presos:");
                Console.WriteLine();

                Console.Write("Nome:");
                string nome = Console.ReadLine();
                while (!Presidiario.setNome(nome))
                {
                    Console.Write("Nome invalido digite novamente:");
                    nome = Console.ReadLine();
                }


                Presidiario.setNome(nome);

                Console.Write("Idade:");
                int idade = int.Parse(Console.ReadLine());
                while (!Presidiario.setIdade(idade))
                {
                    Console.Write("Idade inferior a 18 anos, digite novamente:");
                     idade = int.Parse(Console.ReadLine());
                }
               

                Console.Write(" Data nascimento: ");
                string datanascimento = Console.ReadLine();

                Data nascimento = new Data(datanascimento);
                Presidiario.Data_nascimento(nascimento);

                Console.Write("Crime:");
                string crime = Console.ReadLine();
                Presidiario.setCrime(crime);

                Console.Write("Data de entrada:");
                string data = Console.ReadLine();

                Data d = new Data(data);

                Console.Write("Data de saida:");
                string data1 = Console.ReadLine();

                Data d1 = new Data(data1);


                Pena p1 = new Pena(d, d1);
                Presidiario.setTempo_reclusao(p1);

                Console.Write("Numeração do preso:");
                int numero = int.Parse(Console.ReadLine());
                Presidiario.setNum_preso(numero);

                List<Presidiario> cela01 = new List<Presidiario>();
                List<Presidiario> cela02 = new List<Presidiario>();
                List<Presidiario> cela03 = new List<Presidiario>();

                if (Presidiario.getCrime() == "Roubo")
                {
                    cela01.Add(new Presidiario());
                }

                else if (Presidiario.getCrime() == "Asasinato")
                {
                    cela02.Add(new Presidiario());
                }

                else if (Presidiario.getCrime() == "Estupro")
                {
                    cela03.Add(new Presidiario());
                }

                Presidio Cela1 = new Presidio(cela01, cela02, cela03);
                Presidio.Cadastrar_presos();


                Console.WriteLine(" Cadastrar novo preso? 1 - Não / 2 - Sim");
                resposta = int.Parse(Console.ReadLine());

                if (resposta == 1)
                {
                    
                    break;

                }

            }

            Console.WriteLine(" Ver arquivo? Digite 1 - Cela1, 2 - Cela2, 3 - Cela3");
            int num = int.Parse(Console.ReadLine());
            Presidio.Ver_Cela(num);

            



        }


           

           

                  

                      
                      


    }      

       

        

    
}
