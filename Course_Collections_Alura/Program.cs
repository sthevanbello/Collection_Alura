using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Collections_Alura
{
    class Program
    {
        static void Main(string[] args)
        {

            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";


            #region Aula 01
            //string[] aulas = new string[]
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            //Console.WriteLine($"Aula modelando está no índice: {Array.IndexOf(aulas, aulaModelando)}");

            //Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));

            //Array.Reverse(aulas);

            //Imprimir(aulas);

            //Array.Reverse(aulas);

            //Imprimir(aulas);

            //Array.Resize(ref aulas, 2);
            //Imprimir(aulas);

            //Array.Resize(ref aulas, 3);
            //aulas[aulas.Length -1] = "Conclusao";
            //Imprimir(aulas);

            //Array.Sort(aulas);
            //Imprimir(aulas);

            //string[] copia = new string[2];

            //Array.Copy(aulas, 1, copia, 0, 2);

            //Imprimir(copia);

            //string[] clone = aulas.Clone() as string[];
            //Imprimir(clone);

            //Array.Clear(clone, 1, 2);
            //Imprimir(clone);
            #endregion

            List<string> lista = new List<string>()
            {
                aulaIntro, aulaModelando, aulaSets
            };

            ImprimirLista(lista);

            Console.ReadKey();
        }

        private static void ImprimirLista(List<string> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        private static void ImprimirString(string[] aulas)
        {
            foreach (var item in aulas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
