using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio; 

namespace app1
{
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo nuevoArt = new Articulo();
            ArticuloDatos datosArt = new ArticuloDatos();
            try
            {
                nuevoArt.Codigo = txtCodigo.Text;
                nuevoArt.Nombre = txtNombre.Text;
                nuevoArt.Descripcion = txtDescripcion.Text;

                datosArt.agregar(nuevoArt);
                MessageBox.Show("Agregado!");
                Close(); 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
