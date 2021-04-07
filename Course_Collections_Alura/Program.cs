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

            List<string> listaAulas = new List<string>()
            {
                aulaIntro, aulaModelando, aulaSets
            };

            listaAulas.Add("Lista Genéricas");



            ImprimirLista(listaAulas);

            Console.WriteLine($"Primeira aula: {listaAulas.FirstOrDefault()}");
            Console.WriteLine($"Última aula: {listaAulas.LastOrDefault()}");

            listaAulas[0] = "Trabalhando com Listas";

            ImprimirLista(listaAulas);

            Console.WriteLine($"\nA primeira aula 'Trabalhando' é: {listaAulas.FirstOrDefault(lista => lista.Contains("Trabalhando"))}");
            Console.WriteLine($"\nA última aula 'Trabalhando' é: {listaAulas.LastOrDefault(lista => lista.Contains("Trabalhando"))}");
            Console.WriteLine($"\nA última aula 'Conclusão' é: {listaAulas.LastOrDefault(lista => lista.Contains("Conslusao"))}");

            listaAulas.Reverse();
            ImprimirLista(listaAulas);

            listaAulas.Reverse();
            ImprimirLista(listaAulas);

            listaAulas.Remove(listaAulas.LastOrDefault());
            ImprimirLista(listaAulas);

            listaAulas.Add("Conclusao");
            ImprimirLista(listaAulas);

            listaAulas.Sort();
            ImprimirLista(listaAulas);

            List<string> listaCopia = listaAulas.GetRange(listaAulas.Count-2, 2);
            ImprimirLista(listaCopia);

            List<string> listaClone = new List<string>(listaAulas);
            ImprimirLista(listaClone);

            listaClone.RemoveRange(listaClone.Count - 2, 2);
            ImprimirLista(listaClone);

            Console.ReadKey();
        }

        private static void ImprimirLista(List<string> lista)
        {
            //foreach (var item in lista)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine();
            lista.ForEach(aula =>
            {
                Console.WriteLine($"{aula}");
            });
            Console.WriteLine();
            
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
