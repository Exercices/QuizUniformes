using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizUniformes.Presentacion
{
    public partial class frmSalida : Form
    {
        public int? idAlmacen;
        public frmSalida(int? id = null)
        {
            InitializeComponent();
            this.idAlmacen = id;
        }

        private void frmSalida_Load(object sender, EventArgs e)
        {
            using (Models.RhUniformesEntities db = new Models.RhUniformesEntities())
            {

                var data = db.vw_ExistenciasAlmacen.Where(ea => ea.Folio == idAlmacen).OrderBy(ea => ea.Articulo).ToList();

                lblArticulo.Text += data[0].Articulo + " " + data[0].Talla + " " + data[0].Tipo;

                cmbEmpleados.DataSource = db.Cat_Empleados.Where(em => 1 == 1).OrderBy(em => em.Nombre_Empleado).ToList();
                cmbEmpleados.DisplayMember = "Nombre_Empleado";
                cmbEmpleados.ValueMember = "Id_Empleado";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbxCantidad.Value <= 0)
            {
                MessageBox.Show("Revise la cantidad");
                return;
            }
            using (Models.RhUniformesEntities db = new Models.RhUniformesEntities())
            {
                try
                {
                    var data = db.sp_SalidaAlmacen(idAlmacen, int.Parse(cmbEmpleados.SelectedValue.ToString()), int.Parse(tbxCantidad.Value.ToString()), tbxDescripcion.Text.ToString()).ToList();
                    if(data[0].Length >= 35)
                     {
                        MessageBox.Show(data[0].ToString());
                     }
                     else
                    {
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

           
        }
    }
}
