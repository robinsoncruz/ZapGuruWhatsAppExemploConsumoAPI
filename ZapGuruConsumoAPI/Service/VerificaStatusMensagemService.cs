using Newtonsoft.Json;
using System.Threading.Tasks;
using ZapGuruConsumoAPI.Model;

namespace ZapGuruConsumoAPI.Service
{
    public class VerificaStatusMensagemService : Service
    {

        readonly VerificaStatusMensagem _verificarStatusMensagem;

        public VerificaStatusMensagemService(VerificaStatusMensagem verificarStatus)
        {
            _verificarStatusMensagem = verificarStatus;
        }


        public async Task<Retorno> VerificarStatusMensagemAsync()
        {            
            string urlEnvio = $"?key={key}&account_id={account_id}&phone_id={phone_id}&action={_verificarStatusMensagem.action}&message_id={_verificarStatusMensagem.mensagem_id}";
           using (var response = await cliente.PostAsync(urlEnvio, null))
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Retorno>(responseData);
              }
           
        }

    }
}
