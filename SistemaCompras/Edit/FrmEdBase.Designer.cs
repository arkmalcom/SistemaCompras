namespace SistemaCompras.Edit
{
    partial class FrmEdBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdBase));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ChkEstado = new MaterialSkin.Controls.MaterialCheckBox();
            this.CmdGuardar = new System.Windows.Forms.Button();
            this.CmdEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 83);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(23, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "ID";
            // 
            // TxtID
            // 
            this.TxtID.Depth = 0;
            this.TxtID.Enabled = false;
            this.TxtID.Hint = "";
            this.TxtID.Location = new System.Drawing.Point(126, 83);
            this.TxtID.MaxLength = 32767;
            this.TxtID.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtID.Name = "TxtID";
            this.TxtID.PasswordChar = '\0';
            this.TxtID.SelectedText = "";
            this.TxtID.SelectionLength = 0;
            this.TxtID.SelectionStart = 0;
            this.TxtID.Size = new System.Drawing.Size(163, 23);
            this.TxtID.TabIndex = 5;
            this.TxtID.TabStop = false;
            this.TxtID.Text = "materialSingleLineTextField1";
            this.TxtID.UseSystemPasswordChar = false;
            // 
            // ChkEstado
            // 
            this.ChkEstado.AutoSize = true;
            this.ChkEstado.Depth = 0;
            this.ChkEstado.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChkEstado.Location = new System.Drawing.Point(16, 266);
            this.ChkEstado.Margin = new System.Windows.Forms.Padding(0);
            this.ChkEstado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkEstado.Name = "ChkEstado";
            this.ChkEstado.Ripple = true;
            this.ChkEstado.Size = new System.Drawing.Size(72, 30);
            this.ChkEstado.TabIndex = 9;
            this.ChkEstado.Text = "Estado";
            this.ChkEstado.UseVisualStyleBackColor = true;
            this.ChkEstado.CheckedChanged += new System.EventHandler(this.ChkEstado_CheckedChanged);
            // 
            // CmdGuardar
            // 
            this.CmdGuardar.BackColor = System.Drawing.Color.Transparent;
            this.CmdGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CmdGuardar.BackgroundImage")));
            this.CmdGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CmdGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdGuardar.FlatAppearance.BorderSize = 0;
            this.CmdGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CmdGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdGuardar.ForeColor = System.Drawing.Color.Transparent;
            this.CmdGuardar.Location = new System.Drawing.Point(97, 317);
            this.CmdGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.CmdGuardar.Name = "CmdGuardar";
            this.CmdGuardar.Size = new System.Drawing.Size(32, 32);
            this.CmdGuardar.TabIndex = 14;
            this.CmdGuardar.UseVisualStyleBackColor = false;
            // 
            // CmdEliminar
            // 
            this.CmdEliminar.BackColor = System.Drawing.Color.Transparent;
            this.CmdEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CmdEliminar.BackgroundImage")));
            this.CmdEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CmdEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdEliminar.FlatAppearance.BorderSize = 0;
            this.CmdEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CmdEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CmdEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdEliminar.ForeColor = System.Drawing.Color.Transparent;
            this.CmdEliminar.Location = new System.Drawing.Point(189, 317);
            this.CmdEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.CmdEliminar.Name = "CmdEliminar";
            this.CmdEliminar.Size = new System.Drawing.Size(32, 32);
            this.CmdEliminar.TabIndex = 15;
            this.CmdEliminar.UseVisualStyleBackColor = false;
            // 
            // FrmEdBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(333, 358);
            this.Controls.Add(this.CmdEliminar);
            this.Controls.Add(this.CmdGuardar);
            this.Controls.Add(this.ChkEstado);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.materialLabel1);
            this.Name = "FrmEdBase";
            this.Text = "Empleados - Editar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialSingleLineTextField TxtID;
        public System.Windows.Forms.Button CmdEliminar;
        public MaterialSkin.Controls.MaterialCheckBox ChkEstado;
        public System.Windows.Forms.Button CmdGuardar;
    }
}