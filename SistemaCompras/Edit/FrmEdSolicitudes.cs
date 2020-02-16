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
    public partial class FrmEdSolicitudes : FrmEdBase
    {
        public string empleadoSolicitante { get; set; }
        public string fechaSolicitud { get; set; }
        public string articulo { get; set; }
        public int cantidad { get; set; }
        public string unidad { get; set; }
        public FrmEdSolicitudes()
        {
            InitializeComponent();
        }

        private void FrmEdSolicitudes_Load(object sender, EventArgs e)
        {
            int nextID = 0;
            if (modo.Equals("U"))
            {
                this.Text = "Solicitudes - Actualizar";
                try
                {
                    TxtID.Text = ID.ToString();
                    TxtEmpleado.Text = empleadoSolicitante;
                    TxtFecha.Text = fechaSolicitud;
                    TxtArticulo.Text = articulo;
                    TxtCantidad.Text = cantidad.ToString();
                    TxtUnidad.Text = unidad;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error. " + ex);
                }

            }
            else
            {
                this.Text = "Solicitudes - Agregar";
                string sql = "select TOP 1 ID_solicitud from Solicitud_Articulos ORDER BY ID_solicitud DESC";
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
                    sql = "insert into Solicitud_Articulos values ('";
                    sql += TxtEmpleado.Text + "', '" + TxtFecha.Text + "', '" + TxtArticulo.Text + "', '"
                         + TxtCantidad.Text + "', '" + TxtUnidad.Text + "', " + estadobool + ")";
                }
                else
                {
                    sql = "Update Solicitud_Articulos set ";
                    sql += "empleado_solicitud = '" + TxtEmpleado.Text + "',";
                    sql += "fecha_solicitud = '" + TxtFecha.Text + "',";
                    sql += "articulo_solicitud = '" + TxtArticulo.Text + "',";
                    sql += "cantidad_solicitud = '" + TxtCantidad.Text + "',";
                    sql += "unidad_solicitud = '" + TxtUnidad.Text + "',";
                    sql += "estado_solicitud = " + estadobool;
                    sql += " where ID_solicitud = '" + TxtID.Text + "'";
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
                string sql = "delete Solicitud_Articulos ";
                sql += "where ID_solicitud = '" + TxtID.Text + "'";
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
