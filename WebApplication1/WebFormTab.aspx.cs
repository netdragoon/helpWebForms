using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebFormTab : System.Web.UI.Page
    {
        public string PanelSelect { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PanelSelect = "home";
            }
        }

        protected void BtnHome_Click(object sender, EventArgs e)
        {
            PanelSelect = "home";
        }

        protected void BtnProfile_Click(object sender, EventArgs e)
        {
            PanelSelect = "profile";
        }

        protected void BtnMessage_Click(object sender, EventArgs e)
        {
            PanelSelect = "messages";
        }

        protected void BtnSettings_Click(object sender, EventArgs e)
        {
            PanelSelect = "settings";
        }
    }
}