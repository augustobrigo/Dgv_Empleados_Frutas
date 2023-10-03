using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dgv_Empleados_Frutas
{
    class ClaseFrutas
    {
        int id;
        String nombre;
        double precio;
        byte[] imagen;

        public ClaseFrutas()
        {
        }

        public ClaseFrutas(int id, string nombre, double precio, byte[] imagen)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Imagen = imagen;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }
    }
}
