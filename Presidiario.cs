using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Presidio
{
    class Presidiario
    {
        private static string Nome;
        private static int Idade;
        private static Data Datanascimento;
        private static string Crime;
        private static Pena Tempo_reclusao;
        private static int Cpf_preso;
        private static int Idade_nascimento;

        public Presidiario(string nome, int idade, Data datanascimento, Pena tempo, int numcpf, string crime)
        {
            Nome = nome;
            Idade = idade;
            Datanascimento = datanascimento;
            Tempo_reclusao = tempo;
            Cpf_preso = numcpf;
            Crime = crime;
        }
        public Presidiario()
        {

        }
        public static string getNome()
        {
            return Nome;
        }

        public static bool setNome(string nome)
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

        public static int getIdade()
        {
            return Idade;
        }

        public static bool setIdade(int idade)
        {
            if (idade == Idade_nascimento)
            {
                Idade = idade;
                return true;
            }
            else
            {
                return false; 
            }
        }

        public static Data getData_nascimento()
        {
            return Datanascimento;
        }

        public static bool setData_nascimento(Data nascimento)
        {
            Idade_nascimento = DateTime.Today.Year - nascimento.getAno();
            if (DateTime.Today.Month < nascimento.getMes() || (DateTime.Today.Month == nascimento.getMes() && DateTime.Today.Day < nascimento.getDia()))
            {
                Idade--;
            }

            if (Idade_nascimento < 18)
            {
                return false;
            }
            else
            {
                Datanascimento = nascimento;
                return true;
            }
        }

        public static string getCrime()
        {
            return Crime;
        }

        public static bool setCrime(string crime)
        {
            switch (crime)
            {
                case "Roubo":
                case "Assalto":                
                case "Sequestro":
                case "Assassinato":            
                case "Pedofilia":
                case "Feminicídio":
                    Crime = crime;
                    return true;               
                default:
                    break;
            }

            return false;
        }
        
        public static Pena getTempo_reclusao()
        {
            return Tempo_reclusao;
        }

        public static void setTempo_reclusao(Pena tempo)
        {
            Tempo_reclusao = tempo;
        }

        public static int getcpf_preso()
        {
            return Cpf_preso;
        }

        public static bool setcpf_preso(int num)
        {
            if (num > 4)
            {
                Cpf_preso = num;
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static Presidiario Tipo_crime1()
        {
            Presidiario Preso1 = null;
            if (getCrime() == "Roubo" || getCrime() == "Assalto")
            {
                Preso1 = new Presidiario(Nome, Idade, Datanascimento, Tempo_reclusao, Cpf_preso, Crime);
               
            }

            return Preso1; ;
        }

        public static Presidiario Tipo_crime2()
        {
            Presidiario Preso1 = null;
            if (getCrime() == "Assassinato"|| getCrime() == "Sequestro")
            {
                 Preso1 = new Presidiario(Nome, Idade, Datanascimento, Tempo_reclusao,
                                                     Cpf_preso, Crime);
            }

            return Preso1;
        }
        public static Presidiario Tipo_crime3()
        {
            Presidiario Preso1 = null;
            if (getCrime() == "Pedofilia" || getCrime() == "Feminicídio")
            {    
            
                Preso1 = new Presidiario(Nome, Idade, Datanascimento, Tempo_reclusao,
                                         Cpf_preso, Crime);
                
            }

            return Preso1;
        }

        public override string ToString()
        {
            return " Nome: "  + Nome + " | Idade: " + Idade + " | Data de nascimento: " + Datanascimento +
                " | CPF do preso " + Cpf_preso + " | Crime cometido: " + Crime + Tempo_reclusao;
        }
    }
}
