using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projeto_Presidio
{
    class Pessoa
    {
        private string Nome;
        private static Data Data_nascimento;
        private int Idade;
        private char Sexo;
        private string Id_pessoa;

        public Pessoa()
        {

        }

        public string getNome()
        {
            return Nome;
        }

        public bool setNome(string nome)
        {
            if (nome.Length < 3)
                return false;  
                
            for(int i = 0; i < nome.Length; i++)
            {
                if (char.IsNumber(nome, i))
                {

                    return false;
                }
                   
            }            
            Nome = nome;
            return true;
           
        }

        public static Data getDataDeNascimento()
        {
            return Data_nascimento;
        }

        public bool setDataDeNascimento(Data nascimento)
        {
            Idade = DateTime.Today.Year - nascimento.getAno();
            if (DateTime.Today.Month < nascimento.getMes() ||
               (DateTime.Today.Month == nascimento.getMes() &&
                DateTime.Today.Day < nascimento.getDia()))
            {
                Idade--;
            }

            if (Idade < 18)
            {
                return false;
            }
            else
            {
                Data_nascimento = nascimento;
                return true;
            }
        }

        public char getsexo()
        {

            return Sexo;
        }

        public bool setSexo(char s)
        {
           
            if (s == 'M' || s == 'F' || s == 'f' || s == 'm')
            {
                Sexo = s;
                return true;
            }
            return false;
        }

        public int getIdade()
        {
            return Idade;
        }
        public void setIdade(int num)
        {
            Idade = num;
        }

        public string getId()
        {
            return Id_pessoa;
        }

        public void setId(string n)
        {
            Id_pessoa = n;
        }

        public bool verificarId(string num)
        {
            if (num.Length != 4)
            {
                return false;
            }

            for (int i = 0; i < num.Length; i++)
            {
                if(char.IsLetter(num, i))
                {
                    return false;
                }
            }
            List<string> ID = new List<string>();

            string[] ListaID = File.ReadAllLines("../../ListaDeId.txt");

            for (int i = 0; i < ListaID.Length; i++)
            {
                ID.Add(ListaID[i]);
            }

            if (!ID.Contains(num))
            {
                FileStream Arq1 = new FileStream("../../ListaDeId.txt", FileMode.Append,
                                                 FileAccess.Write);
                StreamWriter sw1 = new StreamWriter(Arq1, Encoding.UTF8);

                sw1.WriteLine(num);

                sw1.Close();
                Arq1.Close();

                setId(num);
                return true;
            }
            return false;
        }

    }
}
