using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace SIMATIC
{
    public partial class InicioSesion : Form
    {
        private SqlConnection conn;
        
        private string sCn;
        private SqlDataAdapter da1;
        private SqlDataReader dr1;
        public InicioSesion()
        {
            InitializeComponent();
            conexion.conec();

            //agrego la variable scn a la cadena conexión
            sCn = conexion.cadena;
            //creo la conexión pensándole como argumento la cadena
            conn = new SqlConnection(sCn);
            tbContrasenaIS.UseSystemPasswordChar = true;
            tbContraRIS.UseSystemPasswordChar = true;
            tbConfContraRIS.UseSystemPasswordChar = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);              

        private void btnSalirRIS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            pRecuperarContra.Visible = false;
            pIngreso.Visible = true;
        }

        private void lbRecuperar_Click(object sender, EventArgs e)
        {
            pIngreso.Visible = false;
            pRecuperarContra.Visible = true;
        }

        private void btnIngresarIS_Click(object sender, EventArgs e)
        {

            
            //Validación de usuarios.
           // conn.Open();
            //string usuario = tbUsuarioIS.Text;
           // string seleccion1 = "Select NombreUsuario, ClaveUsuario from Usuarios Where NombreUsuario = '" + usuario + "'";
          //  da1 = new SqlDataAdapter(seleccion1, conn);
            //SqlParameter prm1 = new SqlParameter("NombreUsuario", SqlDbType.VarChar);
            //prm1.Value = usuario;
            //da1.SelectCommand.Parameters.Add(prm1);
            //dr1 = da1.SelectCommand.ExecuteReader();
            //while (dr1.Read())
            //{
              //  UsuarioComp.Text = dr1["NombreUsuario"].ToString().Trim();
                //ClaveUsuComp.Text = dr1["ClaveUsuario"].ToString().Trim();
            //}
            //conn.Close();
            //conn.Close();
            //if (tbUsuarioIS.Text == UsuarioComp.Text && tbContrasenaIS.Text == ClaveUsuComp.Text)
            //{
                new Form1().Show();
                this.Hide();
            //}
            //else if (tbUsuarioIS.Text == "" || tbContrasenaIS.Text == "")
            //{
              //  MessageBox.Show("Debe de llenar los campos de Usuario y Contraseña...", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else if (tbUsuarioIS.Text == "" && tbContrasenaIS.Text == "")
            //{
              //  MessageBox.Show("Debe de llenar los campos de Usuario y Contraseña...", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
              //  MessageBox.Show("Usuario o Clave no válidos... Intente de nuevo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //tbUsuarioIS.Text = "";
               // tbContrasenaIS.Text = "";
            //}
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {
            toolTip1.SetToolTip(this.iconCerrarIS, "Cerrar");
            toolTip1.SetToolTip(this.iconMaxiIS, "Maximizar");
            toolTip1.SetToolTip(this.iconMiniIS, "Minimizar");
            toolTip1.SetToolTip(this.iconResaurarIS, "Restaurar");
        }

        private void iconCerrarIS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconResaurarIS_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconResaurarIS.Visible = false;
            iconMaxiIS.Visible = true;
        }

        private void iconMiniIS_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconMaxiIS_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconMaxiIS.Visible = false;
            iconResaurarIS.Visible = true;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lbRecuperar_MouseMove(object sender, MouseEventArgs e)
        {
            if (lbRecuperar.ForeColor == Color.Black)
                lbRecuperar.ForeColor = Color.Red;
        }

        private void lbRecuperar_MouseLeave(object sender, EventArgs e)
        {
            if (lbRecuperar.ForeColor == Color.Red)
                lbRecuperar.ForeColor = Color.Black;
        }

        private void btnSalirIS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbContraDisable_Click(object sender, EventArgs e)
        {
            if (pbContraDisable.Visible == true)
            {
                pbContraDisable.Visible = false;
                pbContraEnable.Visible = true;
                tbContrasenaIS.UseSystemPasswordChar = false;
            }
        }

        private void pbcontraEnable_Click(object sender, EventArgs e)
        {
            if (pbContraEnable.Visible == true)
            {
                pbContraDisable.Visible = true;
                pbContraEnable.Visible = false;
                tbContrasenaIS.UseSystemPasswordChar = true;
            }
        }

        private void btnAceptarRecuperacion_Click(object sender, EventArgs e)
        {
            conn.Open();
            string usuario = tbUsuarioRIS.Text;
            string seleccion1 = "Select NombreUsuario, Pregunta, Respuesta from Usuarios Where NombreUsuario Like '" + usuario + "'";
            da1 = new SqlDataAdapter(seleccion1, conn);
            SqlParameter prm1 = new SqlParameter("NombreUsuario", SqlDbType.VarChar);
            prm1.Value = usuario;
            da1.SelectCommand.Parameters.Add(prm1);
            dr1 = da1.SelectCommand.ExecuteReader();
            while (dr1.Read())
            {
                PreguntaSeg.Text = dr1["Pregunta"].ToString().Trim();
                lbRespuesta.Text = dr1["Respuesta"].ToString().Trim();
            }
            conn.Close();
            conn.Close();
            tbPreguntaRIS.Enabled = true;
        }

        private void btnVerificarPreg_Click(object sender, EventArgs e)
        {
            if (lbRespuesta.Text == tbPreguntaRIS.Text)
            {
                pnNuevaContra.Visible = true;
                tbPreguntaRIS.Text = "";
                tbPreguntaRIS.Enabled = false;
                PreguntaSeg.Text = "Pregunta de seguridad:";
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta... Intente de nuevo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestaurarContra_Click(object sender, EventArgs e)
        {
            if (tbContraRIS.Text == tbConfContraRIS.Text)
            {
                conn.Open();
                string update, Contrasena;
                Contrasena = tbContraRIS.Text;
                update = "Update Usuarios Set ClaveUsuario = '" + Contrasena + "' Where NombreUsuario =  '" + tbUsuarioRIS.Text + "'";
                SqlCommand cmd2 = new SqlCommand(update, conn);
                cmd2.ExecuteNonQuery();
                conn.Close();
                conn.Close();
                tbUsuarioRIS.Text = "";
                tbContraRIS.Text = "";
                tbConfContraRIS.Text = "";
                pnNuevaContra.Visible = false;
                pIngreso.Visible = true;
                pRecuperarContra.Visible = false;
            }
            else if (tbContraRIS.Text == "" || tbContraRIS.Text == "")
                MessageBox.Show("Debe de llenar los campos... Intente de nuevo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (tbContraRIS.Text == "" && tbContraRIS.Text == "")
                MessageBox.Show("Debe de llenar los campos... Intente de nuevo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRegresarNvContra_Click(object sender, EventArgs e)
        {
            pnNuevaContra.Visible = false;
            tbUsuarioRIS.Text = "";
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.iconCerrarIS, "Cerrar");
            toolTip1.SetToolTip(this.iconMaxiIS, "Maximizar");
            toolTip1.SetToolTip(this.iconMiniIS, "Minimizar");
            toolTip1.SetToolTip(this.iconResaurarIS, "Restaurar");
        }
    }
}
