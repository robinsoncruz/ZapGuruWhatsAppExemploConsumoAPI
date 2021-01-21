namespace ZapGuruConsumoAPI.Model
{
    public class VerificaStatusChat : IBase 
    {
        public string chat_add_id { get; set; }
        public string action { get { return "chat_add_status"; } }

     
    }
}
