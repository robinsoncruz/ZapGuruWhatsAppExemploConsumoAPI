using ZapGuruConsumoAPI.Model; 
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace ZapGuruConsumoAPI.Service
{
    public class CadastraChatService : Service 
    {
        readonly CadastraChat _cadastraChat;

        public CadastraChatService(CadastraChat cadastraChat)
        {
            _cadastraChat = cadastraChat;
        }


        public async Task<Retorno> CadastrarChatSemUsuarioAsync()
        {            
            string urlEnvio = $"?key={key}&account_id={account_id}&phone_id={phone_id}&action={_cadastraChat.action}&text={_cadastraChat.text}&chat_number={_cadastraChat.chat_number}&name={_cadastraChat.name}";
            
                using (var response = await cliente.PostAsync(urlEnvio, null))
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Retorno>(responseData);
                }            
        }

        public async Task<Retorno> CadastrarChatComUsuarioAsync()
        {
         
            string  urlEnvio = $"{key}{account_id}{phone_id}{_cadastraChat.action}&text={_cadastraChat.text}&chat_number={_cadastraChat.chat_number}&name={_cadastraChat.name}&user_id={_cadastraChat.user_id}";            
                using (var response = await cliente.PostAsync(urlEnvio, null))
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Retorno>(responseData);
                }            
        }
    }
}
