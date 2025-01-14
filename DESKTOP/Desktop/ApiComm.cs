using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using System.ComponentModel;

namespace Desktop
{
    internal class ApiComm
    {
        public static async Task<object> SendPost(Dictionary<string, string> args)
        {
            var client = new HttpClient();
            var values = args;
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("http://localhost:8000/api.php", content);
            var responseString = await response.Content.ReadAsStringAsync();
            client.Dispose();
            return responseString;
        }

    }
}
