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
    public partial class frmEntrada : Form
    {
        public int? idAlmacen;
        public frmEntrada(int? id = null)
        {
            InitializeComponent();
            this.idAlmacen = id;
        }

        private void frmEntrada_Load(object sender, EventArgs e)
        {
            using (Models.RhUniformesEntities db = new Models.RhUniformesEntities())
            {
                
                cmbArticulos.DataSource = db.Cat_Articulos.Where(ar => ar.Id_Estatus == 1).OrderBy(ar => ar.Articulo).ToList();
                cmbArticulos.DisplayMember = "Articulo";
                cmbArticulos.ValueMember = "Id_Articulo";
                
                cmbTipoTalla.DataSource = db.Cat_TiposTallas.Where(tt => tt.Id_Estatus == 1).OrderBy(tt => tt.Tipo).ToList();
                cmbTipoTalla.DisplayMember = "Tipo";
                cmbTipoTalla.ValueMember = "Id_TipoTalla";
                

                cmbTalla.DataSource = db.Cat_Tallas.Where(t => t.Id_Estatus == 1).OrderBy(t => t.Talla).ToList();
                cmbTalla.DisplayMember = "Talla";
                cmbTalla.ValueMember = "Id_Talla";

                if (idAlmacen != 0)
                {
                    var dataExstente = db.Almacen.Where(al => al.Id_Almacen == idAlmacen).ToList();
                    cmbArticulos.SelectedValue = dataExstente[0].Id_Articulo;
                    cmbTipoTalla.SelectedValue = dataExstente[0].Id_TipoTalla;
                    cmbTalla.SelectedValue = dataExstente[0].Id_Talla;
                }
                

                cmbTipoEntrada.DataSource = db.Cat_TiposEntradas.Where(te => te.Id_Estatus == 1).OrderBy(te => te.Tipo).ToList();
                cmbTipoEntrada.DisplayMember = "Tipo";
                cmbTipoEntrada.ValueMember = "Id_TipoEntrada";
                //cmbTipoEntrada.SelectedValue = dataExstente[0].Id_TipoEntrada;

                cmbEmpleados.DataSource = db.Cat_Empleados.Where(em => 1 == 1).OrderBy(em => em.Nombre_Empleado).ToList();
                cmbEmpleados.DisplayMember = "Nombre_Empleado";
                cmbEmpleados.ValueMember = "Id_Empleado";
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxCantidad.Value <= 0)
            {
                MessageBox.Show("Revise la cantidad");
                return;
            }
            using (Models.RhUniformesEntities db = new Models.RhUniformesEntities())
            {
                try
                {
                    var data = db.sp_EntradaAlmacen(idAlmacen, int.Parse(cmbArticulos.SelectedValue.ToString()), int.Parse(cmbTipoTalla.SelectedValue.ToString()), int.Parse(cmbTalla.SelectedValue.ToString()), int.Parse(cmbTipoEntrada.SelectedValue.ToString()), int.Parse(tbxCantidad.Value.ToString()), int.Parse(cmbEmpleados.SelectedValue.ToString()),null,null, tbxDescripcion.Text.ToString()).ToList();
                    if (data[0] == null || data[0] == 0 )
                    {
                        MessageBox.Show("No es posible Agregar al almacen");
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
