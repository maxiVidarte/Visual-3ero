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
    public partial class FrmMostrar : Form
    {
        
        public FrmMostrar()
        {
            InitializeComponent();
            
        }


        private void ActualizarListados(List<CuentaOffShore> lista)
        {
            this.LstMostrar.Items.Clear();

            foreach (CuentaOffShore cuenta in lista)
            {
                this.LstMostrar.Items.Add(cuenta.Titular);
            }

        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {

            FrmPrincipal dueño = (FrmPrincipal)this.Owner;
            dueño.miDelegado = new Del_Actualizar(this.ActualizarListados);
        }

        
    }
}
