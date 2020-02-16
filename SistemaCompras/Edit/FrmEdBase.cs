using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaCompras.Edit
{
    public partial class FrmEdBase : BaseForm
    {
        public int ID { get; set; }
        public string estado { get; set; }
        public int estadobool { get; set; }
        public FrmEdBase()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (estado == "True")
            {
                ChkEstado.Checked = true;
                estadobool = 1;
            }
            if (estado == "False")
            {
                ChkEstado.Checked = false;
                estadobool = 0;
            }
        }

        private void ChkEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkEstado.Checked)
            {
                ChkEstado.Checked = true;
                estadobool = 1;
            }
            else
            {
                ChkEstado.Checked = false;
                estadobool = 0;
            }
        }
    }
}
