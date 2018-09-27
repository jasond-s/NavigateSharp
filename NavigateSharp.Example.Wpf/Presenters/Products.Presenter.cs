using NavigateSharp.Navigation.Events;
using NavigateSharp.Presentation;

namespace NavigateSharp.Example.Wpf.Presenters
{
    public class ProductsBackEvent : NavigationEvent
    {

    }

    public class ProductsPresenter : Presenter<IProductsView>
    {
        public ProductsPresenter(IProductsView productsView)
            : base(productsView)
        {
        }

        protected override void OnDisplay(NavigationEvent evt)
        {
            View.CloseRequest += ProductsViewCloseClicked;
            View.ProductsBack += ProductsViewOnProductsBack;
            View.Show();
        }

        protected override void OnDismiss()
        {
            View.CloseRequest -= ProductsViewCloseClicked;
            View.Close();
        }

        private void ProductsViewCloseClicked(object sender, CloseViewEvent args)
            => Navigator.NavigateTo(args);

        private void ProductsViewOnProductsBack(object sender, ProductsBackEvent args)
            => Navigator.NavigateTo(args);
    }

    public interface IProductsView : IView
    {
        event ProductsBackClickedEventHandler ProductsBack;
    }

    public delegate void ProductsBackClickedEventHandler(object sender, ProductsBackEvent args);
}
