namespace ExPolimorfismo.Entities
{
    public abstract class Colaborador
    {
        public const double SalarioMinimo = 1320;
        public string Nome { get; private set; }
        public string Cpf { get; private set; }

        public Colaborador(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public void SetCpf(string cpf)
        {
            Cpf = cpf;
        }
        public abstract double CalcularSalario();

    }
}
