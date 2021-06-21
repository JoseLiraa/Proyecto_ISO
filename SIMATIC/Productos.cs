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
    public partial class Productos : Form
    {
        private SqlConnection conn;
       // private SqlCommand insert1;
        private string sCn;

        public Productos()
        {
            InitializeComponent();
            conexion.conec();

            //agrego la variable scn a la cadena conexión
            sCn = conexion.cadena;
            //creo la conexión pensándole como argumento la cadena
            conn = new SqlConnection(sCn);
        }

        private void btnCerrarProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            pAddProducto.Visible = true;
            pRegistrosProductos.Visible = false;
        }

        private void btnRegistroProducto_Click(object sender, EventArgs e)
        {
            pRegistrosProductos.Visible = true;
            pAddProducto.Visible = false;
        }

        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            tbCodigoProducto.Text = "";
            tbDescripcionProducto.Text = "";
            tbUnidadesProducto.Text = "";
            tbPrecioCostoProducto.Text = "";
            tbPrecioVentaProducto.Text = "";
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                                                  
                    SqlCommand cmd = new SqlCommand("sp_InsertarProducto", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@CodigoProducto", SqlDbType.VarChar, 30);
                    cmd.Parameters.Add("@NombreProducto", SqlDbType.VarChar,100);
                    cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 500);
                    cmd.Parameters.Add("@Existencia", SqlDbType.Int);
                    cmd.Parameters.Add("@PrecioCosto", SqlDbType.Money);
                    cmd.Parameters.Add("@PrecioVenta", SqlDbType.Money);


                    cmd.Parameters["@CodigoProducto"].Value = tbCodigoProducto.Text;
                    cmd.Parameters["@NombreProducto"].Value = tbNombreProducto.Text;
                    cmd.Parameters["@Descripcion"].Value = tbDescripcionProducto.Text;
                    cmd.Parameters["@Existencia"].Value = tbUnidadesProducto.Text;
                    cmd.Parameters["@PrecioCosto"].Value = Convert.ToDecimal(tbPrecioCostoProducto.Text);
                    cmd.Parameters["@PrecioVenta"].Value = Convert.ToDecimal(tbPrecioVentaProducto.Text);
                
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Producto Registrado", "Aplicacion Control de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                //Se actualiza el datagrid que contiene los datos de los productos
                    Mostrar prod = new Mostrar();
                    dgvProductos.DataSource = prod.Mostrar_Productos();

                    conn.Close();

                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
            
        }
        public void Limpiar()
    {
           tbNombreProducto.Text = "";
           tbCodigoProducto.Text = "";
           tbDescripcionProducto.Text = "";
           tbUnidadesProducto.Text = "";
           tbPrecioCostoProducto.Text = "";
           tbPrecioVentaProducto.Text = "";
    }

        private void Productos_Load(object sender, EventArgs e)
        {
            Mostrar prod = new Mostrar();
            dgvProductos.DataSource = prod.Mostrar_Productos();

            toolTip1.SetToolTip(this.btnlimpiar, "Limpiar Campos");
            toolTip1.SetToolTip(this.btnEliminarProducto, "Eliminar Producto");
            toolTip1.SetToolTip(this.btnCerrarProducto, "Cerrar Ventana");
            toolTip1.SetToolTip(this.btnModificarProducto, "Actualizar Producto");
        }

        private void NProdBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {

                // comando.Connection = conexion.cn.Open();
                conn.Open();
                string Sqlcommando = "select * from Productos where NombreProducto Like('" + NProdBuscar.Text + "%')";
                SqlCommand comando = new SqlCommand(Sqlcommando, conn);
                comando.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                dgvProductos.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "Error 7 ");
                conn.Close();
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {

               // int ID = int.Parse(tbCodigoModificarProducto.Text);

                string actualizar;
                actualizar = "update Productos set ";
                actualizar += " NombreProducto= '" + NombreProd.Text + "', Descripcion= '" +
                tbDescripcionModificarProducto.Text;
                actualizar += "', Existencia='" + tbUnidadesModificarProducto.Text + "', PrecioCosto= '" + tbPCostoModificarProducto.Text + "',PrecioVenta='" + tbPVentaModificarProducto.Text + "' where CodigoProducto= '" + tbCodigoModificarProducto.Text + "'";

                SqlCommand datos = new SqlCommand(actualizar, conn);
                conn.Open();
                //mandando sql a base de datos
                datos.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("PRODUCTO ACTUALIZADO", "Simatic");

                Mostrar prod = new Mostrar();
                dgvProductos.DataSource = prod.Mostrar_Productos();


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
            tbNombreProducto.Text = "";
            tbCodigoProducto.Text = "";
            tbDescripcionProducto.Text = "";
            tbUnidadesProducto.Text = "";
            tbPrecioCostoProducto.Text = "";
            tbPrecioVentaProducto.Text = "";

            tbCodigoModificarProducto.Text = "";
            NombreProd.Text = "";
            tbDescripcionModificarProducto.Text = "";
            tbUnidadesModificarProducto.Text = "";
            tbPCostoModificarProducto.Text = "";
            tbPVentaModificarProducto.Text = "";

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string eliminar;
                eliminar = "delete Productos  ";
                eliminar += " where CodigoProducto= '" + tbCodigoModificarProducto.Text + "'";

                SqlCommand datos = new SqlCommand(eliminar, conn);
                conn.Open();
                //mandando sql a base de datos
                datos.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("PRODUCTO ELIMINADO", "Simatic");

                Mostrar prod = new Mostrar();
                dgvProductos.DataSource = prod.Mostrar_Productos();

                conn.Close();

                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString(), "Error 6 ");
                conn.Close();
            }
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    tbCodigoModificarProducto.Text = dgvProductos.CurrentRow.Cells["CodigoProducto"].Value.ToString();
                    NombreProd.Text = dgvProductos.CurrentRow.Cells["NombreProducto"].Value.ToString();
                    tbDescripcionModificarProducto.Text = dgvProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                    tbUnidadesModificarProducto.Text = dgvProductos.CurrentRow.Cells["Existencia"].Value.ToString();
                    tbPCostoModificarProducto.Text = dgvProductos.CurrentRow.Cells["PrecioCosto"].Value.ToString();
                    tbPVentaModificarProducto.Text = dgvProductos.CurrentRow.Cells["PrecioVenta"].Value.ToString();
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
    }
}
