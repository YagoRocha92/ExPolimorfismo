using ExPolimorfismo.Entities;

namespace ExPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vendedor empregado = new Vendedor("Joao", "407.505.444-35", 50.0, 15);

            Consultor empregadoConsultor = new Consultor("Manoel", "409.505.444-35", 14.5, 180);

            Gerente empregadoGerente = new Gerente("Yago", "407.050.333.45", 7000.0);


            Console.WriteLine();
            Console.WriteLine("Vendedor");
            Console.WriteLine(empregado);
            Console.WriteLine("Salario a receber R$" + empregado.CalcularSalario().ToString("F2"));

            Console.WriteLine();
            ControlePonto meuControleVendedor = new ControlePonto();
            meuControleVendedor.RegistrarEntrada(empregado);

            Console.WriteLine();
            Console.WriteLine("Consultor");
            Console.WriteLine(empregadoConsultor);
            Console.WriteLine("Salario a receber R$" + empregadoConsultor.CalcularSalario().ToString("F2"));

            Console.WriteLine();
            ControlePonto meuControleConsultor = new ControlePonto();
            meuControleConsultor.RegistrarEntrada(empregadoConsultor);
            meuControleConsultor.RegistrarSaida(empregadoConsultor);


            Console.WriteLine();
            Console.WriteLine("Gerente");
            Console.WriteLine(empregadoGerente);
            Console.WriteLine("Salario a receber R$" + empregadoGerente.CalcularSalario().ToString("F2"));

            Console.WriteLine();
            ControlePonto meuControle = new ControlePonto();
            meuControle.RegistrarEntrada(empregadoGerente);
        }
    }
}