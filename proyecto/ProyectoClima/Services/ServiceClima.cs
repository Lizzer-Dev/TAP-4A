using Newtonsoft.Json;
using ProjectClima.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static Android.App.DownloadManager;

namespace ProjectClima.Services
{
    public class ServiceClima
    {
        HttpClient _client;

        public ServiceClima()
        {
            _client = new HttpClient();
        }

        public async Task<Clima> GetWeatherDataAsync(string uri)
        {
            Clima weatherData = null;
            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    weatherData = JsonConvert.DeserializeObject<Clima>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\tERROR {0}", ex.Message);
            }

            return weatherData;
        }
    }
}
