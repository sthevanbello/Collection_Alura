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

            var aulaIntro = new Aula("Introdução às Coleções", 20);
            var aulaModelando = new Aula("Modelando a Classe Aula", 18);
            var aulaSets = new Aula("Trabalhando com Conjuntos", 16);


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

            #region Aula 02 Parte 01
            //List<string> listaAulas = new List<string>()
            //{
            //    aulaIntro, aulaModelando, aulaSets
            //};

            //listaAulas.Add("Lista Genéricas");



            //ImprimirLista(listaAulas);

            //Console.WriteLine($"Primeira aula: {listaAulas.FirstOrDefault()}");
            //Console.WriteLine($"Última aula: {listaAulas.LastOrDefault()}");

            //listaAulas[0] = "Trabalhando com Listas";

            //ImprimirLista(listaAulas);

            //Console.WriteLine($"\nA primeira aula 'Trabalhando' é: {listaAulas.FirstOrDefault(lista => lista.Contains("Trabalhando"))}");
            //Console.WriteLine($"\nA última aula 'Trabalhando' é: {listaAulas.LastOrDefault(lista => lista.Contains("Trabalhando"))}");
            //Console.WriteLine($"\nA última aula 'Conclusão' é: {listaAulas.LastOrDefault(lista => lista.Contains("Conslusao"))}");

            //listaAulas.Reverse();
            //ImprimirLista(listaAulas);

            //listaAulas.Reverse();
            //ImprimirLista(listaAulas);

            //listaAulas.Remove(listaAulas.LastOrDefault());
            //ImprimirLista(listaAulas);

            //listaAulas.Add("Conclusao");
            //ImprimirLista(listaAulas);

            //listaAulas.Sort();
            //ImprimirLista(listaAulas);

            //List<string> listaCopia = listaAulas.GetRange(listaAulas.Count - 2, 2);
            //ImprimirLista(listaCopia);

            //List<string> listaClone = new List<string>(listaAulas);
            //ImprimirLista(listaClone);

            //listaClone.RemoveRange(listaClone.Count - 2, 2);
            //ImprimirLista(listaClone);
            #endregion

            #region Aula 02 Parte 02
            //List<Aula> listaAulas = new List<Aula>();

            //listaAulas.Add(aulaIntro);
            //listaAulas.Add(aulaModelando);
            //listaAulas.Add(aulaSets);
            //listaAulas.Add(new Aula("Conclusão", 10));

            //Imprimir(listaAulas);

            //listaAulas.Sort();

            //Imprimir(listaAulas);

            //listaAulas.Sort((a, b) => a.Tempo.CompareTo(b.Tempo));

            //Imprimir(listaAulas);
            #endregion

            Curso cursos = new Curso(nome: "C# Collection", instrutor: "Marcelo Oliveira");

            cursos.InserirAula(new Aula(titulo: "Trabalhando com listas", 21));


            //Adding two new classes

            cursos.InserirAula(new Aula(titulo: "Criando uma aula", tempo: 20));
            cursos.InserirAula(new Aula(titulo: "Modelando com coleções", tempo: 19));


            //Order

            List<Aula> aulasCopy = new List<Aula>(cursos.Aulas);

            aulasCopy.Sort();

            //Imprimir(aulasCopy);

            //Time total of course

            //Console.WriteLine($"Tempo total em minutos: {cursos.TempoTotal()}");

            
            //Imprimir(aulasCopy);

            Console.WriteLine(cursos);

            Console.ReadKey();
            
        }

        private static void Imprimir(IList<Aula> listaAulas)
        {
            Console.Clear();

            foreach (var aula in listaAulas)
            {
                Console.WriteLine(aula);
            }
        }

       

    }

    
}
