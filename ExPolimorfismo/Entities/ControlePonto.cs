namespace ExPolimorfismo.Entities
{
    public class ControlePonto
    {
        public void RegistrarEntrada(Colaborador funcionario)
        {
            ImprimirComprovante(funcionario, true);

        }
        public void RegistrarSaida(Colaborador funcionario)
        {
            ImprimirComprovante(funcionario, false);
        }

        public void ImprimirComprovante(Colaborador funcionario, bool ehEntrada)
        {
            string tipoEntrada = ehEntrada ? "Entrada" : "Saida"; // operador ternario
            Console.WriteLine(tipoEntrada + " : " + DateTime.Now);
            Console.WriteLine("Funcionario: " + funcionario.Nome);
            Console.WriteLine("Cargo " + funcionario.GetType().Name);
        }

    }
}
