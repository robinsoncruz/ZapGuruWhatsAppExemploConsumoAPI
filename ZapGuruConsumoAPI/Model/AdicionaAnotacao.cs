
namespace ZapGuruConsumoAPI.Model
{    
    public class AdicionaAnotacao : IBase

    {
        public string note_text { get; set; }
        public string action { get { return "note_add"; } }        
        public string chat_number { get; set;}
    }
}
