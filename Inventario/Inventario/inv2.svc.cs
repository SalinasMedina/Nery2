using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;

namespace Inventario
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "inv2" en el código, en svc y en el archivo de configuración a la vez.
    public class inv2 : Iinv2
    {
        public void guardar(int a, string b, int c, int d, string e)
        {
            SqlConnection con;
            SqlCommand cmd;
            string cadena = "";
            con = new SqlConnection("Data Source=DESKTOP-CABRK5M; Initial Catalog=Inventario;Integrated Security=false;user=nery;password=12345;");
            con.Open();
            cadena = "insert into Producto values('" + a + "','" + b + "','" + c + "','" + d + "','" + e + "')";
            cmd = new SqlCommand(cadena, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public string[] buscar(int cla)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dato;
            string cadena = "";
            string[] datos = new string[6];
            con = new SqlConnection("Data Source=DESKTOP-CABRK5M; Initial Catalog=Inventario;Integrated Security=false;user=nery;password=12345;");
            con.Open();
            cadena = "select * from Producto where Id_Producto=" + cla;
            cmd = new SqlCommand(cadena, con);
            dato = cmd.ExecuteReader();
            if (dato.Read())
            { 
                datos[0] = dato.GetInt32(0).ToString();
                datos[1] = dato.GetString(1);
                datos[2] = dato.GetInt32(2).ToString();
                datos[3] = dato.GetInt32(3).ToString();
                datos[4] = dato.GetString(4);
            }
            con.Close();
            return datos;
        }
        public string convertir(string n)
        {
            string res, dec = "";
            Int64 entero;
            int decimales;
            double num;
            try
            {
                num = Convert.ToDouble(n);
            }
            catch
            {
                return "";
            }
            entero = Convert.ToInt64(Math.Truncate(num));
            decimales = Convert.ToInt32(Math.Round((num - entero) * 100, 2));
            if (decimales >0)
            {
                dec = "CON" + decimales.ToString() + "/100";
            }
            res =toText(Convert.ToDouble(entero)) + dec;
            return res;
        }
        public string toText(double value)
        { 
            string Num2Text = "";
            value = Math.Truncate(value);
            if (value == 0) Num2Text = "Cero";

            else if (value == 1) Num2Text = "Uno";
            else if (value == 2) Num2Text = "Dos";
            else if (value == 3) Num2Text = "Tres";
            else if (value == 4) Num2Text = "Cuatro";
            else if (value == 5) Num2Text = "Cinco";
            else if (value == 6) Num2Text = "Seis";
            else if (value == 7) Num2Text = "Siete";
            else if (value == 8) Num2Text = "Ocho";
            else if (value == 9) Num2Text = "Nueve";
            else if (value == 10) Num2Text = "Diez";
            return Num2Text;

        
        
        }
    }
}
