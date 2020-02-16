namespace SistemaCompras.Edit
{
    partial class FrmEdOrdenes
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
            this.TxtIDSolicitud = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtFecha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtArticulo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtCantidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(163, 83);
            // 
            // CmdEliminar
            // 
            this.CmdEliminar.FlatAppearance.BorderSize = 0;
            this.CmdEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CmdEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CmdEliminar.Location = new System.Drawing.Point(201, 346);
            this.CmdEliminar.Click += new System.EventHandler(this.CmdEliminar_Click);
            // 
            // ChkEstado
            // 
            this.ChkEstado.Location = new System.Drawing.Point(16, 283);
            // 
            // CmdGuardar
            // 
            this.CmdGuardar.FlatAppearance.BorderSize = 0;
            this.CmdGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CmdGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CmdGuardar.Location = new System.Drawing.Point(111, 346);
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
            this.materialLabel2.Size = new System.Drawing.Size(86, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "ID Solicitud";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 162);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(92, 19);
            this.materialLabel3.TabIndex = 17;
            this.materialLabel3.Text = "Fecha Orden";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 202);
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
            this.materialLabel5.Location = new System.Drawing.Point(12, 240);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(68, 19);
            this.materialLabel5.TabIndex = 19;
            this.materialLabel5.Text = "Cantidad";
            // 
            // TxtIDSolicitud
            // 
            this.TxtIDSolicitud.Depth = 0;
            this.TxtIDSolicitud.Hint = "";
            this.TxtIDSolicitud.Location = new System.Drawing.Point(163, 123);
            this.TxtIDSolicitud.MaxLength = 32767;
            this.TxtIDSolicitud.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtIDSolicitud.Name = "TxtIDSolicitud";
            this.TxtIDSolicitud.PasswordChar = '\0';
            this.TxtIDSolicitud.SelectedText = "";
            this.TxtIDSolicitud.SelectionLength = 0;
            this.TxtIDSolicitud.SelectionStart = 0;
            this.TxtIDSolicitud.Size = new System.Drawing.Size(163, 23);
            this.TxtIDSolicitud.TabIndex = 0;
            this.TxtIDSolicitud.TabStop = false;
            this.TxtIDSolicitud.UseSystemPasswordChar = false;
            // 
            // TxtFecha
            // 
            this.TxtFecha.Depth = 0;
            this.TxtFecha.Hint = "";
            this.TxtFecha.Location = new System.Drawing.Point(163, 162);
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
            this.TxtArticulo.Location = new System.Drawing.Point(163, 202);
            this.TxtArticulo.MaxLength = 32767;
            this.TxtArticulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtArticulo.Name = "TxtArticulo";
            this.TxtArticulo.PasswordChar = '\0';
            this.TxtArticulo.SelectedText = "";
            this.TxtArticulo.SelectionLength = 0;
            this.TxtArticulo.SelectionStart = 0;
            this.TxtArticulo.Size = new System.Drawing.Size(163, 23);
            this.TxtArticulo.TabIndex = 2;
            this.TxtArticulo.TabStop = false;
            this.TxtArticulo.UseSystemPasswordChar = false;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Depth = 0;
            this.TxtCantidad.Hint = "";
            this.TxtCantidad.Location = new System.Drawing.Point(163, 240);
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
            // FrmEdOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 388);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtArticulo);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.TxtIDSolicitud);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Name = "FrmEdOrdenes";
            this.Text = "FrmEdOrdenes";
            this.Load += new System.EventHandler(this.FrmEdOrdenes_Load);
            this.Controls.SetChildIndex(this.TxtID, 0);
            this.Controls.SetChildIndex(this.ChkEstado, 0);
            this.Controls.SetChildIndex(this.CmdGuardar, 0);
            this.Controls.SetChildIndex(this.CmdEliminar, 0);
            this.Controls.SetChildIndex(this.materialLabel2, 0);
            this.Controls.SetChildIndex(this.materialLabel3, 0);
            this.Controls.SetChildIndex(this.materialLabel4, 0);
            this.Controls.SetChildIndex(this.materialLabel5, 0);
            this.Controls.SetChildIndex(this.TxtIDSolicitud, 0);
            this.Controls.SetChildIndex(this.TxtFecha, 0);
            this.Controls.SetChildIndex(this.TxtArticulo, 0);
            this.Controls.SetChildIndex(this.TxtCantidad, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtIDSolicitud;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtFecha;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtArticulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCantidad;
    }
}