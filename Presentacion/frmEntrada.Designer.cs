
namespace QuizUniformes.Presentacion
{
    partial class frmEntrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbArticulos = new System.Windows.Forms.ComboBox();
            this.cmbTipoTalla = new System.Windows.Forms.ComboBox();
            this.cmbTalla = new System.Windows.Forms.ComboBox();
            this.cmbTipoEntrada = new System.Windows.Forms.ComboBox();
            this.tbxCantidad = new System.Windows.Forms.NumericUpDown();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbxCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbArticulos
            // 
            this.cmbArticulos.FormattingEnabled = true;
            this.cmbArticulos.Location = new System.Drawing.Point(125, 15);
            this.cmbArticulos.Name = "cmbArticulos";
            this.cmbArticulos.Size = new System.Drawing.Size(252, 21);
            this.cmbArticulos.TabIndex = 0;
            // 
            // cmbTipoTalla
            // 
            this.cmbTipoTalla.FormattingEnabled = true;
            this.cmbTipoTalla.Location = new System.Drawing.Point(125, 43);
            this.cmbTipoTalla.Name = "cmbTipoTalla";
            this.cmbTipoTalla.Size = new System.Drawing.Size(148, 21);
            this.cmbTipoTalla.TabIndex = 2;
            // 
            // cmbTalla
            // 
            this.cmbTalla.FormattingEnabled = true;
            this.cmbTalla.Location = new System.Drawing.Point(279, 43);
            this.cmbTalla.Name = "cmbTalla";
            this.cmbTalla.Size = new System.Drawing.Size(98, 21);
            this.cmbTalla.TabIndex = 3;
            // 
            // cmbTipoEntrada
            // 
            this.cmbTipoEntrada.FormattingEnabled = true;
            this.cmbTipoEntrada.Location = new System.Drawing.Point(125, 96);
            this.cmbTipoEntrada.Name = "cmbTipoEntrada";
            this.cmbTipoEntrada.Size = new System.Drawing.Size(252, 21);
            this.cmbTipoEntrada.TabIndex = 4;
            // 
            // tbxCantidad
            // 
            this.tbxCantidad.Location = new System.Drawing.Point(125, 70);
            this.tbxCantidad.Name = "tbxCantidad";
            this.tbxCantidad.Size = new System.Drawing.Size(252, 20);
            this.tbxCantidad.TabIndex = 5;
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(125, 123);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(252, 21);
            this.cmbEmpleados.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Artiulo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Talla:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo de Entrada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Empleado:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "DEscripciòn:";
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Location = new System.Drawing.Point(125, 154);
            this.tbxDescripcion.MaxLength = 250;
            this.tbxDescripcion.Multiline = true;
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(252, 83);
            this.tbxDescripcion.TabIndex = 15;
            // 
            // frmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 281);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEmpleados);
            this.Controls.Add(this.tbxCantidad);
            this.Controls.Add(this.cmbTipoEntrada);
            this.Controls.Add(this.cmbTalla);
            this.Controls.Add(this.cmbTipoTalla);
            this.Controls.Add(this.cmbArticulos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEntrada";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada al Almacen";
            this.Load += new System.EventHandler(this.frmEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbxCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbArticulos;
        private System.Windows.Forms.ComboBox cmbTipoTalla;
        private System.Windows.Forms.ComboBox cmbTalla;
        private System.Windows.Forms.ComboBox cmbTipoEntrada;
        private System.Windows.Forms.NumericUpDown tbxCantidad;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxDescripcion;
    }
}