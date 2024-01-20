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
    public partial class Deposito : Form
    {
        public Deposito()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            double dep = 0;
            Double.TryParse(txtDeposito.Text, out dep);
            Cuenta account = new Cuenta(); /// para llamar a la clase ,tienes que crear variable
                                                      // cuya funcion general se llama contructor 
            account.amount(dep);
        }
    }
}
