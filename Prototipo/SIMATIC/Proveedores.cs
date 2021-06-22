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
    public partial class Proveedores : Form
    {
        private SqlConnection conn;
        private SqlCommand insert1;
        private string sCn;

        public Proveedores()
        {
            InitializeComponent();

            conexion.conec();

            //agrego la variable scn a la cadena conexión
            sCn = conexion.cadena;
            //creo la conexión pensándole como argumento la cadena
            conn = new SqlConnection(sCn);

        }

        private void btnAddProveedores_Click(object sender, EventArgs e)
        {
            if (pRegistrosProveedores.Visible == true)
            {
                pRegistrosProveedores.Visible = false;
                pAddProveedores.Visible = true;
            }
        }

        private void btnRegistroProveedores_Click(object sender, EventArgs e)
        {
            if (pAddProveedores.Visible == true)
            {
                pAddProveedores.Visible = false;
                pRegistrosProveedores.Visible = true;
            }
        }

        private void btnCerrarProveedores_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarProveedores_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // creo la variable que contendrá la consulta sql de inserción
                string insercliente;
                insercliente = ("INSERT INTO Proveedores(CodigoProveedor,NombreProveedor,Telefono,Direccion,Correo)");
                insercliente += "VALUES( @CodigoProveedor,@NombreProveedor,@Telefono,@Direccion,@Correo)";
                insert1 = new SqlCommand(insercliente, conn);
                insert1.Parameters.Add(new SqlParameter("@CodigoProveedor", SqlDbType.VarChar));
                insert1.Parameters["@CodigoProveedor"].Value = codProv.Text;
                    insert1.Parameters.Add(new SqlParameter("@NombreProveedor", SqlDbType.VarChar));
                    insert1.Parameters["@NombreProveedor"].Value = NombreProv.Text;
                insert1.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar));
                insert1.Parameters["@Telefono"].Value = telefonoprov.Text;
                insert1.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar));
                insert1.Parameters["@Direccion"].Value = direccionprov.Text;
                insert1.Parameters.Add(new SqlParameter("@Correo", SqlDbType.VarChar));
                insert1.Parameters["@Correo"].Value = correoprov.Text;

                insert1.ExecuteNonQuery();
                //Limpiamos los textBox

                codProv.Text = "";
                NombreProv.Text = "";
                telefonoprov.Text = "";
                direccionprov.Text = "";
                correoprov.Text = "";

                Mostrar prod = new Mostrar();
                dgvProveedores.DataSource = prod.Mostrar_Proveedores();

                MessageBox.Show("PROVEEDOR AGREGADO", "Simatic");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
                conn.Close();
            }
        }

        private void btnLimpiarProveedores_Click(object sender, EventArgs e)
        {
            codProv.Text = "";
            NombreProv.Text = "";
            telefonoprov.Text = "";
            direccionprov.Text = "";
            correoprov.Text = "";
        }

        private void tbCodigoBuscarProveedores_TextChanged(object sender, EventArgs e)
        {
            try
            {

                // comando.Connection = conexion.cn.Open();
                conn.Open();
                string Sqlcommando = "select * from Proveedores where NombreProveedor Like('" + BuscarProvNom.Text + "%')";
                SqlCommand comando = new SqlCommand(Sqlcommando, conn);
                comando.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                dgvProveedores.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "Error 7 ");
                conn.Close();
            }
        }

        private void btnModificarProveedores_Click(object sender, EventArgs e)
        {
            try
            {

                //int ID = int.Parse(tbCodigoModificarPro.Text);

                string actualizar;
                actualizar = "update Proveedores set ";
                actualizar += " NombreProveedor= '" + tbNombreModificarPro.Text + "', Telefono= '" +
                tbTelModificarPro.Text;
                actualizar += "', Direccion='" + tbDireccionModificarPro.Text + "', Correo= '" + tbCorreoModificarPro.Text + "' where CodigoProveedor= '" + tbCodigoModificarPro.Text + "'";

                SqlCommand datos = new SqlCommand(actualizar, conn);
                conn.Open();
                //mandando sql a base de datos
                datos.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("PROVEEDOR ACTUALIZADO", "Simatic");

                Mostrar prod = new Mostrar();
                dgvProveedores.DataSource = prod.Mostrar_Proveedores();


                Reset();
            }


            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString(), "Error 6 ");
                conn.Close();
            }
        }
        private void Reset()
        {
            codProv.Text = "";
            NombreProv.Text = "";
            telefonoprov.Text = "";
            direccionprov.Text = "";
            correoprov.Text = "";

            tbCodigoModificarPro.Text = "";
            tbNombreModificarPro.Text = "";
            tbTelModificarPro.Text = "";
            tbDireccionModificarPro.Text = "";
            tbCorreoModificarPro.Text = "";


        }

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProveedores.SelectedRows.Count > 0)
                {
                    tbCodigoModificarPro.Text = dgvProveedores.CurrentRow.Cells["CodigoProveedor"].Value.ToString();
                    tbNombreModificarPro.Text = dgvProveedores.CurrentRow.Cells["NombreProveedor"].Value.ToString();
                    tbTelModificarPro.Text = dgvProveedores.CurrentRow.Cells["Telefono"].Value.ToString();
                    tbDireccionModificarPro.Text = dgvProveedores.CurrentRow.Cells["Direccion"].Value.ToString();
                    tbCorreoModificarPro.Text = dgvProveedores.CurrentRow.Cells["Correo"].Value.ToString();
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

        private void Proveedores_Load(object sender, EventArgs e)
        {
            Mostrar prod = new Mostrar();
            dgvProveedores.DataSource = prod.Mostrar_Proveedores();

            toolTip1.SetToolTip(this.btnEliminarProveedores, "Eliminar Proveedor");
            toolTip1.SetToolTip(this.Limpiar, "Limpiar Campos");
            toolTip1.SetToolTip(this.btnCerrarProveedores, "Cerrar Ventana");
            toolTip1.SetToolTip(this.btnModificarProveedores, "Actualizar Proveedor");
            toolTip1.SetToolTip(this.btnGuardarProveedores, "Guardar Proveedor");
            toolTip1.SetToolTip(this.btnLimpiarProveedores, "Limpiar Campos");
        }

        private void btnEliminarProveedores_Click(object sender, EventArgs e)
        {
            try
            {
                string eliminar;
                eliminar = "delete Proveedores  ";
                eliminar += " where CodigoProveedor= '" + tbCodigoModificarPro.Text + "'";

                SqlCommand datos = new SqlCommand(eliminar, conn);
                conn.Open();
                //mandando sql a base de datos
                datos.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("PROVEEDORES ELIMINADO", "Simatic");

                Mostrar prod = new Mostrar();
                dgvProveedores.DataSource = prod.Mostrar_Proveedores();

                conn.Close();

                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString(), "Error 6 ");
                conn.Close();
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            BuscarProvNom.Text = "";
            tbCodigoModificarPro.Text = "";
            tbNombreModificarPro.Text = "";
            tbTelModificarPro.Text = "";
            tbDireccionModificarPro.Text = "";
            tbCorreoModificarPro.Text = "";
        }
    }
}
