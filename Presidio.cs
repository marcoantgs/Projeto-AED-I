using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projeto_Presidio
{
    class Presidio
    {
        private Cela Pres1;
        private Cela Pres2;
        private Cela Pres3;



        public Presidio(Cela pres1, Cela pres2, Cela pres3)
        {
            Pres1 = pres1;
            Pres2 = pres2;
            Pres3 = pres3;

        }

        public Presidio()
        {

        }
                       
        public void Gerenciar1()
        {
            List<Presidiario> TodosPresos = new List<Presidiario>();
            Data t = new Data();
            string[] ListaP = File.ReadAllLines("../../Simples.txt");
            for (int i = 0; i < ListaP.Length; i++)
            {
                Presidiario P22 = new Presidiario();
                string[] aux = ListaP[i].Split('|');
                P22.setNome(aux[0]);
                t.setData(aux[1]);
                P22.setData_nascimento(t);
                P22.setIdade(Convert.ToInt32(aux[2]));
                P22.setCpf_preso(aux[3]);
                P22.setPeriodoReclusao(Convert.ToInt32(aux[4]));

                TodosPresos.Add(P22);

            }

            foreach (var list in TodosPresos)
            {
                Console.WriteLine(list);
            }

            Console.WriteLine();
            Console.WriteLine("Digite o ID do preso");
            string id = Console.ReadLine();
            Presidiario P1;
            P1 = TodosPresos.Find(y => y.getcpf_preso().Contains(id));

            Console.WriteLine(P1);

            Console.WriteLine(" Digite 1 - Acrescentar anos; 2 - Diminuir anos ");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 == 1)
            {
                Console.WriteLine(" Qual motivo? 1 - Brigas; 2 - Tentativa de fuga");
                int num2 = int.Parse(Console.ReadLine());

                if (num2 == 1)
                {

                    if (P1.getPeriodoReclusao() >= 10 && P1.getPeriodoReclusao() <= 60)
                    {
                        int aux = P1.getPeriodoReclusao() + 1;
                        P1.setPeriodoReclusao(aux);
                       

                    }

                }
                else if (num2 == 2)
                {
                    if (P1.getPeriodoReclusao() >= 10 && P1.getPeriodoReclusao() <= 60)
                    {
                        int aux = P1.getPeriodoReclusao() + 2;
                        P1.setPeriodoReclusao(aux);
                      
                    }
                  
                }
                Console.WriteLine(P1);
                AcrescetarLista1(TodosPresos);

            }
            else if (num1 == 2)
            {
                Console.WriteLine(" Qual motivo? 1 - Terminou ensino medio; 2 - Completou 2 anos de trabalho");
                int num3 = int.Parse(Console.ReadLine());

                if (num3 == 1)
                {
                    if (P1.getPeriodoReclusao() >= 10 && P1.getPeriodoReclusao() <= 60)
                    {
                        int aux1 = P1.getPeriodoReclusao() - 1;
                        P1.setPeriodoReclusao(aux1);

                    }
                   
                }
                else if (num3 == 2)
                {
                    if (P1.getPeriodoReclusao() >= 10 && P1.getPeriodoReclusao() <= 60)
                    {
                        int aux1 = P1.getPeriodoReclusao() - 2;
                        P1.setPeriodoReclusao(aux1);

                    }
                   
                }
                Console.WriteLine(P1);
                AcrescetarLista1(TodosPresos);
            }
        }
        public void Gerenciar2()
        {
            List<Presidiario> TodosPresos = new List<Presidiario>();
            Data t = new Data();
            string[] ListaP = File.ReadAllLines("../../Qualificado.txt");
            for (int i = 0; i < ListaP.Length; i++)
            {
                Presidiario P22 = new Presidiario();
                string[] aux = ListaP[i].Split('|');
                P22.setNome(aux[0]);
                t.setData(aux[1]);
                P22.setData_nascimento(t);
                P22.setIdade(Convert.ToInt32(aux[2]));
                P22.setCpf_preso(aux[3]);
                P22.setPeriodoReclusao(Convert.ToInt32(aux[4]));

                TodosPresos.Add(P22);

            }
            foreach (var lista in TodosPresos)
            {
                Console.WriteLine(lista);
            }
            Console.WriteLine("Digite o ID do preso");
            string id = Console.ReadLine();
            Presidiario P1;
            P1 = TodosPresos.Find(y => y.getcpf_preso().Contains(id));

            Console.WriteLine(P1);

            Console.WriteLine(" Digite 1 - Acrescentar anos; 2 - Diminuir anos ");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 == 1)
            {
                Console.WriteLine(" Qual motivo? 1 - Brigas; 2 - Tentativa de fuga");
                int num2 = int.Parse(Console.ReadLine());

                if (num2 == 1)
                {

                    if (P1.getPeriodoReclusao() >= 10 && P1.getPeriodoReclusao() <= 60)
                    {
                        int aux = P1.getPeriodoReclusao() + 1;
                        P1.setPeriodoReclusao(aux);

                    }
                  
                }
                else if (num2 == 2)
                {
                    if (P1.getPeriodoReclusao() >= 10 && P1.getPeriodoReclusao() <= 60)
                    {
                        int aux = P1.getPeriodoReclusao() + 2;
                        P1.setPeriodoReclusao(aux);

                    }
                   
                }
                Console.WriteLine(P1);
                AcrescetarLista2(TodosPresos);
            }
            else if (num1 == 2)
            {
                Console.WriteLine(" Qual motivo? 1 - Terminou ensino medio; 2 - Completou 2 anos de trabalho");
                int num3 = int.Parse(Console.ReadLine());

                if (num3 == 1)
                {
                    if (P1.getPeriodoReclusao() >= 10 && P1.getPeriodoReclusao() <= 60)
                    {
                        int aux1 = P1.getPeriodoReclusao() - 1;
                        P1.setPeriodoReclusao(aux1);

                    }
                   
                }
                else if (num3 == 2)
                {
                    if (P1.getPeriodoReclusao() >= 10 && P1.getPeriodoReclusao() <= 60)
                    {
                        int aux1 = P1.getPeriodoReclusao() - 2;
                        P1.setPeriodoReclusao(aux1);

                    }
                    
                }
                Console.WriteLine(P1);
                AcrescetarLista2(TodosPresos);
            }
        }

        public void Gerenciar3()
        {
            List<Presidiario> TodosPresos = new List<Presidiario>();

            Data t = new Data();
            string[] ListaP = File.ReadAllLines("../../Hediondo.txt");
            for (int i = 0; i < ListaP.Length; i++)
            {
                Presidiario P22 = new Presidiario();
                string[] aux = ListaP[i].Split('|');
                P22.setNome(aux[0]);
                t.setData(aux[1]);
                P22.setData_nascimento(t);
                P22.setIdade(Convert.ToInt32(aux[2]));
                P22.setCpf_preso(aux[3]);
                P22.setPeriodoReclusao(Convert.ToInt32(aux[4]));

                TodosPresos.Add(P22);

            }
            foreach (var lista in TodosPresos)
            {
                Console.WriteLine(lista);
            }
            Console.WriteLine("Digite o ID do preso");
            string id = Console.ReadLine();
            Presidiario P1;
            P1 = TodosPresos.Find(y => y.getcpf_preso().Contains(id));

            Console.WriteLine(P1);

            Console.WriteLine(" Digite 1 - Acrescentar anos; 2 - Diminuir anos ");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 == 1)
            {
                Console.WriteLine(" Qual motivo? 1 - Brigas; 2 - Tentativa de fuga");
                int num2 = int.Parse(Console.ReadLine());

                if (num2 == 1)
                {

                    if (P1.getPeriodoReclusao() >= 10 && P1.getPeriodoReclusao() <= 60)
                    {
                        int aux = P1.getPeriodoReclusao() + 1;
                        P1.setPeriodoReclusao(aux);

                    }
                   
                }
                else if (num2 == 2)
                {
                    if (P1.getPeriodoReclusao() >= 10 && P1.getPeriodoReclusao() <= 60)
                    {
                        int aux = P1.getPeriodoReclusao() + 2;
                        P1.setPeriodoReclusao(aux);

                    }
                 
                }
                Console.WriteLine(P1);
                AcrescetarLista3(TodosPresos);
            }
            else if (num1 == 2)
            {
                Console.WriteLine(" Qual motivo? 1 - Terminou ensino medio; 2 - Completou 2 anos de trabalho");
                int num3 = int.Parse(Console.ReadLine());

                if (num3 == 1)
                {
                    if (P1.getPeriodoReclusao() >= 10 && P1.getPeriodoReclusao() <= 60)
                    {
                        int aux1 = P1.getPeriodoReclusao() - 1;
                        P1.setPeriodoReclusao(aux1);

                    }
                    
                }
                else if (num3 == 2)
                {
                    if (P1.getPeriodoReclusao() >= 10 && P1.getPeriodoReclusao() <= 60)
                    {
                        int aux1 = P1.getPeriodoReclusao() - 2;
                        P1.setPeriodoReclusao(aux1);

                    }
                   
                }
                Console.WriteLine(P1);
                AcrescetarLista3(TodosPresos);
            }
        }
                                 
        public void AcrescetarLista1(List<Presidiario> det)
        {
            FileStream Arq1 = new FileStream("../../Simples.txt", FileMode.Open, FileAccess.Write);
            StreamWriter sw1 = new StreamWriter(Arq1, Encoding.UTF8);

            foreach (Presidiario lista in det)
            {
                sw1.WriteLine(lista);
            }


            sw1.Close();
            Arq1.Close();
        }
        public void AcrescetarLista2(List<Presidiario> det)
        {
            FileStream Arq1 = new FileStream("../../Qualificado.txt", FileMode.Open, FileAccess.Write);
            StreamWriter sw1 = new StreamWriter(Arq1, Encoding.UTF8);

            foreach (Presidiario lista in det)
            {
                sw1.WriteLine(lista);
            }


            sw1.Close();
            Arq1.Close();
        }
        public void AcrescetarLista3(List<Presidiario> det)
        {
            FileStream Arq1 = new FileStream("../../Hediondo.txt", FileMode.Open, FileAccess.Write);
            StreamWriter sw1 = new StreamWriter(Arq1, Encoding.UTF8);

            foreach (Presidiario lista in det)
            {
                sw1.WriteLine(lista);
            }


            sw1.Close();
            Arq1.Close();
        }

        public void Cadastrar_presos()
        {
            FileStream Arq1 = new FileStream("../../Simples.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw1 = new StreamWriter(Arq1, Encoding.UTF8);

            sw1.WriteLine(Pres1);

            sw1.Close();
            Arq1.Close();

            FileStream Arq2 = new FileStream("../../Qualificado.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw2 = new StreamWriter(Arq2, Encoding.UTF8);

            sw2.WriteLine(Pres2);

            sw2.Close();
            Arq2.Close();

            FileStream Arq3 = new FileStream("../../Hediondo.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw3 = new StreamWriter(Arq3, Encoding.UTF8);

            sw3.WriteLine(Pres3);

            sw3.Close();
            Arq3.Close();
        }

        public static void Ver_Cela(int num)
        {
            if (num == 1)
            {
                List<Presidiario> TodosPresos = new List<Presidiario>();

                Data t = new Data();
                string[] ListaP = File.ReadAllLines("../../Simples.txt");
                for (int i = 0; i < ListaP.Length; i++)
                {
                    Presidiario P22 = new Presidiario();
                    string[] aux = ListaP[i].Split('|');
                    P22.setNome(aux[0]);
                    t.setData(aux[1]);
                    P22.setData_nascimento(t);
                    P22.setIdade(Convert.ToInt32(aux[2]));
                    P22.setCpf_preso(aux[3]);
                    P22.setPeriodoReclusao(Convert.ToInt32(aux[4]));

                    TodosPresos.Add(P22);

                }
                foreach (var lista in TodosPresos)
                {
                    Console.WriteLine(lista.Trasformar());
                }

            }

            if (num == 2)
            {
                List<Presidiario> TodosPresos = new List<Presidiario>();

                Data t = new Data();
                string[] ListaP = File.ReadAllLines("../../Qualificado.txt");
                for (int i = 0; i < ListaP.Length; i++)
                {
                    Presidiario P22 = new Presidiario();
                    string[] aux = ListaP[i].Split('|');
                    P22.setNome(aux[0]);
                    t.setData(aux[1]);
                    P22.setData_nascimento(t);
                    P22.setIdade(Convert.ToInt32(aux[2]));
                    P22.setCpf_preso(aux[3]);
                    P22.setPeriodoReclusao(Convert.ToInt32(aux[4]));

                    TodosPresos.Add(P22);

                }
                foreach (var lista in TodosPresos)
                {
                    Console.WriteLine(lista.Trasformar());
                }

            }

            if (num == 3)
            {
                List<Presidiario> TodosPresos = new List<Presidiario>();

                Data t = new Data();
                string[] ListaP = File.ReadAllLines("../../Hediondo.txt");
                for (int i = 0; i < ListaP.Length; i++)
                {
                    Presidiario P22 = new Presidiario();
                    string[] aux = ListaP[i].Split('|');
                    P22.setNome(aux[0]);
                    t.setData(aux[1]);
                    P22.setData_nascimento(t);
                    P22.setIdade(Convert.ToInt32(aux[2]));
                    P22.setCpf_preso(aux[3]);
                    P22.setPeriodoReclusao(Convert.ToInt32(aux[4]));

                    TodosPresos.Add(P22);

                }
                foreach (var lista in TodosPresos)
                {
                    Console.WriteLine(lista.Trasformar());
                }

            }
        }
                    
       
    }
}
