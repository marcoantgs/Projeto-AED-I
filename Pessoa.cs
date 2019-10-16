using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Presidio
{
    class Pessoa
    {
        private string nome;
        private int idade;
        private Data dataNascimento;
        private Pena periodo_crime;
        private string funcao;

        public Data getDataNascimento()
        {
            return dataNascimento;
        }

        public void setDataNascimento(Data dt)
        {
            dataNascimento = dt;
        }

        public Pena getperiodo_crime()
        {
            return periodo_crime;
        }

        public void setperiodo_crime(Pena pc)
        {
            periodo_crime = pc;
        }

        public string getNome()
        {
            return nome;
        }

        public void setNome( string n)
        {
            nome = n;
        }

        public int getIdade()
        {
            return idade;
        }

        public void setIdade( int i)
        {
            idade = i;
        }

        public string getfuncao()
        {
            return funcao;
        }

        public void setfuncao(string f)
        {
            funcao = f;
        }

        public Pessoa(string n, int i, Data dt, Pena p)
        {
            periodo_crime = p;
            nome = n;
            idade = i;
            dataNascimento = dt;
        }

        public Pessoa(string n, int i, Data dt, string f)
        {
            nome = n;
            idade = i;
            dataNascimento = dt;
            funcao = f;
        }

        public Pessoa()
        {
            nome = " ";
            idade = 0;
           
        }
                    

        public override string ToString()
        {
            return "Nome: "+ nome + " / Idade: " + idade + " anos / Data de nascimento: " + dataNascimento + " / Pena: " + periodo_crime;

        }

    }
}
