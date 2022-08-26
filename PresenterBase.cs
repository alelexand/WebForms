namespace Implanta.Common
{
    public class PresenterBase<TBusiness, TIView> : IPresenterBase
    {
        public PresenterBase(TBusiness businessFactory)
        {
            BusinessFactory = businessFactory;
        }

        protected TIView View { get; set; }
        protected TBusiness BusinessFactory { get; set; }
        protected bool Salvar { get; set; }
    }
}
