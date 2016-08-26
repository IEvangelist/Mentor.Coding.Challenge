using System.Windows.Forms;
using Mentor.Coding.Challenge.Weather;

namespace Mentor.Coding.Challenge
{
    public partial class Main : Form
    {
        private readonly IWeatherService _weatherService = new WeatherService();

        public Main()
        {
            InitializeComponent();
        }

        private void OnStartButtonClick(object sender, System.EventArgs e)
        {
            // TODO: implement invocation...
        }
    }
}