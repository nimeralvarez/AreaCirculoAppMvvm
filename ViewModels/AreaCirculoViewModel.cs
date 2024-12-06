
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AreaCirculoAppMvvm.ViewModels
{
    public partial class AreaCirculoViewModel:ObservableObject
    {
        [ObservableProperty] private double radio;
        [ObservableProperty] private string resultadoAreaCirculo;

        private void Alerta(string titulo, string mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(titulo, mensaje, "Aceptar"));
        }



        [RelayCommand]
        private void CalcularAreaDelCirculo()
        {
            double resultado = Math.Round((Math.PI * (Math.Pow(Radio, 2))), 2);
            ResultadoAreaCirculo = $"{resultado} cm";
        }

        [RelayCommand]
        private void Limpiar()
        {
            Radio = 0;
            ResultadoAreaCirculo = "";
        }

    }
}
