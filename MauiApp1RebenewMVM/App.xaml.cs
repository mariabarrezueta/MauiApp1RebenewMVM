using MauiApp1RebenewMVM.Services;

namespace MauiApp1RebenewMVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<ILibroServiceRebe, LibroServiceRebe>();

            MainPage = new AppShell();
        }
    }
}
