using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class FrmEdDepartamentos : FrmEdBase
    {
        public string nombre { get; set; }
        public FrmEdDepartamentos()
        {
            InitializeComponent();
        }

        private void FrmEdDepartamentos_Load(object sender, EventArgs e)
        {
            int nextID = 0;
            if (modo.Equals("U"))
            {
                this.Text = "Departamentos - Actualizar";
                try
                {
                    TxtID.Text = ID.ToString();
                    TxtNombre.Text = nombre;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error. " + ex);
                }

            }
            else
            {
                this.Text = "Departamentos - Agregar";
                string sql = "select TOP 1 ID_departamento from Departamentos ORDER BY ID_departamento DESC";
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
                    sql = "insert into Departamentos values ('";
                    sql += TxtNombre.Text + "', " + estadobool + ")";
                }
                else
                {
                    sql = "Update Departamentos set ";
                    sql += "nombre_departamento = '" + TxtNombre.Text + "',";
                    sql += "estado_departamento = " + estadobool;
                    sql += " where ID_departamento = '" + TxtID.Text + "'";
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
                string sql = "delete Departamentos ";
                sql += "where ID_departamento = '" + TxtID.Text + "'";
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
