using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Dgv_Empleados_Frutas
{
    public partial class Form1 : Form
    {
        List<ClaseEmpleados> listaEmp = new List<ClaseEmpleados>();
        List<ClaseFrutas> listaFrutas = new List<ClaseFrutas>();
        ClaseConectar cnx = new ClaseConectar();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnImagenEmpleado_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaEmp = cnx.listarEmpleados();
            listaFrutas = cnx.listarFrutas();
            dgvEmpleados.DataSource = listaEmp;
            dgvFrutas.DataSource = listaFrutas;
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(listaEmp[fila].Imagen);
            MemoryStream ms = new MemoryStream(bytes);
            System.Drawing.Image imagen = System.Drawing.Image.FromStream(ms);
            btnImagenEmpleado.BackgroundImage = imagen;
        }

        private void dgvFrutas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
