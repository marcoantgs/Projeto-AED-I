using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projeto_Presidio
{
    class Presidiario : Pessoa
    {
        private int Crime;
        private int Periodo_reclusao;

        public Presidiario()
        {

        }

        public Presidiario(int crime, int periodo, string nome, Data dn, int idade,
                         char sexo, string id) : base(nome, dn, idade, sexo, id)
        {
            Crime = crime;
            Periodo_reclusao = periodo;
        }

        public int getPeriodoDeReclusao()
        {
            return Periodo_reclusao;
        }
        public void setPeriodoDeReclusao(int periodo)
        {
            Periodo_reclusao = periodo;
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

        public string Trasformar()
        {
            return " Nome: " +getNome()+ " | Data de nascimento: " +getDataDeNascimento()
                 + "|Idade: "+getIdade()+ " Anos | ID: " +getId()+ " | Tempo de reclusão: "
                   + Periodo_reclusao + " Anos ";
        }

        public override string ToString()
        {
            return getNome() + " | " + getDataDeNascimento() + " | " + getIdade() +
                   " | " + getId() + "|" + Periodo_reclusao;
        }

    }
}
