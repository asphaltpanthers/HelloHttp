using System;
using System.Net.Http;
using System.Text;

namespace HelloHttp
{
    public static class Api
    {
        public static String Get(Uri uri)
        {
            using (var client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, uri);
                HttpResponseMessage response = client.SendAsync(request).Result;
                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    throw new System.Net.WebException(response.Content.ReadAsStringAsync().Result);
                }
            }
        }

        public static String Post(Uri uri, String payload)
        {
            using (var client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, uri);
                request.Content = new StringContent(payload.ToString(), Encoding.UTF8, "application/json");

                HttpResponseMessage response = client.SendAsync(request).Result;
                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    throw new System.Net.WebException(response.Content.ReadAsStringAsync().Result);
                }
            }
        }
    }
}