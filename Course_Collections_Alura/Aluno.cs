namespace Course_Collections_Alura
{
    public class Aluno
    {
        private string _nome;
        private int _matricula;


        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }


        public int NumeroMatricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }
        public Aluno(string nome, int matricula)
        {
            _nome = nome;
            _matricula = matricula;
        }

        public override string ToString()
        {
            return $"Nome do aluno(a) -    {Nome}\tMatrícula: {NumeroMatricula}";
        }

        public override bool Equals(object obj)
        {
            Aluno other = obj as Aluno;

            if (!(other is Aluno))
            {
                return false;
            }
            return _nome.Equals(other.Nome);
        }

        public override int GetHashCode()
        {
            return _nome.GetHashCode();
        }
    }
}