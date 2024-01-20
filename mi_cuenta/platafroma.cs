using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mi_cuenta
{
    public partial class platafroma : Form
    {

        public string datos;    //ES UNA VARIABLE  PUBLICA 
        public platafroma()
        {
            InitializeComponent();
        }

        //Funcion de crear texto
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        //boton para el balance
        private void btnBalance_Click(object sender, EventArgs e)
        {
            Cuenta ac = new Cuenta(); //se crea un constructor
            ac.get_balance();   //se llama la funcion 
        }

        //boton para el Depositar
        private void btnDepositar_Click(object sender, EventArgs e)
        {
            Form formu = new Deposito(); // se crea cualquier variable para llamar el nuevo form
            formu.ShowDialog();    // con su funcion 
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            Form frm = new Retiro(); // se crea cualquier variable para llamar el nuevo form
            frm.ShowDialog();  // con su funcion 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void platafroma_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = datos;
        }
    }
}
