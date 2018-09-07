namespace AnalizeNotebook
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgv_Notas = new System.Windows.Forms.DataGridView();
            this.dgv_clm_Clase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_clm_Accesibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_clm_Modificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_clm_Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_clm_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mst_Menu = new System.Windows.Forms.MenuStrip();
            this.tsmi_Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Archivo_NuevaNota = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Archivo_MoverA = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Archivo_Guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Archivo_Clases = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Clases_CShp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Clases_VB = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Archivo_Ajustes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Libretas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Libretas_NuevaLibreta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Libretas_AdministrarLibretas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Etiquetas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Etiquetas_NuevaEtiqueta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Etiquetas_AdministrarEtiquetas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Ayuda_Idioma = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Idioma_Espanyol = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Idioma_Ingles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Ayuda_AcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Ayuda_Contacto = new System.Windows.Forms.ToolStripMenuItem();
            this.pn_Accesos = new System.Windows.Forms.Panel();
            this.lb_NuevaEtiqueta = new System.Windows.Forms.Label();
            this.lb_NuevaLibreta = new System.Windows.Forms.Label();
            this.lb_NuevoAtajo = new System.Windows.Forms.Label();
            this.lb_Etiquetas = new System.Windows.Forms.Label();
            this.lb_Libretas = new System.Windows.Forms.Label();
            this.lb_Notas = new System.Windows.Forms.Label();
            this.lb_Atajos = new System.Windows.Forms.Label();
            this.lb_NuevaNota = new System.Windows.Forms.Label();
            this.lb_CerrarPanel = new System.Windows.Forms.Label();
            this.cms_MenuClickDcho = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_MoverA = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_AsignarEtiqueta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_AnyadirAtajos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_CrearClases = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_Title = new System.Windows.Forms.Label();
            this.lb_Minimizar = new System.Windows.Forms.Label();
            this.lb_Cerrar = new System.Windows.Forms.Label();
            this.lb_Maximizar = new System.Windows.Forms.Label();
            this.pb_ApplicationIcon = new System.Windows.Forms.PictureBox();
            this.pn_Contenidos = new System.Windows.Forms.Panel();
            this.lb_NuevoContenido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Notas)).BeginInit();
            this.mst_Menu.SuspendLayout();
            this.pn_Accesos.SuspendLayout();
            this.cms_MenuClickDcho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ApplicationIcon)).BeginInit();
            this.pn_Contenidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Notas
            // 
            this.dgv_Notas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Notas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_clm_Clase,
            this.dgv_clm_Accesibilidad,
            this.dgv_clm_Modificador,
            this.dgv_clm_Tipo,
            this.dgv_clm_Nombre});
            this.dgv_Notas.Location = new System.Drawing.Point(157, 63);
            this.dgv_Notas.Name = "dgv_Notas";
            this.dgv_Notas.Size = new System.Drawing.Size(641, 543);
            this.dgv_Notas.TabIndex = 0;
            // 
            // dgv_clm_Clase
            // 
            this.dgv_clm_Clase.HeaderText = "Clase / Interfaz";
            this.dgv_clm_Clase.Name = "dgv_clm_Clase";
            this.dgv_clm_Clase.Width = 110;
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
            this.dgv_clm_Nombre.Width = 180;
            // 
            // mst_Menu
            // 
            this.mst_Menu.Dock = System.Windows.Forms.DockStyle.None;
            this.mst_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Archivo,
            this.tsmi_Libretas,
            this.tsmi_Etiquetas,
            this.tsmi_Ayuda});
            this.mst_Menu.Location = new System.Drawing.Point(3, 36);
            this.mst_Menu.Name = "mst_Menu";
            this.mst_Menu.Size = new System.Drawing.Size(248, 24);
            this.mst_Menu.TabIndex = 1;
            this.mst_Menu.Text = "menuStrip1";
            // 
            // tsmi_Archivo
            // 
            this.tsmi_Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Archivo_NuevaNota,
            this.tsmi_Archivo_MoverA,
            this.tsmi_Archivo_Guardar,
            this.tsmi_Archivo_Clases,
            this.tsmi_Archivo_Ajustes});
            this.tsmi_Archivo.Name = "tsmi_Archivo";
            this.tsmi_Archivo.Size = new System.Drawing.Size(60, 20);
            this.tsmi_Archivo.Text = "&Archivo";
            // 
            // tsmi_Archivo_NuevaNota
            // 
            this.tsmi_Archivo_NuevaNota.Name = "tsmi_Archivo_NuevaNota";
            this.tsmi_Archivo_NuevaNota.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmi_Archivo_NuevaNota.Size = new System.Drawing.Size(178, 22);
            this.tsmi_Archivo_NuevaNota.Text = "Nueva nota";
            this.tsmi_Archivo_NuevaNota.Click += new System.EventHandler(this.tsmi_Archivo_NuevaNota_Click);
            // 
            // tsmi_Archivo_MoverA
            // 
            this.tsmi_Archivo_MoverA.Name = "tsmi_Archivo_MoverA";
            this.tsmi_Archivo_MoverA.Size = new System.Drawing.Size(178, 22);
            this.tsmi_Archivo_MoverA.Text = "Mover a libreta...";
            // 
            // tsmi_Archivo_Guardar
            // 
            this.tsmi_Archivo_Guardar.Name = "tsmi_Archivo_Guardar";
            this.tsmi_Archivo_Guardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmi_Archivo_Guardar.Size = new System.Drawing.Size(178, 22);
            this.tsmi_Archivo_Guardar.Text = "Guardar";
            this.tsmi_Archivo_Guardar.Click += new System.EventHandler(this.tsmi_Archivo_Guardar_Click);
            // 
            // tsmi_Archivo_Clases
            // 
            this.tsmi_Archivo_Clases.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Clases_CShp,
            this.tsmi_Clases_VB});
            this.tsmi_Archivo_Clases.Name = "tsmi_Archivo_Clases";
            this.tsmi_Archivo_Clases.Size = new System.Drawing.Size(178, 22);
            this.tsmi_Archivo_Clases.Text = "Crear clases...";
            // 
            // tsmi_Clases_CShp
            // 
            this.tsmi_Clases_CShp.Name = "tsmi_Clases_CShp";
            this.tsmi_Clases_CShp.Size = new System.Drawing.Size(116, 22);
            this.tsmi_Clases_CShp.Text = "C#";
            // 
            // tsmi_Clases_VB
            // 
            this.tsmi_Clases_VB.Name = "tsmi_Clases_VB";
            this.tsmi_Clases_VB.Size = new System.Drawing.Size(116, 22);
            this.tsmi_Clases_VB.Text = "VB .NET";
            // 
            // tsmi_Archivo_Ajustes
            // 
            this.tsmi_Archivo_Ajustes.Name = "tsmi_Archivo_Ajustes";
            this.tsmi_Archivo_Ajustes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmi_Archivo_Ajustes.Size = new System.Drawing.Size(178, 22);
            this.tsmi_Archivo_Ajustes.Text = "Ajustes";
            // 
            // tsmi_Libretas
            // 
            this.tsmi_Libretas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Libretas_NuevaLibreta,
            this.tsmi_Libretas_AdministrarLibretas});
            this.tsmi_Libretas.Name = "tsmi_Libretas";
            this.tsmi_Libretas.Size = new System.Drawing.Size(60, 20);
            this.tsmi_Libretas.Text = "&Libretas";
            // 
            // tsmi_Libretas_NuevaLibreta
            // 
            this.tsmi_Libretas_NuevaLibreta.Name = "tsmi_Libretas_NuevaLibreta";
            this.tsmi_Libretas_NuevaLibreta.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.tsmi_Libretas_NuevaLibreta.Size = new System.Drawing.Size(184, 22);
            this.tsmi_Libretas_NuevaLibreta.Text = "Nueva libreta";
            this.tsmi_Libretas_NuevaLibreta.Click += new System.EventHandler(this.tsmi_Libretas_NuevaLibreta_Click);
            // 
            // tsmi_Libretas_AdministrarLibretas
            // 
            this.tsmi_Libretas_AdministrarLibretas.Name = "tsmi_Libretas_AdministrarLibretas";
            this.tsmi_Libretas_AdministrarLibretas.Size = new System.Drawing.Size(184, 22);
            this.tsmi_Libretas_AdministrarLibretas.Text = "Administrar libretas";
            // 
            // tsmi_Etiquetas
            // 
            this.tsmi_Etiquetas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Etiquetas_NuevaEtiqueta,
            this.tsmi_Etiquetas_AdministrarEtiquetas});
            this.tsmi_Etiquetas.Name = "tsmi_Etiquetas";
            this.tsmi_Etiquetas.Size = new System.Drawing.Size(67, 20);
            this.tsmi_Etiquetas.Text = "&Etiquetas";
            // 
            // tsmi_Etiquetas_NuevaEtiqueta
            // 
            this.tsmi_Etiquetas_NuevaEtiqueta.Name = "tsmi_Etiquetas_NuevaEtiqueta";
            this.tsmi_Etiquetas_NuevaEtiqueta.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmi_Etiquetas_NuevaEtiqueta.Size = new System.Drawing.Size(194, 22);
            this.tsmi_Etiquetas_NuevaEtiqueta.Text = "Nueva etiqueta";
            // 
            // tsmi_Etiquetas_AdministrarEtiquetas
            // 
            this.tsmi_Etiquetas_AdministrarEtiquetas.Name = "tsmi_Etiquetas_AdministrarEtiquetas";
            this.tsmi_Etiquetas_AdministrarEtiquetas.Size = new System.Drawing.Size(194, 22);
            this.tsmi_Etiquetas_AdministrarEtiquetas.Text = "Administrar etiquetas";
            // 
            // tsmi_Ayuda
            // 
            this.tsmi_Ayuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Ayuda_Idioma,
            this.tsmi_Ayuda_AcercaDe,
            this.tsmi_Ayuda_Contacto});
            this.tsmi_Ayuda.Name = "tsmi_Ayuda";
            this.tsmi_Ayuda.Size = new System.Drawing.Size(53, 20);
            this.tsmi_Ayuda.Text = "A&yuda";
            // 
            // tsmi_Ayuda_Idioma
            // 
            this.tsmi_Ayuda_Idioma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Idioma_Espanyol,
            this.tsmi_Idioma_Ingles});
            this.tsmi_Ayuda_Idioma.Name = "tsmi_Ayuda_Idioma";
            this.tsmi_Ayuda_Idioma.Size = new System.Drawing.Size(201, 22);
            this.tsmi_Ayuda_Idioma.Text = "Idioma...";
            // 
            // tsmi_Idioma_Espanyol
            // 
            this.tsmi_Idioma_Espanyol.Name = "tsmi_Idioma_Espanyol";
            this.tsmi_Idioma_Espanyol.Size = new System.Drawing.Size(115, 22);
            this.tsmi_Idioma_Espanyol.Text = "Español";
            // 
            // tsmi_Idioma_Ingles
            // 
            this.tsmi_Idioma_Ingles.Name = "tsmi_Idioma_Ingles";
            this.tsmi_Idioma_Ingles.Size = new System.Drawing.Size(115, 22);
            this.tsmi_Idioma_Ingles.Text = "English";
            // 
            // tsmi_Ayuda_AcercaDe
            // 
            this.tsmi_Ayuda_AcercaDe.Name = "tsmi_Ayuda_AcercaDe";
            this.tsmi_Ayuda_AcercaDe.Size = new System.Drawing.Size(201, 22);
            this.tsmi_Ayuda_AcercaDe.Text = "Acerca del desarrollador";
            // 
            // tsmi_Ayuda_Contacto
            // 
            this.tsmi_Ayuda_Contacto.Name = "tsmi_Ayuda_Contacto";
            this.tsmi_Ayuda_Contacto.Size = new System.Drawing.Size(201, 22);
            this.tsmi_Ayuda_Contacto.Text = "Contacto";
            // 
            // pn_Accesos
            // 
            this.pn_Accesos.Controls.Add(this.lb_NuevaEtiqueta);
            this.pn_Accesos.Controls.Add(this.lb_NuevaLibreta);
            this.pn_Accesos.Controls.Add(this.lb_NuevoAtajo);
            this.pn_Accesos.Controls.Add(this.lb_Etiquetas);
            this.pn_Accesos.Controls.Add(this.lb_Libretas);
            this.pn_Accesos.Controls.Add(this.lb_Notas);
            this.pn_Accesos.Controls.Add(this.lb_Atajos);
            this.pn_Accesos.Controls.Add(this.lb_NuevaNota);
            this.pn_Accesos.Location = new System.Drawing.Point(3, 63);
            this.pn_Accesos.Name = "pn_Accesos";
            this.pn_Accesos.Size = new System.Drawing.Size(148, 543);
            this.pn_Accesos.TabIndex = 2;
            // 
            // lb_NuevaEtiqueta
            // 
            this.lb_NuevaEtiqueta.AutoSize = true;
            this.lb_NuevaEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_NuevaEtiqueta.Location = new System.Drawing.Point(32, 150);
            this.lb_NuevaEtiqueta.Name = "lb_NuevaEtiqueta";
            this.lb_NuevaEtiqueta.Size = new System.Drawing.Size(0, 17);
            this.lb_NuevaEtiqueta.TabIndex = 11;
            this.lb_NuevaEtiqueta.Tag = "Etiqueta";
            this.lb_NuevaEtiqueta.Click += new System.EventHandler(this.AccesoContenidos);
            // 
            // lb_NuevaLibreta
            // 
            this.lb_NuevaLibreta.AutoSize = true;
            this.lb_NuevaLibreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_NuevaLibreta.Location = new System.Drawing.Point(32, 125);
            this.lb_NuevaLibreta.Name = "lb_NuevaLibreta";
            this.lb_NuevaLibreta.Size = new System.Drawing.Size(0, 17);
            this.lb_NuevaLibreta.TabIndex = 10;
            this.lb_NuevaLibreta.Tag = "Libreta";
            this.lb_NuevaLibreta.Click += new System.EventHandler(this.AccesoContenidos);
            // 
            // lb_NuevoAtajo
            // 
            this.lb_NuevoAtajo.AutoSize = true;
            this.lb_NuevoAtajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_NuevoAtajo.Location = new System.Drawing.Point(32, 75);
            this.lb_NuevoAtajo.Name = "lb_NuevoAtajo";
            this.lb_NuevoAtajo.Size = new System.Drawing.Size(0, 17);
            this.lb_NuevoAtajo.TabIndex = 9;
            this.lb_NuevoAtajo.Tag = "Atajo";
            this.lb_NuevoAtajo.Click += new System.EventHandler(this.AccesoContenidos);
            // 
            // lb_Etiquetas
            // 
            this.lb_Etiquetas.AutoSize = true;
            this.lb_Etiquetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_Etiquetas.Location = new System.Drawing.Point(12, 125);
            this.lb_Etiquetas.Name = "lb_Etiquetas";
            this.lb_Etiquetas.Size = new System.Drawing.Size(67, 17);
            this.lb_Etiquetas.TabIndex = 8;
            this.lb_Etiquetas.Tag = "Etiqueta,3";
            this.lb_Etiquetas.Text = "Etiquetas";
            this.lb_Etiquetas.Click += new System.EventHandler(this.MostrarDesplegable);
            // 
            // lb_Libretas
            // 
            this.lb_Libretas.AutoSize = true;
            this.lb_Libretas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_Libretas.Location = new System.Drawing.Point(12, 100);
            this.lb_Libretas.Name = "lb_Libretas";
            this.lb_Libretas.Size = new System.Drawing.Size(59, 17);
            this.lb_Libretas.TabIndex = 7;
            this.lb_Libretas.Tag = "Libreta,2";
            this.lb_Libretas.Text = "Libretas";
            this.lb_Libretas.Click += new System.EventHandler(this.MostrarDesplegable);
            // 
            // lb_Notas
            // 
            this.lb_Notas.AutoSize = true;
            this.lb_Notas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_Notas.Location = new System.Drawing.Point(12, 75);
            this.lb_Notas.Name = "lb_Notas";
            this.lb_Notas.Size = new System.Drawing.Size(45, 17);
            this.lb_Notas.TabIndex = 6;
            this.lb_Notas.Tag = "Nota";
            this.lb_Notas.Text = "Notas";
            this.lb_Notas.Click += new System.EventHandler(this.AccesoContenidos);
            // 
            // lb_Atajos
            // 
            this.lb_Atajos.AutoSize = true;
            this.lb_Atajos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_Atajos.Location = new System.Drawing.Point(12, 50);
            this.lb_Atajos.Name = "lb_Atajos";
            this.lb_Atajos.Size = new System.Drawing.Size(47, 17);
            this.lb_Atajos.TabIndex = 5;
            this.lb_Atajos.Tag = "Atajo,1";
            this.lb_Atajos.Text = "Atajos";
            this.lb_Atajos.Click += new System.EventHandler(this.MostrarDesplegable);
            // 
            // lb_NuevaNota
            // 
            this.lb_NuevaNota.AutoSize = true;
            this.lb_NuevaNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NuevaNota.Location = new System.Drawing.Point(12, 20);
            this.lb_NuevaNota.Name = "lb_NuevaNota";
            this.lb_NuevaNota.Size = new System.Drawing.Size(93, 17);
            this.lb_NuevaNota.TabIndex = 4;
            this.lb_NuevaNota.Tag = " Acceso";
            this.lb_NuevaNota.Text = "+ Nueva nota";
            this.lb_NuevaNota.Click += new System.EventHandler(this.lb_NuevaNota_Click);
            // 
            // lb_CerrarPanel
            // 
            this.lb_CerrarPanel.AutoSize = true;
            this.lb_CerrarPanel.Location = new System.Drawing.Point(167, 9);
            this.lb_CerrarPanel.Name = "lb_CerrarPanel";
            this.lb_CerrarPanel.Size = new System.Drawing.Size(14, 13);
            this.lb_CerrarPanel.TabIndex = 14;
            this.lb_CerrarPanel.Text = "X";
            this.lb_CerrarPanel.Click += new System.EventHandler(this.lb_CerrarPanel_Click);
            // 
            // cms_MenuClickDcho
            // 
            this.cms_MenuClickDcho.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_MoverA,
            this.tsmi_AsignarEtiqueta,
            this.tsmi_AnyadirAtajos,
            this.tsmi_CrearClases});
            this.cms_MenuClickDcho.Name = "cms_MenuClickDcho";
            this.cms_MenuClickDcho.Size = new System.Drawing.Size(170, 92);
            // 
            // tsmi_MoverA
            // 
            this.tsmi_MoverA.Name = "tsmi_MoverA";
            this.tsmi_MoverA.Size = new System.Drawing.Size(169, 22);
            this.tsmi_MoverA.Text = "Mover a...";
            // 
            // tsmi_AsignarEtiqueta
            // 
            this.tsmi_AsignarEtiqueta.Name = "tsmi_AsignarEtiqueta";
            this.tsmi_AsignarEtiqueta.Size = new System.Drawing.Size(169, 22);
            this.tsmi_AsignarEtiqueta.Text = "Asignar etiqueta...";
            // 
            // tsmi_AnyadirAtajos
            // 
            this.tsmi_AnyadirAtajos.Name = "tsmi_AnyadirAtajos";
            this.tsmi_AnyadirAtajos.Size = new System.Drawing.Size(169, 22);
            this.tsmi_AnyadirAtajos.Text = "Añadir a atajos";
            // 
            // tsmi_CrearClases
            // 
            this.tsmi_CrearClases.Name = "tsmi_CrearClases";
            this.tsmi_CrearClases.Size = new System.Drawing.Size(169, 22);
            this.tsmi_CrearClases.Text = "Crear clases...";
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lb_Title.Location = new System.Drawing.Point(37, 15);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(114, 15);
            this.lb_Title.TabIndex = 4;
            this.lb_Title.Text = "AnalizeNotebook++";
            // 
            // lb_Minimizar
            // 
            this.lb_Minimizar.AutoSize = true;
            this.lb_Minimizar.Location = new System.Drawing.Point(742, 15);
            this.lb_Minimizar.Name = "lb_Minimizar";
            this.lb_Minimizar.Size = new System.Drawing.Size(13, 13);
            this.lb_Minimizar.TabIndex = 5;
            this.lb_Minimizar.Text = "_";
            this.lb_Minimizar.Click += new System.EventHandler(this.lb_Minimizar_Click);
            // 
            // lb_Cerrar
            // 
            this.lb_Cerrar.AutoSize = true;
            this.lb_Cerrar.Location = new System.Drawing.Point(784, 15);
            this.lb_Cerrar.Name = "lb_Cerrar";
            this.lb_Cerrar.Size = new System.Drawing.Size(14, 13);
            this.lb_Cerrar.TabIndex = 7;
            this.lb_Cerrar.Text = "X";
            this.lb_Cerrar.Click += new System.EventHandler(this.lb_Cerrar_Click);
            // 
            // lb_Maximizar
            // 
            this.lb_Maximizar.AutoSize = true;
            this.lb_Maximizar.Enabled = false;
            this.lb_Maximizar.Image = global::AnalizeNotebook.Properties.Resources.maximizar;
            this.lb_Maximizar.Location = new System.Drawing.Point(763, 15);
            this.lb_Maximizar.Name = "lb_Maximizar";
            this.lb_Maximizar.Size = new System.Drawing.Size(13, 13);
            this.lb_Maximizar.TabIndex = 6;
            this.lb_Maximizar.Text = "  ";
            this.lb_Maximizar.Click += new System.EventHandler(this.lb_Maximizar_Click);
            // 
            // pb_ApplicationIcon
            // 
            this.pb_ApplicationIcon.Location = new System.Drawing.Point(12, 13);
            this.pb_ApplicationIcon.Name = "pb_ApplicationIcon";
            this.pb_ApplicationIcon.Size = new System.Drawing.Size(19, 20);
            this.pb_ApplicationIcon.TabIndex = 3;
            this.pb_ApplicationIcon.TabStop = false;
            // 
            // pn_Contenidos
            // 
            this.pn_Contenidos.Controls.Add(this.lb_CerrarPanel);
            this.pn_Contenidos.Controls.Add(this.lb_NuevoContenido);
            this.pn_Contenidos.Location = new System.Drawing.Point(155, 63);
            this.pn_Contenidos.Name = "pn_Contenidos";
            this.pn_Contenidos.Size = new System.Drawing.Size(194, 543);
            this.pn_Contenidos.TabIndex = 5;
            this.pn_Contenidos.Visible = false;
            // 
            // lb_NuevoContenido
            // 
            this.lb_NuevoContenido.AutoSize = true;
            this.lb_NuevoContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_NuevoContenido.Location = new System.Drawing.Point(15, 20);
            this.lb_NuevoContenido.Name = "lb_NuevoContenido";
            this.lb_NuevoContenido.Size = new System.Drawing.Size(93, 17);
            this.lb_NuevoContenido.TabIndex = 11;
            this.lb_NuevoContenido.Tag = "Contenido";
            this.lb_NuevoContenido.Text = "+ Nueva nota";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 614);
            this.Controls.Add(this.pn_Contenidos);
            this.Controls.Add(this.lb_Cerrar);
            this.Controls.Add(this.lb_Maximizar);
            this.Controls.Add(this.lb_Minimizar);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.pb_ApplicationIcon);
            this.Controls.Add(this.pn_Accesos);
            this.Controls.Add(this.dgv_Notas);
            this.Controls.Add(this.mst_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mst_Menu;
            this.Name = "FormPrincipal";
            this.Text = "AnalizeNotebook++";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPrincipal_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Notas)).EndInit();
            this.mst_Menu.ResumeLayout(false);
            this.mst_Menu.PerformLayout();
            this.pn_Accesos.ResumeLayout(false);
            this.pn_Accesos.PerformLayout();
            this.cms_MenuClickDcho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ApplicationIcon)).EndInit();
            this.pn_Contenidos.ResumeLayout(false);
            this.pn_Contenidos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Notas;
        private System.Windows.Forms.MenuStrip mst_Menu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Archivo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Archivo_NuevaNota;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Archivo_Clases;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Archivo_Ajustes;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Libretas;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Libretas_AdministrarLibretas;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Etiquetas;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Etiquetas_AdministrarEtiquetas;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Ayuda;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Ayuda_Idioma;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Ayuda_Contacto;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Idioma_Espanyol;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Idioma_Ingles;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Archivo_MoverA;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Ayuda_AcercaDe;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Clases_CShp;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Clases_VB;
        private System.Windows.Forms.Panel pn_Accesos;
        private System.Windows.Forms.ContextMenuStrip cms_MenuClickDcho;
        private System.Windows.Forms.ToolStripMenuItem tsmi_MoverA;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AsignarEtiqueta;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AnyadirAtajos;
        private System.Windows.Forms.ToolStripMenuItem tsmi_CrearClases;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Archivo_Guardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_clm_Clase;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_clm_Accesibilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_clm_Modificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_clm_Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_clm_Nombre;
        private System.Windows.Forms.PictureBox pb_ApplicationIcon;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Label lb_Minimizar;
        private System.Windows.Forms.Label lb_Maximizar;
        private System.Windows.Forms.Label lb_Cerrar;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Libretas_NuevaLibreta;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Etiquetas_NuevaEtiqueta;
        private System.Windows.Forms.Panel pn_Contenidos;
        private System.Windows.Forms.Label lb_CerrarPanel;
        private System.Windows.Forms.Label lb_Etiquetas;
        private System.Windows.Forms.Label lb_Libretas;
        private System.Windows.Forms.Label lb_Notas;
        private System.Windows.Forms.Label lb_Atajos;
        private System.Windows.Forms.Label lb_NuevaNota;
        private System.Windows.Forms.Label lb_NuevoContenido;
        private System.Windows.Forms.Label lb_NuevaEtiqueta;
        private System.Windows.Forms.Label lb_NuevaLibreta;
        private System.Windows.Forms.Label lb_NuevoAtajo;
    }
}

