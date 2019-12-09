using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projeto_Presidio
{
    class Carcereiro : Pessoa
    {
        private double Salario;
        private string Patente;
        private int qtd_maxCar = 31;

        public Carcereiro()
        {

        }
        public Carcereiro(double salario, string patente, int qtd, string nome, Data dn, int idade,
                        char sexo, string id) : base(nome, dn, idade, sexo, id)
        {
            Salario = salario;
            Patente = patente;
            qtd_maxCar = qtd;
        }

        public double getSalario()
        {
            return Salario;
        }

        public void setSalario(double salario)
        {

            Salario = salario;
        }

        public string getPatente()
        {

            return Patente;
        }

        public void setPatente(string c)
        {

            Patente = c;
        }

        public bool VerificaPatente(string nivel)
        {
          
            switch (nivel)
            {
                case "Soldado":
                case "Cabo":
                case "soldado":
                case "cabo":
                    setPatente(nivel);
                    return true;
                default:
                    break;
            }

            return false;
        }

        public bool VerificaqtdCarcereiro()
        {
            List<Carcereiro> TodosPresos = new List<Carcereiro>();

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
                TodosPresos.Add(P22);
            }

            if (TodosPresos.Count() < qtd_maxCar)
            {
                return true;
            }
            return false;
        }

        public string RelatorioCarcereiro()
        {
            return " Nome: " + getNome() + "| Data de nascimento: " + getDataDeNascimento()
                   + "| Idade: " + getIdade() + "| ID: " + getId() + "| Salario: R$ "
                   + Salario + "| Patente: " + Patente ;
        }

        public override string ToString()
        {
            return getNome()+ "|" + getDataDeNascimento() + "|" + getIdade() +
                   " | " + getId() + " | " + Salario + " | " + Patente;
        }



    }
}
