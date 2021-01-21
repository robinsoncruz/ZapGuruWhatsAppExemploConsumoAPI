namespace ZapGuruConsumoAPI.Model
{
    public class EnviaMensagem : IBase
    {

        public string chat_number { get; set; }

        public string send_Date{ get; set; }
        
        public string text { get; set; }

        public string user_id { get; set; }

        public string action { get { return "message_send"; } }

        
    }
}
