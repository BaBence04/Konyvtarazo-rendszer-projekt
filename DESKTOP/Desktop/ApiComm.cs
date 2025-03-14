using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using System.ComponentModel;
using System.Web.Script.Serialization;

namespace Desktop
{
    internal class ApiComm
    {
        public static async Task<object> SendPost(Dictionary<string, string> args)
        {
            var client = new HttpClient();
            //var content = new FormUrlEncodedContent(args);
            string parameters = "";
            foreach(KeyValuePair<string, string> line in args)
            {
                parameters += $"{line.Key}={line.Value}&";
            }
            parameters.Remove(parameters.Length - 1);
            var content = new StringContent(parameters, Encoding.UTF8, "application/x-www-form-urlencoded");
            var response = await client.PostAsync("http://localhost:8000/BACKEND/api.php", content);
            var responseString = await response.Content.ReadAsStringAsync();
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var responseDir = serializer.Deserialize(responseString, typeof(List<Dictionary<string, string>>));
            client.Dispose();

            return responseDir;
        }

    }
}

