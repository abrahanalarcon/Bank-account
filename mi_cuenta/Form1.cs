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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            platafroma signin = new platafroma();   // contructor ,es creado parra llamar al 2do form
                                                    // declaración e inicialización de un objeto
                                                    // los contructores son para llamar form o clases 

            signin.datos = "Hola, " + txtAccountHolder.Text + " Bienvenido a tu cuenta bancaria no. " + txtAccountNumber.Text;
          
            signin.Show();


        }
    }
}
