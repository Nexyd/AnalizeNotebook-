///<author>Daniel Morato Baudi</author>
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AnalizeNotebook
{
    public partial class FormNuevaNota : Form
    {
        #region Constructor
        public FormNuevaNota()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos


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
            this.Close();
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
        private void FormNuevaNota_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}