
using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto> // aqui eu puxo os objetos da classe QUARTO
        {
            new Quarto()
            {
                 Descricao = "Suíte Super Luxo",
                 ValorDiariaAdulto = 110.0,
                 ValorDiariaCrianca = 55.0
            },

            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 80.0,
                ValorDiariaCrianca = 40.0
            },

            new Quarto()
            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto = 50.0,
                ValorDiariaCrianca = 25.0
            }, 

            new Quarto()
            {
                Descricao = "Suíte Crise",
                ValorDiariaAdulto = 25,
                ValorDiariaCrianca = 12.50
            }

        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem()); // Aqui eu troco a tela inicial da MainPage para ContratacaoHospedagem
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {

            var window = base.CreateWindow(activationState);

            window.Height = 600;
            window.Width = 400;

            return window;
        } // Essa parte mexe apenas com as dimensões da janela 
    }
}
