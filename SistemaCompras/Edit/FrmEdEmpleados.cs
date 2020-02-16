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
    public partial class FrmEdEmpleados : FrmEdBase
    {
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string departamento { get; set; }
        public FrmEdEmpleados()
        {
            InitializeComponent();
        }

        private void FrmEdEmpleados_Load(object sender, EventArgs e)
        {
            int nextID = 0;
            if (modo.Equals("U"))
            {
                this.Text = "Empleados - Actualizar";
                try
                {
                    TxtID.Text = ID.ToString() ;
                    TxtCedula.Text = cedula;
                    TxtNombre.Text = nombre;
                    TxtDepartamento.Text = departamento;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error. " + ex);
                }

            }
            else
            {
                this.Text = "Empleados - Agregar";
                string sql = "select TOP 1 ID_empleado from Empleados ORDER BY ID_empleado DESC";
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
                    sql = "insert into Empleados values ('";
                    sql += TxtCedula.Text + "', '" + TxtNombre.Text + "', '" + TxtDepartamento.Text + "', " + estadobool + ")";
                }
                else {
                    sql = "Update Empleados set ";
                    sql += "cedula_empleado = '" + TxtCedula.Text + "',";
                    sql += "nombre_empleado = '" + TxtNombre.Text + "',";
                    sql += "departamento_empleado = '" + TxtDepartamento.Text + "',";
                    sql += "estado_empleado = " + estadobool;
                    sql += " where ID_Empleado = '" + TxtID.Text + "'";
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
                string sql = "delete Empleados ";
                sql += "where ID_empleado = '" + TxtID.Text + "'";
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
