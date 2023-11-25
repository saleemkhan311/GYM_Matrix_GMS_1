using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using System.Windows.Forms;

namespace GMS
{
    class WhatsAppCloud
    {
        public static void send()
        {
            

            var client = new RestClient("https://graph.facebook.com/v16.0/102127016182484/messages");

            var request = new RestRequest(Method.POST);

            request.AddHeader("Authorization", "Bearer EAAT9qZACSzlkBAPgsx2UgYZAt80PefyR8RatRTaJNKMTQ9vBsE1yKlkqT38GuZB9MYRPfFH07A9CQtrvmYkRdXroQZCxrvpw7HKTCtapOda9XiZBgbfsCcGzuplKd7eAFvjSTXJ88Qk2C545Lq5ZAHgflt9gCxENl1t1wYjI3mGrq7H45lLGzZCtqDZAW5D8dP9Q8INJlI0yJwZDZD");

            request.AddHeader("Content-Type", "application/json");

            request.AddParameter("application/json", "{ \"messaging_product\": \"whatsapp\", \"to\": \"923331245518\", \"type\": \"template\", \"template\": { \"name\": \"hello_world\", \"language\": { \"code\": \"en_US\" } } }", ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            var content = response.Content;
            MessageBox.Show(response.StatusCode.ToString());

        }
    }
}
