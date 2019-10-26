using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPresidio
{
    class Presidiario
    {
        private static string Nome;
        private static int Idade;
        private static Data Datanascimento;
        private static string Crime;
        private static Pena Tempo_reclusao;
        private static int Numero_preso;

        public static string getNome()
        {
            return Nome;
        }

        public static void setNome(string nome)
        {
            int len = 3;
            if (nome.Length >= len)
            {
                Nome = nome;
            }
            else
            {
                Nome = "ERRO! NOME COM MENOS DE 3 CARACTERES!";
            }
        }

        public static int getIdade()
        {
            return Idade;
        }

        public static void setIdade(int idade)
        {
            if (idade >= 18)
            {
                Idade = idade;
            }
            else
            {
                Idade = 0;
            }
        }

        public Presidiario(string nome, int idade, Data datanascimento, Pena tempo, int numero)
        {
            Nome = nome;
            Idade = idade;
            Datanascimento = datanascimento;
            Tempo_reclusao = tempo;
            Numero_preso = numero;
        }

        public Presidiario()
        {

        }

        public static Data Data_nascimento()
        {
            return Datanascimento;
        }

        public static void Data_nascimento(Data nascimento)
        {
            Datanascimento = nascimento;
        }

        public static string getCrime()
        {
            return Crime;
        }

        public static void setCrime(string crime)
        {
            Crime = crime;
        }

        public static Pena getTempo_reclusao()
        {
            return Tempo_reclusao;
        }

        public static void setTempo_reclusao(Pena tempo)
        {
            Tempo_reclusao = tempo;
        }

        public static int getNumero_preso()
        {
            return Numero_preso;
        }
        public static void setNum_preso(int num)
        {
            Numero_preso = num;
        }
        public static Presidiario Tipo_crime1()
        {
            if (getCrime() == "Roubo" || getCrime() == "Assalto" || getCrime() == "Furto" 
                || getCrime() == "Sequestro")
            {
                Presidiario Preso1 = new Presidiario(Nome, Idade, Datanascimento, Tempo_reclusao,
                                                     Numero_preso);
                return Preso1;
            }

            return null;

        }

        public static Presidiario Tipo_crime2()
        {
            if (getCrime() == "Trafico" || getCrime() == "Latrocínio" || getCrime() == "Homicídio" 
                || getCrime() == "Lesão corporal")
            {
                Presidiario Preso1 = new Presidiario(Nome, Idade, Datanascimento, Tempo_reclusao, 
                                                     Numero_preso);
            }

            return null;

        }

        public static Presidiario Tipo_crime3()
        {

            if (getCrime() == "Estupro" || getCrime() == "Pedofilia" || getCrime() == "Feminicídio" 
                || getCrime() == "Pornografia infantil")
            {
                Presidiario Preso1 = new Presidiario(Nome, Idade, Datanascimento, Tempo_reclusao, 
                                                     Numero_preso);
                return Preso1;
            }

            return null;

        }

        public override string ToString()
        {
            return "Nome: " + Nome + " | Idade: " + Idade + " | Data de nascimento: " + Datanascimento +
                   " | Número: " + Numero_preso + Tempo_reclusao;
        }
    }
}
