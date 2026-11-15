
using CadastroEventos.Models;
using CadastroEventos.ViewModels;

namespace CadastroEventos.Views;

public partial class CadastroEventoPage : ContentPage
{
    public CadastroEventoPage()
    {
        InitializeComponent();
        BindingContext = new EventoViewModel();
    }

    private async void OnContinuarClicked(
        object sender, EventArgs e)
    {
        var vm = (EventoViewModel)BindingContext;

        if (string.IsNullOrWhiteSpace(vm.NomeEvento))
        {
            await DisplayAlert("Atenção",
                "Informe o nome do evento.", "OK");
            return;
        }

        if (vm.DataTermino.Date < vm.DataInicio.Date)
        {
            await DisplayAlert("Atenção",
                "A data de término não pode ser anterior à data de início.", "OK");
            return;
        }

        if (vm.NumeroParticipantes <= 0)
        {
            await DisplayAlert("Atenção",
                "Informe um número válido de participantes.", "OK");
            return;
        }

        if (string.IsNullOrWhiteSpace(vm.LocalEvento))
        {
            await DisplayAlert("Atenção",
                "Informe o local do evento.", "OK");
            return;
        }

        if (vm.CustoPorParticipante < 0)
        {
            await DisplayAlert("Atenção",
                "O custo não pode ser negativo.", "OK");
            return;
        }

        Evento evento = new Evento
        {
            NomeEvento = vm.NomeEvento,
            DataInicio = vm.DataInicio,
            DataTermino = vm.DataTermino,
            NumeroParticipantes = vm.NumeroParticipantes,
            LocalEvento = vm.LocalEvento,
            CustoPorParticipante = vm.CustoPorParticipante
        };

        await Navigation.PushAsync(
            new ResumoEventoPage(evento));
    }
}
