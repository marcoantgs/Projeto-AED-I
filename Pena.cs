using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Presidio
{
    class Pena
    {
        private  Data Data_inicial;
        private  Data Data_final;

        public Pena(Data inicial, Data final)
        {
            Data_inicial = inicial;
            Data_final = final;
        }

        public Pena()
        {

        }

        public  Data getData_inicial()
        {
            return Data_inicial;
        }

        public  void setData_inicial(Data inicial)
        {
            Data_inicial = inicial;
        }

        public  Data getData_final()
        {
            return Data_final;
        }

        public  void setData_final(Data data_final)
        {
            Data_final = data_final;
        }

        public int Periodo_dias()
        {
            return Data_inicial.Diferenca_dias(Data_final);
        }

        public  int Periodo_anos()
        {
            return Data_inicial.Diferenca_anos(Data_final);
        }

        public override string ToString()
        {
            return " | Tempo de reclusão: " + Periodo_anos() + " anos e " + Periodo_dias() + " dias ";
        }
    }
}
