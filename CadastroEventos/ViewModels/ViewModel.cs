
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CadastroEventos.ViewModels
{
    public class EventoViewModel : INotifyPropertyChanged
    {
        private string nomeEvento = string.Empty;
        private DateTime dataInicio = DateTime.Today;
        private DateTime dataTermino = DateTime.Today;
        private int numeroParticipantes;
        private string localEvento = string.Empty;
        private decimal custoPorParticipante;

        public string NomeEvento
        {
            get => nomeEvento;
            set => AtualizarPropriedade(ref nomeEvento, value);
        }

        public DateTime DataInicio
        {
            get => dataInicio;
            set => AtualizarPropriedade(ref dataInicio, value);
        }

        public DateTime DataTermino
        {
            get => dataTermino;
            set => AtualizarPropriedade(ref dataTermino, value);
        }

        public int NumeroParticipantes
        {
            get => numeroParticipantes;
            set
            {
                if (AtualizarPropriedade(ref numeroParticipantes, value))
                    OnPropertyChanged(nameof(CustoTotal));
            }
        }

        public string LocalEvento
        {
            get => localEvento;
            set => AtualizarPropriedade(ref localEvento, value);
        }

        public decimal CustoPorParticipante
        {
            get => custoPorParticipante;
            set
            {
                if (AtualizarPropriedade(ref custoPorParticipante, value))
                    OnPropertyChanged(nameof(CustoTotal));
            }
        }

        public int DuracaoEmDias =>
            (DataTermino.Date - DataInicio.Date).Days + 1;

        public decimal CustoTotal =>
            NumeroParticipantes * CustoPorParticipante;

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(
            [CallerMemberName] string? nome = null)
        {
            PropertyChanged?.Invoke(
                this, new PropertyChangedEventArgs(nome));
        }

        protected bool AtualizarPropriedade<T>(
            ref T campo, T valor,
            [CallerMemberName] string? nome = null)
        {
            if (EqualityComparer<T>.Default.Equals(campo, valor))
                return false;

            campo = valor;
            OnPropertyChanged(nome);
            return true;
        }
    }
}

