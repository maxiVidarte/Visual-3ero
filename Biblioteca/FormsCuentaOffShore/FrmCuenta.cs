using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormsCuentaOffShore
{
    public partial class FrmCuenta : Form
    {
        protected Biblioteca.Cuenta _cuenta;

        public Biblioteca.Cuenta Cuenta
        {
            get { return this._cuenta; }
        }
        public FrmCuenta()
        {
            InitializeComponent();
        }

        protected virtual void btnAceptar_Click(object sender, EventArgs e)
        {

           
            this.DialogResult = DialogResult.OK;
          
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

       
    }
}
