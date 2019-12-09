using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projeto_Presidio
{
    class Cela
    {
        private int qtd_max = 6;
        private List<Presidiario> Preso1;

        public Cela(List<Presidiario> Preso)
        {
            Preso1 = Preso;
            qtd_max = 6;
        }

        public Cela()
        {

        }
        public int getqtd_max()
        {
            return qtd_max;
        }

        public void setqtd_max(int max)
        {
            qtd_max = max; 
        }
        public List<Presidiario> getPreso()
        {
            return Preso1;
        }

        public void setPreso(List<Presidiario> preso)
        {
            Preso1 = preso;
        }        

        public string Converter()
        {
            foreach (var i in Preso1)
            {
                return i.ToString();
            }
            return null;
        }

        public override string ToString()
        {
            return Converter();
        }

    }
}
