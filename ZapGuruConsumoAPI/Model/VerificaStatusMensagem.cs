
namespace ZapGuruConsumoAPI.Model
{
    public class VerificaStatusMensagem : IBase 
    {
        public string  mensagem_id { get; set; }
        public string action { get { return "message_status"; } }
    }
}
