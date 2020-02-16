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
    public partial class FrmEdUnidades : FrmEdBase
    {
        public string descripcion { get; set; }
        public FrmEdUnidades()
        {
            InitializeComponent();
        }

        private void FrmEdUnidades_Load(object sender, EventArgs e)
        {
            int nextID = 0;
            if (modo.Equals("U"))
            {
                this.Text = "Unidades de Medida - Actualizar";
                try
                {
                    TxtID.Text = ID.ToString();
                    TxtDescripcion.Text = descripcion;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error. " + ex);
                }

            }
            else
            {
                this.Text = "Unidades de Medida - Agregar";
                string sql = "select TOP 1 ID_unidad from Unidades_Medida ORDER BY ID_unidad DESC";
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
                    sql = "insert into Unidades_Medida values ('";
                    sql += TxtDescripcion.Text + "', " + estadobool + ")";
                }
                else
                {
                    sql = "Update Unidades_Medida set ";
                    sql += "descripcion_unidad = '" + TxtDescripcion.Text + "',";
                    sql += "estado_unidad = " + estadobool;
                    sql += " where ID_unidad = '" + TxtID.Text + "'";
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
                string sql = "delete Unidades_Medida ";
                sql += "where ID_unidad = '" + TxtID.Text + "'";
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
