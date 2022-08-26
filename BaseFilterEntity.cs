using System;
using System.Collections.Generic;

namespace Implanta.Common
{
    public abstract class BaseFilterEntity
    {
        public Guid? Id { get; set; }
        public List<Guid> Ids { get; set; }
        public int Pagina { get; set; } = 1;
        public int Tamanho { get; set; } = 100;

        public int Skip => (Pagina - 1) * Tamanho;
        public int Take => Tamanho;
    }


}
