using MauiApp1RebenewMVM.Services;
using MauiApp1RebenewMVM.ViewModels;

namespace MauiApp1RebenewMVM.Views;

public partial class LibrosPageRebe : ContentPage
{
	private readonly LibroViewModel _viewModel;
	public LibrosPageRebe()
    {
        InitializeComponent();
        _viewModel = new LibroViewModel();

        var libroService = DependencyService.Get<ILibroServiceRebe>();

        var libros = libroService.ObtenerLibro();

        _viewModel.Libros = libros;

        BindingContext = _viewModel;
    }
}