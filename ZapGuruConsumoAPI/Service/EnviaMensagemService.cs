using Newtonsoft.Json;
using System.Threading.Tasks;
using ZapGuruConsumoAPI.Model;

namespace ZapGuruConsumoAPI.Service
{
    public class EnviaMensagemService : Service
    {
        readonly EnviaMensagem _enviarMensagem; 

        public EnviaMensagemService(EnviaMensagem enviarMensagem)
        {
            _enviarMensagem = enviarMensagem; 
        }


        public async Task<Retorno> EnviarMensagemAgoraAsync()
        {           
           string  urlEnvio = $"?key={key}&account_id={account_id}&phone_id={phone_id}&action={_enviarMensagem.action}&text={_enviarMensagem.text}&chat_number={_enviarMensagem.chat_number}";                                   
               using (var response = await cliente.PostAsync(urlEnvio, null))
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Retorno>(responseData);
                }
        }

        public async Task<Retorno> EnviarMensagemAgendadaAsync()
        {            
            string  urlEnvio = $"{key}{account_id}{phone_id}{_enviarMensagem.action}&text={_enviarMensagem.text}&chat_number={_enviarMensagem.chat_number}&send_date={_enviarMensagem.send_Date}";            
                using (var response = await cliente.PostAsync(urlEnvio, null))
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Retorno>(responseData);
                }
            
        }
    }
}
