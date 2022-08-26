using System;

namespace Implanta.Common
{
    public abstract class BaseEntity
    {
        public abstract Guid Id { get; set; }
        public EntityAction Acao { get; set; } = EntityAction.None;
    }
}
