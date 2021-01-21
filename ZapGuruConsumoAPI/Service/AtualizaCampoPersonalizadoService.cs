using ZapGuruConsumoAPI.Model;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ZapGuruConsumoAPI.Service
{
    public class AtualizaCampoPersonalizadoService : Service
    {

        readonly AtualizaCampoPersonalizado _atualizaCampo;
        public AtualizaCampoPersonalizadoService(AtualizaCampoPersonalizado atualizaCampo)
        {
            _atualizaCampo = atualizaCampo;
        }

        public async Task<Retorno> AtualizarCampoPersonalizadoAsync()
        {            
            string  urlEnvio = $"?key={key}&account_id={account_id}&phone_id={phone_id}&action={_atualizaCampo.action}&field__NOME_DO_CAMPO={_atualizaCampo.field_NOME_DO_CAMPO}&chat_number={_atualizaCampo.chat_number}";            
                using (var response = await cliente.PostAsync(urlEnvio, null))
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Retorno>(responseData);
                }            
        }
    }
}

