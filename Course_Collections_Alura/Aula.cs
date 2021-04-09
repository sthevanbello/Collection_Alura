using System;

namespace Course_Collections_Alura
{
    internal class Aula : IComparable
    {
        public Aula()
        {
        }


        public string Titulo { get; set; }
        public int Tempo { get; set; }

        
        public Aula(string titulo, int tempo)
        {
            Titulo = titulo;
            Tempo = tempo;
        }

        public override string ToString()
        {
            return $"Título da aula: {Titulo} - Tempo da aula: {Tempo} minutos";
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Aula))
            {
                throw new Exception("This object not is Aula");
            }

            Aula other = obj as Aula;

            return Titulo.CompareTo(other.Titulo);

        }
    }
}