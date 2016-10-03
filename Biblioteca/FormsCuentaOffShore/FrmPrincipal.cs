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
   
    public partial class FrmPrincipal : Form
    {
        public Del_Actualizar miDelegado;
        private static List<CuentaOffShore> listaCuentaOffShore;
        

        public FrmPrincipal()
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(frmPrincipal_FormClosing); // cerrar por crucesita

        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.SalirDelPrograma(new System.Windows.Forms.FormClosingEventArgs(CloseReason.UserClosing, true));
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e) //cerrar por crucesita
        {
            this.SalirDelPrograma(e);
        }

        private void SalirDelPrograma(FormClosingEventArgs evento)
        {
            if (MessageBox.Show("¿Esta seguro que quiere Salir?", "Salir", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)

                evento.Cancel = true;

            else
                    this.Dispose();
       
        }




        static FrmPrincipal()
        {
            listaCuentaOffShore = new List<CuentaOffShore>();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            this.toolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (Biblioteca.eTipoOrdenamiento enumeracion in Enum.GetValues(typeof(Biblioteca.eTipoOrdenamiento)))
            {
                this.toolStripComboBox1.Items.Add(enumeracion);
            }

            this.toolStripComboBox1.SelectedIndex = 1;

        }

        private void CargarLista()
        {
            FrmCuentaOffShore frm = new FrmCuentaOffShore();

            frm.WindowState = FormWindowState.Normal;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
           

            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                listaCuentaOffShore.Add(frm.cuentaOff);
                CargarListado(listaCuentaOffShore,this.listBoxPrincipal);

            }
        }


        public static void CargarListado(List<CuentaOffShore> lista,ListBox box)
        {
            box.Items.Clear();

            foreach (CuentaOffShore cuenta in lista)
            {
                box.Items.Add(cuenta);
            }
        }

        public static List<CuentaOffShore> OrdenarListado(List<CuentaOffShore> listaAOrdenar, eTipoOrdenamiento Criterio)
        {
            Comparison<CuentaOffShore> Comparador = null;


            switch (Criterio)

            {
                case eTipoOrdenamiento.PorNroCuenta:
                  
                        Comparador = new Comparison<CuentaOffShore>(CuentaOffShore.OrdenarPorNumeroCuenta);
                   //    Comparador += CuentaOffShore.OrdenarPorNumeroCuenta;   // probar
                    break;
                case eTipoOrdenamiento.PorParaisoFiscal:

                    Comparador = new Comparison<CuentaOffShore>(CuentaOffShore.OrdenarPorParaiso);
                    
                    break;
                case eTipoOrdenamiento.PorTitular:
                    
                        Comparador = new Comparison<CuentaOffShore>(CuentaOffShore.OrdenarPorTitular);
                    break;
                  
                default:
                    break;
            }

            listaAOrdenar.Sort(Comparador);

            return listaAOrdenar;
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CargarLista();
        }

        private void listBoxPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bajaToolStripMenuItem.Click += new EventHandler(this.ManejadorCentral);
            this.modificarToolStripMenuItem.Click += this.ManejadorCentral;
            this.listBoxPrincipal.SelectedIndexChanged -= listBoxPrincipal_SelectedIndexChanged;
        }

        public void ManejadorCentral(object sender, EventArgs e)
        {
            this.bajaToolStripMenuItem.Click -= new EventHandler(this.ManejadorCentral);
            this.modificarToolStripMenuItem.Click -= this.ManejadorCentral;
            this.listBoxPrincipal.SelectedIndexChanged += listBoxPrincipal_SelectedIndexChanged;
            CuentaOffShore auxCuentaOff = ((CuentaOffShore)this.listBoxPrincipal.SelectedItem);
            FrmCuentaOffShore miFCO = new FrmCuentaOffShore(auxCuentaOff);


            if ((ToolStripMenuItem)sender == bajaToolStripMenuItem)
            {
                miFCO.WindowState = FormWindowState.Normal;
                miFCO.StartPosition = FormStartPosition.CenterScreen;
                miFCO.ShowDialog();

                if (miFCO.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    listaCuentaOffShore.Remove(auxCuentaOff);
                    miFCO.Close();
                    CargarListado(listaCuentaOffShore, this.listBoxPrincipal);


                }

            }
            else if ((ToolStripMenuItem)sender == modificarToolStripMenuItem)
            {

                miFCO.WindowState = FormWindowState.Normal;
                miFCO.StartPosition = FormStartPosition.CenterScreen;
                miFCO.ShowDialog();

                if (miFCO.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    listaCuentaOffShore.Remove(auxCuentaOff);
                    listaCuentaOffShore.Add(miFCO.cuentaOff);
                    miFCO.Close();

                    CargarListado(listaCuentaOffShore, this.listBoxPrincipal);


                }

            }
          



        }

        private void mostrarListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmMostrar formularioMostrar = new FrmMostrar();
           
            formularioMostrar.Show();




        }
    }
}
