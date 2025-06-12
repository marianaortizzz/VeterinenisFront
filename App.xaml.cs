using Veterinaria.Views;

namespace Veterinaria
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var registroMascota = new RegistroMascotaPage();
            return new Window(new NavigationPage(registroMascota));
        }
    }
}