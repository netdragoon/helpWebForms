using System;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1
{    
    public class GenericHandlerLoadImagem : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            try {
                if (context != null
                    && context.Request != null
                    && context.Request.QueryString["id"] != null)
                {
                    int id = int.Parse(context.Request.QueryString["id"].ToString());
                    DatabaseDataContext db = new DatabaseDataContext();
                    Imagen model = db.Imagens.FirstOrDefault(x => x.Id == id);
                    if (model != null)
                    {
                        System.Data.Linq.Binary imagem = model.Foto;
                        string ext = model.Extensao;
                        db.Dispose();
                        context.Response.ContentType = ext;
                        context.Response.BinaryWrite(imagem.ToArray());
                        context.Response.End();
                    }
                    db.Dispose();
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}