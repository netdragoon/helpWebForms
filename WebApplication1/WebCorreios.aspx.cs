using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebCorreios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEnviar_Click(object sender, EventArgs e)
        {
            LitResponse.Text = "";
            Correios.AtendeCliente ac = new Correios.AtendeClienteClient();
            Correios.consultaCEPResponse result = ac.consultaCEP(new Correios.consultaCEP(TxtCep.Text));
            LitResponse.Text = string.Format("{0}<br>{1}<br>{2}<br>", result.@return.cidade, result.@return.uf, result.@return.bairro);
        }
    }
}