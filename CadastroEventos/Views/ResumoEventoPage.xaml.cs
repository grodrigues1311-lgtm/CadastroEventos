
using CadastroEventos.Models;

namespace CadastroEventos.Views;

public partial class ResumoEventoPage : ContentPage
{
    public ResumoEventoPage(Evento evento)
    {
        InitializeComponent();
        BindingContext = evento;
    }
}

