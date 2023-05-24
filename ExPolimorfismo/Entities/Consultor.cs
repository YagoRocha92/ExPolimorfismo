namespace ExPolimorfismo.Entities
{
    public class Consultor : Colaborador
    {
        public double ValorHora { get; private set; }
        public long HorasTrabalhadas { get; private set; }

        public Consultor(string nome, string cpf, double valorHora, long horasTrabalhadas) : base(nome, cpf)
        {
            ValorHora = valorHora;
            HorasTrabalhadas = horasTrabalhadas;
        }

        public void SetValorHora(double valorHora)
        {
            ValorHora = valorHora;
        }
        public void SetHorasTrabalhadas(long horasTrabalhadas)
        {
            HorasTrabalhadas = horasTrabalhadas;
        }
        public override double CalcularSalario()
        {
            double total = ValorHora * HorasTrabalhadas;
            return total;
        }
        public override string? ToString()
        {
            return "Colaborador " + Nome + ", CPF n° " + Cpf + ", valor da hora trabalhada R$" + ValorHora.ToString("F2") +
                " e a quantidade de horas nesse mês foi de " + HorasTrabalhadas + " horas";
        }
    }
}
