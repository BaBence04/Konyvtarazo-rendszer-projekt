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
            try
            {
                using (var client = new HttpClient())
                using (var content = new MultipartFormDataContent())
                {
                    foreach (var pair in args)
                    {
                        content.Add(new StringContent(pair.Value), pair.Key);
                    }

                    var response = await client.PostAsync("http://localhost:8000/BACKEND/api.php", content);
                    var responseString = await response.Content.ReadAsStringAsync();

                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    var responseDir = serializer.Deserialize(responseString, typeof(List<Dictionary<string, string>>));

                    return responseDir;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException?.Message);
            }
            return null;
        }


    }
}

