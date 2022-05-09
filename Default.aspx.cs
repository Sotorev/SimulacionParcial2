using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimulacionParcial
{
    public partial class _Default : Page
    {
        public static List<Album> albumes = new List<Album>();
        public static List<Cancion> canciones = new List<Cancion>();
        protected void Page_Load(object sender, EventArgs e)
        {
            LeerDatos();
        }
        public void LeerDatos()
        {
            try
            {
                string path = Server.MapPath("Datos.json");
                StreamReader reader = File.OpenText(path);
                string datos = reader.ReadToEnd();
                reader.Close();
                if (datos.Length > 0)
                    albumes = JsonConvert.DeserializeObject<List<Album>>(datos);
                else
                    albumes = new List<Album>();
            }catch(Exception e)
            {

            }
        }
        private void GuardarDatos()
        {
            string path = Server.MapPath("Datos.json");
            string content = JsonConvert.SerializeObject(albumes);
            System.IO.File.WriteAllText(path, content);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Cancion cancion = new Cancion()
            {
                Nombre = TextBox1.Text,
                Artista = TextBox2.Text,
                Duracion = Convert.ToInt32(TextBox3.Text)
            };
            canciones.Add(cancion);
            GridView1.DataSource = canciones;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Album album = new Album()
            {
                Titulo = TextBox4.Text,
                Artista = TextBox5.Text,
                Publicacion = Calendar1.SelectedDate,
                Canciones = canciones.ToArray().ToList()
            };
            canciones.Clear();
            albumes.Add(album);
            GuardarDatos();
        }
    }
}