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
    public partial class FrmEdOrdenes : FrmEdBase
    {
        public string idSolicitud { get; set; }
        public string fechaOrden { get; set; }
        public string articulo { get; set; }
        public int cantidad { get; set; }
        public FrmEdOrdenes()
        {
            InitializeComponent();
        }

        private void FrmEdOrdenes_Load(object sender, EventArgs e)
        {
            int nextID = 0;
            if (modo.Equals("U"))
            {
                this.Text = "Ordenes de Compra - Actualizar";
                try
                {
                    TxtID.Text = ID.ToString();
                    TxtIDSolicitud.Text = idSolicitud;
                    TxtFecha.Text = fechaOrden;
                    TxtArticulo.Text = articulo;
                    TxtCantidad.Text = cantidad.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error. " + ex);
                }

            }
            else
            {
                this.Text = "Ordenes de Compra - Agregar";
                string sql = "select TOP 1 ID_orden from Orden_compras ORDER BY ID_orden DESC";
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
                    sql = "insert into Orden_Compras values ('";
                    sql += TxtIDSolicitud.Text + "', '" + TxtFecha.Text + "', " + estadobool + ", '" + TxtArticulo.Text + "', '"
                         + TxtCantidad.Text + "')";
                }
                else
                {
                    sql = "Update Orden_Compras set ";
                    sql += "id_solicitud_orden = '" + TxtIDSolicitud.Text + "',";
                    sql += "fecha_orden = '" + TxtFecha.Text + "',";
                    sql += "estado_orden = " + estadobool;
                    sql += "articulo_orden = '" + TxtArticulo.Text + "',";
                    sql += "cantidad_orden = '" + TxtCantidad.Text + "',";
                    sql += " where ID_orden = '" + TxtID.Text + "'";
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
            {
                try
                {
                    string sql = "delete Orden_Compras ";
                    sql += "where ID_orden = '" + TxtID.Text + "'";
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
}
