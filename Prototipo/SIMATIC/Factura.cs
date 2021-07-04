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
    public partial class Factura : Form
    {
        private SqlConnection conn;
        
        private string sCn;
        private SqlDataAdapter da1;
        private SqlDataReader dr1;

        public Factura()
        {
            InitializeComponent();

            conexion.conec();

            //agrego la variable scn a la cadena conexión
            sCn = conexion.cadena;
            //creo la conexión pensándole como argumento la cadena
            conn = new SqlConnection(sCn);
            n = 0;

        }
        double n;
        facturacion gg = new facturacion();
        facturacioncreditocs ggg = new facturacioncreditocs();
        public void llenarDatosCliente()
        {
            DataSet dataSet = new DataSet();
            DataSet ds = dataSet;
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT NombreCliente FROM Clientes", conn);
            da.Fill(ds, "Clientes");
            NombreCliente.DataSource = ds.Tables[0].DefaultView;
            NombreCliente.ValueMember = "NombreCliente";

        }
        public void llenarDatosProductos()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT NombreProducto FROM Productos", conn);
            da.Fill(ds, "Productos");
            NombreProd.DataSource = ds.Tables[0].DefaultView;
            NombreProd.ValueMember = "NombreProducto";

        }
        private void NombreCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                conn.Open();


                string nom = NombreCliente.Text;
                string seleccion;
                seleccion = "SELECT NRC, NIT, Direccion, Giro FROM Clientes WHERE NombreCliente = '" + nom + "'";
                da1 = new SqlDataAdapter(seleccion, conn);
                SqlParameter prm = new SqlParameter("NombreCliente", SqlDbType.VarChar);


                prm.Value = nom;
                da1.SelectCommand.Parameters.Add(prm);
                dr1 = da1.SelectCommand.ExecuteReader();
                
                while (dr1.Read())
                {
                    nrc.Text = dr1["NRC"].ToString().Trim();
                    nit.Text = dr1["NIT"].ToString().Trim();
                    direccion.Text = dr1["Direccion"].ToString().Trim();
                    giro.Text = dr1["Giro"].ToString().Trim();
                   
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString(), "error 10");
                conn.Close();

            }
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            llenarDatosCliente();
            llenarDatosProductos();

           // ToolTip mensaje = new ToolTip();
            toolTip1.SetToolTip(this.btnLimpiarProducto, "Limpiar campos");
            toolTip1.SetToolTip(this.AgregarProducto, "Agregar Producto");
            toolTip1.SetToolTip(this.btnCerrarProducto, "Cerrar Ventana");
        }

        private void NombreProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CantidadVendida.Value = 0;

                conn.Open();


                string nom = NombreProd.Text;
                string seleccion;
                seleccion = "SELECT CodigoProducto, PrecioVenta, Existencia FROM Productos WHERE NombreProducto = '" + nom + "'";
                da1 = new SqlDataAdapter(seleccion, conn);
                SqlParameter prm = new SqlParameter("NombreProducto", SqlDbType.VarChar);


                prm.Value = nom;
                da1.SelectCommand.Parameters.Add(prm);
                dr1 = da1.SelectCommand.ExecuteReader();
                
                while (dr1.Read())
                {
                    CodProd.Text = dr1["CodigoProducto"].ToString().Trim();
                    PrecioUnitario.Text = dr1["PrecioVenta"].ToString().Trim();
                    Disponible.Text = dr1["Existencia"].ToString().Trim();
                    
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString(), "error 10");
                conn.Close();

            }
        }

        private void CantidadVendida_ValueChanged(object sender, EventArgs e)
        {
            if (Disponible.Text == "")
            {

            }
            else
            {



                if (UnidadesRestantes.Text.Equals(0))
                {
                    CantidadVendida.Value = 0;


                }
                else
                {
                    try
                    {
                        if (CantidadVendida.Value <= int.Parse(Disponible.Text) && CantidadVendida.Value >= 0)
                        {

                            UnidadesRestantes.Text = (int.Parse(Disponible.Text) - (CantidadVendida.Value)).ToString();

                        }
                        else
                        {
                            MessageBox.Show("No se puede agregar una cantidad mayor o menor a la disponible");
                            CantidadVendida.Value = 0;
                        }

                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }


                }
            }
            
        }

        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            btnConsumidorFinal.Checked = false;
            BtnCreditoFiscal.Checked = false;
            CantidadVendida.Value = 0;
            //Datos Clientes Clear
            NombreCliente.Text = "";
            nrc.Text = "";
            nit.Text = "";
            giro.Text = "";
            direccion.Text = "";
            //Datos Producto Clear
            NombreProd.Text = "";
            CodProd.Text = "";
            PrecioUnitario.Text = "";
            Disponible.Text = "";
            UnidadesRestantes.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public void actualiar()
        { 
            try
            {


                string actualizar;
                actualizar = "update Productos set ";
                actualizar += " Existencia= '" + UnidadesRestantes.Text + "' where CodigoProducto= '" + CodProd.Text + "'";
                SqlCommand datos = new SqlCommand(actualizar, conn);
                conn.Open();
                //mandando sql a base de datos
                datos.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Producto ACTUALIZADO", "Simatic");

            }


            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString(), "Error 6 ");
                conn.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (NombreProd.Text == "" || CantidadVendida.Value == 0 || !btnConsumidorFinal.Checked == true && !BtnCreditoFiscal.Checked == true)
            {
                MessageBox.Show("Favor colocar el código del producto y " +
                    "\nestablezca la cantidad a vender..." + "seleccionar el tipo de factura", "Advertencia...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {

                    if (btnConsumidorFinal.Checked==true)
                    {
                        if (gg.TXTCLIENTE.Text != "NO")
                        {

                            n = n + 1;
                            if (n == 1)

                            {


                                gg.Visible = true;
                                gg.TXTCLIENTE.Text = NombreCliente.Text;
                                gg.NRC.Text = nrc.Text;
                                gg.NIT.Text = nit.Text;
                                gg.TXTIDFACTURA.Text = "001";
                                gg.TXTDIRECCION.Text = direccion.Text;
                                gg.TXTCANTIDAD1.Text = CantidadVendida.Value.ToString();
                                gg.TXTDETALLE1.Text = NombreProd.Text;
                                gg.TXTVALORUNITARIO1.Text = PrecioUnitario.Text;
                                gg.TXTFECHA.Text = dateTimePicker1.Value.ToString();
                                gg.DATOS();
                                actualiar();


                            }
                            else if (n == 2)
                            {
                                gg.Visible = true;

                                gg.TXTCANTIDAD2.Text = CantidadVendida.Value.ToString();
                                gg.TXTVALORUNITARIO2.Text = PrecioUnitario.Text;
                                gg.TXTDETALLE2.Text = NombreProd.Text;
                                gg.DATOS();
                                actualiar();

                            }
                            else if (n == 3)
                            {
                                gg.Visible = true;

                                gg.TXTCANTIDAD3.Text = CantidadVendida.Value.ToString();
                                gg.TXTVALORUNITARIO3.Text = PrecioUnitario.Text;
                                gg.TXTDETALLE3.Text = NombreProd.Text;
                                actualiar();

                            }
                            else if (n == 4)
                            {
                                gg.Visible = true;

                                gg.TXTCANTIDAD4.Text = CantidadVendida.Value.ToString();
                                gg.TXTVALORUNITARIO4.Text = PrecioUnitario.Text;
                                gg.TXTDETALLE4.Text = NombreProd.Text;
                                gg.DATOS();
                                actualiar();
                            }
                            else if (n == 5)
                            {
                                gg.Visible = true;

                                gg.TXTCANTIDAD5.Text = CantidadVendida.Value.ToString();
                                gg.TXTVALORUNITARIO5.Text = PrecioUnitario.Text;
                                gg.TXTDETALLE5.Text = NombreProd.Text;
                                gg.DATOS();
                                actualiar();
                            }
                            else if (n == 6)
                            {

                                gg.Visible = true;

                                gg.TXTCANTIDAD6.Text = CantidadVendida.Value.ToString();
                                gg.TXTVALORUNITARIO6.Text = PrecioUnitario.Text;
                                gg.TXTDETALLE6.Text = NombreProd.Text;
                                gg.DATOS();
                                actualiar();
                            }
                            else if (n == 7)
                            {

                                gg.Visible = true;

                                gg.TXTCANTIDAD7.Text = CantidadVendida.Value.ToString();
                                gg.TXTVALORUNITARIO7.Text = PrecioUnitario.Text;
                                gg.TXTDETALLE7.Text = NombreProd.Text;
                                gg.DATOS();
                                actualiar();
                            }
                            else if (n == 8)
                            {

                                gg.Visible = true;

                                gg.TXTCANTIDAD8.Text = CantidadVendida.Value.ToString();
                                gg.TXTVALORUNITARIO8.Text = PrecioUnitario.Text;
                                gg.TXTDETALLE8.Text = NombreProd.Text;
                                gg.DATOS();
                                actualiar();
                            }
                            else if (n == 9)
                            {

                                gg.Visible = true;

                                gg.TXTCANTIDAD9.Text = CantidadVendida.Value.ToString();
                                gg.TXTVALORUNITARIO9.Text = PrecioUnitario.Text;
                                gg.TXTDETALLE9.Text = NombreProd.Text;
                                gg.DATOS();
                                actualiar();
                            }
                            else if (n == 10)
                            {

                                gg.Visible = true;

                                gg.TXTCANTIDAD10.Text = CantidadVendida.Value.ToString();
                                gg.TXTVALORUNITARIO10.Text = PrecioUnitario.Text;
                                gg.TXTDETALLE10.Text = NombreProd.Text;
                                gg.DATOS();
                                actualiar();
                            }
                            else if (n == 11)
                            {

                                gg.Visible = true;

                                gg.TXTCANTIDAD11.Text = CantidadVendida.Value.ToString();
                                gg.TXTVALORUNITARIO11.Text = PrecioUnitario.Text;
                                gg.TXTDETALLE11.Text = NombreProd.Text;
                                gg.DATOS();
                                actualiar();
                            }
                            else if (n == 12)
                            {

                                gg.Visible = true;

                                gg.TXTCANTIDAD12.Text = CantidadVendida.Value.ToString();
                                gg.TXTVALORUNITARIO12.Text = PrecioUnitario.Text;
                                gg.TXTDETALLE12.Text = NombreProd.Text;
                                gg.DATOS();
                                actualiar();
                            }
                            else if (n == 13)
                            {

                                gg.Visible = true;

                                gg.TXTCANTIDAD13.Text = CantidadVendida.Value.ToString();
                                gg.TXTVALORUNITARIO13.Text = PrecioUnitario.Text;
                                gg.TXTDETALLE13.Text = NombreProd.Text;
                                gg.DATOS();
                                actualiar();
                            }
                            else if (n == 14)
                            {

                                gg.Visible = true;

                                gg.TXTCANTIDAD14.Text = CantidadVendida.Value.ToString();
                                gg.TXTVALORUNITARIO14.Text = PrecioUnitario.Text;
                                gg.TXTDETALLE14.Text = NombreProd.Text;
                                gg.DATOS();
                                gg.btnagregar.Visible = false;
                            }
                            else if (n == 14)
                            {
                                MessageBox.Show("YA NO HAY ESPACIO POR ''FAVOR HACER OTRA'' ");
                              

                            }
                        }
                        else
                        {
                            n = 2;
                            gg.Visible = true;
                            gg.TXTCLIENTE.Text = NombreCliente.Text;
                            gg.NRC.Text = nrc.Text;
                            gg.NIT.Text = nit.Text;
                            gg.TXTIDFACTURA.Text = "001";
                            gg.TXTDIRECCION.Text = direccion.Text;
                            gg.TXTCANTIDAD1.Text = CantidadVendida.Value.ToString();
                            gg.TXTDETALLE1.Text = NombreProd.Text;
                            gg.TXTVALORUNITARIO1.Text = PrecioUnitario.Text;
                            gg.TXTFECHA.Text = dateTimePicker1.Value.ToString();
                            gg.DATOS();
                            actualiar();
                        }

                    }
                    else 
                    {
                        if (ggg.TXTCLIENTE.Text != "NO")
                        {

                            n = n + 1;
                            if (n == 1)

                            {


                                ggg.Visible = true;
                                ggg.TXTCLIENTE.Text = NombreCliente.Text;
                                ggg.NRC.Text = nrc.Text;
                                ggg.NIT.Text = nit.Text;
                                ggg.TXTIDFACTURA.Text = "001";
                                ggg.TXTDIRECCION.Text = direccion.Text;
                                ggg.TXTCANTIDAD1.Text = CantidadVendida.Value.ToString();
                                ggg.TXTDETALLE1.Text = NombreProd.Text;
                                ggg.TXTVALORUNITARIO1.Text = PrecioUnitario.Text;
                                ggg.TXTFECHA.Text = dateTimePicker1.Value.ToString();
                                ggg.DATOS();
                                actualiar();


                            }
                            else if (n == 2)
                            {
                                ggg.Visible = true;

                                ggg.TXTCANTIDAD2.Text = CantidadVendida.Value.ToString();
                                ggg.TXTVALORUNITARIO2.Text = PrecioUnitario.Text;
                                ggg.TXTDETALLE2.Text = NombreProd.Text;
                                ggg.DATOS();
                                actualiar();

                            }
                            else if (n == 3)
                            {
                                ggg.Visible = true;

                                ggg.TXTCANTIDAD3.Text = CantidadVendida.Value.ToString();
                                ggg.TXTVALORUNITARIO3.Text = PrecioUnitario.Text;
                                ggg.TXTDETALLE3.Text = NombreProd.Text;
                                actualiar();

                            }
                            else if (n == 4)
                            {
                                ggg.Visible = true;

                                ggg.TXTCANTIDAD4.Text = CantidadVendida.Value.ToString();
                                ggg.TXTVALORUNITARIO4.Text = PrecioUnitario.Text;
                                ggg.TXTDETALLE4.Text = NombreProd.Text;
                                ggg.DATOS();
                                actualiar();
                            }
                            else if (n == 5)
                            {
                                ggg.Visible = true;

                                ggg.TXTCANTIDAD5.Text = CantidadVendida.Value.ToString();
                                ggg.TXTVALORUNITARIO5.Text = PrecioUnitario.Text;
                                ggg.TXTDETALLE5.Text = NombreProd.Text;
                                ggg.DATOS();
                                actualiar();
                            }
                            else if (n == 6)
                            {

                                ggg.Visible = true;

                                ggg.TXTCANTIDAD6.Text = CantidadVendida.Value.ToString();
                                ggg.TXTVALORUNITARIO6.Text = PrecioUnitario.Text;
                                ggg.TXTDETALLE6.Text = NombreProd.Text;
                                ggg.DATOS();
                                actualiar();
                            }
                            else if (n == 7)
                            {

                                ggg.Visible = true;

                                ggg.TXTCANTIDAD7.Text = CantidadVendida.Value.ToString();
                                ggg.TXTVALORUNITARIO7.Text = PrecioUnitario.Text;
                                ggg.TXTDETALLE7.Text = NombreProd.Text;
                                ggg.DATOS();
                                actualiar();
                            }
                            else if (n == 8)
                            {

                                ggg.Visible = true;

                                ggg.TXTCANTIDAD8.Text = CantidadVendida.Value.ToString();
                                ggg.TXTVALORUNITARIO8.Text = PrecioUnitario.Text;
                                ggg.TXTDETALLE8.Text = NombreProd.Text;
                                ggg.DATOS();
                                actualiar();
                            }
                            else if (n == 9)
                            {

                                ggg.Visible = true;

                                ggg.TXTCANTIDAD9.Text = CantidadVendida.Value.ToString();
                                ggg.TXTVALORUNITARIO9.Text = PrecioUnitario.Text;
                                ggg.TXTDETALLE9.Text = NombreProd.Text;
                                ggg.DATOS();
                                actualiar();
                            }
                            else if (n == 10)
                            {

                                ggg.Visible = true;

                                ggg.TXTCANTIDAD10.Text = CantidadVendida.Value.ToString();
                                ggg.TXTVALORUNITARIO10.Text = PrecioUnitario.Text;
                                ggg.TXTDETALLE10.Text = NombreProd.Text;
                                ggg.DATOS();
                                actualiar();
                            }
                            else if (n == 11)
                            {

                                MessageBox.Show("YA NO HAY ESPACIO POR ''FAVOR HACER OTRA'' ");
                            
                            }
                        }
                        else
                        {
                            n = 2;
                            gg.Visible = true;
                            gg.TXTCLIENTE.Text = NombreCliente.Text;
                            gg.NRC.Text = nrc.Text;
                            gg.NIT.Text = nit.Text;
                            gg.TXTIDFACTURA.Text = "001";
                            gg.TXTDIRECCION.Text = direccion.Text;
                            gg.TXTCANTIDAD1.Text = CantidadVendida.Value.ToString();
                            gg.TXTDETALLE1.Text = NombreProd.Text;
                            gg.TXTVALORUNITARIO1.Text = PrecioUnitario.Text;
                            gg.TXTFECHA.Text = dateTimePicker1.Value.ToString();
                            gg.DATOS();
                            actualiar();
                        }

                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("" + error);
                }

                CantidadVendida.Value = 0;
                NombreProd.Text = "";
                CodProd.Text = "";
                PrecioUnitario.Text = "";
                Disponible.Text = "";
                UnidadesRestantes.Text = "0";
                

            }
        }

        private void btnCerrarProducto_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnConsumidorFinal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarProductoFactura_Click(object sender, EventArgs e)
        {

        }
    }
}
