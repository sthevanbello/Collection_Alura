using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Collections_Alura
{
    class Curso
    {
        private IList<Aula> aulas;
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        private IDictionary<int, Aluno> alunosDictionary = new Dictionary<int, Aluno>();

        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }

        }

        private string _nome;
        private string _instrutor;


        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }



        public string Instrutor

        {
            get { return _instrutor; }
            set { _instrutor = value; }
        }
        public Curso(string nome, string instrutor)
        {
            _nome = nome;
            _instrutor = instrutor;
            aulas = new List<Aula>();
            
        }

        public void InserirAula(Aula aula)
        {
            aulas.Add(aula);
        }

        public void RemoverAula(Aula aula)
        {
            aulas.Remove(aula);
        }

        public int TempoTotal()
        {
            //int total = 0;

            //foreach (var item in Aulas)
            //{
            //    total += item.Tempo;
            //}

            //return total;

            //LINQ
            return aulas.Sum(t => t.Tempo);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome do curso: {Nome} ");
            sb.AppendLine($"Instrutor: {Instrutor} ");
            sb.AppendLine($"Tempo total do curso: {TempoTotal()} minutos");
            sb.AppendLine();
            //foreach (var aula in aulas)
            //{
            //    sb.AppendLine($"{aula}");
            //}
            sb.AppendLine($"{string.Join("\n", aulas)}");

            return $"{sb}";

        }

        internal void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
            alunosDictionary.Add(aluno.NumeroMatricula, aluno);
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            foreach (var item in alunos)
            {
                if (item.Equals(aluno))
                {
                    return true;
                }
            }
            return false;
        }

        internal Aluno BuscaMatriculado(int numeroNatricula)
        {
            //var aluno =  alunos.Where(a => a.NumeroMatricula == numeroNatricula).FirstOrDefault();
            //if (aluno == null)
            //{
            //    throw new Exception("Student not found");
            //}
            //return aluno;
            Aluno aluno = null;
            alunosDictionary.TryGetValue(numeroNatricula, out aluno);

            return aluno;
        }

        internal void SubstuiAluno(Aluno aluno)
        {
            alunosDictionary[aluno.NumeroMatricula] = aluno;
        }
    }
}
