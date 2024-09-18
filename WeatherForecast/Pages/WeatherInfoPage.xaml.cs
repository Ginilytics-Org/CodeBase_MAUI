using WeatherForecast.Services;

namespace WeatherForecast.Pages;

public partial class WeatherInfoPage : ContentPage
{
    private readonly WeatherApiService _weatherApiService;
    public List<Models.ApiModels.List> WeatherList;

    public double? _latitude;
    public double? _longitude;

    public WeatherInfoPage()
	{
		InitializeComponent();
        _weatherApiService = new WeatherApiService();

        WeatherList = new List<Models.ApiModels.List>();
	}

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        await GetLocation();
        await GetWeatherInfoByLocation(_latitude, _longitude);
    }

    public async Task GetLocation()
    {
        var location = await Geolocation.GetLocationAsync();

        _latitude = location?.Latitude;
        _longitude = location?.Longitude;
    }

    private async Task GetWeatherInfoByLocation(double? latitude, double? longitude)
    {

        if (latitude != null && longitude != null)
        {
            var data = await _weatherApiService.GetWeatherInfo(_latitude.ToString(), _longitude.ToString());

            foreach (var item in data.list)
            {
                WeatherList.Add(item);
            }

            CvWeather.ItemsSource = WeatherList;

            LblCity.Text = data.city.name;
            LblWeatherDescription.Text = data.list[0].weather[0].description;
            LblTemp.Text = data.list[0].main.temperature + "°C";
            LblHumidity.Text = data.list[0].main.humidity + "%";
            LblWind.Text = data.list[0].wind.speed + "Km/h";

            WeatherIcon.Source = data.list[0].weather[0].iconUrl;
        }
    }
    private async void TapLocation_Tapped(object sender, TappedEventArgs e)
    {
        await GetLocation();
        await GetWeatherInfoByLocation(_latitude, _longitude);
    }
}