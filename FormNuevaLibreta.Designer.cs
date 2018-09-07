namespace AnalizeNotebook
{
    partial class FormNuevaLibreta
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
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.lb_CrearDentroDe = new System.Windows.Forms.Label();
            this.cbx_CrearDentroDe = new System.Windows.Forms.ComboBox();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.lb_Title = new System.Windows.Forms.Label();
            this.pb_ApplicationIcon = new System.Windows.Forms.PictureBox();
            this.lb_Cerrar = new System.Windows.Forms.Label();
            this.lb_Maximizar = new System.Windows.Forms.Label();
            this.lb_Minimizar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ApplicationIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Location = new System.Drawing.Point(12, 47);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(47, 13);
            this.lb_Nombre.TabIndex = 0;
            this.lb_Nombre.Text = "Nombre:";
            // 
            // lb_CrearDentroDe
            // 
            this.lb_CrearDentroDe.AutoSize = true;
            this.lb_CrearDentroDe.Location = new System.Drawing.Point(12, 74);
            this.lb_CrearDentroDe.Name = "lb_CrearDentroDe";
            this.lb_CrearDentroDe.Size = new System.Drawing.Size(83, 13);
            this.lb_CrearDentroDe.TabIndex = 1;
            this.lb_CrearDentroDe.Text = "Crear dentro de:";
            // 
            // cbx_CrearDentroDe
            // 
            this.cbx_CrearDentroDe.FormattingEnabled = true;
            this.cbx_CrearDentroDe.Location = new System.Drawing.Point(107, 71);
            this.cbx_CrearDentroDe.Name = "cbx_CrearDentroDe";
            this.cbx_CrearDentroDe.Size = new System.Drawing.Size(121, 21);
            this.cbx_CrearDentroDe.TabIndex = 3;
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Location = new System.Drawing.Point(107, 44);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(121, 20);
            this.tb_Nombre.TabIndex = 4;
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lb_Title.Location = new System.Drawing.Point(37, 15);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(114, 15);
            this.lb_Title.TabIndex = 11;
            this.lb_Title.Text = "AnalizeNotebook++";
            // 
            // pb_ApplicationIcon
            // 
            this.pb_ApplicationIcon.Location = new System.Drawing.Point(12, 13);
            this.pb_ApplicationIcon.Name = "pb_ApplicationIcon";
            this.pb_ApplicationIcon.Size = new System.Drawing.Size(19, 20);
            this.pb_ApplicationIcon.TabIndex = 10;
            this.pb_ApplicationIcon.TabStop = false;
            // 
            // lb_Cerrar
            // 
            this.lb_Cerrar.AutoSize = true;
            this.lb_Cerrar.Location = new System.Drawing.Point(225, 15);
            this.lb_Cerrar.Name = "lb_Cerrar";
            this.lb_Cerrar.Size = new System.Drawing.Size(14, 13);
            this.lb_Cerrar.TabIndex = 15;
            this.lb_Cerrar.Text = "X";
            this.lb_Cerrar.Click += new System.EventHandler(this.lb_Cerrar_Click);
            // 
            // lb_Maximizar
            // 
            this.lb_Maximizar.AutoSize = true;
            this.lb_Maximizar.Enabled = false;
            this.lb_Maximizar.Image = global::AnalizeNotebook.Properties.Resources.maximizar;
            this.lb_Maximizar.Location = new System.Drawing.Point(204, 15);
            this.lb_Maximizar.Name = "lb_Maximizar";
            this.lb_Maximizar.Size = new System.Drawing.Size(13, 13);
            this.lb_Maximizar.TabIndex = 14;
            this.lb_Maximizar.Text = "  ";
            this.lb_Maximizar.Click += new System.EventHandler(this.lb_Maximizar_Click);
            // 
            // lb_Minimizar
            // 
            this.lb_Minimizar.AutoSize = true;
            this.lb_Minimizar.Location = new System.Drawing.Point(183, 15);
            this.lb_Minimizar.Name = "lb_Minimizar";
            this.lb_Minimizar.Size = new System.Drawing.Size(13, 13);
            this.lb_Minimizar.TabIndex = 13;
            this.lb_Minimizar.Text = "_";
            this.lb_Minimizar.Click += new System.EventHandler(this.lb_Minimizar_Click);
            // 
            // FormNuevaLibreta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 102);
            this.Controls.Add(this.lb_Cerrar);
            this.Controls.Add(this.lb_Maximizar);
            this.Controls.Add(this.lb_Minimizar);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.pb_ApplicationIcon);
            this.Controls.Add(this.tb_Nombre);
            this.Controls.Add(this.cbx_CrearDentroDe);
            this.Controls.Add(this.lb_CrearDentroDe);
            this.Controls.Add(this.lb_Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNuevaLibreta";
            this.Text = "Nueva libreta";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormNuevaLibreta_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ApplicationIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Nombre;
        private System.Windows.Forms.Label lb_CrearDentroDe;
        private System.Windows.Forms.ComboBox cbx_CrearDentroDe;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.PictureBox pb_ApplicationIcon;
        private System.Windows.Forms.Label lb_Cerrar;
        private System.Windows.Forms.Label lb_Maximizar;
        private System.Windows.Forms.Label lb_Minimizar;
    }
}