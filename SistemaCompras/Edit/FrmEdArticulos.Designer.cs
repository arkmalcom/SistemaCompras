namespace SistemaCompras.Edit
{
    partial class FrmEdArticulos
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtUnidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtExistencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtCostoUnitario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.gestionComprasDataSet = new SistemaCompras.GestionComprasDataSet();
            this.gestionComprasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtMarca = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.gestionComprasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionComprasDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(154, 83);
            // 
            // CmdEliminar
            // 
            this.CmdEliminar.FlatAppearance.BorderSize = 0;
            this.CmdEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CmdEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CmdEliminar.Location = new System.Drawing.Point(192, 372);
            this.CmdEliminar.Click += new System.EventHandler(this.CmdEliminar_Click);
            // 
            // ChkEstado
            // 
            this.ChkEstado.Location = new System.Drawing.Point(16, 325);
            this.ChkEstado.TabIndex = 5;
            // 
            // CmdGuardar
            // 
            this.CmdGuardar.FlatAppearance.BorderSize = 0;
            this.CmdGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CmdGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CmdGuardar.Location = new System.Drawing.Point(108, 372);
            this.CmdGuardar.Click += new System.EventHandler(this.CmdGuardar_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 118);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(89, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Descripcion";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 160);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(51, 19);
            this.materialLabel3.TabIndex = 17;
            this.materialLabel3.Text = "Marca";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 204);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(128, 19);
            this.materialLabel4.TabIndex = 18;
            this.materialLabel4.Text = "Unidad de Medida";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 244);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(78, 19);
            this.materialLabel5.TabIndex = 19;
            this.materialLabel5.Text = "Existencia";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Depth = 0;
            this.TxtDescripcion.Hint = "";
            this.TxtDescripcion.Location = new System.Drawing.Point(154, 118);
            this.TxtDescripcion.MaxLength = 32767;
            this.TxtDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.PasswordChar = '\0';
            this.TxtDescripcion.SelectedText = "";
            this.TxtDescripcion.SelectionLength = 0;
            this.TxtDescripcion.SelectionStart = 0;
            this.TxtDescripcion.Size = new System.Drawing.Size(163, 23);
            this.TxtDescripcion.TabIndex = 0;
            this.TxtDescripcion.TabStop = false;
            this.TxtDescripcion.UseSystemPasswordChar = false;
            // 
            // TxtUnidad
            // 
            this.TxtUnidad.Depth = 0;
            this.TxtUnidad.Hint = "";
            this.TxtUnidad.Location = new System.Drawing.Point(154, 204);
            this.TxtUnidad.MaxLength = 32767;
            this.TxtUnidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtUnidad.Name = "TxtUnidad";
            this.TxtUnidad.PasswordChar = '\0';
            this.TxtUnidad.SelectedText = "";
            this.TxtUnidad.SelectionLength = 0;
            this.TxtUnidad.SelectionStart = 0;
            this.TxtUnidad.Size = new System.Drawing.Size(163, 23);
            this.TxtUnidad.TabIndex = 2;
            this.TxtUnidad.TabStop = false;
            this.TxtUnidad.UseSystemPasswordChar = false;
            // 
            // TxtExistencia
            // 
            this.TxtExistencia.Depth = 0;
            this.TxtExistencia.Hint = "";
            this.TxtExistencia.Location = new System.Drawing.Point(154, 244);
            this.TxtExistencia.MaxLength = 32767;
            this.TxtExistencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtExistencia.Name = "TxtExistencia";
            this.TxtExistencia.PasswordChar = '\0';
            this.TxtExistencia.SelectedText = "";
            this.TxtExistencia.SelectionLength = 0;
            this.TxtExistencia.SelectionStart = 0;
            this.TxtExistencia.Size = new System.Drawing.Size(163, 23);
            this.TxtExistencia.TabIndex = 3;
            this.TxtExistencia.TabStop = false;
            this.TxtExistencia.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel6.Location = new System.Drawing.Point(12, 289);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(107, 19);
            this.materialLabel6.TabIndex = 20;
            this.materialLabel6.Text = "Costo Unitario";
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCostoUnitario
            // 
            this.TxtCostoUnitario.Depth = 0;
            this.TxtCostoUnitario.Hint = "";
            this.TxtCostoUnitario.Location = new System.Drawing.Point(154, 289);
            this.TxtCostoUnitario.MaxLength = 32767;
            this.TxtCostoUnitario.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCostoUnitario.Name = "TxtCostoUnitario";
            this.TxtCostoUnitario.PasswordChar = '\0';
            this.TxtCostoUnitario.SelectedText = "";
            this.TxtCostoUnitario.SelectionLength = 0;
            this.TxtCostoUnitario.SelectionStart = 0;
            this.TxtCostoUnitario.Size = new System.Drawing.Size(163, 23);
            this.TxtCostoUnitario.TabIndex = 4;
            this.TxtCostoUnitario.TabStop = false;
            this.TxtCostoUnitario.UseSystemPasswordChar = false;
            // 
            // gestionComprasDataSet
            // 
            this.gestionComprasDataSet.DataSetName = "GestionComprasDataSet";
            this.gestionComprasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestionComprasDataSetBindingSource
            // 
            this.gestionComprasDataSetBindingSource.DataSource = this.gestionComprasDataSet;
            this.gestionComprasDataSetBindingSource.Position = 0;
            // 
            // TxtMarca
            // 
            this.TxtMarca.Depth = 0;
            this.TxtMarca.Hint = "";
            this.TxtMarca.Location = new System.Drawing.Point(154, 160);
            this.TxtMarca.MaxLength = 32767;
            this.TxtMarca.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.PasswordChar = '\0';
            this.TxtMarca.SelectedText = "";
            this.TxtMarca.SelectionLength = 0;
            this.TxtMarca.SelectionStart = 0;
            this.TxtMarca.Size = new System.Drawing.Size(163, 23);
            this.TxtMarca.TabIndex = 1;
            this.TxtMarca.TabStop = false;
            this.TxtMarca.UseSystemPasswordChar = false;
            // 
            // FrmEdArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 413);
            this.Controls.Add(this.TxtMarca);
            this.Controls.Add(this.TxtCostoUnitario);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.TxtExistencia);
            this.Controls.Add(this.TxtUnidad);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Name = "FrmEdArticulos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.TxtID, 0);
            this.Controls.SetChildIndex(this.ChkEstado, 0);
            this.Controls.SetChildIndex(this.CmdGuardar, 0);
            this.Controls.SetChildIndex(this.CmdEliminar, 0);
            this.Controls.SetChildIndex(this.materialLabel2, 0);
            this.Controls.SetChildIndex(this.materialLabel3, 0);
            this.Controls.SetChildIndex(this.materialLabel4, 0);
            this.Controls.SetChildIndex(this.materialLabel5, 0);
            this.Controls.SetChildIndex(this.TxtDescripcion, 0);
            this.Controls.SetChildIndex(this.TxtUnidad, 0);
            this.Controls.SetChildIndex(this.TxtExistencia, 0);
            this.Controls.SetChildIndex(this.materialLabel6, 0);
            this.Controls.SetChildIndex(this.TxtCostoUnitario, 0);
            this.Controls.SetChildIndex(this.TxtMarca, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gestionComprasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionComprasDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDescripcion;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtUnidad;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtExistencia;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCostoUnitario;
        private GestionComprasDataSet gestionComprasDataSet;
        private System.Windows.Forms.BindingSource gestionComprasDataSetBindingSource;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtMarca;
    }
}