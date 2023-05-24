
namespace ExPolimorfismo.Entities
{
    public class Gerente : Colaborador
    {
        public double Bonificacao { get; private set; }

        public Gerente(string nome, string cpf, double bonificacao) : base(nome, cpf)
        {
            Bonificacao = bonificacao;
        }

        public void SetBonificação(double bonificacao)
        {
            Bonificacao = bonificacao;
        }

        public override double CalcularSalario()
        {
            double total = SalarioMinimo * 6 + Bonificacao;
            return total;
        }

        public override string? ToString()
        {
            return "Colaborador " + Nome + ", CPF n° " + Cpf + ", valor da sua Bonificação é R$" + Bonificacao.ToString("F2");
        }
    }
}
