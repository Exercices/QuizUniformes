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
    public partial class frmArticulos : Form
    {
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            reresh();
        }

        private void reresh()
        {
            using (Models.RhUniformesEntities db = new Models.RhUniformesEntities())
            {
                dataGridView1.DataSource = db.vw_ListadoArticulos.ToList();
            }
        }
    }
}
