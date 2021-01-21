namespace ZapGuruConsumoAPI.Model
{
    public class CadastraChat : IBase
    {
        public string chat_number { get; set; }
        public string dialog_id { get; set; }
        public string name { get; set; }
        public string text { get; set; }
        public string user_id { get; set; }
        public string action { get { return "chat_add"; } }
    }
}
