using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace WeatherApp.Models
{
    public class WeatherClass
    {
        public Object getWeatherForecast()
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Cleveland&APPID=dcc54514a9fb87e33b7c1ebf436bc9a4&units=imperial";
            //synchronous client
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }
    }
}