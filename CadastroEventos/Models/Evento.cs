
namespace CadastroEventos.Models
{
    public class Evento
    {
        public string NomeEvento { get; set; } = string.Empty;

        public DateTime DataInicio { get; set; }

        public DateTime DataTermino { get; set; }

        public int NumeroParticipantes { get; set; }

        public string LocalEvento { get; set; } = string.Empty;

        public decimal CustoPorParticipante { get; set; }

        // Calcula a duração do evento em dias
        public int DuracaoEmDias
        {
            get
            {
                return (DataTermino.Date - DataInicio.Date).Days + 1;
            }
        }

        // Calcula o custo total do evento
        public decimal CustoTotal
        {
            get
            {
                return NumeroParticipantes * CustoPorParticipante;
            }
        }
    }
}
