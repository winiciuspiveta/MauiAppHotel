
namespace MauiAppHotel
{
    public partial class App : Application
    {
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
