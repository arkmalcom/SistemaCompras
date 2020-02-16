namespace SistemaCompras.Edit
{
    partial class FrmEdMarcas
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
            this.TxtDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // CmdEliminar
            // 
            this.CmdEliminar.FlatAppearance.BorderSize = 0;
            this.CmdEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CmdEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CmdEliminar.Location = new System.Drawing.Point(186, 233);
            this.CmdEliminar.Click += new System.EventHandler(this.CmdEliminar_Click);
            // 
            // ChkEstado
            // 
            this.ChkEstado.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChkEstado.Location = new System.Drawing.Point(16, 191);
            // 
            // CmdGuardar
            // 
            this.CmdGuardar.FlatAppearance.BorderSize = 0;
            this.CmdGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CmdGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CmdGuardar.Location = new System.Drawing.Point(97, 233);
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
            this.materialLabel2.Size = new System.Drawing.Size(89, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Descripcion";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Depth = 0;
            this.TxtDescripcion.Hint = "";
            this.TxtDescripcion.Location = new System.Drawing.Point(126, 130);
            this.TxtDescripcion.MaxLength = 32767;
            this.TxtDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.PasswordChar = '\0';
            this.TxtDescripcion.SelectedText = "";
            this.TxtDescripcion.SelectionLength = 0;
            this.TxtDescripcion.SelectionStart = 0;
            this.TxtDescripcion.Size = new System.Drawing.Size(163, 23);
            this.TxtDescripcion.TabIndex = 17;
            this.TxtDescripcion.TabStop = false;
            this.TxtDescripcion.UseSystemPasswordChar = false;
            // 
            // FrmEdMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 291);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.materialLabel2);
            this.Name = "FrmEdMarcas";
            this.Text = "FrmEdMarcas";
            this.Load += new System.EventHandler(this.FrmEdMarcas_Load);
            this.Controls.SetChildIndex(this.TxtID, 0);
            this.Controls.SetChildIndex(this.ChkEstado, 0);
            this.Controls.SetChildIndex(this.CmdGuardar, 0);
            this.Controls.SetChildIndex(this.CmdEliminar, 0);
            this.Controls.SetChildIndex(this.materialLabel2, 0);
            this.Controls.SetChildIndex(this.TxtDescripcion, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDescripcion;
    }
}