using System;
using ZapGuruConsumoAPI.Service;
using ZapGuruConsumoAPI.Model;


namespace TestarAPI
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            //EnviaMensagem mensagem = new EnviaMensagem();
            //mensagem.chat_number = "553490000000";
            //mensagem.text = "Mensagem";
            //EnviaMensagemService enviarMensagem = new EnviaMensagemService(mensagem);
            //Retorno retorno = await enviarMensagem.EnviarMensagemAgoraAsync();


            //VerificaStatusMensagem status = new VerificaStatusMensagem();
            //status.mensagem_id = "6009d727e48f89962ea0e7ae";
            //VerificaStatusMensagemService verificarStatus = new VerificaStatusMensagemService(status); 
            //Retorno retorno = await verificarStatus.VerificarStatusMensagemAsync();

            CadastraChat mensagem = new CadastraChat();
            mensagem.chat_number = "553490000000";
            mensagem.text = "Teste";
            mensagem.name = "Poo";
            CadastraChatService cadastraChat = new CadastraChatService(mensagem);
            Retorno retorno = await cadastraChat.CadastrarChatSemUsuarioAsync();


            //VerificaStatusChat  chatstatus = new VerificaStatusChat();
            //chatstatus.chat_add_id  = "6009d7aa223ca0044f292227";            
            //VerificaStatusChatService verificaChat = new VerificaStatusChatService(chatstatus);
            //Retorno ret = await verificaChat.VerificarStatusChatAsync(); 

            //AdicionaAnotacao adicionaAnotacao = new AdicionaAnotacao();
            //adicionaAnotacao.note_text = "teste de anotação";
            //adicionaAnotacao.chat_number = " de velocidade"; 
            //AdicionaAnotacaoService adicionarAnotacaoService = new AdicionaAnotacaoService(adicionaAnotacao);
            //Retorno ret = await adicionarAnotacaoService.AdicionarAnotacaoAsync(); 



        }
    }
}
