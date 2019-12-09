using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projeto_Presidio
{
    class CelaFeminina:Cela
    {
        public CelaFeminina()
        {

        }
      
        public bool VerificaCelaFeminina1()
        {
            string[] array = File.ReadAllLines("../../FemininaSimples.txt");
            int cont = 0;
            for (int i = 0; i < array.Length; i++)
            {
                cont = i + 1;
            }

            if (cont < getqtd_max())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerificaCelaFeminina2()
        {
            string[] array = File.ReadAllLines("../../FemininaQualificado.txt");
            int cont = 0;
            for (int i = 0; i < array.Length; i++)
            {
                cont = i + 1;
            }

            if (cont < getqtd_max())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerificaCelaFeminina3()
        {
            string[] array = File.ReadAllLines("../../FemininaHediondo.txt");
            int cont = 0;
            for (int i = 0; i < array.Length; i++)
            {
                cont = i + 1;
            }

            if (cont < getqtd_max())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
