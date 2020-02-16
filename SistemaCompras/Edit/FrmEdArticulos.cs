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
    public partial class FrmEdArticulos : FrmEdBase
    {
        public string descripcion { get; set; }
        public string marca { get; set; }
        public string unidad { get; set; }
        public int existencia { get; set; }
        public int costoUnitario { get; set; }
        public FrmEdArticulos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int nextID = 0;
            if (modo.Equals("U"))
            {
                this.Text = "Articulos - Actualizar";
                try
                {
                    TxtID.Text = ID.ToString();
                    TxtDescripcion.Text = descripcion;
                    TxtMarca.Text = marca;
                    TxtUnidad.Text = unidad;
                    TxtExistencia.Text = existencia.ToString();
                    TxtCostoUnitario.Text = costoUnitario.ToString() ;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error. " + ex);
                }

            }
            else
            {
                this.Text = "Articulos - Agregar";
                string sql = "select TOP 1 ID_articulo from Articulos ORDER BY ID_articulo DESC";
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
                    sql = "insert into Articulos values ('";
                    sql += TxtDescripcion.Text + "', '" + TxtMarca.Text + "', '" + TxtUnidad.Text + "', '"
                         + TxtExistencia.Text + "', '" + TxtCostoUnitario.Text + "', " + estadobool + ")";
                }
                else
                {
                    sql = "Update Articulos set ";
                    sql += "descripcion_articulo = '" + TxtDescripcion.Text + "',";
                    sql += "marca_articulo = '" + TxtMarca.Text + "',";
                    sql += "unidad_articulo = '" + TxtUnidad.Text + "',";
                    sql += "existencia_articulo = '" + TxtExistencia.Text + "',";
                    sql += "costo_unitario_articulo = '" + TxtCostoUnitario.Text + "',";
                    sql += "estado_articulo = " + estadobool;
                    sql += " where ID_articulo = '" + TxtID.Text + "'";
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
                string sql = "delete Articulos ";
                sql += "where ID_articulo = '" + TxtID.Text + "'";
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
