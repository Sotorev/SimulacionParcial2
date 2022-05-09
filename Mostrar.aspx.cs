using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimulacionParcial
{
    public partial class MOstrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            _Default d = new _Default();
            d.LeerDatos();
            if(_Default.albumes != null && !IsPostBack)
            {
                foreach (var album in _Default.albumes)
                {
                    DropDownList1.Items.Add(album.Titulo);
                }
            }
            GridView1.DataSource = _Default.albumes;
            GridView1.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}