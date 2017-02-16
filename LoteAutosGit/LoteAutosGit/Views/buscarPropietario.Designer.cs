namespace LoteAutosGit.Views
{
    partial class buscarPropietario
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
            this.dgvDatosPropietario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnNuevoPropietario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.idpropietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotografia = new System.Windows.Forms.DataGridViewImageColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPropietario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatosPropietario
            // 
            this.dgvDatosPropietario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatosPropietario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosPropietario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpropietario,
            this.fotografia,
            this.nombre,
            this.telefono,
            this.correo});
            this.dgvDatosPropietario.Location = new System.Drawing.Point(12, 44);
            this.dgvDatosPropietario.Name = "dgvDatosPropietario";
            this.dgvDatosPropietario.Size = new System.Drawing.Size(730, 310);
            this.dgvDatosPropietario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(77, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(299, 26);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnNuevoPropietario
            // 
            this.btnNuevoPropietario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoPropietario.Location = new System.Drawing.Point(12, 407);
            this.btnNuevoPropietario.Name = "btnNuevoPropietario";
            this.btnNuevoPropietario.Size = new System.Drawing.Size(144, 34);
            this.btnNuevoPropietario.TabIndex = 3;
            this.btnNuevoPropietario.Text = "Nuevo Propietario";
            this.btnNuevoPropietario.UseVisualStyleBackColor = true;
            this.btnNuevoPropietario.Click += new System.EventHandler(this.btnNuevoPropietario_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Registros:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(162, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // idpropietario
            // 
            this.idpropietario.DataPropertyName = "idpropietario";
            this.idpropietario.HeaderText = "ID";
            this.idpropietario.Name = "idpropietario";
            this.idpropietario.ReadOnly = true;
            this.idpropietario.Visible = false;
            // 
            // fotografia
            // 
            this.fotografia.DataPropertyName = "fotografia";
            this.fotografia.HeaderText = "fotografia";
            this.fotografia.Name = "fotografia";
            this.fotografia.ReadOnly = true;
            this.fotografia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "nombre";
            this.nombre.MinimumWidth = 150;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "telefono";
            this.telefono.MinimumWidth = 100;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 150;
            // 
            // correo
            // 
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "correo";
            this.correo.MinimumWidth = 150;
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            this.correo.Width = 230;
            // 
            // buscarPropietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 453);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNuevoPropietario);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDatosPropietario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "buscarPropietario";
            this.Text = "Buscar Propietarios";
            this.Load += new System.EventHandler(this.buscarPropietario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPropietario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosPropietario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnNuevoPropietario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpropietario;
        private System.Windows.Forms.DataGridViewImageColumn fotografia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
    }
}