using System.Collections.Generic;
using System.Linq;

namespace Implanta.Common
{
    public class ActionReturn
    {
        private readonly List<string> _mensagens;

        public ActionReturn()
        {
            _mensagens = new List<string>();
        }

        public List<string> Mensagens => _mensagens.ToList();

        public bool Erro => _mensagens.Any();

        public void AdicionarErro(string mensagem)
        {
            _mensagens.Add(mensagem);
        }

        public void AdicionarErro(ActionReturn operacao)
        {
            foreach (var msg in operacao.Mensagens)
                AdicionarErro(msg);
        }
        
    }

}
