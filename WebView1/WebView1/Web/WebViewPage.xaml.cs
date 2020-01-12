using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebView1.Web
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();
        }
        private void IrPagina(object sender, EventArgs args) 
        {
            NAVEGADOR.Source = "Http://www" + url.Text;
        }        
        private void VoltaPagina(object sender, EventArgs args) 
        {
            if(NAVEGADOR.CanGoBack) 
            {
                NAVEGADOR.GoBack();
            }
        }        
        private void IrPaginaCarregada(object sender, EventArgs args) 
        {
            if (NAVEGADOR.CanGoForward)
            {
                NAVEGADOR.GoForward();
            }
        }        
        private void ACAOCARREGANDO(object sender, EventArgs args) 
        {
            ACAOSITE.Text = "Carregando";
        }        
        private void ACAOFINALIZADA(object sender, EventArgs args) 
        {
            ACAOSITE.Text = "Finalizado";
        }
    }
}