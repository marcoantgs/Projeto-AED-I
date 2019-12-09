using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Projeto_Presidio
{
    class Data
    {
        private int dia, mes, ano;

        public Data()
        {

        }

        public int getDia()
        {
            return dia;
        }
        public int getMes()
        {
            return mes;
        }
        public int getAno()
        {
            return ano;
        }
        public void setDia(int d)
        {
            dia = d;
        }

        public void setMes(int m)
        {
            mes = m;
        }

        public void setAno(int a)
        {
            ano = a;
        }

        public bool setData(string data)
        {
            string[] dat = data.Split('/');
            dia = int.Parse(dat[0]);
            mes = int.Parse(dat[1]);
            ano = int.Parse(dat[2]);

            if (dia < MaxDiasMes())
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public Data(string data)
        {
            string[] dat = data.Split('/');
            dia = int.Parse(dat[0]);
            mes = int.Parse(dat[1]);
            ano = int.Parse(dat[2]);
        }

        public Data(int d, int m, int a)
        {
            dia = d;
            mes = m;
            ano = a;
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}/{2}", dia, mes, ano);
        }

        public bool Bissexto()
        {
            return (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);
        }

        public int MaxDiasMes()
        {
            switch (mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return Bissexto() ? 29 : 28;
                default:
                    return 0;
            }
        }

        private void IncrementaUmDia()
        {
            if (dia < MaxDiasMes())
            {
                dia++;
            }
            else
            {
                dia = 1;
                if (mes == 12)
                {
                    mes = 1;
                    ano++;
                }
                else
                {
                    mes++;
                }
            }
        }

        public void Incrementa(int dias)
        {
            for (int cont = 1; cont <= dias; cont++)
                IncrementaUmDia();
        }

        public bool Maior(Data outra_data)
        {
            if (outra_data.ano < ano)
            {
                return true;
            }

            else if (outra_data.ano == ano && outra_data.mes < mes)
            {
                return true;

            }

            else if (outra_data.ano == ano && outra_data.ano == mes && outra_data.dia < dia)
            {
                return true;
            }
            return false;
        }

        public bool Igual(Data outra_data)
        {
            if (outra_data.ano == ano)
            {
                if (outra_data.mes == mes)
                {
                    if (outra_data.mes == mes)
                    {
                        return true;
                    }

                }
            }
            return false;
        }

        public int Diferenca_dias(Data outra)
        {
            Data maior, menor;

            if (Maior(outra))
            {
                maior = this;
                menor = new Data(outra.dia, outra.mes, outra.ano);
            }
            else
            {
                maior = outra;
                menor = new Data(this.dia, this.mes, this.ano);
            }

            int dif_dias = 0;
            int dif_anos = 0;

            while (!menor.Igual(maior))
            {
                menor.IncrementaUmDia();
                dif_dias++;
                if (Bissexto() == true)
                {
                    if (dif_dias == 366)
                    {
                        dif_anos++;
                        dif_dias = 0;
                    }
                }
                else
                {
                    if (dif_dias == 365)
                    {
                        dif_anos++;
                        dif_dias = 0;
                    }
                }
            }
            return dif_dias;
        }

        public int Diferenca_anos(Data outra)
        {
            Data maior, menor;

            if (Maior(outra))
            {
                maior = this;
                menor = new Data(outra.dia, outra.mes, outra.ano);
            }
            else
            {
                maior = outra;
                menor = new Data(this.dia, this.mes, this.ano);
            }

            int dif_dias = 0;
            int dif_anos = 0;

            while (!menor.Igual(maior))
            {
                menor.IncrementaUmDia();
                dif_dias++;

                if (Bissexto() == true)
                {
                    if (dif_dias == 366)
                    {
                        dif_anos++;
                        dif_dias = 0;
                    }
                }
                else
                {
                    if (dif_dias == 365)
                    {
                        dif_anos++;
                        dif_dias = 0;
                    }
                }
            }
            return dif_anos;
        }

    }
}
