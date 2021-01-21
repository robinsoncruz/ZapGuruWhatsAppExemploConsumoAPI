using ZapGuruConsumoAPI.Model; 
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ZapGuruConsumoAPI.Service
{
    public class AdicionaAnotacaoService : Service 
    {
        readonly AdicionaAnotacao _adicionaAnotacao;

        public AdicionaAnotacaoService(AdicionaAnotacao adicionaAnotacao)
        {
            _adicionaAnotacao = adicionaAnotacao;
        }


        public async Task<Retorno> AdicionarAnotacaoAsync()
        {           
            string urlEnvio = $"?key={key}&account_id={account_id}&phone_id={phone_id}&action={_adicionaAnotacao.action}&note_text={_adicionaAnotacao.note_text}&chat_number={_adicionaAnotacao.chat_number}";         
            using (var response = await cliente.PostAsync(urlEnvio, null))
            {
                string responseData = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Retorno>(responseData);
            }            
        }
    }
}
