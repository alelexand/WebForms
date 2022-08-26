using System;
using System.Collections.Generic;

namespace Implanta.Common
{
    public interface IViewEdicaoSimple : IViewBase
    {
        List<string> Mensagens { set; }

        event EventHandler Salvar;
        event EventHandler Novo;
        event EventHandler Inicia;
        event EventHandler<EventParam<Guid>> Abrir;
    }
}
