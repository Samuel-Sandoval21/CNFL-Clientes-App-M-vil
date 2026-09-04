using CNFLAppMobile.Views;

namespace CNFLAppMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Iniciar en Home Pública (sin login)
            return new Window(new HomePublicPage());
        }
    }
}