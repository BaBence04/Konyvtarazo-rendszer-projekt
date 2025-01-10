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
        public static async Task<object> SendPost()
        {
            var client = new HttpClient();
            var values = new Dictionary<string, string> { { "test", "ping" } };
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("http://localhost:84/Konyvtarazo-rendszer-projekt-main/BACKEND/api.php", content);
            var responseString = await response.Content.ReadAsStringAsync();
            return responseString;
            client.Dispose();
        }

    }
}
