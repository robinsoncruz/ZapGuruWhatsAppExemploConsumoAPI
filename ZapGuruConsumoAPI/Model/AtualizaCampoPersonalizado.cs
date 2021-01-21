namespace ZapGuruConsumoAPI.Model
{
    public class AtualizaCampoPersonalizado : IBase 
    {
        public string field_NOME_DO_CAMPO { get; set; }
        public string action { get { return "chat_update_custom_fields"; } }        
        public string chat_number { get; set; }
    }
}
