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
        private List<Carcereiro> Car1 = new List<Carcereiro>();

        public Presidio()
        {

        }

        public Presidio(Cela pres1, Cela pres2, Cela pres3)
        {
            Pres1 = pres1;
            Pres2 = pres2;
            Pres3 = pres3;
        }

        public List<Carcereiro> getCarcereiros()
        {
            return Car1;
        }

        public void setCarcereiros(List<Carcereiro> c)
        {
            Car1 = c;

        }

        public void GerenciarCelaMasculina1()
        {
            List<Presidiario> TodosPresos = new List<Presidiario>();
            Data t = new Data();
            string[] ListaP = File.ReadAllLines("../../MasculinaSimples.txt");
            for (int i = 0; i < ListaP.Length; i++)
            {
                Presidiario P22 = new Presidiario();
                string[] aux = ListaP[i].Split('|');
                P22.setNome(aux[0]);
                t.setData(aux[1]);
                P22.setDataDeNascimento(t);
                P22.setIdade(Convert.ToInt32(aux[2]));
                P22.setId(aux[3]);
                P22.setPeriodoDeReclusao(Convert.ToInt32(aux[4]));
                TodosPresos.Add(P22);
            }
            Console.WriteLine();
            foreach (var list in TodosPresos)
            {
                Console.WriteLine(list.Trasformar());
            }

            Console.WriteLine();
            Console.Write("> Digite o ID do preso: ");
            string id = Console.ReadLine();

            Presidiario P1;
            P1 = TodosPresos.Find(y => y.getId().Contains(id));

            Console.WriteLine();

            Console.WriteLine("| 1 - Acrescentar anos de reclusão; 2 - Reduzir anos de reclusão;" +
                               " 3 - Preso Transferido retira-lo do sistema |");
            Console.WriteLine();
            Console.Write("> Digite a opção desejada: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (num1 == 1)
            {
                Console.WriteLine("Qual o motivo?");
                Console.WriteLine("| 1 - Brigas frequentes; 2 - Tentativas de fuga |");
                Console.Write("> Digite a opção desejada: ");
                int num2 = int.Parse(Console.ReadLine());

                if (num2 == 1)
                {

                    if (P1.getPeriodoDeReclusao() >= 10 && P1.getPeriodoDeReclusao() <= 60)
                    {
                        int aux = P1.getPeriodoDeReclusao() + 1;
                        P1.setPeriodoDeReclusao(aux);
                    }
                }
                else if (num2 == 2)
                {
                    if (P1.getPeriodoDeReclusao() >= 10 && P1.getPeriodoDeReclusao() <= 60)
                    {
                        int aux = P1.getPeriodoDeReclusao() + 2;
                        P1.setPeriodoDeReclusao(aux);
                    }
                }
                Console.WriteLine(P1);
                AtualizarCelaMasculina1(TodosPresos);
            }
            else if (num1 == 2)
            {
                Console.WriteLine("Qual o motivo?");
                Console.WriteLine("1 - Terminou o ensino médio; 2 - Completou 2 anos de trabalho |");
                Console.Write("> Digite a opção desejada: ");

                int num3 = int.Parse(Console.ReadLine());

                if (num3 == 1)
                {
                    if (P1.getPeriodoDeReclusao() >= 10 && P1.getPeriodoDeReclusao() <= 60)
                    {
                        int aux1 = P1.getPeriodoDeReclusao() - 1;
                        P1.setPeriodoDeReclusao(aux1);
                    }

                }
                else if (num3 == 2)
                {
                    if (P1.getPeriodoDeReclusao() >= 10 && P1.getPeriodoDeReclusao() <= 60)
                    {
                        int aux1 = P1.getPeriodoDeReclusao() - 2;
                        P1.setPeriodoDeReclusao(aux1);
                    }
                }
                Console.WriteLine(P1);
                AtualizarCelaMasculina1(TodosPresos);
            }

            else if (num1 == 3)
            {
                ArquivarPresoTransferido(P1);
                TodosPresos.Remove(P1);
                AtualizarCelaMasculina1(TodosPresos);
                Console.WriteLine(" Preso removido do sistema");

            }
        }
        public void GerenciarCelaMasculina2()
        {
            List<Presidiario> TodosPresos = new List<Presidiario>();
            Data t = new Data();
            string[] ListaP = File.ReadAllLines("../../MasculinaQualificado.txt");
            for (int i = 0; i < ListaP.Length; i++)
            {
                Presidiario P22 = new Presidiario();
                string[] aux = ListaP[i].Split('|');
                P22.setNome(aux[0]);
                t.setData(aux[1]);
                P22.setDataDeNascimento(t);
                P22.setIdade(Convert.ToInt32(aux[2]));
                P22.setId(aux[3]);
                P22.setPeriodoDeReclusao(Convert.ToInt32(aux[4]));
                TodosPresos.Add(P22);
            }

            foreach (var lista in TodosPresos)
            {
                Console.WriteLine(lista.Trasformar());
            }

            Console.WriteLine();
            Console.Write("> Digite o ID do preso: ");
            string id = Console.ReadLine();

            Presidiario P1;
            P1 = TodosPresos.Find(y => y.getId().Contains(id));

            Console.WriteLine();

            Console.WriteLine("| 1 - Acrescentar anos de reclusão; 2 - Reduzir anos de reclusão; +" +
                               " 3 - Preso Transferido retira-lo do sistema |");

            Console.WriteLine();
            Console.Write("> Digite a opção desejada: ");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 == 1)
            {
                Console.WriteLine("Qual o motivo?");
                Console.WriteLine("| 1 - Brigas frequentes; 2 - Tentativas de fuga |");
                Console.Write("> Digite a opção desejada: ");
                int num2 = int.Parse(Console.ReadLine());

                if (num2 == 1)
                {
                    if (P1.getPeriodoDeReclusao() >= 10 && P1.getPeriodoDeReclusao() <= 60)
                    {
                        int aux = P1.getPeriodoDeReclusao() + 1;
                        P1.setPeriodoDeReclusao(aux);
                    }
                }
                else if (num2 == 2)
                {
                    if (P1.getPeriodoDeReclusao() >= 10 && P1.getPeriodoDeReclusao() <= 60)
                    {
                        int aux = P1.getPeriodoDeReclusao() + 2;
                        P1.setPeriodoDeReclusao(aux);
                    }
                }
                Console.WriteLine(P1);
                AtualizarCelaMasculina2(TodosPresos);
            }
            else if (num1 == 2)
            {
                Console.WriteLine("Qual o motivo?");
                Console.WriteLine("1 - Terminou o ensino médio; 2 - Completou 2 anos de trabalho |");
                Console.Write("> Digite a opção desejada: ");
                int num3 = int.Parse(Console.ReadLine());

                if (num3 == 1)
                {
                    if (P1.getPeriodoDeReclusao() >= 10 && P1.getPeriodoDeReclusao() <= 60)
                    {
                        int aux1 = P1.getPeriodoDeReclusao() - 1;
                        P1.setPeriodoDeReclusao(aux1);
                    }

                }
                else if (num3 == 2)
                {
                    if (P1.getPeriodoDeReclusao() >= 10 && P1.getPeriodoDeReclusao() <= 60)
                    {
                        int aux1 = P1.getPeriodoDeReclusao() - 2;
                        P1.setPeriodoDeReclusao(aux1);
                    }
                }
                Console.WriteLine(P1);
                AtualizarCelaMasculina2(TodosPresos);
            }

            else if (num1 == 3)
            {
                ArquivarPresoTransferido(P1);
                TodosPresos.Remove(P1);
                AtualizarCelaMasculina2(TodosPresos);
                Console.WriteLine(" Preso removido do sistema");
            }
        }

        public void GerenciarCelaMasculina3()
        {
            List<Presidiario> TodosPresos = new List<Presidiario>();

            Data t = new Data();
            string[] ListaP = File.ReadAllLines("../../MasculinaHediondo.txt");
            for (int i = 0; i < ListaP.Length; i++)
            {
                Presidiario P22 = new Presidiario();
                string[] aux = ListaP[i].Split('|');
                P22.setNome(aux[0]);
                t.setData(aux[1]);
                P22.setDataDeNascimento(t);
                P22.setIdade(Convert.ToInt32(aux[2]));
                P22.setId(aux[3]);
                P22.setPeriodoDeReclusao(Convert.ToInt32(aux[4]));
                TodosPresos.Add(P22);
            }
            Console.WriteLine();
            foreach (var lista in TodosPresos)
            {
                Console.WriteLine(lista.Trasformar());
            }

            Console.WriteLine();
            Console.Write("> Digite o ID do preso: ");
            string id = Console.ReadLine();

            Presidiario P1;
            P1 = TodosPresos.Find(y => y.getId().Contains(id));

            Console.WriteLine();

            Console.WriteLine("| 1 - Acrescentar anos de reclusão; 2 - Reduzir anos de reclusão; " +
                               " 3 - Preso Transferido, retira-lo do sistema |");
            Console.WriteLine();
            Console.Write("> Digite a opção desejada: ");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 == 1)
            {
                Console.WriteLine("Qual o motivo?");
                Console.WriteLine("| 1 - Brigas frequentes; 2 - Tentativas de fuga |");
                Console.Write("> Digite a opção desejada: ");
                int num2 = int.Parse(Console.ReadLine());

                if (num2 == 1)
                {

                    if (P1.getPeriodoDeReclusao() >= 10 && P1.getPeriodoDeReclusao() <= 60)
                    {
                        int aux = P1.getPeriodoDeReclusao() + 1;
                        P1.setPeriodoDeReclusao(aux);
                    }
                }
                else if (num2 == 2)
                {
                    if (P1.getPeriodoDeReclusao() >= 10 && P1.getPeriodoDeReclusao() <= 60)
                    {
                        int aux = P1.getPeriodoDeReclusao() + 2;
                        P1.setPeriodoDeReclusao(aux);
                    }
                }
                Console.WriteLine(P1);
                AtualizarCelaMasculina3(TodosPresos);
            }
            else if (num1 == 2)
            {
                Console.WriteLine("Qual o motivo?");
                Console.WriteLine("1 - Terminou o ensino médio; 2 - Completou 2 anos de trabalho |");
                Console.Write("> Digite a opção desejada: ");
                int num3 = int.Parse(Console.ReadLine());

                if (num3 == 1)
                {
                    if (P1.getPeriodoDeReclusao() >= 10 && P1.getPeriodoDeReclusao() <= 60)
                    {
                        int aux1 = P1.getPeriodoDeReclusao() - 1;
                        P1.setPeriodoDeReclusao(aux1);
                    }
                }
                else if (num3 == 2)
                {
                    if (P1.getPeriodoDeReclusao() >= 10 && P1.getPeriodoDeReclusao() <= 60)
                    {
                        int aux1 = P1.getPeriodoDeReclusao() - 2;
                        P1.setPeriodoDeReclusao(aux1);
                    }
                }
                Console.WriteLine(P1);
                AtualizarCelaMasculina3(TodosPresos);
            }

            else if (num1 == 3)
            {
                ArquivarPresoTransferido(P1);
                TodosPresos.Remove(P1);
                AtualizarCelaMasculina3(TodosPresos);
                Console.WriteLine(" Preso removido do sistema");
            }


        }

        public void AtualizarCelaMasculina1(List<Presidiario> det)
        {
            FileStream Arq1 = new FileStream("../../MasculinaSimples.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw1 = new StreamWriter(Arq1, Encoding.UTF8);

            foreach (Presidiario lista in det)
            {
                sw1.WriteLine(lista);
            }

            sw1.Close();
            Arq1.Close();
        }

        public void AtualizarCelaMasculina2(List<Presidiario> det)
        {
            FileStream Arq1 = new FileStream("../../MasculinaQualificado.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw1 = new StreamWriter(Arq1, Encoding.UTF8);

            foreach (Presidiario lista in det)
            {
                sw1.WriteLine(lista);
            }

            sw1.Close();
            Arq1.Close();
        }

        public void AtualizarCelaMasculina3(List<Presidiario> det)
        {
            FileStream Arq1 = new FileStream("../../MasculinaHediondo.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw1 = new StreamWriter(Arq1, Encoding.UTF8);

            foreach (Presidiario lista in det)
            {
                sw1.WriteLine(lista);
            }

            sw1.Close();
            Arq1.Close();
        }

        public void Cadastrar_presosMasculino1()
        {
            FileStream Arq1 = new FileStream("../../MasculinaSimples.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw1 = new StreamWriter(Arq1, Encoding.UTF8);

            sw1.WriteLine(Pres1);

            sw1.Close();
            Arq1.Close();
        }
        public void Cadastrar_presosMasculino2()
        {
            FileStream Arq2 = new FileStream("../../MasculinaQualificado.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw2 = new StreamWriter(Arq2, Encoding.UTF8);

            sw2.WriteLine(Pres2);

            sw2.Close();
            Arq2.Close();

        }
        public void Cadastrar_presosMasculino3()
        {
            FileStream Arq3 = new FileStream("../../MasculinaHediondo.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw3 = new StreamWriter(Arq3, Encoding.UTF8);

            sw3.WriteLine(Pres3);

            sw3.Close();
            Arq3.Close();
        }

        public static void Ver_CelaMasculina(int num)
        {
            if (num == 1)
            {
                List<Presidiario> TodosPresos = new List<Presidiario>();

                Data t = new Data();
                string[] ListaP = File.ReadAllLines("../../MasculinaSimples.txt");
                for (int i = 0; i < ListaP.Length; i++)
                {
                    Presidiario P22 = new Presidiario();
                    string[] aux = ListaP[i].Split('|');
                    P22.setNome(aux[0]);
                    t.setData(aux[1]);
                    P22.setDataDeNascimento(t);
                    P22.setIdade(Convert.ToInt32(aux[2]));
                    P22.setId(aux[3]);
                    P22.setPeriodoDeReclusao(Convert.ToInt32(aux[4]));
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
                string[] ListaP = File.ReadAllLines("../../MasculinaQualificado.txt");
                for (int i = 0; i < ListaP.Length; i++)
                {
                    Presidiario P22 = new Presidiario();
                    string[] aux = ListaP[i].Split('|');
                    P22.setNome(aux[0]);
                    t.setData(aux[1]);
                    P22.setDataDeNascimento(t);
                    P22.setIdade(Convert.ToInt32(aux[2]));
                    P22.setId(aux[3]);
                    P22.setPeriodoDeReclusao(Convert.ToInt32(aux[4]));
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
                string[] ListaP = File.ReadAllLines("../../MasculinaHediondo.txt");
                for (int i = 0; i < ListaP.Length; i++)
                {
                    Presidiario P22 = new Presidiario();
                    string[] aux = ListaP[i].Split('|');
                    P22.setNome(aux[0]);
                    t.setData(aux[1]);
                    P22.setDataDeNascimento(t);
                    P22.setIdade(Convert.ToInt32(aux[2]));
                    P22.setId(aux[3]);
                    P22.setPeriodoDeReclusao(Convert.ToInt32(aux[4]));

                    TodosPresos.Add(P22);

                }

                foreach (var lista in TodosPresos)
                {
                    Console.WriteLine(lista.Trasformar());
                }
            }
        }

        public void GerenciarCelaFeminina1()
        {
            List<Presidiario> TodosPresos = new List<Presidiario>();
            Data t = new Data();
            string[] ListaP = File.ReadAllLines("../../FemininaSimples.txt");
            for (int i = 0; i < ListaP.Length; i++)
            {
                Presidiario P22 = new Presidiario();
                string[] aux = ListaP[i].Split('|');
                P22.setNome(aux[0]);
                t.setData(aux[1]);
                P22.setDataDeNascimento(t);
                P22.setIdade(Convert.ToInt32(aux[2]));
                P22.setId(aux[3]);
                P22.setPeriodoDeReclusao(Convert.ToInt32(aux[4]));
                TodosPresos.Add(P22);
            }
            Console.WriteLine();
            foreach (var list in TodosPresos)
            {
                Console.WriteLine(list.Trasformar());
            }

            Console.WriteLine();
            Console.Write("> Digite o ID do preso: ");
            string id = Console.ReadLine();

            Presidiario P1;
            P1 = TodosPresos.Find(y => y.getId().Contains(id));

            Console.WriteLine();

            Console.WriteLine("| 1 - Acrescentar anos de reclusão; 2 - Reduzir anos de reclusão; +" +
                               " 3 - Preso Transferido retira-lo do sistema |");
            Console.WriteLine();
            Console.Write("> Digite a opção desejada: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (num1 == 1)
            {
                Console.WriteLine("Qual o motivo?");
                Console.WriteLine("| 1 - Brigas frequentes; 2 - Tentativas de fuga |");
                Console.Write("> Digite a opção desejada: ");
                int num2 = int.Parse(Console.ReadLine());

                if (num2 == 1)
                {

                    if (P1.getPeriodoDeReclusao() >= 10 && P1.getPeriodoDeReclusao() <= 60)
                    {
                        int aux = P1.getPeriodoDeReclusao() + 1;
                        P1.setPeriodoDeReclusao(aux);
                    }
                }
                else if (num2 == 2)
                {
                    if (P1.getPeriodoDeReclusao() >= 10 && P1.getPeriodoDeReclusao() <= 60)
                    {
                        int aux = P1.getPeriodoDeReclusao() + 2;
                        P1.setPeriodoDeReclusao(aux);
                    }
                }
                Console.WriteLine(P1);
                AtualizarCelaFeminina1(TodosPresos);
            }
            else if (num1 == 2)
            {
                Console.WriteLine("Qual o motivo?");
                Console.WriteLine("1 - Terminou o ensino médio; 2 - Completou 2 anos de trabalho |");
                Console.Write("> Digite a opção desejada: ");

                int num3 = int.Parse(Console.ReadLine());

                if (num3 == 1)
                {
                    if (P1.getPeriodoDeReclusao() >= 10 && P1.getPeriodoDeReclusao() <= 60)
                    {
                        int aux1 = P1.getPeriodoDeReclusao() - 1;
                        P1.setPeriodoDeReclusao(aux1);
                    }

                }
                else if (num3 == 2)
                {
                    if (P1.getPeriodoDeReclusao() >= 10 && P1.getPeriodoDeReclusao() <= 60)
                    {
                        int aux1 = P1.getPeriodoDeReclusao() - 2;
                        P1.setPeriodoDeReclusao(aux1);
                    }
                }
                Console.WriteLine(P1);
                AtualizarCelaFeminina1(TodosPresos);
            }

            else if (num1 == 3)
            {
                ArquivarPresoTransferido(P1);
                TodosPresos.Remove(P1);
                AtualizarCelaFeminina1(TodosPresos);
                Console.WriteLine(" Preso removido do sistema");
            }
        }
        public void GerenciarCelaFeminina2()
        {
            List<Presidiario> TodosPresos = new List<Presidiario>();
            Data t = new Data();
            string[] ListaP = File.ReadAllLines("../../FemininaQualificado.txt");
            for (int i = 0; i < ListaP.Length; i++)
            {
                Presidiario P22 = new Presidiario();
                string[] aux = ListaP[i].Split('|');
                P22.setNome(aux[0]);
                t.setData(aux[1]);
                P22.setDataDeNascimento(t);
                P22.setIdade(Convert.ToInt32(aux[2]));
                P22.setId(aux[3]);
                P22.setPeriodoDeReclusao(Convert.ToInt32(aux[4]));
                TodosPresos.Add(P22);
            }
            Console.WriteLine();
            foreach (var lista in TodosPresos)
            {
                Console.WriteLine(lista.Trasformar());
            }

            Console.WriteLine();
            Console.Write("> Digite o ID do preso: ");
            string id = Console.ReadLine();

            Presidiario P1;
            P1 = TodosPresos.Find(y => y.getId().Contains(id));

            Console.WriteLine();


            Console.WriteLine("| 1 - Acrescentar anos de reclusão; 2 - Reduzir anos de reclusão; +" +
                               " 3 - Preso Transferido retira-lo do sistema |");
            Console.WriteLine();
            Console.Write("> Digite a opção desejada: ");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 == 1)
            {
                Console.WriteLine("Qual o motivo?");
                Console.WriteLine("| 1 - Brigas frequentes; 2 - Tentativas de fuga |");
                Console.Write("> Digite a opção desejada: ");
                int num2 = int.Parse(Console.ReadLine());

                if (num2 == 1)
                {
                    if (P1.getPeriodoDeReclusao() >= 10 && P1.getPeriodoDeReclusao() <= 60)
                    {
                        int aux = P1.getPeriodoDeReclusao() + 1;
                        P1.setPeriodoDeReclusao(aux);
                    }
                }
                else if (num2 == 2)
                {
                    if (P1.getPeriodoDeReclusao() >= 10 && P1.getPeriodoDeReclusao() <= 60)
                    {
                        int aux = P1.getPeriodoDeReclusao() + 2;
                        P1.setPeriodoDeReclusao(aux);
                    }
                }
                Console.WriteLine(P1);
                AtualizarCelaFeminina2(TodosPresos);
            }
            else if (num1 == 2)
            {
                Console.WriteLine("Qual o motivo?");
                Console.WriteLine("1 - Terminou o ensino médio; 2 - Completou 2 anos de trabalho |");
                Console.Write("> Digite a opção desejada: ");
                int num3 = int.Parse(Console.ReadLine());

                if (num3 == 1)
                {
                    if (P1.getPeriodoDeReclusao() >= 10 && P1.getPeriodoDeReclusao() <= 60)
                    {
                        int aux1 = P1.getPeriodoDeReclusao() - 1;
                        P1.setPeriodoDeReclusao(aux1);
                    }

                }
                else if (num3 == 2)
                {
                    if (P1.getPeriodoDeReclusao() >= 10 && P1.getPeriodoDeReclusao() <= 60)
                    {
                        int aux1 = P1.getPeriodoDeReclusao() - 2;
                        P1.setPeriodoDeReclusao(aux1);
                    }
                }
                Console.WriteLine(P1);
                AtualizarCelaFeminina2(TodosPresos);
            }
            else if (num1 == 3)
            {
                ArquivarPresoTransferido(P1);
                TodosPresos.Remove(P1);
                AtualizarCelaFeminina2(TodosPresos);
                Console.WriteLine(" Preso removido do sistema");
            }
        }

        public void GerenciarCelaFeminina3()
        {
            List<Presidiario> TodosPresos = new List<Presidiario>();

            Data t = new Data();
            string[] ListaP = File.ReadAllLines("../../FemininaHediondo.txt");
            for (int i = 0; i < ListaP.Length; i++)
            {
                Presidiario P22 = new Presidiario();
                string[] aux = ListaP[i].Split('|');
                P22.setNome(aux[0]);
                t.setData(aux[1]);
                P22.setDataDeNascimento(t);
                P22.setIdade(Convert.ToInt32(aux[2]));
                P22.setId(aux[3]);
                P22.setPeriodoDeReclusao(Convert.ToInt32(aux[4]));
                TodosPresos.Add(P22);
            }
            Console.WriteLine();
            foreach (var lista in TodosPresos)
            {
                Console.WriteLine(lista.Trasformar());
            }

            Console.WriteLine();
            Console.Write("> Digite o ID do preso: ");
            string id = Console.ReadLine();

            Presidiario P1;
            P1 = TodosPresos.Find(y => y.getId().Contains(id));

            Console.WriteLine();

            Console.WriteLine("| 1 - Acrescentar anos de reclusão; 2 - Reduzir anos de reclusão; +" +
                               " 3 - Preso Transferido retira-lo do sistema |");
            Console.WriteLine();
            Console.Write("> Digite a opção desejada: ");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 == 1)
            {
                Console.WriteLine("Qual o motivo?");
                Console.WriteLine("| 1 - Brigas frequentes; 2 - Tentativas de fuga |");
                Console.Write("> Digite a opção desejada: ");
                int num2 = int.Parse(Console.ReadLine());

                if (num2 == 1)
                {

                    if (P1.getPeriodoDeReclusao() >= 10 && P1.getPeriodoDeReclusao() <= 60)
                    {
                        int aux = P1.getPeriodoDeReclusao() + 1;
                        P1.setPeriodoDeReclusao(aux);
                    }
                }
                else if (num2 == 2)
                {
                    if (P1.getPeriodoDeReclusao() >= 10 && P1.getPeriodoDeReclusao() <= 60)
                    {
                        int aux = P1.getPeriodoDeReclusao() + 2;
                        P1.setPeriodoDeReclusao(aux);
                    }
                }
                Console.WriteLine(P1);
                AtualizarCelaFeminina3(TodosPresos);
            }
            else if (num1 == 2)
            {
                Console.WriteLine("Qual o motivo?");
                Console.WriteLine("1 - Terminou o ensino médio; 2 - Completou 2 anos de trabalho |");
                Console.Write("> Digite a opção desejada: ");
                int num3 = int.Parse(Console.ReadLine());

                if (num3 == 1)
                {
                    if (P1.getPeriodoDeReclusao() >= 10 && P1.getPeriodoDeReclusao() <= 60)
                    {
                        int aux1 = P1.getPeriodoDeReclusao() - 1;
                        P1.setPeriodoDeReclusao(aux1);
                    }
                }
                else if (num3 == 2)
                {
                    if (P1.getPeriodoDeReclusao() >= 10 && P1.getPeriodoDeReclusao() <= 60)
                    {
                        int aux1 = P1.getPeriodoDeReclusao() - 2;
                        P1.setPeriodoDeReclusao(aux1);
                    }
                }
                Console.WriteLine(P1);
                AtualizarCelaFeminina3(TodosPresos);
            }

            else if (num1 == 3)
            {
                ArquivarPresoTransferido(P1);
                TodosPresos.Remove(P1);
                AtualizarCelaFeminina3(TodosPresos);
                Console.WriteLine(" Preso removido do sistema;");
            }
        }

        public void AtualizarCelaFeminina1(List<Presidiario> det)
        {
            FileStream Arq1 = new FileStream("../../FemininaSimples.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw1 = new StreamWriter(Arq1, Encoding.UTF8);

            foreach (Presidiario lista in det)
            {
                sw1.WriteLine(lista);
            }

            sw1.Close();
            Arq1.Close();
        }

        public void AtualizarCelaFeminina2(List<Presidiario> det)
        {
            FileStream Arq1 = new FileStream("../../FemininaQualificado.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw1 = new StreamWriter(Arq1, Encoding.UTF8);

            foreach (Presidiario lista in det)
            {
                sw1.WriteLine(lista);
            }

            sw1.Close();
            Arq1.Close();
        }

        public void AtualizarCelaFeminina3(List<Presidiario> det)
        {
            FileStream Arq1 = new FileStream("../../FemininaHediondo.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw1 = new StreamWriter(Arq1, Encoding.UTF8);

            foreach (Presidiario lista in det)
            {
                sw1.WriteLine(lista);
            }

            sw1.Close();
            Arq1.Close();
        }


        public void Cadastrar_presosFeminina1()
        {
            FileStream Arq1 = new FileStream("../../FemininaSimples.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw1 = new StreamWriter(Arq1, Encoding.UTF8);

            sw1.WriteLine(Pres1);

            sw1.Close();
            Arq1.Close();
        }
        public void Cadastrar_presosFeminina2()
        {
            FileStream Arq2 = new FileStream("../../FemininaQualificado.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw2 = new StreamWriter(Arq2, Encoding.UTF8);

            sw2.WriteLine(Pres2);

            sw2.Close();
            Arq2.Close();

        }
        public void Cadastrar_presosFeminina3()
        {
            FileStream Arq3 = new FileStream("../../FemininaHediondo.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw3 = new StreamWriter(Arq3, Encoding.UTF8);

            sw3.WriteLine(Pres3);

            sw3.Close();
            Arq3.Close();
        }

        public static void Ver_CelaFeminina(int num)
        {
            if (num == 4)
            {
                List<Presidiario> TodosPresos = new List<Presidiario>();

                Data t = new Data();
                string[] ListaP = File.ReadAllLines("../../FemininaSimples.txt");
                for (int i = 0; i < ListaP.Length; i++)
                {
                    Presidiario P22 = new Presidiario();
                    string[] aux = ListaP[i].Split('|');
                    P22.setNome(aux[0]);
                    t.setData(aux[1]);
                    P22.setDataDeNascimento(t);
                    P22.setIdade(Convert.ToInt32(aux[2]));
                    P22.setId(aux[3]);
                    P22.setPeriodoDeReclusao(Convert.ToInt32(aux[4]));
                    TodosPresos.Add(P22);
                }
                foreach (var lista in TodosPresos)
                {
                    Console.WriteLine(lista.Trasformar());
                }
            }

            if (num == 5)
            {
                List<Presidiario> TodosPresos = new List<Presidiario>();

                Data t = new Data();
                string[] ListaP = File.ReadAllLines("../../FemininaQualificado.txt");
                for (int i = 0; i < ListaP.Length; i++)
                {
                    Presidiario P22 = new Presidiario();
                    string[] aux = ListaP[i].Split('|');
                    P22.setNome(aux[0]);
                    t.setData(aux[1]);
                    P22.setDataDeNascimento(t);
                    P22.setIdade(Convert.ToInt32(aux[2]));
                    P22.setId(aux[3]);
                    P22.setPeriodoDeReclusao(Convert.ToInt32(aux[4]));
                    TodosPresos.Add(P22);
                }
                foreach (var lista in TodosPresos)
                {
                    Console.WriteLine(lista.Trasformar());
                }
            }

            if (num == 6)
            {
                List<Presidiario> TodosPresos = new List<Presidiario>();

                Data t = new Data();
                string[] ListaP = File.ReadAllLines("../../FemininaHediondo.txt");
                for (int i = 0; i < ListaP.Length; i++)
                {
                    Presidiario P22 = new Presidiario();
                    string[] aux = ListaP[i].Split('|');
                    P22.setNome(aux[0]);
                    t.setData(aux[1]);
                    P22.setDataDeNascimento(t);
                    P22.setIdade(Convert.ToInt32(aux[2]));
                    P22.setId(aux[3]);
                    P22.setPeriodoDeReclusao(Convert.ToInt32(aux[4]));

                    TodosPresos.Add(P22);

                }

                foreach (var lista in TodosPresos)
                {
                    Console.WriteLine(lista.Trasformar());
                }
            }
        }

        public void CadastrarCarcereiros()
        {
            FileStream Arq1 = new FileStream("../../Carcereiros.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw1 = new StreamWriter(Arq1, Encoding.UTF8);
            foreach (var i in Car1)
            {
                sw1.WriteLine(i);
            }

            sw1.Close();
            Arq1.Close();

        }

        public void GerenciarCarcereiros()
        {


            List<Carcereiro> TodosCarcereiros = new List<Carcereiro>();

            Data t = new Data();
            string[] ListaP = File.ReadAllLines("../../Carcereiros.txt");
            for (int i = 0; i < ListaP.Length; i++)
            {
                Carcereiro P22 = new Carcereiro();
                string[] aux = ListaP[i].Split('|');
                P22.setNome(aux[0]);
                t.setData(aux[1]);
                P22.setDataDeNascimento(t);
                P22.setIdade(Convert.ToInt32(aux[2]));
                P22.setId(aux[3]);
                P22.setSalario(Convert.ToInt32(aux[4]));
                P22.setPatente(aux[5]);
                TodosCarcereiros.Add(P22);
            }
            foreach (var lista in TodosCarcereiros)
            {
                Console.WriteLine(lista.RelatorioCarcereiro());
            }



            Console.WriteLine();
            Console.Write("> Digite o ID do Carcereiro: ");
            string id = Console.ReadLine();

            Carcereiro P1;
            P1 = TodosCarcereiros.Find(y => y.getId().Contains(id));

            Console.WriteLine(P1);


            Console.WriteLine("| 1 - Registrar hora extra; 2 - Reduzir sálario por falta; +" +
                               " 3 - Demitir carcereiro |");
            Console.Write("> Digite a opção desejada: ");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 == 1)
            {
                Console.WriteLine("Quantas horas extras feitas?");
                int num2 = int.Parse(Console.ReadLine());

                int total = num2 * 5;

                double aux = P1.getSalario() + total;
                P1.setSalario(aux);
                Console.WriteLine(P1);
                AtualizaCarcereiros(TodosCarcereiros);
            }
            else if (num1 == 2)
            {
                Console.WriteLine("Quantas faltas no mês?");
                int num2 = int.Parse(Console.ReadLine());

                int total = num2 * 20;

                double aux = P1.getSalario() - total;
                P1.setSalario(aux);
                Console.WriteLine(P1);
                AtualizaCarcereiros(TodosCarcereiros);
            }

            else if (num1 == 3)
            {
                ArquivarCarcereirosDemitidos(P1);

                TodosCarcereiros.Remove(P1);
                
                AtualizaCarcereiros(TodosCarcereiros);

                Console.WriteLine(" Carcererio removido do quadro de funcionario;");
            }

        }

        public void AtualizaCarcereiros(List<Carcereiro> car)
        {

            FileStream Arq1 = new FileStream("../../Carcereiros.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw1 = new StreamWriter(Arq1, Encoding.UTF8);

            foreach (Carcereiro lista in car)
            {
                sw1.WriteLine(lista);
            }

            sw1.Close();
            Arq1.Close();
        }

        public static void RelatorioCarcereiros()
        {

            List<Carcereiro> TodosCarcereiros = new List<Carcereiro>();

            Data t = new Data();
            string[] ListaP = File.ReadAllLines("../../Carcereiros.txt");
            for (int i = 0; i < ListaP.Length; i++)
            {
                Carcereiro P22 = new Carcereiro();
                string[] aux = ListaP[i].Split('|');
                P22.setNome(aux[0]);
                t.setData(aux[1]);
                P22.setDataDeNascimento(t);
                P22.setIdade(Convert.ToInt32(aux[2]));
                P22.setId(aux[3]);
                P22.setSalario(Convert.ToInt32(aux[4]));
                P22.setPatente(aux[5]);
                TodosCarcereiros.Add(P22);
            }
            foreach (var lista in TodosCarcereiros)
            {
                Console.WriteLine(lista.RelatorioCarcereiro());
            }

        }

        public static void RelatorioPresosTrasferidos()
        {

            List<Presidiario> TodosPresos = new List<Presidiario>();

            Data t = new Data();
            string[] ListaP = File.ReadAllLines("../../PresosTransferidos.txt");
            for (int i = 0; i < ListaP.Length; i++)
            {
                Presidiario P22 = new Presidiario();
                string[] aux = ListaP[i].Split('|');
                P22.setNome(aux[0]);
                t.setData(aux[1]);
                P22.setDataDeNascimento(t);
                P22.setIdade(Convert.ToInt32(aux[2]));
                P22.setId(aux[3]);
                P22.setPeriodoDeReclusao(Convert.ToInt32(aux[4]));
                TodosPresos.Add(P22);
            }
            foreach (var lista in TodosPresos)
            {
                Console.WriteLine(lista.Trasformar());
            }

        }

        public void ArquivarPresoTransferido(Presidiario P)
        {
           
            FileStream Arq1 = new FileStream("../../PresosTransferidos.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw1 = new StreamWriter(Arq1, Encoding.UTF8);
           
            sw1.WriteLine(P);
            
            sw1.Close();
            Arq1.Close();

            
        }

        public static void RelatorioCarcereirosDemitidos()
        {

            List<Carcereiro> TodosCarcereiros = new List<Carcereiro>();

            Data t = new Data();
            string[] ListaP = File.ReadAllLines("../../CarcereirosDemitidos.txt");
            for (int i = 0; i < ListaP.Length; i++)
            {
                Carcereiro P22 = new Carcereiro();
                string[] aux = ListaP[i].Split('|');
                P22.setNome(aux[0]);
                t.setData(aux[1]);
                P22.setDataDeNascimento(t);
                P22.setIdade(Convert.ToInt32(aux[2]));
                P22.setId(aux[3]);
                P22.setSalario(Convert.ToInt32(aux[4]));
                P22.setPatente(aux[5]);
                TodosCarcereiros.Add(P22);
            }
            foreach (var lista in TodosCarcereiros)
            {
                Console.WriteLine(lista.RelatorioCarcereiro());
            }

        }

        public void ArquivarCarcereirosDemitidos(Carcereiro P)
        {

            FileStream Arq1 = new FileStream("../../CarcereirosDemitidos.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw1 = new StreamWriter(Arq1, Encoding.UTF8);

            sw1.WriteLine(P);

            sw1.Close();
            Arq1.Close();


        }       

    }

}
