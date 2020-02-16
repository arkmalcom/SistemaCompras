using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCompras.Edit
{
    public partial class FrmEdProveedores : FrmEdBase
    {
        public string cedula { get; set; }
        public string nombre { get; set; }
        public FrmEdProveedores()
        {
            InitializeComponent();
        }

        private void FrmEdProveedores_Load(object sender, EventArgs e)
        {
            int nextID = 0;
            if (modo.Equals("U"))
            {
                this.Text = "Proveedores - Actualizar";
                try
                {
                    TxtID.Text = ID.ToString();
                    TxtCedula.Text = cedula;
                    TxtNombre.Text = nombre;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error. " + ex);
                }

            }
            else
            {
                this.Text = "Proveedores - Agregar";
                string sql = "select TOP 1 ID_proveedor from Proveedores ORDER BY ID_proveedor DESC";
                SqlCommand cmd = new SqlCommand(sql, con);
                if (cmd.ExecuteScalar() == null)
                {
                    nextID = 1;
                }
                else
                {
                    nextID = (int)cmd.ExecuteScalar() + 1;
                }
                TxtID.Text = nextID.ToString();
            }
        }

        private void CmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                if (modo.Equals("C"))
                {
                    sql = "insert into Proveedores values ('";
                    sql += TxtCedula.Text + "', '" + TxtNombre.Text + "', " + estadobool + ")";
                }
                else
                {
                    sql = "Update Proveedores set ";
                    sql += "cedula_proveedor = '" + TxtCedula.Text + "',";
                    sql += "nombre_proveedor = '" + TxtNombre.Text + "',";
                    sql += "estado_proveedor = " + estadobool;
                    sql += " where ID_proveedor = '" + TxtID.Text + "'";
                }
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro guardado con exito.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. " + ex);
            }
        }

        private void CmdEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete Proveedores ";
                sql += "where ID_proveedor = '" + TxtID.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado con exito.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. " + ex);

            }
        }
    }
}
