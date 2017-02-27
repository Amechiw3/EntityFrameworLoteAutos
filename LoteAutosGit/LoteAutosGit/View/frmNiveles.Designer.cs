namespace LoteAutosGit.View
{
    partial class frmNiveles
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvNiveles = new System.Windows.Forms.DataGridView();
            this.idnivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboPermisos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPermisoNegados = new System.Windows.Forms.DataGridView();
            this.idpermisonegadonivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnBloquear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNuevoNivel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisoNegados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(424, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 49);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Tag = "16";
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nivel";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(406, 26);
            this.textBox1.TabIndex = 2;
            // 
            // dgvNiveles
            // 
            this.dgvNiveles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNiveles.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvNiveles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNiveles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idnivel,
            this.nombre});
            this.dgvNiveles.Location = new System.Drawing.Point(12, 131);
            this.dgvNiveles.Name = "dgvNiveles";
            this.dgvNiveles.Size = new System.Drawing.Size(504, 139);
            this.dgvNiveles.TabIndex = 3;
            this.dgvNiveles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNiveles_CellDoubleClick);
            // 
            // idnivel
            // 
            this.idnivel.DataPropertyName = "idnivel";
            this.idnivel.HeaderText = "ID";
            this.idnivel.Name = "idnivel";
            this.idnivel.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nivel";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // cboPermisos
            // 
            this.cboPermisos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPermisos.FormattingEnabled = true;
            this.cboPermisos.Location = new System.Drawing.Point(12, 333);
            this.cboPermisos.Name = "cboPermisos";
            this.cboPermisos.Size = new System.Drawing.Size(504, 28);
            this.cboPermisos.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Permisos";
            // 
            // dgvPermisoNegados
            // 
            this.dgvPermisoNegados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPermisoNegados.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvPermisoNegados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisoNegados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpermisonegadonivel,
            this.permiso,
            this.descripcion,
            this.status});
            this.dgvPermisoNegados.Location = new System.Drawing.Point(12, 387);
            this.dgvPermisoNegados.Name = "dgvPermisoNegados";
            this.dgvPermisoNegados.Size = new System.Drawing.Size(504, 112);
            this.dgvPermisoNegados.TabIndex = 6;
            // 
            // idpermisonegadonivel
            // 
            this.idpermisonegadonivel.DataPropertyName = "id";
            this.idpermisonegadonivel.HeaderText = "ID";
            this.idpermisonegadonivel.Name = "idpermisonegadonivel";
            this.idpermisonegadonivel.ReadOnly = true;
            // 
            // permiso
            // 
            this.permiso.DataPropertyName = "permiso";
            this.permiso.HeaderText = "Permiso";
            this.permiso.Name = "permiso";
            this.permiso.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "estado";
            this.status.HeaderText = "Estado";
            this.status.Name = "status";
            // 
            // btnBloquear
            // 
            this.btnBloquear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBloquear.Location = new System.Drawing.Point(326, 505);
            this.btnBloquear.Name = "btnBloquear";
            this.btnBloquear.Size = new System.Drawing.Size(92, 45);
            this.btnBloquear.TabIndex = 7;
            this.btnBloquear.Tag = "16";
            this.btnBloquear.Text = "Denegar";
            this.btnBloquear.UseVisualStyleBackColor = true;
            this.btnBloquear.Click += new System.EventHandler(this.btnBloquear_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Permisos negados";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(12, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(406, 26);
            this.textBox2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descripcion";
            // 
            // btnNuevoNivel
            // 
            this.btnNuevoNivel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoNivel.Location = new System.Drawing.Point(424, 78);
            this.btnNuevoNivel.Name = "btnNuevoNivel";
            this.btnNuevoNivel.Size = new System.Drawing.Size(92, 35);
            this.btnNuevoNivel.TabIndex = 11;
            this.btnNuevoNivel.Tag = "16";
            this.btnNuevoNivel.Text = "Nuevo";
            this.btnNuevoNivel.UseVisualStyleBackColor = true;
            this.btnNuevoNivel.Click += new System.EventHandler(this.btnNuevoNivel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(424, 505);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(92, 45);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cancelar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmNiveles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(528, 562);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnNuevoNivel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBloquear);
            this.Controls.Add(this.dgvPermisoNegados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboPermisos);
            this.Controls.Add(this.dgvNiveles);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNiveles";
            this.Text = "Niveles";
            this.Load += new System.EventHandler(this.frmNiveles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisoNegados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvNiveles;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.ComboBox cboPermisos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPermisoNegados;
        private System.Windows.Forms.Button btnBloquear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpermisonegadonivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn permiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNuevoNivel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCerrar;
    }
}