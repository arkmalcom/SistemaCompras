namespace SistemaCompras.Edit
{
    partial class FrmEdEmpleados
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
            this.TxtCedula = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDepartamento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // CmdEliminar
            // 
            this.CmdEliminar.AutoSize = true;
            this.CmdEliminar.FlatAppearance.BorderSize = 0;
            this.CmdEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CmdEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CmdEliminar.Click += new System.EventHandler(this.CmdEliminar_Click);
            // 
            // ChkEstado
            // 
            this.ChkEstado.TabIndex = 3;
            // 
            // CmdGuardar
            // 
            this.CmdGuardar.FlatAppearance.BorderSize = 0;
            this.CmdGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CmdGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CmdGuardar.Click += new System.EventHandler(this.CmdGuardar_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 130);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(55, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Cedula";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 180);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(63, 19);
            this.materialLabel3.TabIndex = 17;
            this.materialLabel3.Text = "Nombre";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 223);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(104, 19);
            this.materialLabel4.TabIndex = 18;
            this.materialLabel4.Text = "Departamento";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Depth = 0;
            this.TxtCedula.Hint = "";
            this.TxtCedula.Location = new System.Drawing.Point(126, 130);
            this.TxtCedula.MaxLength = 32767;
            this.TxtCedula.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.PasswordChar = '\0';
            this.TxtCedula.SelectedText = "";
            this.TxtCedula.SelectionLength = 0;
            this.TxtCedula.SelectionStart = 0;
            this.TxtCedula.Size = new System.Drawing.Size(163, 23);
            this.TxtCedula.TabIndex = 0;
            this.TxtCedula.TabStop = false;
            this.TxtCedula.UseSystemPasswordChar = false;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Depth = 0;
            this.TxtNombre.Hint = "";
            this.TxtNombre.Location = new System.Drawing.Point(126, 180);
            this.TxtNombre.MaxLength = 32767;
            this.TxtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.PasswordChar = '\0';
            this.TxtNombre.SelectedText = "";
            this.TxtNombre.SelectionLength = 0;
            this.TxtNombre.SelectionStart = 0;
            this.TxtNombre.Size = new System.Drawing.Size(163, 23);
            this.TxtNombre.TabIndex = 1;
            this.TxtNombre.TabStop = false;
            this.TxtNombre.UseSystemPasswordChar = false;
            // 
            // TxtDepartamento
            // 
            this.TxtDepartamento.Depth = 0;
            this.TxtDepartamento.Hint = "";
            this.TxtDepartamento.Location = new System.Drawing.Point(126, 223);
            this.TxtDepartamento.MaxLength = 32767;
            this.TxtDepartamento.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDepartamento.Name = "TxtDepartamento";
            this.TxtDepartamento.PasswordChar = '\0';
            this.TxtDepartamento.SelectedText = "";
            this.TxtDepartamento.SelectionLength = 0;
            this.TxtDepartamento.SelectionStart = 0;
            this.TxtDepartamento.Size = new System.Drawing.Size(163, 23);
            this.TxtDepartamento.TabIndex = 2;
            this.TxtDepartamento.TabStop = false;
            this.TxtDepartamento.UseSystemPasswordChar = false;
            // 
            // FrmEdEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 389);
            this.Controls.Add(this.TxtDepartamento);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Name = "FrmEdEmpleados";
            this.Text = "FrmEdEmpleados";
            this.Load += new System.EventHandler(this.FrmEdEmpleados_Load);
            this.Controls.SetChildIndex(this.TxtID, 0);
            this.Controls.SetChildIndex(this.ChkEstado, 0);
            this.Controls.SetChildIndex(this.CmdGuardar, 0);
            this.Controls.SetChildIndex(this.CmdEliminar, 0);
            this.Controls.SetChildIndex(this.materialLabel2, 0);
            this.Controls.SetChildIndex(this.materialLabel3, 0);
            this.Controls.SetChildIndex(this.materialLabel4, 0);
            this.Controls.SetChildIndex(this.TxtCedula, 0);
            this.Controls.SetChildIndex(this.TxtNombre, 0);
            this.Controls.SetChildIndex(this.TxtDepartamento, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCedula;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDepartamento;
    }
}