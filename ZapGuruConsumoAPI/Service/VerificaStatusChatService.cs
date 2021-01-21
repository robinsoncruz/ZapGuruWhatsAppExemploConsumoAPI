using Newtonsoft.Json;
using System.Threading.Tasks;
using ZapGuruConsumoAPI.Model;

namespace ZapGuruConsumoAPI.Service
{
    public class VerificaStatusChatService : Service
    {
        readonly VerificaStatusChat _verificarStatusChat;

        public VerificaStatusChatService(VerificaStatusChat verificarStatus)
        {
            _verificarStatusChat = verificarStatus;
        }


        public async Task<Retorno> VerificarStatusChatAsync()
        {            
            string  urlEnvio = $"?key={key}&account_id={account_id}&phone_id={phone_id}&action={_verificarStatusChat.action}&chat_add_id={_verificarStatusChat.chat_add_id}";
                using (var response = await cliente.PostAsync(urlEnvio, null))
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Retorno>(responseData);
                }
            
        }
    }
}
