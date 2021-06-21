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
    public partial class Clientes : Form
    {
        private SqlConnection conn;
        private SqlCommand insert1;
        private string sCn;

        public Clientes()
        {
            InitializeComponent();

            conexion.conec();

            //agrego la variable scn a la cadena conexión
            sCn = conexion.cadena;
            //creo la conexión pensándole como argumento la cadena
            conn = new SqlConnection(sCn);
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            pAddCliente.Visible = true;
            pRegistrosCliente.Visible = false;
        }

        private void btnRegistroCliente_Click(object sender, EventArgs e)
        {
            pRegistrosCliente .Visible = true;
            pAddCliente.Visible = false;

        }     

        
        private void btnCerrarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            tbNRCCliente.Text = "";
            tbNombreCliente.Text = "";
            tbNITCliente.Text = "";
            tbDireccionCliente.Text = "";
            tbGiroCliente.Text = "";




        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // creo la variable que contendrá la consulta sql de inserción
                string insercliente;
                insercliente = ("INSERT INTO Clientes(NRC,NombreCliente,NIT,Direccion,Giro)");
                insercliente += "VALUES( @NRC,@NombreCliente,@NIT,@Direccion,@Giro)";
                insert1 = new SqlCommand(insercliente, conn);
                insert1.Parameters.Add(new SqlParameter("@NRC", SqlDbType.VarChar));
                insert1.Parameters["@NRC"].Value = tbNRCCliente.Text;
                insert1.Parameters.Add(new SqlParameter("@NombreCliente", SqlDbType.VarChar));
                insert1.Parameters["@NombreCliente"].Value = tbNombreCliente.Text;
                insert1.Parameters.Add(new SqlParameter("@NIT", SqlDbType.VarChar));
                insert1.Parameters["@NIT"].Value = tbNITCliente.Text;
                insert1.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar));
                insert1.Parameters["@Direccion"].Value = tbDireccionCliente.Text;
                insert1.Parameters.Add(new SqlParameter("@Giro", SqlDbType.VarChar));
                insert1.Parameters["@Giro"].Value = tbGiroCliente.Text;

                insert1.ExecuteNonQuery();
                //Limpiamos los textBox

                tbNRCCliente.Text = "";
                tbNombreCliente.Text = "";
                tbNITCliente.Text = "";
                tbDireccionCliente.Text = "";
                tbGiroCliente.Text = "";

                Mostrar prod = new Mostrar();
                dgvClientes.DataSource = prod.Mostrar_Clientes();

                MessageBox.Show("CLIENTE AGREGADO", "Simatic");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
                conn.Close();
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            Mostrar prod = new Mostrar();
            dgvClientes.DataSource = prod.Mostrar_Clientes();

            toolTip1.SetToolTip(this.Limpiar, "Limpiar campos");
            toolTip1.SetToolTip(this.btnEliminarCliente, "Eliminar Cliente");
            toolTip1.SetToolTip(this.btnModificar, "Actualizar Cliente");
            toolTip1.SetToolTip(this.btnCerrarCliente, "Cerrar Ventana");
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    tbNRCModificar.Text = dgvClientes.CurrentRow.Cells["NRC"].Value.ToString();
                    tbNombreModificar.Text = dgvClientes.CurrentRow.Cells["NombreCliente"].Value.ToString();
                   tbNITModificar.Text = dgvClientes.CurrentRow.Cells["NIT"].Value.ToString();
                    tbDireccionModificar.Text = dgvClientes.CurrentRow.Cells["Direccion"].Value.ToString();
                    tbGiroModificar.Text = dgvClientes.CurrentRow.Cells["Giro"].Value.ToString();
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

        private void tbNombreClienteBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {

                // comando.Connection = conexion.cn.Open();
                conn.Open();
                string Sqlcommando = "select * from Clientes where NombreCliente Like('" + tbNombreClienteBuscar.Text + "%')";
                SqlCommand comando = new SqlCommand(Sqlcommando, conn);
                comando.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                dgvClientes.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "Error 7 ");
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbNRCModificar.Text = "";
            tbNombreModificar.Text = "";
            tbNITModificar.Text = "";
            tbDireccionModificar.Text = "";
            tbGiroModificar.Text = "";
        }

        private void Reset()
        {
            tbNRCModificar.Text = "";
            tbNombreModificar.Text = "";
            tbNITModificar.Text = "";
            tbDireccionModificar.Text = "";
            tbGiroModificar.Text = "";

            tbNRCCliente.Text = "";
            tbNombreCliente.Text = "";
            tbNITCliente.Text = "";
            tbDireccionCliente.Text = "";
            tbGiroCliente.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                //int ID = int.Parse(tbNRCModificar.Text);

                string actualizar;
                actualizar = "update Clientes set ";
                actualizar += " NombreCliente= '" + tbNombreModificar.Text + "', NIT= '" +
                tbNITModificar.Text;
                actualizar += "', Direccion='" + tbDireccionModificar.Text + "', Giro= '" + tbGiroModificar.Text + "' where NRC= '" + tbNRCModificar.Text + "'";

                SqlCommand datos = new SqlCommand(actualizar, conn);
                conn.Open();
                //mandando sql a base de datos
                datos.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("CLIENTE ACTUALIZADO", "Simatic");

                Mostrar prod = new Mostrar();
                dgvClientes.DataSource = prod.Mostrar_Clientes();


                Reset();
            }


            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString(), "Error 6 ");
                conn.Close();
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
             try
            {
                string eliminar;
                eliminar = "delete Clientes  ";
                eliminar += " where NRC= '" + tbNRCModificar.Text + "'";

                SqlCommand datos = new SqlCommand(eliminar, conn);
                conn.Open();
                //mandando sql a base de datos
                datos.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("CLIENTE ELIMINADO","Simatic");

                Mostrar prod = new Mostrar();
                dgvClientes.DataSource = prod.Mostrar_Clientes();

                conn.Close();

                Reset();
            }
             catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString(), "Error 6 ");
                conn.Close();
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
         
        }
    }

