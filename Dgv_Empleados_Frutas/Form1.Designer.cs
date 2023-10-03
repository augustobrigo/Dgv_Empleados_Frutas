
namespace Dgv_Empleados_Frutas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.dgvFrutas = new System.Windows.Forms.DataGridView();
            this.btnImagenEmpleado = new System.Windows.Forms.Button();
            this.btnImagenFruta = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.InsertarFruta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEmpleados.Location = new System.Drawing.Point(32, 13);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(240, 150);
            this.dgvEmpleados.TabIndex = 0;
            this.dgvEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellDoubleClick);
            // 
            // dgvFrutas
            // 
            this.dgvFrutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrutas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFrutas.Location = new System.Drawing.Point(32, 182);
            this.dgvFrutas.Name = "dgvFrutas";
            this.dgvFrutas.Size = new System.Drawing.Size(240, 150);
            this.dgvFrutas.TabIndex = 1;
            this.dgvFrutas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFrutas_CellDoubleClick);
            // 
            // btnImagenEmpleado
            // 
            this.btnImagenEmpleado.Location = new System.Drawing.Point(298, 23);
            this.btnImagenEmpleado.Name = "btnImagenEmpleado";
            this.btnImagenEmpleado.Size = new System.Drawing.Size(75, 90);
            this.btnImagenEmpleado.TabIndex = 2;
            this.btnImagenEmpleado.UseVisualStyleBackColor = true;
            this.btnImagenEmpleado.Click += new System.EventHandler(this.btnImagenEmpleado_Click);
            // 
            // btnImagenFruta
            // 
            this.btnImagenFruta.Location = new System.Drawing.Point(298, 195);
            this.btnImagenFruta.Name = "btnImagenFruta";
            this.btnImagenFruta.Size = new System.Drawing.Size(75, 90);
            this.btnImagenFruta.TabIndex = 3;
            this.btnImagenFruta.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 405);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(253, 405);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // InsertarFruta
            // 
            this.InsertarFruta.Location = new System.Drawing.Point(43, 390);
            this.InsertarFruta.Name = "InsertarFruta";
            this.InsertarFruta.Size = new System.Drawing.Size(75, 48);
            this.InsertarFruta.TabIndex = 8;
            this.InsertarFruta.Text = "InsertarFruta";
            this.InsertarFruta.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(377, 375);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "NombreFruta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Click para imagen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InsertarFruta);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnImagenFruta);
            this.Controls.Add(this.btnImagenEmpleado);
            this.Controls.Add(this.dgvFrutas);
            this.Controls.Add(this.dgvEmpleados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridView dgvFrutas;
        private System.Windows.Forms.Button btnImagenEmpleado;
        private System.Windows.Forms.Button btnImagenFruta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button InsertarFruta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

