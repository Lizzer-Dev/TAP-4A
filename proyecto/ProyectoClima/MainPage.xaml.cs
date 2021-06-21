using ProjectClima.Model;
using ProjectClima.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjectClima
{
    public partial class MainPage : ContentPage
    {
        ServiceClima _restService;

        public MainPage()
        {
            InitializeComponent();
            _restService = new ServiceClima();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cityEntry.Text))
            {
                Clima weatherData = await _restService.GetWeatherDataAsync(GenerateRequestUri(Constants.OpenWeatherMapEndpoint));
                BindingContext = weatherData;
            }
        }

        string GenerateRequestUri(string endpoint)
        {
            string requestUri = endpoint;
            requestUri += $"?q={cityEntry.Text}";
            requestUri += "&units=imperial"; // or units=metric
            requestUri += $"&APPID={Constants.OpenWeatherMapAPIKey}";
            return requestUri;
        }
    }
}
