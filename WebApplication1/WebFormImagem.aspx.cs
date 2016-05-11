using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;
namespace WebApplication1
{
    public partial class WebFormImagem : System.Web.UI.Page
    {
        protected DatabaseDataContext db;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new DatabaseDataContext();
            if (!IsPostBack)
            {
                Load_Grid();
            }
        }

        private void Load_Grid()
        {
            GridImagens.DataSource = db.Imagens.ToList();
            GridImagens.DataBind();
        }
        protected void Page_Unload(object sender, EventArgs e)
        {
            db.Dispose();
        }
        protected void BtnEnviar_Click(object sender, EventArgs e)
        {
            Imagen img = new Imagen()
            {
                Nome = TxtNome.Text,
                Foto = new System.Data.Linq.Binary(FileUploadFoto.FileBytes),
                Extensao = Path.GetExtension(FileUploadFoto.FileName).Replace(".","image/")

            };
            db.Imagens.InsertOnSubmit(img);
            db.SubmitChanges();
            Load_Grid();
        }

        protected void GridImagens_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Alterar"))
            {
                LblEscolhido.Text = e.CommandArgument.ToString();
            }
        }
    }
}