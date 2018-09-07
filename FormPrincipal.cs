/// <author>Daniel Morato Baudi</author>
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Collections.Generic;

namespace AnalizeNotebook
{
    public partial class FormPrincipal : Form
    {
        #region Atributos
        private const int ESPACIADO_HORIZONTAL = 25;
        private const int ESPACIADO_VERTICAL   = 20;
        private bool redimensionado;
        private bool desplegado;
        private List<string> listaContenido;
        private string[] listaTags;
        #endregion

        #region Constructor
        public FormPrincipal()
        {
            InitializeComponent();

            redimensionado = false;
            desplegado = false;
            listaContenido = new List<string>();

            listaContenido.Add("Prueba 1");
            listaContenido.Add("Prueba 2");
            listaContenido.Add("Prueba 3");

            listaTags = new string[3];
            listaTags[0] = "Atajo";
            // listaTags[1] = "Nota";
            listaTags[1] = "Libreta";
            listaTags[2] = "Etiqueta";
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Rellena el panel con la lista de contenidos especificada.
        /// </summary>
        /// <param name="sender">Label de contenidos a introducir en el panel.</param>
        /// <param name="tags">Tags de los labels principales.</param>
        /// <param name="desplegable">Indica el panel en el que se mostraran los controles.</param>
        private void RellenarPanel(Label sender, string[] tags, bool desplegable)
        {
            // Extraer de la DB la lista de contenidos especificada.
            // listaContenido = ConsultarDB("Nombre", sender.Text);

            Label control;
            Control ctrl = pn_Contenidos.Controls
                .Find("lb_NuevoContenido", false)[0];

            Label aux = desplegable ? sender : (Label)ctrl;
            int posicionY = aux.Location.Y + ESPACIADO_HORIZONTAL;
            int posicionX = desplegable ? aux.Location.X +
                     ESPACIADO_VERTICAL : aux.Location.X;

            int index = System.Convert.ToInt32(tags[1]);
            string nombre = tags[0] == "Atajo" ? "+ Nuevo " : "+ Nueva ";
            string contenidoTag = sender.Text.Substring(
                             0, sender.Text.Length - 1);

            if (listaContenido.Count > 0)
            {
                // for (int i = 0; i < listaTags.Length; i++)
                foreach (string contenido in listaContenido)
                {
                    control = new Label();
                    control.Name = "lb_" + sender.Text + "_" + contenido;  // cambiar sender.Text por listaTags[i].
                    control.Name = control.Name.Replace(" ", "_");
                    control.Text = contenido;
                    control.Tag =  tags[0];
                    control.Font = new Font("Microsoft Sans Serif", 10);
                    control.Location = new Point(posicionX, posicionY);
                    
                    posicionY += ESPACIADO_HORIZONTAL;

                    if (desplegable)
                    {
                        control.Click += new System.EventHandler(AccesoContenidos);
                        pn_Accesos.Controls.Add(control);

                    } else {

                        // control.Click += new System.EventHandler(MostrarNota);
                        pn_Contenidos.Controls.Add(control);
                    }
                }
                // posicionY = aux.Location.Y + (ESPACIADO_HORIZONTAL * 2);
            }

            lb_NuevoContenido.Text = nombre + tags[0].ToLower();

            #region Label nuevo contenido 2
            // Label nuevo contenido.
            // control = new Label();
            // control.Name = "lb_Contenido";
            // control.Text = "+ Nuevo";
            // control.Tag = sender.Tag;
            // control.Font = new Font("Microsoft Sans Serif", 10);
            // control.Location = new Point(posicionX, posicionY);
            // // control.Click += new System.EventHandler(lb_NuevaNota_Click);
            // pn_Accesos.Controls.Add(control);
            #endregion

            // Reordenar controles inferiores.
            // OrdenarListaControles();
            RecolocarControles(sender, index);
        }

        /// <summary>
        /// Recoloca los controles inferiores al desplegar un label desplegable.
        /// </summary>
        /// <param name="sender">Label desplegado.</param>
        /// <param name="index">(Optional) Índice a partir del cual empezaremos a recolocar.</param>
        private void RecolocarControles(Label sender, int index)
        {
            Control[][] ctrl = new Control[3][];
            List<Control> aux = new List<Control>();
            int posicionInicialX, posicionInicialY;

            // Almacenamos todos los controles relativos unos a otros en arrays diferentes.
            for (int i = 0; i < listaTags.Length; i++)
                for (int j = 0; j < pn_Accesos.Controls.Count; j++)
                {
                    if (PrepararTag(pn_Accesos.Controls[j].Tag.ToString()) == listaTags[i])
                        aux.Add(pn_Accesos.Controls[j]);
                 
                    ctrl[i] = aux.ToArray();
                }

            // Prueba contenido ctrl. (Introducir)
            for (int i = 0; i < listaTags.Length; i++)
            {
                for (int j = 0; j < pn_Accesos.Controls.Count; j++)
                {
                    System.Diagnostics.Debug.WriteLine("i: " + i + " j: " + j);
                    System.Diagnostics.Debug.WriteLine("Control Name: " + pn_Accesos.Controls[j].Name);
                    System.Diagnostics.Debug.WriteLine("Control tag:  " + pn_Accesos.Controls[j].Tag.ToString());
                    System.Diagnostics.Debug.WriteLine("Lista tag:    " + listaTags[i]);
            
                    if (PrepararTag(pn_Accesos.Controls[j].Tag.ToString()) == listaTags[i])
                    {
                        aux.Add(pn_Accesos.Controls[j]);
                        System.Diagnostics.Debug.WriteLine("Added.");
                    }
            
                    System.Diagnostics.Debug.WriteLine("");
                }
            
                ctrl[i] = aux.ToArray();
            }

            // Prueba contenido ctrl. (Comprobar)
            for (int i = 0; i < ctrl.Length; i++)
            {
                System.Diagnostics.Debug.WriteLine("Array " + i + ": ");
            
                for (int j = 0; j < ctrl[i].Length; j++)
                    System.Diagnostics.Debug
                        .WriteLine(ctrl[i][j].Name);
            
                System.Diagnostics.Debug.WriteLine("");
            }

            MessageBox.Show("OK");
            // La posición X de los controles será la misma que la del sender.
            posicionInicialX = sender.Location.X;

            // Mientras que la posición Y inicial será la del control
            // inmediatamente superior + ESPACIADO_HORIZONTAL(25).
            posicionInicialY = ctrl[index][ctrl[index]
                .Length - 1].Location.Y + ESPACIADO_HORIZONTAL;

            // Reducimos la posición Y de cada control del array en ESPACIADO_HORIZONTAL(25);
            for (int i = index; i < ctrl.Length - 1; i++)
                for (int j = 0; j < ctrl[i].Length - 1; j++)
                    ctrl[i][j].Location = new Point(
                        posicionInicialX, posicionInicialY);
        }
        
        /// <summary>
        /// Permite adaptar el tag de los label principales.
        /// </summary>
        /// <param name="tag">Tag a adaptar.</param>
        /// <returns>Tag adaptado.</returns>
        private string PrepararTag(string tag)
        {
            if (tag == "Atajo,1" || tag == "Libreta,2" || tag == "Etiqueta,3")
                return tag.Substring(0, tag.Length - 2);

            return tag;
        }
        #endregion

        #region Eventos
        private void tsmi_Archivo_Guardar_Click(object sender, System.EventArgs e)
        {
            // Guardar en DB.
        }

        private void tsmi_Archivo_MoverA_Click(object sender, System.EventArgs e)
        {
            // Asignar una diferente libreta a una nota y actualizar DB.
        }

        /// <summary>
        /// Muestra el contenido de un label desplegable.
        /// </summary>
        /// <param name="sender">Label cuyo contenido queremos mostrar.</param>
        private void MostrarDesplegable(object sender, System.EventArgs e)
        {
            Label contenido = (Label)sender;
            string[] tags = contenido.Tag.ToString().Split(',');

            if (!desplegado)
            {
                RellenarPanel(contenido, tags, true);
                desplegado = true;

            } else {

                OcultarDesplegable(contenido, tags[0]);
                desplegado = false;
            }
        }

        /// <summary>
        /// Oculta el contenido de un label desplegable.
        /// </summary>
        /// <param name="contenido">Label cuyo contenido queremos ocultar.</param>
        /// <param name="tag">Tag a usar como filtro para ocultar los label.</param>
        private void OcultarDesplegable(Label contenido, string tag)
        {
            foreach (Control control in pn_Accesos.Controls)
                if (control.Tag.ToString() == tag)
                    control.Visible = false;

            contenido.Visible = true;
        }

        private void AccesoContenidos(object sender, System.EventArgs e)
        {
            Label contenido = (Label)sender;
            string[] tags = contenido.Tag.ToString().Split(',');

            if ((!redimensionado) && (!pn_Contenidos.Visible))
            {
                pn_Contenidos.Visible = true;

                // Redimensionar grid view.
                dgv_Notas.Size = new Size(
                    dgv_Notas.Size.Width - pn_Contenidos.Width,
                    dgv_Notas.Size.Height);

                // Recolocar grid view.
                dgv_Notas.Location = new Point(
                    dgv_Notas.Location.X + pn_Contenidos.Width,
                    dgv_Notas.Location.Y);

                redimensionado = true;
            }

            if (pn_Contenidos.Visible)
                RellenarPanel(contenido, tags, false);
        }

        private void lb_CerrarPanel_Click(object sender, System.EventArgs e)
        {
            // pn_Contenidos.Controls.Clear();
            pn_Contenidos.Visible = false;

            // Redimensionar grid view al tamaño original.
            dgv_Notas.Size = new Size(
                dgv_Notas.Size.Width + pn_Contenidos.Width, 
                dgv_Notas.Size.Height);
            
            // Recolocar grid view.
            dgv_Notas.Location = new Point(
                dgv_Notas.Location.X - pn_Contenidos.Width,
                dgv_Notas.Location.Y);

            redimensionado = false;
        }

        #region Abrir Forms
        private void lb_NuevaNota_Click(object sender, System.EventArgs e)
        {
            FormNuevaNota form = new FormNuevaNota();
            form.Show();
        }

        private void tsmi_Archivo_NuevaNota_Click(object sender, System.EventArgs e)
        {
            FormNuevaNota form = new FormNuevaNota();
            form.Show();
        }

        private void tsmi_Libretas_NuevaLibreta_Click(object sender, System.EventArgs e)
        {
            FormNuevaLibreta form = new FormNuevaLibreta();
            form.Show();
        }
        #endregion

        #region Form
        private void lb_Minimizar_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lb_Maximizar_Click(object sender, System.EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                lb_Maximizar.Image = Properties.Resources.maximizar;

            } else {

                this.WindowState = FormWindowState.Maximized;
                lb_Maximizar.Image = Properties.Resources.minimizar;
            }
        }

        private void lb_Cerrar_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #endregion

        #region Dll Imports
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,
                                int wMsg, int wParam, int lParam);

        // Permite arrastrar la ventana.
        private void FormPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}