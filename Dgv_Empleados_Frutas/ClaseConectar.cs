using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace Dgv_Empleados_Frutas
{
    class ClaseConectar
    {
        List<ClaseEmpleados> listaEmpleados = new List<ClaseEmpleados>();
        List<ClaseFrutas> listaFrutas = new List<ClaseFrutas>();
        MySqlConnection conexion;
        MySqlCommand comando;
        MySqlDataReader datos;
        public ClaseConectar()
        {
            conexion = new MySqlConnection();
            conexion.ConnectionString = "server=localhost;" +
                "Database=dam2023;user=root;pwd='';old guids=true";
        }
        public List<ClaseEmpleados> listarEmpleados()
        {
            conexion.Open();
            String cadenaSql = "select * from empleados";
            comando = new MySqlCommand(cadenaSql, conexion);
            datos = comando.ExecuteReader();
            while (datos.Read())
            {
                ClaseEmpleados emp = new ClaseEmpleados();
                emp.Dni =Convert.ToString( datos["dni"]);
                emp.Pwd = Convert.ToString(datos["password"]);
                emp.Nivel = Convert.ToInt16(datos["nivel"]);
                emp.Imagen = Convert.ToString(datos["imagen"]);
                listaEmpleados.Add(emp);
            }
            conexion.Close();
            return listaEmpleados;
        }
        public List<ClaseFrutas> listarFrutas(){
            conexion.Open();
            String cadenaSql = "select * from frutas";
            comando = new MySqlCommand(cadenaSql, conexion);
            datos = comando.ExecuteReader();
            while (datos.Read())
            {
                ClaseFrutas f = new ClaseFrutas();
                f.Id = Convert.ToInt16(datos["id"]);
                f.Nombre = Convert.ToString(datos["nombre"]);
                f.Precio = Convert.ToDouble(datos["precio"]);
                f.Imagen =(byte[])(datos["imagen"]);
                listaFrutas.Add(f);
            }
            conexion.Close();
            return listaFrutas;
        }
    }
}
