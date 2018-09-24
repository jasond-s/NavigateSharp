using NavigateSharp.Navigation.Events;
using NavigateSharp.Presentation;

namespace NavigateSharp.Example.Forms.Presentation.Presenters
{
    public class ProductsPresenter : Presenter
    {
        private readonly IProductsView _productsView;

        public ProductsPresenter(IProductsView productsView) 
            : base(productsView)
        {
            _productsView = productsView;
        }

        protected override void OnDisplay(NavigationEvent evt)
        {
            _productsView.CloseRequest += ProductsViewCloseClicked;
            _productsView.Show();
        }

        protected override void OnDismiss()
        {
            _productsView.CloseRequest -= ProductsViewCloseClicked;
            _productsView.Close();
        }

        private void ProductsViewCloseClicked(object sender, CloseViewEvent args)
            => Navigator.NavigateTo(args);
    }

    public interface IProductsView : IView
    {

    }
}
