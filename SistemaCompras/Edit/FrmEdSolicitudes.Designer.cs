namespace SistemaCompras.Edit
{
    partial class FrmEdSolicitudes
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtFecha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtArticulo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtCantidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtUnidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(223, 83);
            // 
            // CmdEliminar
            // 
            this.CmdEliminar.FlatAppearance.BorderSize = 0;
            this.CmdEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CmdEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CmdEliminar.Location = new System.Drawing.Point(223, 398);
            this.CmdEliminar.Click += new System.EventHandler(this.CmdEliminar_Click);
            // 
            // ChkEstado
            // 
            this.ChkEstado.Location = new System.Drawing.Point(16, 345);
            this.ChkEstado.TabIndex = 5;
            // 
            // CmdGuardar
            // 
            this.CmdGuardar.FlatAppearance.BorderSize = 0;
            this.CmdGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CmdGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CmdGuardar.Location = new System.Drawing.Point(132, 398);
            this.CmdGuardar.Click += new System.EventHandler(this.CmdGuardar_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 123);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(152, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Empleado Solicitante";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 164);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(112, 19);
            this.materialLabel3.TabIndex = 17;
            this.materialLabel3.Text = "Fecha Solicitud";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 207);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(62, 19);
            this.materialLabel4.TabIndex = 18;
            this.materialLabel4.Text = "Articulo";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 254);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(68, 19);
            this.materialLabel5.TabIndex = 19;
            this.materialLabel5.Text = "Cantidad";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel6.Location = new System.Drawing.Point(12, 298);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(128, 19);
            this.materialLabel6.TabIndex = 20;
            this.materialLabel6.Text = "Unidad de Medida";
            // 
            // TxtEmpleado
            // 
            this.TxtEmpleado.Depth = 0;
            this.TxtEmpleado.Hint = "";
            this.TxtEmpleado.Location = new System.Drawing.Point(223, 123);
            this.TxtEmpleado.MaxLength = 32767;
            this.TxtEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtEmpleado.Name = "TxtEmpleado";
            this.TxtEmpleado.PasswordChar = '\0';
            this.TxtEmpleado.SelectedText = "";
            this.TxtEmpleado.SelectionLength = 0;
            this.TxtEmpleado.SelectionStart = 0;
            this.TxtEmpleado.Size = new System.Drawing.Size(163, 23);
            this.TxtEmpleado.TabIndex = 0;
            this.TxtEmpleado.TabStop = false;
            this.TxtEmpleado.UseSystemPasswordChar = false;
            // 
            // TxtFecha
            // 
            this.TxtFecha.Depth = 0;
            this.TxtFecha.Hint = "";
            this.TxtFecha.Location = new System.Drawing.Point(223, 164);
            this.TxtFecha.MaxLength = 32767;
            this.TxtFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.PasswordChar = '\0';
            this.TxtFecha.SelectedText = "";
            this.TxtFecha.SelectionLength = 0;
            this.TxtFecha.SelectionStart = 0;
            this.TxtFecha.Size = new System.Drawing.Size(163, 23);
            this.TxtFecha.TabIndex = 1;
            this.TxtFecha.TabStop = false;
            this.TxtFecha.UseSystemPasswordChar = false;
            // 
            // TxtArticulo
            // 
            this.TxtArticulo.Depth = 0;
            this.TxtArticulo.Hint = "";
            this.TxtArticulo.Location = new System.Drawing.Point(223, 207);
            this.TxtArticulo.MaxLength = 32767;
            this.TxtArticulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtArticulo.Name = "TxtArticulo";
            this.TxtArticulo.PasswordChar = '\0';
            this.TxtArticulo.SelectedText = "";
            this.TxtArticulo.SelectionLength = 0;
            this.TxtArticulo.SelectionStart = 0;
            this.TxtArticulo.Size = new System.Drawing.Size(163, 23);
            this.TxtArticulo.TabIndex = 22;
            this.TxtArticulo.TabStop = false;
            this.TxtArticulo.UseSystemPasswordChar = false;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Depth = 0;
            this.TxtCantidad.Hint = "";
            this.TxtCantidad.Location = new System.Drawing.Point(223, 254);
            this.TxtCantidad.MaxLength = 32767;
            this.TxtCantidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.PasswordChar = '\0';
            this.TxtCantidad.SelectedText = "";
            this.TxtCantidad.SelectionLength = 0;
            this.TxtCantidad.SelectionStart = 0;
            this.TxtCantidad.Size = new System.Drawing.Size(163, 23);
            this.TxtCantidad.TabIndex = 3;
            this.TxtCantidad.TabStop = false;
            this.TxtCantidad.UseSystemPasswordChar = false;
            // 
            // TxtUnidad
            // 
            this.TxtUnidad.Depth = 0;
            this.TxtUnidad.Hint = "";
            this.TxtUnidad.Location = new System.Drawing.Point(223, 298);
            this.TxtUnidad.MaxLength = 32767;
            this.TxtUnidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtUnidad.Name = "TxtUnidad";
            this.TxtUnidad.PasswordChar = '\0';
            this.TxtUnidad.SelectedText = "";
            this.TxtUnidad.SelectionLength = 0;
            this.TxtUnidad.SelectionStart = 0;
            this.TxtUnidad.Size = new System.Drawing.Size(163, 23);
            this.TxtUnidad.TabIndex = 4;
            this.TxtUnidad.TabStop = false;
            this.TxtUnidad.UseSystemPasswordChar = false;
            // 
            // FrmEdSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 442);
            this.Controls.Add(this.TxtUnidad);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtArticulo);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.TxtEmpleado);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Name = "FrmEdSolicitudes";
            this.Text = "FrmEdSolicitudes";
            this.Load += new System.EventHandler(this.FrmEdSolicitudes_Load);
            this.Controls.SetChildIndex(this.TxtID, 0);
            this.Controls.SetChildIndex(this.ChkEstado, 0);
            this.Controls.SetChildIndex(this.CmdGuardar, 0);
            this.Controls.SetChildIndex(this.CmdEliminar, 0);
            this.Controls.SetChildIndex(this.materialLabel2, 0);
            this.Controls.SetChildIndex(this.materialLabel3, 0);
            this.Controls.SetChildIndex(this.materialLabel4, 0);
            this.Controls.SetChildIndex(this.materialLabel5, 0);
            this.Controls.SetChildIndex(this.materialLabel6, 0);
            this.Controls.SetChildIndex(this.TxtEmpleado, 0);
            this.Controls.SetChildIndex(this.TxtFecha, 0);
            this.Controls.SetChildIndex(this.TxtArticulo, 0);
            this.Controls.SetChildIndex(this.TxtCantidad, 0);
            this.Controls.SetChildIndex(this.TxtUnidad, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtFecha;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtArticulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCantidad;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtUnidad;
    }
}