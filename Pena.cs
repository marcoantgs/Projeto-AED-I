using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Presidio
{
    class Pena
    {
        private Data Data_inicial;
        private Data Data_final;
        private string Crime;

        public Data getdata_inicial()
        {
            return Data_inicial;
        }

       
        public Data getdata_final()
        {
            return Data_inicial;
        }

        public void setdata_final(Data df)
        {
            Data_inicial = df;
        }

        public string getCrime()
        {
           return Crime;
        }

            
        public Pena (  Data inicial, Data final , string crime)
        {
            Data_inicial = inicial;
            Data_final = final;
            Crime = crime;
        }

        public Pena()
        {

        }

        public int Periodo_dias()
        {
            return this.Data_inicial.Diferenca_dias(Data_final);
        }

        public int Periodo_anos()
        {
            return this.Data_inicial.Diferenca_anos(Data_final);
        }

        public override string ToString()
        {
            return Crime + " / Tempo de reclusao: " + Periodo_anos() + " anos " + Periodo_dias() + " dias ";
        }









    }

}
