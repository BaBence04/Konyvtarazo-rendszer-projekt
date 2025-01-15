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
=======
﻿using System;
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
            var values = args;
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("http://localhost:84/Konyvtarazo-rendszer-projekt-main/BACKEND/api.php", content);
            var responseString = await response.Content.ReadAsStringAsync();
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var responseDir = serializer.Deserialize(responseString, typeof(List<Dictionary<string, string>>));
            Console.WriteLine(responseString);
            /*//THIS IS MAY BE TEMPORARY BUT IT SHOULD WORK IT'S JUST UGLY
            object responseDir;
            try
            {
                
            }
            catch (Exception ex)
            {
                if(ex is InvalidOperationException)
                {
                    responseDir = serializer.Deserialize(responseString, typeof(Dictionary<string, string>));
                }
                else
                {
                    throw ex;
                }
                
            }*/
            
            client.Dispose();
            return responseDir;
        }

    }
}
>>>>>>> Stashed changes
