using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaBoletinEscolar
{
    public class Boletim
    {
        public int CalculaMedia(int valor1, int valor2, int valor3)
        {
            return (valor1 + valor2 + valor3) / 3;
        }

        public int CalculaFrequencia(int Faltas, int TotalAulas)
        {

            // if (Faltas <= TotalAulas*0.25)
            // {
            //     frequencia = 1;
            // }
            //
            // else
            // frequencia = 0;

            return (TotalAulas - Faltas) * 100 / TotalAulas;

        }

        public void situacao(int media, int frequecia)
        {
            if ((media >= 7) && (frequecia >= 75))
            {
                Console.WriteLine("O aluno foi Aprovado");
            }

            else
                Console.WriteLine("O aluno foi Reprovado");
            }

        }

    }






