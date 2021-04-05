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
    public partial class frmEntradas : Form
    {
        public frmEntradas()
        {
            InitializeComponent();
        }

        private void frmEntradas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            reresh();
        }

        private void reresh()
        {
            using (Models.RhUniformesEntities db = new Models.RhUniformesEntities())
            {
                dataGridView1.DataSource = db.vw_EntradasAlmacen.ToList();
            }
        }
    }
}
