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

namespace SistemaCompras
{
    public partial class BaseForm : MaterialForm
    {
        public SqlConnection con { get; set; }
        public string modo { get; set; }
        public BaseForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Indigo800, Primary.Indigo900,
                Primary.Indigo900, Accent.Indigo200,
                TextShade.WHITE
                );
        }

        private void baseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
