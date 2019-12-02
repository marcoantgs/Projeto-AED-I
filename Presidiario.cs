using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Projeto_Presidio
{
    class Presidiario:Pessoas
    {
        private  string Nome;
        private static Data Datanascimento;
        private  int Crime;
        private  int Periodo_Reclusao;
        private  string Cpf_preso;
        private  int Idade;

                   
        public Presidiario()
        {

        }
        public  string getNome()
        {
            return Nome;
        }

        public  bool setNome(string nome)
        {

            if (nome.Length >= 3)
            {
                Nome = nome;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getIdade()
        {
            return Idade;
        }
        public void setIdade(int num)
        {
            Idade = num;
        }

        public int getPeriodoReclusao()
        {
            return Periodo_Reclusao;
        }
        public void setPeriodoReclusao(int periodo)
        {
           Periodo_Reclusao = periodo;
        }

        public static Data getData_nascimento()
        {
            return Datanascimento;
        }

       
        public bool setData_nascimento(Data nascimento)
        {
            Idade = DateTime.Today.Year - nascimento.getAno();
            if (DateTime.Today.Month < nascimento.getMes() || (DateTime.Today.Month == nascimento.getMes() && DateTime.Today.Day < nascimento.getDia()))
            {
                Idade --;
            }

            if (Idade < 18)
            {
                return false;
            }
            else
            {

                Datanascimento = nascimento;
                return true;
            }
        }

        public int getCrime()
        {
            return Crime;
        }

        public bool setCrime(int crime)
        {
            switch (crime)
            {
                case 1:
                case 2:
                case 3:
                    Crime = crime;
                    return true;
                default:
                    break;
            }

            return false;
        }

       
        public string getcpf_preso()
        {
            return Cpf_preso;
        }

        public void setCpf_preso(string n)
        {
            Cpf_preso = n;
        }
       
        public bool verificacpf_preso(string num)
        {
            List<string> ID = new List<string>();

            string[] ListaID= File.ReadAllLines("../../listadeID.txt");
            
            for (int i = 0; i < ListaID.Length; i++)
            {
                ID.Add(ListaID[i]);


            }          
            
            if (!ID.Contains(num))
            {
                FileStream Arq1 = new FileStream("../../listadeID.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw1 = new StreamWriter(Arq1, Encoding.UTF8);

                sw1.WriteLine(num);

                sw1.Close();
                Arq1.Close();

                setCpf_preso(num);                
                return true;
            }

            return false;



        }
       public string Trasformar()
       {
            return " Nome: " + Nome + " | Data nascimento: " + Datanascimento + " | Idade: " + Idade +
                " | ID Detento: " + Cpf_preso + " | Tempo de reclusao: " + Periodo_Reclusao;
       }
       

       

        public override string ToString()
        {
            return  Nome + " | " + Datanascimento + " | " + Idade +
                " | " + Cpf_preso + "|" + Periodo_Reclusao;
        }
    }
}
