using System.Diagnostics.CodeAnalysis;

namespace APIVigilian.Modelos
{
    public class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string PontoDeVigia { get; set; }
        public DateTime DiaDeServico { get; set; }
        public TimeSpan HorarioDoServico { get; set; }
        public TimeSpan HorarioFinalDoServico { get; set; }
        public decimal Salario { get; set; }
        public bool Disponibilidade { get; set; }

    }
}
