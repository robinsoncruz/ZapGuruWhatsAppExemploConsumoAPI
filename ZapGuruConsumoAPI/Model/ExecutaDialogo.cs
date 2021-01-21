namespace ZapGuruConsumoAPI.Model
{
    class ExecutaDialogo : IBase 
    {
        public string send_date { get; set; }
        public string dialog_id { get; set; }
        public string action { get { return "dialog_execute"; } }
    }
}
