using System;
using NavigateSharp.Forms;

namespace NavigateSharp.Example.Forms.Presenters
{
    public partial class Products : View, IProductsView
    {
        public Products() 
            => InitializeComponent();

        public string ProductsText
        {
            get => productsText.Text;
            set => productsText.Text = value;
        }

        public event ProductsBackClickedEventHandler ProductsBack;

        private void BackButtonClick(object sender, EventArgs e)
            => ProductsBack?.Invoke(sender, new ProductsBackEvent());
    }
}
