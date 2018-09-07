namespace AnalizeNotebook
{
    partial class FormNuevaNota
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
            this.ln_Nombre = new System.Windows.Forms.Label();
            this.tb_NuevaNota = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgv_clm_Clases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_clm_Accesibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_clm_Modificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_clm_Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_clm_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_Libreta = new System.Windows.Forms.Label();
            this.cbx_Libreta = new System.Windows.Forms.ComboBox();
            this.lb_Etiqueta = new System.Windows.Forms.Label();
            this.cbx_Etiqueta = new System.Windows.Forms.ComboBox();
            this.lb_Cerrar = new System.Windows.Forms.Label();
            this.lb_Maximizar = new System.Windows.Forms.Label();
            this.lb_Minimizar = new System.Windows.Forms.Label();
            this.lb_Title = new System.Windows.Forms.Label();
            this.pb_ApplicationIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ApplicationIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // ln_Nombre
            // 
            this.ln_Nombre.AutoSize = true;
            this.ln_Nombre.Location = new System.Drawing.Point(8, 44);
            this.ln_Nombre.Name = "ln_Nombre";
            this.ln_Nombre.Size = new System.Drawing.Size(47, 13);
            this.ln_Nombre.TabIndex = 0;
            this.ln_Nombre.Text = "Nombre:";
            // 
            // tb_NuevaNota
            // 
            this.tb_NuevaNota.Location = new System.Drawing.Point(61, 41);
            this.tb_NuevaNota.Name = "tb_NuevaNota";
            this.tb_NuevaNota.Size = new System.Drawing.Size(143, 20);
            this.tb_NuevaNota.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_clm_Clases,
            this.dgv_clm_Accesibilidad,
            this.dgv_clm_Modificador,
            this.dgv_clm_Tipo,
            this.dgv_clm_Nombre});
            this.dataGridView1.Location = new System.Drawing.Point(5, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(576, 354);
            this.dataGridView1.TabIndex = 2;
            // 
            // dgv_clm_Clases
            // 
            this.dgv_clm_Clases.HeaderText = "Clase / Interfaz";
            this.dgv_clm_Clases.Name = "dgv_clm_Clases";
            this.dgv_clm_Clases.Width = 110;
            // 
            // dgv_clm_Accesibilidad
            // 
            this.dgv_clm_Accesibilidad.HeaderText = "Accesibilidad";
            this.dgv_clm_Accesibilidad.Name = "dgv_clm_Accesibilidad";
            this.dgv_clm_Accesibilidad.Width = 80;
            // 
            // dgv_clm_Modificador
            // 
            this.dgv_clm_Modificador.HeaderText = "Modificador";
            this.dgv_clm_Modificador.Name = "dgv_clm_Modificador";
            this.dgv_clm_Modificador.Width = 80;
            // 
            // dgv_clm_Tipo
            // 
            this.dgv_clm_Tipo.HeaderText = "Tipo";
            this.dgv_clm_Tipo.Name = "dgv_clm_Tipo";
            // 
            // dgv_clm_Nombre
            // 
            this.dgv_clm_Nombre.HeaderText = "Nombre";
            this.dgv_clm_Nombre.Name = "dgv_clm_Nombre";
            this.dgv_clm_Nombre.Width = 160;
            // 
            // lb_Libreta
            // 
            this.lb_Libreta.AutoSize = true;
            this.lb_Libreta.Location = new System.Drawing.Point(210, 44);
            this.lb_Libreta.Name = "lb_Libreta";
            this.lb_Libreta.Size = new System.Drawing.Size(42, 13);
            this.lb_Libreta.TabIndex = 3;
            this.lb_Libreta.Text = "Libreta:";
            // 
            // cbx_Libreta
            // 
            this.cbx_Libreta.FormattingEnabled = true;
            this.cbx_Libreta.Location = new System.Drawing.Point(258, 41);
            this.cbx_Libreta.Name = "cbx_Libreta";
            this.cbx_Libreta.Size = new System.Drawing.Size(121, 21);
            this.cbx_Libreta.TabIndex = 4;
            // 
            // lb_Etiqueta
            // 
            this.lb_Etiqueta.AutoSize = true;
            this.lb_Etiqueta.Location = new System.Drawing.Point(385, 44);
            this.lb_Etiqueta.Name = "lb_Etiqueta";
            this.lb_Etiqueta.Size = new System.Drawing.Size(49, 13);
            this.lb_Etiqueta.TabIndex = 5;
            this.lb_Etiqueta.Text = "Etiqueta:";
            // 
            // cbx_Etiqueta
            // 
            this.cbx_Etiqueta.FormattingEnabled = true;
            this.cbx_Etiqueta.Location = new System.Drawing.Point(439, 41);
            this.cbx_Etiqueta.Name = "cbx_Etiqueta";
            this.cbx_Etiqueta.Size = new System.Drawing.Size(121, 21);
            this.cbx_Etiqueta.TabIndex = 6;
            // 
            // lb_Cerrar
            // 
            this.lb_Cerrar.AutoSize = true;
            this.lb_Cerrar.Location = new System.Drawing.Point(562, 15);
            this.lb_Cerrar.Name = "lb_Cerrar";
            this.lb_Cerrar.Size = new System.Drawing.Size(14, 13);
            this.lb_Cerrar.TabIndex = 12;
            this.lb_Cerrar.Text = "X";
            this.lb_Cerrar.Click += new System.EventHandler(this.lb_Cerrar_Click);
            // 
            // lb_Maximizar
            // 
            this.lb_Maximizar.AutoSize = true;
            this.lb_Maximizar.Enabled = false;
            this.lb_Maximizar.Image = global::AnalizeNotebook.Properties.Resources.maximizar;
            this.lb_Maximizar.Location = new System.Drawing.Point(541, 15);
            this.lb_Maximizar.Name = "lb_Maximizar";
            this.lb_Maximizar.Size = new System.Drawing.Size(13, 13);
            this.lb_Maximizar.TabIndex = 11;
            this.lb_Maximizar.Text = "  ";
            this.lb_Maximizar.Click += new System.EventHandler(this.lb_Maximizar_Click);
            // 
            // lb_Minimizar
            // 
            this.lb_Minimizar.AutoSize = true;
            this.lb_Minimizar.Location = new System.Drawing.Point(520, 15);
            this.lb_Minimizar.Name = "lb_Minimizar";
            this.lb_Minimizar.Size = new System.Drawing.Size(13, 13);
            this.lb_Minimizar.TabIndex = 10;
            this.lb_Minimizar.Text = "_";
            this.lb_Minimizar.Click += new System.EventHandler(this.lb_Minimizar_Click);
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lb_Title.Location = new System.Drawing.Point(37, 15);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(114, 15);
            this.lb_Title.TabIndex = 9;
            this.lb_Title.Text = "AnalizeNotebook++";
            // 
            // pb_ApplicationIcon
            // 
            this.pb_ApplicationIcon.Location = new System.Drawing.Point(12, 13);
            this.pb_ApplicationIcon.Name = "pb_ApplicationIcon";
            this.pb_ApplicationIcon.Size = new System.Drawing.Size(19, 20);
            this.pb_ApplicationIcon.TabIndex = 8;
            this.pb_ApplicationIcon.TabStop = false;
            // 
            // FormNuevaNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 425);
            this.Controls.Add(this.lb_Cerrar);
            this.Controls.Add(this.lb_Maximizar);
            this.Controls.Add(this.lb_Minimizar);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.pb_ApplicationIcon);
            this.Controls.Add(this.cbx_Etiqueta);
            this.Controls.Add(this.lb_Etiqueta);
            this.Controls.Add(this.cbx_Libreta);
            this.Controls.Add(this.lb_Libreta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_NuevaNota);
            this.Controls.Add(this.ln_Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNuevaNota";
            this.Text = "Nueva nota";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormNuevaNota_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ApplicationIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ln_Nombre;
        private System.Windows.Forms.TextBox tb_NuevaNota;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_Libreta;
        private System.Windows.Forms.ComboBox cbx_Libreta;
        private System.Windows.Forms.Label lb_Etiqueta;
        private System.Windows.Forms.ComboBox cbx_Etiqueta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_clm_Clases;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_clm_Accesibilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_clm_Modificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_clm_Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_clm_Nombre;
        private System.Windows.Forms.Label lb_Cerrar;
        private System.Windows.Forms.Label lb_Maximizar;
        private System.Windows.Forms.Label lb_Minimizar;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.PictureBox pb_ApplicationIcon;
    }
}