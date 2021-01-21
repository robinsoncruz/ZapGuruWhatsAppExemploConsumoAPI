using System.Net.Http;
using ZapGuruConsumoAPI.Communication;

namespace ZapGuruConsumoAPI.Service
{
    public abstract class Service
    {
        public readonly HttpClient cliente = HttpInstance.GetHttpClient;
        public readonly string key = "adicionesuachave";
        public readonly string account_id = "adicioneseuaccountid";
        public readonly string phone_id = "adicioneseuphoneid";
    }
}
