using Laboratorio16.ViewModels;
using System;
using Xamarin.Forms;

namespace Laboratorio16
{
    public partial class MainPage : ContentPage
    {
        private ApiManager _apiManager;

        public MainPage()
        {
            InitializeComponent();
            _apiManager = new ApiManager();
            LoadData();
        }

        private async void LoadData()
        {
            try
            {
                Console.WriteLine("Iniciando carga de datos...");

                var places = await _apiManager.GetPlacesAsync();

                // Imprimir datos en la consola
                foreach (var place in places)
                {
                    Console.WriteLine($"Nombre: {place.Name}, Ciudad: {place.Location.City}, Precio: {place.Price}");
                }

                // Asignar la lista de lugares al origen de datos del ListView
                placesListView.ItemsSource = places;

                // Notificar a la interfaz de usuario que los datos han cambiado
                OnPropertyChanged(nameof(places));

                Console.WriteLine("Datos cargados correctamente.");
            }
            catch (Exception ex)
            {
                // Imprimir detalles del error en la consola
                Console.WriteLine($"Error: {ex.Message}");
                // Manejar errores aquí
            }
        }
    }
}
