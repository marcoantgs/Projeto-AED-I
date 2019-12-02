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
        private int qtd_max = 1000;
        private List<Presidiario> Preso1;

        public List<Presidiario> get_preso()
        {
              return Preso1;
            
            
        }
        public void set_preso(List<Presidiario> preso)
        {
          
                Preso1 = preso;         


        }
       
        public bool Verifica_cela1()
        {
                  
            string[] array = File.ReadAllLines("../../Simples.txt");
            int cont = 0;
            for (int i = 0; i < array.Length; i++)
            {
              
                cont = i + 1;
               
            }
            
            if (cont <= qtd_max)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        

        public bool Verifica_cela2()
        {

            string[] array = File.ReadAllLines("../../Qualificado.txt");
            int cont = 0;
            for (int i = 0; i < array.Length; i++)
            {
                cont = i + 1;

            }

            if (cont <= qtd_max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Verifica_cela3()
        {

            string[] array = File.ReadAllLines("../../Hediondo.txt");
            int cont = 0;
            for (int i = 0; i < array.Length; i++)
            {
                cont = i + 1;

            }

            if (cont <= qtd_max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public  string comverter()
        {
            
            foreach( var i in Preso1)
            {
               return i.ToString();
            }
            return null;
        }
        public override string ToString()
        {
            return  comverter() ;
        }


    }
}
