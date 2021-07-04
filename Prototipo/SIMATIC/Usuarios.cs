using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace SIMATIC
{
    public partial class Usuarios : Form
    {
        private SqlConnection conn;
         private SqlCommand insert2;
     
        private string sCn;

        public Usuarios()
        {
            InitializeComponent();

            conexion.conec();

            //agrego la variable scn a la cadena conexión
            sCn = conexion.cadena;
            //creo la conexión pensándole como argumento la cadena
            conn = new SqlConnection(sCn);
            llenarcbusu();
        }

        private void btnAddUsuarios_Click(object sender, EventArgs e)
        {
            if (pAddUsuarios.Visible == false)
            {
                pAddUsuarios.Visible = true;
                pRegistrosUsuarios.Visible = false;
            }
        }

        private void btnRegistroUsuarios_Click(object sender, EventArgs e)
        {
            if (pRegistrosUsuarios.Visible == false)
            {
                pAddUsuarios.Visible = false;
                pRegistrosUsuarios.Visible = true;
            }
        }

        private void btnCerrarUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void llenarcbusu()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Roles", conn);
            da.Fill(ds, "Roles");
            cbRolModificarUsuarios.DataSource = ds.Tables[0].DefaultView;
            cbRolModificarUsuarios.ValueMember = "NombreRol";
            cbRolUsuario.DataSource = ds.Tables[0].DefaultView;
            cbRolUsuario.ValueMember = "NombreRol";
        }
        public void UsuarioIDAdd()
        {
            string UsuarioId = "Select IdUsuario From Usuarios where NombreUsuario = '" + tbNombreUsuario.Text + "'";
            SqlCommand cmd1 = new SqlCommand(UsuarioId, conn);
            conn.Open();
            SqlDataReader Leer = cmd1.ExecuteReader();
            if (Leer.Read() == true)
            {
                lblidusuario.Text = Leer["IdUsuario"].ToString();
            }
            conn.Close();
            conn.Close();
        }
        public void UsuarioIdMod()
        {
            string UsuarioId1 = "Select IdUsuario From Usuarios where NombreUsuario = '" + tbNombreModificarUsuario.Text + "'";
            SqlCommand cmd1 = new SqlCommand(UsuarioId1, conn);
            conn.Open();
            SqlDataReader Leer1 = cmd1.ExecuteReader();
            if (Leer1.Read() == true)
            {
                lblUsuarioId.Text = Leer1["IdUsuario"].ToString();
            }
            conn.Close();
            conn.Close();
        }
        public void RolIdAdd()
        {
            string Rol = "Select IdRol From Roles where NombreRol = '" + cbRolUsuario.Text + "'";

            SqlCommand cmd1 = new SqlCommand(Rol, conn);
            conn.Open();
            SqlDataReader Leer = cmd1.ExecuteReader();
            if (Leer.Read() == true)
            {
                lblRolID.Text = Leer["IdRol"].ToString();
            }
            conn.Close();
            conn.Close();
        }
        public void RolIdMod()
        {
            string Rol1 = "Select IdRol From Roles where NombreRol = '" + cbRolModificarUsuarios.Text + "'";
            SqlCommand cmd2 = new SqlCommand(Rol1, conn);
            conn.Open();
            SqlDataReader Leer1 = cmd2.ExecuteReader();
            if (Leer1.Read() == true)
            {
                lblIdRol.Text = Leer1["IdRol"].ToString();
            }
            conn.Close();
            conn.Close();
        }
        public void RolIdMod1()
        {
            string Rol1 = "Select IdUsuarioRoles From UsuarioRoles where IdRol = '" + lblIdRol.Text + "'";
            SqlCommand cmd2 = new SqlCommand(Rol1, conn);
            conn.Open();
            SqlDataReader Leer1 = cmd2.ExecuteReader();
            if (Leer1.Read() == true)
            {
                lblIdUsuarioRol.Text = Leer1["IdUsuarioRoles"].ToString();
            }
            conn.Close();
            conn.Close();
        }
        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_InsertarUsuarios", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NombreUsuario", SqlDbType.VarChar, 100);
                cmd.Parameters.Add("@ClaveUsuario", SqlDbType.VarChar, 100);
                cmd.Parameters.Add("@Pregunta", SqlDbType.VarChar, 300);
                cmd.Parameters.Add("@Respuesta", SqlDbType.VarChar, 300);
                cmd.Parameters.Add("@Correo", SqlDbType.VarChar, 100);
                cmd.Parameters.Add("@Telefono", SqlDbType.VarChar, 9);
                cmd.Parameters["@NombreUsuario"].Value = tbNombreUsuario.Text;
                cmd.Parameters["@ClaveUsuario"].Value = tbClaveUsuario.Text;
                cmd.Parameters["@Pregunta"].Value = tbPreguntaUsuario.Text;
                cmd.Parameters["@Respuesta"].Value = tbRespuestaUsuario.Text;
                cmd.Parameters["@Correo"].Value = tbCorreoUsuario.Text;
                cmd.Parameters["@Telefono"].Value = tbTelefonoUsuario.Text;
                cmd.ExecuteNonQuery();
                conn.Close();
                UsuarioIDAdd();
                RolIdAdd();
                conn.Open();
                string insertIR;
                insertIR = "Insert Into UsuarioRoles(IdUsuario, IdRol)";
                insertIR += "Values (@IdUsuario, @IdRol)";
                insert2 = new SqlCommand(insertIR, conn);
                insert2.Parameters.Add(new SqlParameter("@IdUsuario", SqlDbType.Int));
                insert2.Parameters["@IdUsuario"].Value = int.Parse(lblidusuario.Text);
                insert2.Parameters.Add(new SqlParameter("@IdRol", SqlDbType.VarChar));
                insert2.Parameters["@IdRol"].Value = int.Parse(lblRolID.Text);
                insert2.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Usuario Registrado", "SIMATIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();

                Mostrar usuarios = new Mostrar();
                dgvUsuarios.DataSource = usuarios.Mostrar_Usuarios();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }
        public void Limpiar()
        {
            tbNombreUsuario.Text = "";
            tbClaveUsuario.Text = "";
            tbPreguntaUsuario.Text = "";
            tbRespuestaUsuario.Text = "";
            tbCorreoUsuario.Text = "";
            tbTelefonoUsuario.Text = "";
            tbNombreModificarUsuario.Clear();
            tbClaveModificarUsuarios.Clear();
            tbPreguntaModificarUsuarios.Clear();
            tbRespuestaModificarUsuarios.Clear();
            tbCorreoModificarUsuarios.Clear();
            tbTelefonoModificarUsuarios.Clear();
            lblidusuario.Text = "";
            lblIdRol.Text = "";
            lblUsuarioId.Text = "";
            lblIdRol.Text = "";
        }
        private void btnLimpiarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Mostrar usuarios = new Mostrar();
            dgvUsuarios.DataSource = usuarios.Mostrar_Usuarios();
        }

        private void tbNombreBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            try
            {

                // comando.Connection = conexion.cn.Open();
                conn.Open();
                string Sqlcommando = "SELECT        dbo.Roles.NombreRol AS 'Roles', dbo.Usuarios.NombreUsuario, dbo.Usuarios.ClaveUsuario, dbo.Usuarios.Pregunta, dbo.Usuarios.Respuesta, dbo.Usuarios.Correo, dbo.Usuarios.Telefono " +
"FROM            dbo.Roles INNER JOIN " +
                         "dbo.UsuarioRoles ON dbo.Roles.IdRol = dbo.UsuarioRoles.IdRol INNER JOIN" +
                        " dbo.Usuarios ON dbo.UsuarioRoles.IdUsuario = dbo.Usuarios.IdUsuario where NombreUsuario Like('" + tbNombreBuscarUsuario.Text + "%')";
                SqlCommand comando = new SqlCommand(Sqlcommando, conn);
                comando.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                dgvUsuarios.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "Error 7 ");
                conn.Close();
            }
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvUsuarios.SelectedRows.Count > 0)
                {
                    cbRolModificarUsuarios.Text = dgvUsuarios.CurrentRow.Cells["Roles"].Value.ToString();
                    tbNombreModificarUsuario.Text = dgvUsuarios.CurrentRow.Cells["NombreUsuario"].Value.ToString();
                    tbPreguntaModificarUsuarios.Text = dgvUsuarios.CurrentRow.Cells["Pregunta"].Value.ToString();
                    tbRespuestaModificarUsuarios.Text = dgvUsuarios.CurrentRow.Cells["Respuesta"].Value.ToString();
                    tbCorreoModificarUsuarios.Text = dgvUsuarios.CurrentRow.Cells["Correo"].Value.ToString();
                    tbTelefonoModificarUsuarios.Text = dgvUsuarios.CurrentRow.Cells["Telefono"].Value.ToString();
                    tbClaveModificarUsuarios.Text = dgvUsuarios.CurrentRow.Cells["ClaveUsuario"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Seleccione una fila por favor");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString(), "Error 3 ");
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                string sqlUPDATE;
                
                UsuarioIdMod();
                sqlUPDATE = "Update Usuarios Set NombreUsuario = '" + tbNombreModificarUsuario.Text + "', " +
                    "ClaveUsuario = '" + tbClaveModificarUsuarios.Text + "', Pregunta = '" + tbPreguntaModificarUsuarios.Text + "', Respuesta = '" + tbRespuestaModificarUsuarios.Text +
                    "', Correo = '" + tbCorreoModificarUsuarios.Text + "', Telefono = '" + tbTelefonoModificarUsuarios.Text + "'" +
                    "Where IdUsuario = '" + int.Parse(lblUsuarioId.Text) + "'";
                SqlCommand cmd = new SqlCommand(sqlUPDATE, conn);
                conn.Open();
                cmd.ExecuteNonQuery();

                conn.Close();
                RolIdMod();
                RolIdMod1();
                string sqlUPDATE1;
                sqlUPDATE1 = "Update UsuarioRoles Set IdUsuario = '" + int.Parse(lblUsuarioId.Text) + "', " +
                    "IdRol = '" + int.Parse(lblIdRol.Text) + "'Where IdUsuarioRoles = '" + int.Parse(lblIdUsuarioRol.Text) + "'";
                SqlCommand cmd1 = new SqlCommand(sqlUPDATE1, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                
                conn.Close();

                MessageBox.Show("Registro modificado...", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
                conn.Close();
            }




            Mostrar usuarios = new Mostrar();
            dgvUsuarios.DataSource = usuarios.Mostrar_Usuarios();
        }

        private void pRegistrosUsuarios_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
