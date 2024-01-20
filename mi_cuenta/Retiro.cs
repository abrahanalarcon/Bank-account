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
    public partial class Retiro : Form
    {
        public Retiro()
        {
            InitializeComponent();
        }

        private void txtRetiro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            double ret = 0;  ///creamos la variable
            Double.TryParse(txtRetiro.Text, out ret); //de double a string 
            Cuenta account = new Cuenta(); /// lllamo la clase
            account.withdraw(ret); //llamamos la funcion y dentro de la funcion la varibel 
        }
    }
}
