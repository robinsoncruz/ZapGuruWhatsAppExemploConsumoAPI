using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ZapGuruConsumoAPI.Communication
{
    public static class HttpInstance
    {
        public static HttpClient httpClientIntance;
        private const string UriServico = "https://app3.zap.guru/api/v1";

        public static HttpClient GetHttpClient
        {
            get
            {
                if (httpClientIntance == null)
                {
                    httpClientIntance = new HttpClient();
                    httpClientIntance.BaseAddress = new Uri(UriServico);
                    httpClientIntance.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json")
                    );

                    httpClientIntance.DefaultRequestHeaders.ConnectionClose = false;
                }
                return httpClientIntance;
            }
        }

        public static void Dispose()
        {
            httpClientIntance.Dispose();
        }

    }

}
