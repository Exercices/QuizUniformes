using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizUniformes
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadExistencias();
        }

        private void LoadExistencias()
        {
            using (Models.RhUniformesEntities db = new Models.RhUniformesEntities())
            {
                dataGridView1.DataSource = db.vw_ExistenciasAlmacen.ToList();
            }
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count <= 0)
            {
                MessageBox.Show("No tiene Articulos en Almacen");
                return;
            }
            int? IdAlmacen = GetId();
            Console.WriteLine(IdAlmacen);
            if(IdAlmacen != null)
            {
                Presentacion.frmSalida ofrmSalida = new Presentacion.frmSalida(IdAlmacen);
                ofrmSalida.ShowDialog();
                LoadExistencias();

            }
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return 0;
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadExistencias();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Capture F5 KeyPress
            if (e.KeyCode == Keys.F5)
            {
                MessageBox.Show("F5 Key Pressed!");
                LoadExistencias();
                e.Handled = true;

            }
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            int? IdAlmacen = GetId();
            Console.WriteLine(IdAlmacen);
            if (IdAlmacen != null)
            {
                Presentacion.frmEntrada ofrmEntrada = new Presentacion.frmEntrada(IdAlmacen);
                ofrmEntrada.ShowDialog();
                LoadExistencias();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                Presentacion.frmSalidas ofrmSalidas = new Presentacion.frmSalidas();
                ofrmSalidas.ShowDialog();
                LoadExistencias();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Presentacion.frmEntradas ofrmEntradas = new Presentacion.frmEntradas();
            ofrmEntradas.ShowDialog();
            LoadExistencias();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Presentacion.frmArticulos ofrmArticulos = new Presentacion.frmArticulos();
            ofrmArticulos.ShowDialog();
            LoadExistencias();
        }
    }
}
