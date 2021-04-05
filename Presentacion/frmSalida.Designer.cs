
namespace QuizUniformes.Presentacion
{
    partial class frmSalida
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
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.tbxCantidad = new System.Windows.Forms.NumericUpDown();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblArticulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbxCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(115, 38);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(252, 21);
            this.cmbEmpleados.TabIndex = 0;
            // 
            // tbxCantidad
            // 
            this.tbxCantidad.Location = new System.Drawing.Point(115, 65);
            this.tbxCantidad.Name = "tbxCantidad";
            this.tbxCantidad.Size = new System.Drawing.Size(252, 20);
            this.tbxCantidad.TabIndex = 1;
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Location = new System.Drawing.Point(115, 91);
            this.tbxDescripcion.MaxLength = 250;
            this.tbxDescripcion.Multiline = true;
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(252, 83);
            this.tbxDescripcion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Empleado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripciòn:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Dar Salida";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.Location = new System.Drawing.Point(24, 9);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(48, 13);
            this.lblArticulo.TabIndex = 7;
            this.lblArticulo.Text = "Articulo: ";
            // 
            // frmSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 251);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.tbxCantidad);
            this.Controls.Add(this.cmbEmpleados);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSalida";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salida de Almacen";
            this.Load += new System.EventHandler(this.frmSalida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbxCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.NumericUpDown tbxCantidad;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblArticulo;
    }
}