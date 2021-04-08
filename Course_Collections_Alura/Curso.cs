using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Collections_Alura
{
    class Curso
    {
        private List<Aula> aulas;

        public List<Aula> Aulas
        {
            get { return aulas; }
            set { aulas = value; }
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
        }



    }
}
