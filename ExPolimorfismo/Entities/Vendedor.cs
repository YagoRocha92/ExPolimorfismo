namespace ExPolimorfismo.Entities
{
    public class Vendedor : Colaborador
    {
        public double Comissao { get; private set; }
        public long NumeroVendas { get; private set; }

        public Vendedor(string nome, string cpf, double comissao, long numeroVendas) : base(nome, cpf)
        {
            Comissao = comissao;
            NumeroVendas = numeroVendas;
        }

        public void SetComissao(double comissao)
        {
            Comissao = comissao;
        }
        public void SetNumeroVendas(long numeroVendas)
        {
            NumeroVendas = numeroVendas;
        }

        public override double CalcularSalario()
        {
            double total = (Comissao * NumeroVendas) + SalarioMinimo;
            return total;
        }

        public override string? ToString()
        {
            return "Colaborador " + Nome + ", CPF n° " + Cpf + ", e o valor da sua comissão é R$" + Comissao.ToString("F2") +
                " realizou um total de " + NumeroVendas + " vendas";
        }
    }
}
