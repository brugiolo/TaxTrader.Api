using MediatR;

namespace TaxTrader.Business.Events
{
    public class NotificacaoTeste : INotification
    {
        public string Mensagem { get; private set; }

        public NotificacaoTeste(string mensagem)
        {
            Mensagem = mensagem;
        }
    }
}