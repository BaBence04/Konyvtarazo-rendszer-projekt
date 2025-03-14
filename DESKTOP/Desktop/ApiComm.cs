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
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            //var content = new FormUrlEncodedContent(values);

            var jsonString = serializer.Serialize(args);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("http://localhost:8000/BACKEND/api.php", content);
            var responseString = await response.Content.ReadAsStringAsync();
            
            var responseDir = serializer.Deserialize(responseString, typeof(List<Dictionary<string, string>>));
            client.Dispose();

            return responseDir;
        }

    }
}

