using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projeto_Presidio
{
    class Presidio
    {
        private static List<Presidiario> Pres1;
        private static List<Presidiario> Pres2;
        private static List<Presidiario> Pres3;
       
       

        public Presidio(List<Presidiario> pres1, List<Presidiario> pres2, List<Presidiario> pres3 )
        {
            Pres1 = pres1;
            Pres2 = pres2;
            Pres3 = pres3;
           
        }

        public static void Cadastrar_presos()
        {
            FileStream Arq1 = new FileStream("../../../lista1.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw1 = new StreamWriter(Arq1, Encoding.UTF8);

            int n1 = Pres1.Count;

            for (int i = 0; i < n1; i++)
            {
                sw1.WriteLine(Pres1[i].ToString());
            }

            sw1.Close();
            Arq1.Close();

            FileStream Arq2 = new FileStream("../../../lista2.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw2 = new StreamWriter(Arq2, Encoding.UTF8);

            int n2 = Pres2.Count;

            for (int i = 0; i < n2; i++)
            {
                sw2.WriteLine(Pres2[i].ToString());
            }

            sw2.Close();
            Arq2.Close();

            FileStream Arq3 = new FileStream("../../../lista3.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw3 = new StreamWriter(Arq3, Encoding.UTF8);

            int n3 = Pres3.Count;

            for (int i = 0; i < n3; i++)
            {
                sw3.WriteLine(Pres3[i].ToString());
            }


            sw3.Close();
            Arq3.Close();
        }

        public static void Ver_Cela(int num)
        {
            if ( num == 1)
            {
                string line1;
                FileStream leituraCela1 = new FileStream("../../../lista1.txt", FileMode.Open, FileAccess.Read);
                StreamReader lerCela1 = new StreamReader(leituraCela1, Encoding.UTF8);
                int contador1 = 0;
                while ((line1 = lerCela1.ReadLine()) != null)
                {
                    Console.WriteLine(line1);
                    contador1++;
                }

                lerCela1.Close();
                leituraCela1.Close();
                
            }

            if (num == 2)
            {
                string line2;
                FileStream leituraCela2 = new FileStream("../../../lista2.txt", FileMode.Open, FileAccess.Read);
                StreamReader lerCela2 = new StreamReader(leituraCela2, Encoding.UTF8);
                int contador2 = 0;
                while ((line2 = lerCela2.ReadLine()) != null)
                {
                    Console.WriteLine(line2);
                    contador2++;
                }

                lerCela2.Close();
                leituraCela2.Close();

            }

            if (num == 3)
            {
                string line3;
                FileStream leituraCela3 = new FileStream("../../../lista3.txt", FileMode.Open, FileAccess.Read);
                StreamReader lerCela3 = new StreamReader(leituraCela3, Encoding.UTF8);
                int contador3 = 0;
                while ((line3 = lerCela3.ReadLine()) != null)
                {
                    Console.WriteLine(line3);
                    contador3++;
                }

                lerCela3.Close();
                leituraCela3.Close();
            }
        }
    }
}
