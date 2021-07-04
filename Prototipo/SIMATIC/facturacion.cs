using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMATIC
{
    public partial class facturacion : Form
    {
        public facturacion()
        {
            InitializeComponent();
        }
        

        private void btnagregar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        public void DATOS()
        {
            TXTVALORTOTAL1.Text = Convert.ToString(Convert.ToDouble(TXTCANTIDAD1.Text) * Convert.ToDouble(TXTVALORUNITARIO1.Text));
            TXTVALORTOTAL2.Text = Convert.ToString(Convert.ToDouble(TXTCANTIDAD2.Text) * Convert.ToDouble(TXTVALORUNITARIO2.Text));
            TXTVALORTOTAL3.Text = Convert.ToString(Convert.ToDouble(TXTCANTIDAD3.Text) * Convert.ToDouble(TXTVALORUNITARIO3.Text));
            TXTVALORTOTAL4.Text = Convert.ToString(Convert.ToDouble(TXTCANTIDAD4.Text) * Convert.ToDouble(TXTVALORUNITARIO4.Text));
            TXTVALORTOTAL5.Text = Convert.ToString(Convert.ToDouble(TXTCANTIDAD5.Text) * Convert.ToDouble(TXTVALORUNITARIO5.Text));
            TXTVALORTOTAL6.Text = Convert.ToString(Convert.ToDouble(TXTCANTIDAD6.Text) * Convert.ToDouble(TXTVALORUNITARIO6.Text));
            TXTVALORTOTAL7.Text = Convert.ToString(Convert.ToDouble(TXTCANTIDAD7.Text) * Convert.ToDouble(TXTVALORUNITARIO7.Text));
            TXTVALORTOTAL8.Text = Convert.ToString(Convert.ToDouble(TXTCANTIDAD8.Text) * Convert.ToDouble(TXTVALORUNITARIO8.Text));
            TXTVALORTOTAL9.Text = Convert.ToString(Convert.ToDouble(TXTCANTIDAD9.Text) * Convert.ToDouble(TXTVALORUNITARIO9.Text));
            TXTVALORTOTAL10.Text = Convert.ToString(Convert.ToDouble(TXTCANTIDAD10.Text) * Convert.ToDouble(TXTVALORUNITARIO10.Text));
            TXTVALORTOTAL11.Text = Convert.ToString(Convert.ToDouble(TXTCANTIDAD11.Text) * Convert.ToDouble(TXTVALORUNITARIO11.Text));
            TXTVALORTOTAL12.Text = Convert.ToString(Convert.ToDouble(TXTCANTIDAD12.Text) * Convert.ToDouble(TXTVALORUNITARIO12.Text));
            TXTVALORTOTAL13.Text = Convert.ToString(Convert.ToDouble(TXTCANTIDAD13.Text) * Convert.ToDouble(TXTVALORUNITARIO13.Text));
            TXTVALORTOTAL14.Text = Convert.ToString(Convert.ToDouble(TXTCANTIDAD14.Text) * Convert.ToDouble(TXTVALORUNITARIO14.Text));
            textBox77.Text = Convert.ToString(Convert.ToDouble(TXTVALORTOTAL1.Text) + Convert.ToDouble(TXTVALORTOTAL2.Text) + Convert.ToDouble(TXTVALORTOTAL3.Text) + Convert.ToDouble(TXTVALORTOTAL4.Text)
                + Convert.ToDouble(TXTVALORTOTAL5.Text) + Convert.ToDouble(TXTVALORTOTAL6.Text) + Convert.ToDouble(TXTVALORTOTAL7.Text) + Convert.ToDouble(TXTVALORTOTAL8.Text) + Convert.ToDouble(TXTVALORTOTAL9.Text)
                + Convert.ToDouble(TXTVALORTOTAL10.Text) + Convert.ToDouble(TXTVALORTOTAL11.Text) + Convert.ToDouble(TXTVALORTOTAL12.Text) + Convert.ToDouble(TXTVALORTOTAL13.Text) + Convert.ToDouble(TXTVALORTOTAL14.Text));
        }
        public void clean() {
            TXTVALORTOTAL1.Text = "0";
            TXTCANTIDAD1.Text = "0";
            TXTVALORUNITARIO1.Text = "0";
            TXTVALORTOTAL2.Text = "0";
            TXTCANTIDAD2.Text = "0";
            TXTVALORUNITARIO2.Text = "0";
            TXTVALORTOTAL3.Text = "0";
            TXTCANTIDAD3.Text = "0";
            TXTVALORUNITARIO3.Text = "0";
            TXTVALORTOTAL4.Text = "0";
            TXTCANTIDAD4.Text = "0";
            TXTVALORUNITARIO4.Text = "0";
            TXTVALORTOTAL5.Text = "0";
            TXTCANTIDAD5.Text = "0";
            TXTVALORUNITARIO5.Text = "0";
            TXTVALORTOTAL6.Text = "0";
            TXTCANTIDAD6.Text = "0";
            TXTVALORUNITARIO6.Text = "0";
            TXTVALORTOTAL7.Text = "0";
            TXTCANTIDAD7.Text = "0";
            TXTVALORUNITARIO7.Text = "0";
            TXTVALORTOTAL8.Text = "0";
            TXTCANTIDAD8.Text = "0";
            TXTVALORUNITARIO8.Text = "0";
            TXTVALORTOTAL9.Text = "0";
            TXTCANTIDAD9.Text = "0";
            TXTVALORUNITARIO9.Text = "0";
            TXTVALORTOTAL10.Text = "0";
            TXTCANTIDAD10.Text = "0";
            TXTVALORUNITARIO10.Text = "0";
            TXTVALORTOTAL11.Text = "0";
            TXTCANTIDAD11.Text = "0";
            TXTVALORUNITARIO11.Text = "0";
            TXTVALORTOTAL12.Text = "0";
            TXTCANTIDAD12.Text = "0";
            TXTVALORUNITARIO12.Text = "0";
            TXTVALORTOTAL13.Text = "0";
            TXTCANTIDAD13.Text = "0";
            TXTVALORUNITARIO13.Text = "0";
            TXTVALORTOTAL14.Text = "0";
            TXTCANTIDAD14.Text = "0";
            TXTVALORUNITARIO14.Text = "0";
            textBox77.Text = "0";

            TXTCLIENTE.Text = "";
            NIT.Text = "";
            NRC.Text = "";
            TXTDIRECCION.Text = "";
            TXTFECHA.Text = "";
            TXTIDFACTURA.Text = "";

            TXTDETALLE1.Text = "";
            TXTDETALLE2.Text = "";
            TXTDETALLE3.Text = "";
            TXTDETALLE4.Text = "";
            TXTDETALLE5.Text = "";
            TXTDETALLE6.Text = "";
            TXTDETALLE7.Text = "";
            TXTDETALLE9.Text = "";
            TXTDETALLE10.Text = "";
            TXTDETALLE11.Text = "";
            TXTDETALLE12.Text = "";
            TXTDETALLE13.Text = "";
            TXTDETALLE14.Text = "";
            TXTDETALLE8.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printForm1.Print();  
            clean();
            TXTCLIENTE.Text = "NO";
            this.Visible = false;






        }

        private void facturacion_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            clean();
            TXTCLIENTE.Text = "NO";  
            this.Visible = false;

        }
    }
}
