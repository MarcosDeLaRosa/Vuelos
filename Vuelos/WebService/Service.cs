using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.WebService
{
    class Service
    {


        public string clima(string longitud, string latitud) {


            string strResponseValue = string.Empty;

                StringBuilder sb = new StringBuilder();
                sb.Append("http://api.openweathermap.org/data/2.5/weather?");
                sb.Append("lat=" + latitud + "&");
                sb.Append("lon=" + longitud);
                sb.Append("&APPID=f1626dc4ff8e1c59474637274cd00f8d");

                Uri url = new Uri(sb.ToString());
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
              
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                strResponseValue = reader.ReadToEnd();


            return strResponseValue;

        }

    }
}
