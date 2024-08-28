using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buscador_Telefonos
{
    public partial class Formulario_Busqueda : Form
    {
        public Formulario_Busqueda()
        {
            InitializeComponent();
        }

        private string consulta_sql(string documento, string email)
        {
            string query;
            query = "SELECT DISTINCT NRO_DOCUMENTO, EMAIL FROM CANALES_EMAILS WHERE";

            if (documento != "")
            {
                if (email != "")
                {
                    query += " NRO_DOCUMENTO = " + documento + " AND EMAIL = '" + email + "'";
                }
                else
                {
                    query += " NRO_DOCUMENTO = " + documento;
                }
            }
            else
            {
                if (email != "")
                {
                    query += " EMAIL = '" + email + "'";
                }
                else
                {
                    query += "";
                }
            }
            return query;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string documento = txt_documento.Text;
            string email = txt_email.Text.ToLower();

            // Validar entradas de TextBox
            // 1) Valido que el valor de los campos (documento numérico y email texto)
            if ((!documento.All(char.IsNumber) && documento != "") || (email.All(char.IsNumber) && email != ""))
            {
                MessageBox.Show("Algunos de los campos ingresados no son válidos");
                return;
            }
            // 2) Valido que el email sea contenga @
            if (email != "" && !email.Contains("@"))
            {
                MessageBox.Show("El email ingresado no es válido");
                return;
            }
            // 3) Valido que los campos no sean todos vacíos
            if (documento == "" && email == "")
            {
                MessageBox.Show("Debe ingresar al menos 1 campo de Búsqueda");
                return;
            }

            string query = consulta_sql(documento, email);

            // Creo tabla en nuevo formulario y realizo conexión SQL
            Tabla resultado = new Tabla();
            string conexionSql = "Data Source=CSPMA000DW02;Initial Catalog=DMCOBRANZAS;Integrated Security=True";
            var conexion = new SqlConnection(conexionSql);
            try
            {
                conexion.Open();
                var adaptador = new SqlDataAdapter(query, conexion);
                var ds = new DataSet();
                adaptador.Fill(ds);
                resultado.dgv1.ReadOnly = true;
                resultado.dgv1.DataSource = ds.Tables[0];

                resultado.lbl_info.Text = "(" + resultado.dgv1.ColumnCount + " Campos, " + resultado.dgv1.RowCount + " Registros)";

                resultado.Show();
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("No fue posible conectar a la base de Datos. Verifique sus permisos.");
            }
        }

        private void txt_KeyPress_Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_buscar_Click(sender, e);
            }
        }
        private void txt_KeyPress_Escape(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                this.Close();
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_documento.Text = string.Empty;
            txt_email.Text = string.Empty;
        }
    }
}
