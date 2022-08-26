using System.Reflection;

namespace Implanta.Common
{
    public abstract class WebPageBase : System.Web.UI.Page
    {
        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            PropertyInfo[] properties = GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                object[] attributes = property.GetCustomAttributes(typeof(SaveInViewStateAttribute), true);
                if (attributes.Length > 0)
                {
                    if (ViewState[property.Name] != null)
                        property.SetValue(this, ViewState[property.Name], null);
                }
            }

            EnsureChildControls();
        }

        protected override object SaveViewState()
        {
            PropertyInfo[] properties = GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                object[] attributes = property.GetCustomAttributes(typeof(SaveInViewStateAttribute), true);
                if (attributes.Length > 0)
                    ViewState[property.Name] = property.GetValue(this, null);
            }

            return base.SaveViewState();
        }
    }
    public abstract class WebPageBase<TPresenter> : WebPageBase
        where TPresenter : IPresenterBase
    {        
        protected TPresenter Presenter { get; set; }
    }
}
