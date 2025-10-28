namespace SistemaNotas.Formularios
{
    partial class frmRegistrarNotaCmd
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.txtLaboratorio = new System.Windows.Forms.TextBox();
            this.lblParcial = new System.Windows.Forms.Label();
            this.txtParcial = new System.Windows.Forms.TextBox();
            this.lblAsistencia = new System.Windows.Forms.Label();
            this.txtAsistencia = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(132, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(33, 91);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(132, 91);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.Location = new System.Drawing.Point(36, 136);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(63, 13);
            this.lblLaboratorio.TabIndex = 4;
            this.lblLaboratorio.Text = "Laboratorio:";
            // 
            // txtLaboratorio
            // 
            this.txtLaboratorio.Location = new System.Drawing.Point(132, 136);
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.Size = new System.Drawing.Size(100, 20);
            this.txtLaboratorio.TabIndex = 5;
            // 
            // lblParcial
            // 
            this.lblParcial.AutoSize = true;
            this.lblParcial.Location = new System.Drawing.Point(36, 185);
            this.lblParcial.Name = "lblParcial";
            this.lblParcial.Size = new System.Drawing.Size(42, 13);
            this.lblParcial.TabIndex = 6;
            this.lblParcial.Text = "Parcial:";
            // 
            // txtParcial
            // 
            this.txtParcial.Location = new System.Drawing.Point(132, 182);
            this.txtParcial.Name = "txtParcial";
            this.txtParcial.Size = new System.Drawing.Size(100, 20);
            this.txtParcial.TabIndex = 7;
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.AutoSize = true;
            this.lblAsistencia.Location = new System.Drawing.Point(39, 231);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Size = new System.Drawing.Size(58, 13);
            this.lblAsistencia.TabIndex = 8;
            this.lblAsistencia.Text = "Asistencia:";
            // 
            // txtAsistencia
            // 
            this.txtAsistencia.Location = new System.Drawing.Point(132, 223);
            this.txtAsistencia.Name = "txtAsistencia";
            this.txtAsistencia.Size = new System.Drawing.Size(100, 20);
            this.txtAsistencia.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(39, 279);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(193, 42);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.Location = new System.Drawing.Point(281, 34);
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.Size = new System.Drawing.Size(458, 287);
            this.dgvRegistro.TabIndex = 11;
            this.dgvRegistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistro_CellContentClick);
            // 
            // frmRegistrarNotaCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRegistro);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtAsistencia);
            this.Controls.Add(this.lblAsistencia);
            this.Controls.Add(this.txtParcial);
            this.Controls.Add(this.lblParcial);
            this.Controls.Add(this.txtLaboratorio);
            this.Controls.Add(this.lblLaboratorio);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmRegistrarNotaCmd";
            this.Text = "frmRegistrarNotaCmd";
            this.Load += new System.EventHandler(this.frmRegistrarNotaCmd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblLaboratorio;
        private System.Windows.Forms.TextBox txtLaboratorio;
        private System.Windows.Forms.Label lblParcial;
        private System.Windows.Forms.TextBox txtParcial;
        private System.Windows.Forms.Label lblAsistencia;
        private System.Windows.Forms.TextBox txtAsistencia;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvRegistro;
    }
}