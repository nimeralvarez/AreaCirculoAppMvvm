using AreaCirculoAppMvvm.ViewModels;
namespace AreaCirculoAppMvvm.Views;

public partial class AreaCirculoMainView : ContentPage
{
	AreaCirculoViewModel viewModel;
	public AreaCirculoMainView()
	{
		InitializeComponent();
		viewModel = new AreaCirculoViewModel();
		BindingContext= viewModel;
	}
}