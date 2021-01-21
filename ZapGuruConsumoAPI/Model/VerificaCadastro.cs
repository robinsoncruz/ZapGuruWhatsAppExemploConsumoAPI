namespace ZapGuruConsumoAPI.Model
{
    class VerificaCadastro : IBase    
    {
        public string chat_add_id { get; set; }
        public string action { get { return "chat_add_status"; } }
    }
}
