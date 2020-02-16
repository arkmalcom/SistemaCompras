using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;
using SistemaCompras.Edit;

namespace SistemaCompras
{
    public partial class MenuPrincipal : BaseForm
    {
        string valorSeleccionado = "Empleados";
        List<Elementos> elementosBusqueda = new List<Elementos>();
        

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionComprasDataSet.Empleados' table. You can move, or remove it, as needed.
            this.empleadosTableAdapter.Fill(this.gestionComprasDataSet.Empleados);
            // TODO: This line of code loads data into the 'gestionComprasDataSet.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.Fill(this.gestionComprasDataSet.Marcas);
            TxtCriterio.Focus();
            ejecutarConsulta();
            switch(valorSeleccionado)
            {
                case "Empleados":
                    elementosBusqueda.Add(new Elementos() { Name = "ID_empleado", Value = "ID_empleado" });                    
                    break;
            }
            CbxCriterio.DataSource = elementosBusqueda;
            CbxCriterio.DisplayMember = "Name";
            CbxCriterio.ValueMember = "Value";
        }

        private void ejecutarConsulta()
        {
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-23U7U2T\\SQLEXPRESS;Initial Catalog=GestionCompras;Integrated Security=True");
                con.Open();
                string sql = "select * from " + valorSeleccionado;
                if (TxtCriterio.Text.Length > 0 && TxtCriterio.Text != "Valor a buscar")
                {
                    sql += " where " + CbxCriterio.Text + " like '%" + TxtCriterio.Text + "%'";
                    sql += " order by " + CbxCriterio.Text;
                }
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DgvResultados.DataSource = dt;
                DgvResultados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. " + ex.Message);

            }
        }

        private void CmdDepartamentos_Click(object sender, EventArgs e)
        {
            valorSeleccionado = "Departamentos";
            ejecutarConsulta();
        }

        private void CmdEmpleados_Click(object sender, EventArgs e)
        {
            valorSeleccionado = "Empleados";
            
            ejecutarConsulta();
        }

        private void CmdArticulos_Click(object sender, EventArgs e)
        {
            valorSeleccionado = "Articulos";
            ejecutarConsulta();
        }

        private void CmdMarcas_Click(object sender, EventArgs e)
        {
            valorSeleccionado = "Marcas";
            ejecutarConsulta();
        }

        private void CmdUnidades_Click(object sender, EventArgs e)
        {
            valorSeleccionado = "Unidades_Medida";
            ejecutarConsulta();
        }

        private void CmdProveedores_Click(object sender, EventArgs e)
        {
            valorSeleccionado = "Proveedores";
            ejecutarConsulta();
        }

        private void CmdSolicitudes_Click(object sender, EventArgs e)
        {
            valorSeleccionado = "Solicitud_Articulos";
            ejecutarConsulta();
        }

        private void CmdOrdenes_Click(object sender, EventArgs e)
        {
            valorSeleccionado = "Orden_Compras";
            ejecutarConsulta();
        }

        private void DgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DgvResultados.SelectedRows[0];
                FrmEdBase frmEd = new FrmEdBase();

                switch (valorSeleccionado)
                {

                    case "Empleados":
                        FrmEdEmpleados frmEmp = new FrmEdEmpleados();
                        frmEmp.ID = (int) row.Cells[0].Value;
                        frmEmp.cedula = row.Cells[1].Value.ToString();
                        frmEmp.nombre = row.Cells[2].Value.ToString();
                        frmEmp.departamento = row.Cells[3].Value.ToString();
                        frmEmp.estado = row.Cells[4].Value.ToString();
                        frmEmp.con = con;
                        frmEmp.modo = "U";
                        frmEmp.ShowDialog();
                        break;
                    case "Departamentos":
                        FrmEdDepartamentos frmDep = new FrmEdDepartamentos();
                        frmDep.ID = (int) row.Cells[0].Value;
                        frmDep.nombre = row.Cells[1].Value.ToString();
                        frmDep.estado = row.Cells[2].Value.ToString();
                        frmDep.con = con;
                        frmDep.modo = "U";
                        frmDep.ShowDialog();
                        break;
                    case "Marcas":
                        FrmEdMarcas frmMarcas = new FrmEdMarcas();
                        frmMarcas.ID = (int)row.Cells[0].Value;
                        frmMarcas.descripcion = row.Cells[1].Value.ToString();
                        frmMarcas.estado = row.Cells[2].Value.ToString();
                        frmMarcas.con = con;
                        frmMarcas.modo = "U";
                        frmMarcas.ShowDialog();
                        break;
                    case "Unidades_Medida":
                        FrmEdUnidades frmUd = new FrmEdUnidades();
                        frmUd.ID = (int)row.Cells[0].Value;
                        frmUd.descripcion = row.Cells[1].Value.ToString();
                        frmUd.estado = row.Cells[2].Value.ToString();
                        frmUd.con = con;
                        frmUd.modo = "U";
                        frmUd.ShowDialog();
                        break;
                    case "Proveedores":
                        FrmEdProveedores frmPro = new FrmEdProveedores();
                        frmPro.ID = (int)row.Cells[0].Value;
                        frmPro.cedula = row.Cells[1].Value.ToString();
                        frmPro.nombre = row.Cells[2].Value.ToString();
                        frmPro.estado = row.Cells[3].Value.ToString();
                        frmPro.con = con;
                        frmPro.modo = "U";
                        frmPro.ShowDialog();
                        break;
                    case "Articulos":
                        FrmEdArticulos frmArt = new FrmEdArticulos();
                        frmArt.ID = (int)row.Cells[0].Value;
                        frmArt.descripcion = row.Cells[1].Value.ToString();
                        frmArt.marca = row.Cells[2].Value.ToString();
                        frmArt.unidad = row.Cells[3].Value.ToString();
                        frmArt.existencia = (int)row.Cells[4].Value;
                        frmArt.costoUnitario = (int)row.Cells[5].Value;
                        frmArt.estado = row.Cells[6].Value.ToString();
                        frmArt.con = con;
                        frmArt.modo = "U";
                        frmArt.ShowDialog();
                        break;
                    case "Solicitud_Articulos":
                        FrmEdSolicitudes frmSol = new FrmEdSolicitudes();
                        frmSol.ID = (int)row.Cells[0].Value;
                        frmSol.empleadoSolicitante = row.Cells[1].Value.ToString();
                        frmSol.fechaSolicitud = row.Cells[2].Value.ToString();
                        frmSol.articulo = row.Cells[3].Value.ToString();
                        frmSol.cantidad = (int)row.Cells[4].Value;
                        frmSol.unidad = row.Cells[5].Value.ToString();
                        frmSol.estado = row.Cells[6].Value.ToString();
                        frmSol.con = con;
                        frmSol.modo = "U";
                        frmSol.ShowDialog();
                        break;
                    case "Orden_Compras":
                        FrmEdOrdenes frmOrd = new FrmEdOrdenes();
                        frmOrd.ID = (int)row.Cells[0].Value;
                        frmOrd.idSolicitud = row.Cells[1].Value.ToString();
                        frmOrd.fechaOrden = row.Cells[2].Value.ToString();
                        frmOrd.estado = row.Cells[3].Value.ToString();
                        frmOrd.articulo = row.Cells[4].Value.ToString();
                        frmOrd.cantidad = (int)row.Cells[5].Value;
                        frmOrd.con = con;
                        frmOrd.modo = "U";
                        frmOrd.ShowDialog();
                        break;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. " + ex.Message);
            }
        }

        private void CmdAgregar_Click(object sender, EventArgs e)
        {
            FrmEdBase frmEd = new FrmEdBase();
            frmEd.con = con;
            frmEd.modo = "C";
            switch (valorSeleccionado)
            {
                case "Empleados":
                    FrmEdEmpleados frmEmp = new FrmEdEmpleados();
                    frmEmp.modo = "C";
                    frmEmp.con = con;
                    frmEmp.ShowDialog();
                    break;
                case "Departamentos":
                    FrmEdDepartamentos frmDep = new FrmEdDepartamentos();
                    frmDep.modo = "C";
                    frmDep.con = con;
                    frmDep.ShowDialog();
                    break;
                case "Marcas":
                    FrmEdMarcas frmMarcas = new FrmEdMarcas();
                    frmMarcas.modo = "C";
                    frmMarcas.con = con;
                    frmMarcas.ShowDialog();
                    break;
                case "Unidades_Medida":
                    FrmEdUnidades frmUd = new FrmEdUnidades();
                    frmUd.con = con;
                    frmUd.modo = "C";
                    frmUd.ShowDialog();
                    break;
                case "Proveedores":
                    FrmEdProveedores frmPro = new FrmEdProveedores();
                    frmPro.con = con;
                    frmPro.modo = "C";
                    frmPro.ShowDialog();
                    break;
                case "Articulos":
                    FrmEdArticulos frmArt = new FrmEdArticulos();
                    frmArt.con = con;
                    frmArt.modo = "C";
                    frmArt.ShowDialog();
                    break;
                case "Solicitud_Articulos":
                    FrmEdSolicitudes frmSol = new FrmEdSolicitudes();
                    frmSol.con = con;
                    frmSol.modo = "C";
                    frmSol.ShowDialog();
                    break;
                case "Orden_Compras":
                    FrmEdOrdenes frmOrd = new FrmEdOrdenes();
                    frmOrd.con = con;
                    frmOrd.modo = "C";
                    frmOrd.ShowDialog();
                    break;
            }

        }

        private void MenuPrincipal_Activated(object sender, EventArgs e)
        {
            TxtCriterio.Focus();
            ejecutarConsulta();
        }

        private void CmdBuscar_Click(object sender, EventArgs e)
        {
            ejecutarConsulta();
        }
    }
}
