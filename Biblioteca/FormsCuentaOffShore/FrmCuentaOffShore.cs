using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace FormsCuentaOffShore
{
    public partial class FrmCuentaOffShore : FrmCuenta
    {

        private CuentaOffShore _cuentaOff;

        public CuentaOffShore cuentaOff
        {
            get { return _cuentaOff; }
        }


        public FrmCuentaOffShore()
        {
            InitializeComponent();

            this.cboBoxParaiso.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (Biblioteca.eParaisoFiscal enumeracion in Enum.GetValues(typeof(Biblioteca.eParaisoFiscal)))
            {
                this.cboBoxParaiso.Items.Add(enumeracion);
            }

            this.cboBoxParaiso.SelectedIndex = 0;

            this.txtTitular.Focus();
        }

        public FrmCuentaOffShore(CuentaOffShore a):this()
        {
           
            txtNroCuenta.Text = a.NroCuenta;
            txtTitular.Text = a.Titular;
            this.cboBoxParaiso.SelectedIndex = Convert.ToInt32(a.ParaisoFiscal);


        }
        private void FrmCuentaOffShore_Load(object sender, EventArgs e)
        {
            
        }


        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            
          _cuentaOff = new CuentaOffShore(this.txtNroCuenta.Text, this.txtTitular.Text, (eParaisoFiscal)this.cboBoxParaiso.SelectedIndex);
            base.btnAceptar_Click( sender,  e);
            Close();

        
        }


    }
}
