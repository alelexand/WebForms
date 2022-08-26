namespace Implanta.Common
{
    public class Operacao<TEntity> : ActionReturn
    {
        public Operacao()
        {
        }

        public Operacao(TEntity entidade)
            : this()
        {
            Entidade = entidade;
        }

        public TEntity Entidade { get; set; }
    }

}
