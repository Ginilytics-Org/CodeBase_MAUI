using WeatherForecast.Pages;

namespace WeatherForecast
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new WeatherInfoPage();
        }
    }
}
