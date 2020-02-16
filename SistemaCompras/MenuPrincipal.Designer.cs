namespace SistemaCompras
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.sssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CmdEmpleados = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CmdDepartamentos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CmdArticulos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CmdMarcas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DgvResultados = new System.Windows.Forms.DataGridView();
            this.CmdUnidades = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CmdProveedores = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CmdSolicitudes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CmdOrdenes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtCriterio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbxCriterio = new System.Windows.Forms.ComboBox();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionComprasDataSet = new SistemaCompras.GestionComprasDataSet();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.CmdAgregar = new System.Windows.Forms.Button();
            this.CmdBuscar = new System.Windows.Forms.Button();
            this.gestionComprasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcasTableAdapter = new SistemaCompras.GestionComprasDataSetTableAdapters.MarcasTableAdapter();
            this.empleadosTableAdapter = new SistemaCompras.GestionComprasDataSetTableAdapters.EmpleadosTableAdapter();
            this.materialContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResultados)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionComprasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionComprasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sssToolStripMenuItem});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(90, 26);
            // 
            // sssToolStripMenuItem
            // 
            this.sssToolStripMenuItem.Name = "sssToolStripMenuItem";
            this.sssToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.sssToolStripMenuItem.Text = "sss";
            // 
            // CmdEmpleados
            // 
            this.CmdEmpleados.AutoSize = true;
            this.CmdEmpleados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdEmpleados.Depth = 0;
            this.CmdEmpleados.Icon = null;
            this.CmdEmpleados.Location = new System.Drawing.Point(0, 64);
            this.CmdEmpleados.MinimumSize = new System.Drawing.Size(195, 50);
            this.CmdEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdEmpleados.Name = "CmdEmpleados";
            this.CmdEmpleados.Primary = true;
            this.CmdEmpleados.Size = new System.Drawing.Size(195, 50);
            this.CmdEmpleados.TabIndex = 1;
            this.CmdEmpleados.Text = "Empleados";
            this.CmdEmpleados.UseVisualStyleBackColor = true;
            this.CmdEmpleados.Click += new System.EventHandler(this.CmdEmpleados_Click);
            // 
            // CmdDepartamentos
            // 
            this.CmdDepartamentos.AutoSize = true;
            this.CmdDepartamentos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdDepartamentos.Depth = 0;
            this.CmdDepartamentos.Icon = null;
            this.CmdDepartamentos.Location = new System.Drawing.Point(0, 113);
            this.CmdDepartamentos.MinimumSize = new System.Drawing.Size(195, 50);
            this.CmdDepartamentos.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdDepartamentos.Name = "CmdDepartamentos";
            this.CmdDepartamentos.Primary = true;
            this.CmdDepartamentos.Size = new System.Drawing.Size(195, 50);
            this.CmdDepartamentos.TabIndex = 2;
            this.CmdDepartamentos.Text = "Departamentos";
            this.CmdDepartamentos.UseVisualStyleBackColor = true;
            this.CmdDepartamentos.Click += new System.EventHandler(this.CmdDepartamentos_Click);
            // 
            // CmdArticulos
            // 
            this.CmdArticulos.AutoSize = true;
            this.CmdArticulos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdArticulos.Depth = 0;
            this.CmdArticulos.Icon = null;
            this.CmdArticulos.Location = new System.Drawing.Point(0, 162);
            this.CmdArticulos.MinimumSize = new System.Drawing.Size(195, 50);
            this.CmdArticulos.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdArticulos.Name = "CmdArticulos";
            this.CmdArticulos.Primary = true;
            this.CmdArticulos.Size = new System.Drawing.Size(195, 50);
            this.CmdArticulos.TabIndex = 3;
            this.CmdArticulos.Text = "Articulos";
            this.CmdArticulos.UseVisualStyleBackColor = true;
            this.CmdArticulos.Click += new System.EventHandler(this.CmdArticulos_Click);
            // 
            // CmdMarcas
            // 
            this.CmdMarcas.AutoSize = true;
            this.CmdMarcas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdMarcas.Depth = 0;
            this.CmdMarcas.Icon = null;
            this.CmdMarcas.Location = new System.Drawing.Point(0, 211);
            this.CmdMarcas.MinimumSize = new System.Drawing.Size(195, 50);
            this.CmdMarcas.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdMarcas.Name = "CmdMarcas";
            this.CmdMarcas.Primary = true;
            this.CmdMarcas.Size = new System.Drawing.Size(195, 50);
            this.CmdMarcas.TabIndex = 4;
            this.CmdMarcas.Text = "Marcas";
            this.CmdMarcas.UseVisualStyleBackColor = true;
            this.CmdMarcas.Click += new System.EventHandler(this.CmdMarcas_Click);
            // 
            // DgvResultados
            // 
            this.DgvResultados.AllowUserToAddRows = false;
            this.DgvResultados.AllowUserToDeleteRows = false;
            this.DgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvResultados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.DgvResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvResultados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Gothic", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvResultados.ColumnHeadersHeight = 25;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvResultados.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvResultados.EnableHeadersVisualStyles = false;
            this.DgvResultados.GridColor = System.Drawing.Color.Black;
            this.DgvResultados.Location = new System.Drawing.Point(196, 104);
            this.DgvResultados.Name = "DgvResultados";
            this.DgvResultados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvResultados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvResultados.ShowEditingIcon = false;
            this.DgvResultados.Size = new System.Drawing.Size(741, 352);
            this.DgvResultados.TabIndex = 5;
            this.DgvResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvResultados_CellDoubleClick);
            // 
            // CmdUnidades
            // 
            this.CmdUnidades.AutoSize = true;
            this.CmdUnidades.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdUnidades.Depth = 0;
            this.CmdUnidades.Icon = null;
            this.CmdUnidades.Location = new System.Drawing.Point(0, 260);
            this.CmdUnidades.MinimumSize = new System.Drawing.Size(195, 50);
            this.CmdUnidades.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdUnidades.Name = "CmdUnidades";
            this.CmdUnidades.Primary = true;
            this.CmdUnidades.Size = new System.Drawing.Size(195, 50);
            this.CmdUnidades.TabIndex = 6;
            this.CmdUnidades.Text = "Unidades de Medida";
            this.CmdUnidades.UseVisualStyleBackColor = true;
            this.CmdUnidades.Click += new System.EventHandler(this.CmdUnidades_Click);
            // 
            // CmdProveedores
            // 
            this.CmdProveedores.AutoSize = true;
            this.CmdProveedores.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdProveedores.Depth = 0;
            this.CmdProveedores.Icon = null;
            this.CmdProveedores.Location = new System.Drawing.Point(0, 309);
            this.CmdProveedores.MinimumSize = new System.Drawing.Size(195, 50);
            this.CmdProveedores.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdProveedores.Name = "CmdProveedores";
            this.CmdProveedores.Primary = true;
            this.CmdProveedores.Size = new System.Drawing.Size(195, 50);
            this.CmdProveedores.TabIndex = 7;
            this.CmdProveedores.Text = "Proveedores";
            this.CmdProveedores.UseVisualStyleBackColor = true;
            this.CmdProveedores.Click += new System.EventHandler(this.CmdProveedores_Click);
            // 
            // CmdSolicitudes
            // 
            this.CmdSolicitudes.AutoSize = true;
            this.CmdSolicitudes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdSolicitudes.Depth = 0;
            this.CmdSolicitudes.Icon = null;
            this.CmdSolicitudes.Location = new System.Drawing.Point(0, 358);
            this.CmdSolicitudes.MinimumSize = new System.Drawing.Size(195, 50);
            this.CmdSolicitudes.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdSolicitudes.Name = "CmdSolicitudes";
            this.CmdSolicitudes.Primary = true;
            this.CmdSolicitudes.Size = new System.Drawing.Size(195, 50);
            this.CmdSolicitudes.TabIndex = 8;
            this.CmdSolicitudes.Text = "Solicitudes";
            this.CmdSolicitudes.UseVisualStyleBackColor = true;
            this.CmdSolicitudes.Click += new System.EventHandler(this.CmdSolicitudes_Click);
            // 
            // CmdOrdenes
            // 
            this.CmdOrdenes.AutoSize = true;
            this.CmdOrdenes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdOrdenes.Depth = 0;
            this.CmdOrdenes.Icon = null;
            this.CmdOrdenes.Location = new System.Drawing.Point(0, 407);
            this.CmdOrdenes.MinimumSize = new System.Drawing.Size(195, 50);
            this.CmdOrdenes.MouseState = MaterialSkin.MouseState.HOVER;
            this.CmdOrdenes.Name = "CmdOrdenes";
            this.CmdOrdenes.Primary = true;
            this.CmdOrdenes.Size = new System.Drawing.Size(195, 50);
            this.CmdOrdenes.TabIndex = 9;
            this.CmdOrdenes.Text = "Ordenes de Compra";
            this.CmdOrdenes.UseVisualStyleBackColor = true;
            this.CmdOrdenes.Click += new System.EventHandler(this.CmdOrdenes_Click);
            // 
            // TxtCriterio
            // 
            this.TxtCriterio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.TxtCriterio.Depth = 0;
            this.TxtCriterio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtCriterio.Hint = "";
            this.TxtCriterio.Location = new System.Drawing.Point(261, 72);
            this.TxtCriterio.MaxLength = 32767;
            this.TxtCriterio.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCriterio.Name = "TxtCriterio";
            this.TxtCriterio.PasswordChar = '\0';
            this.TxtCriterio.SelectedText = "";
            this.TxtCriterio.SelectionLength = 0;
            this.TxtCriterio.SelectionStart = 0;
            this.TxtCriterio.Size = new System.Drawing.Size(370, 23);
            this.TxtCriterio.TabIndex = 0;
            this.TxtCriterio.TabStop = false;
            this.TxtCriterio.Text = "Valor a buscar";
            this.TxtCriterio.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel1.Location = new System.Drawing.Point(201, 72);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(55, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Buscar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.CbxCriterio);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.CmdAgregar);
            this.panel1.Controls.Add(this.CmdBuscar);
            this.panel1.Location = new System.Drawing.Point(194, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 393);
            this.panel1.TabIndex = 14;
            // 
            // CbxCriterio
            // 
            this.CbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCriterio.FormattingEnabled = true;
            this.CbxCriterio.Location = new System.Drawing.Point(508, 7);
            this.CbxCriterio.Name = "CbxCriterio";
            this.CbxCriterio.Size = new System.Drawing.Size(134, 21);
            this.CbxCriterio.TabIndex = 15;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.gestionComprasDataSet;
            // 
            // gestionComprasDataSet
            // 
            this.gestionComprasDataSet.DataSetName = "GestionComprasDataSet";
            this.gestionComprasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel2.Location = new System.Drawing.Point(443, 8);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(59, 19);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.Text = "Criterio";
            // 
            // CmdAgregar
            // 
            this.CmdAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.CmdAgregar.BackgroundImage = global::SistemaCompras.Properties.Resources.add;
            this.CmdAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CmdAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdAgregar.FlatAppearance.BorderSize = 0;
            this.CmdAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CmdAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CmdAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdAgregar.ForeColor = System.Drawing.Color.Transparent;
            this.CmdAgregar.Location = new System.Drawing.Point(703, 2);
            this.CmdAgregar.Margin = new System.Windows.Forms.Padding(0);
            this.CmdAgregar.Name = "CmdAgregar";
            this.CmdAgregar.Size = new System.Drawing.Size(32, 32);
            this.CmdAgregar.TabIndex = 13;
            this.CmdAgregar.UseVisualStyleBackColor = false;
            this.CmdAgregar.Click += new System.EventHandler(this.CmdAgregar_Click);
            // 
            // CmdBuscar
            // 
            this.CmdBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.CmdBuscar.BackgroundImage = global::SistemaCompras.Properties.Resources.search3;
            this.CmdBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CmdBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdBuscar.FlatAppearance.BorderSize = 0;
            this.CmdBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CmdBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.CmdBuscar.Location = new System.Drawing.Point(660, 2);
            this.CmdBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.CmdBuscar.Name = "CmdBuscar";
            this.CmdBuscar.Size = new System.Drawing.Size(32, 32);
            this.CmdBuscar.TabIndex = 12;
            this.CmdBuscar.UseVisualStyleBackColor = false;
            this.CmdBuscar.Click += new System.EventHandler(this.CmdBuscar_Click);
            // 
            // gestionComprasDataSetBindingSource
            // 
            this.gestionComprasDataSetBindingSource.DataSource = this.gestionComprasDataSet;
            this.gestionComprasDataSetBindingSource.Position = 0;
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.gestionComprasDataSet;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 457);
            this.Controls.Add(this.DgvResultados);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.TxtCriterio);
            this.Controls.Add(this.CmdOrdenes);
            this.Controls.Add(this.CmdSolicitudes);
            this.Controls.Add(this.CmdProveedores);
            this.Controls.Add(this.CmdUnidades);
            this.Controls.Add(this.CmdMarcas);
            this.Controls.Add(this.CmdArticulos);
            this.Controls.Add(this.CmdDepartamentos);
            this.Controls.Add(this.CmdEmpleados);
            this.Controls.Add(this.panel1);
            this.Name = "MenuPrincipal";
            this.Text = "Gestion de Compras";
            this.Activated += new System.EventHandler(this.MenuPrincipal_Activated);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.materialContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvResultados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionComprasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionComprasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sssToolStripMenuItem;
        private MaterialSkin.Controls.MaterialRaisedButton CmdEmpleados;
        private MaterialSkin.Controls.MaterialRaisedButton CmdDepartamentos;
        private MaterialSkin.Controls.MaterialRaisedButton CmdArticulos;
        private MaterialSkin.Controls.MaterialRaisedButton CmdMarcas;
        private System.Windows.Forms.DataGridView DgvResultados;
        private MaterialSkin.Controls.MaterialRaisedButton CmdUnidades;
        private MaterialSkin.Controls.MaterialRaisedButton CmdProveedores;
        private MaterialSkin.Controls.MaterialRaisedButton CmdSolicitudes;
        private MaterialSkin.Controls.MaterialRaisedButton CmdOrdenes;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCriterio;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button CmdBuscar;
        private System.Windows.Forms.Button CmdAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CbxCriterio;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.BindingSource gestionComprasDataSetBindingSource;
        private GestionComprasDataSet gestionComprasDataSet;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private GestionComprasDataSetTableAdapters.MarcasTableAdapter marcasTableAdapter;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private GestionComprasDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
    }
}

