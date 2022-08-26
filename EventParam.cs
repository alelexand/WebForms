using System;

namespace Implanta.Common
{
    public class EventParam<T> : EventArgs
    {
        public EventParam(T parametro)
        {
            Parametro = parametro;
        }

        public T Parametro { get; internal set; }
    }
}
