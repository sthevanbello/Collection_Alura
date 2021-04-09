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

            //var aulaIntro = new Aula("Introdução às Coleções", 20);
            //var aulaModelando = new Aula("Modelando a Classe Aula", 18);
            //var aulaSets = new Aula("Trabalhando com Conjuntos", 16);


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

            #region Aula 02 Parte 03
            //Curso cursos = new Curso(nome: "C# Collection", instrutor: "Marcelo Oliveira");

            //cursos.InserirAula(new Aula(titulo: "Trabalhando com listas", 21));


            ////Adding two new classes

            //cursos.InserirAula(new Aula(titulo: "Criando uma aula", tempo: 20));
            //cursos.InserirAula(new Aula(titulo: "Modelando com coleções", tempo: 19));


            ////Order

            //List<Aula> aulasCopy = new List<Aula>(cursos.Aulas);

            //aulasCopy.Sort();

            ////Imprimir(aulasCopy);

            ////Time total of course

            ////Console.WriteLine($"Tempo total em minutos: {cursos.TempoTotal()}");


            ////Imprimir(aulasCopy);

            //Console.WriteLine(cursos);
            #endregion

            #region Aula 03 Parte 01
            //ISet<string> alunos = new HashSet<string>();
            //alunos.Add("Vanessa Tonini");
            //alunos.Add("Ana Losnak");
            //alunos.Add("Rafael Nercessian");

            //Console.WriteLine(string.Join("\n", alunos));

            //alunos.Add("Priscila Stuani");
            //alunos.Add("Rafael Rollo");
            //alunos.Add("Fabio Gushiken");

            //alunos.Remove("Ana Losnak");
            //alunos.Add("Marcelo Oliveira");

            //Console.WriteLine(string.Join("\n", alunos));
            //alunos.Add("Fabio Gushiken");
            //Console.WriteLine(string.Join("\n", alunos));

            //List<string> lista = new List<string>(alunos);

            //lista.Sort();
            //Console.WriteLine("=========================");
            //Console.WriteLine("\tOrdenados");
            //Console.WriteLine(string.Join("\n", lista));
            #endregion

            #region Aula 03 Parte 02
            Curso csharpCollections = new Curso(nome: "C# Collections", instrutor: "Marcelo Oliveira");

            csharpCollections.InserirAula(new Aula(titulo: "Trabalhando com listas", 21));
            csharpCollections.InserirAula(new Aula(titulo: "Crianda uma Aula", 20));
            csharpCollections.InserirAula(new Aula(titulo: "Modelando com coleções", 24));

            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            csharpCollections.Matricula(a1);
            csharpCollections.Matricula(a2);
            csharpCollections.Matricula(a3);

            ImprimirAluno(csharpCollections);

            Console.WriteLine($"O aluno {a1.Nome} está matriculado?");

            Console.WriteLine(csharpCollections.EstaMatriculado(a1));


            Aluno tonini = new Aluno("Vanessa Tonini", 34672);

            Console.WriteLine("Tonini está matriculada? " + csharpCollections.EstaMatriculado(tonini));
            Console.WriteLine("Tonini está matriculada? " + csharpCollections.EstaMatriculado(tonini));
            Console.WriteLine(a1 == tonini);
            Console.WriteLine(a1.Equals(tonini));
            #endregion

            #region Aula 04 Parte 01

            Console.Clear();
            try
            {
                Aluno aluno5617 = csharpCollections.BuscaMatriculado(5617);
                Console.WriteLine($"Aluno(a) 5617: {aluno5617}");
                Aluno aluno5618 = csharpCollections.BuscaMatriculado(5618);
                Console.WriteLine($"Aluno(a) 5618: {aluno5618}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            var fabio = new Aluno(nome: "Fabio Gushiken", matricula: 5617);
            //csharpCollections.Matricula(new Aluno(nome: "Fabio Gushiken", matricula: 5617));

            csharpCollections.SubstuiAluno(fabio);

            Console.WriteLine(csharpCollections.BuscaMatriculado(5617));

            #endregion

            Console.ReadKey();
        }
        private static void ImprimirAluno(Curso csharpCollections)
        {
            foreach (var item in csharpCollections.Alunos)
            {
                Console.WriteLine(item);
            }
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
