using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public class ControlDeUsuario : TextBox
    {

        protected eTipoDato letras;

        public eTipoDato Letras
        {
            get
            {
                return letras;
            }

            set
            {
                letras = value;
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch (Letras)
            {
                case eTipoDato.SoloNumeros:
                    if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back)
                    {
                        e.Handled = true;
                        base.OnKeyPress(e);
                    }
                    break;
                case eTipoDato.SoloLetras:
                    if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                    {
                         e.Handled = true;
                        base.OnKeyPress(e);
                    }
                    break;
              
                default:
                    MessageBox.Show("No se selecciono formato para el cuadro de texto.");
                    break;
            }
        }
    }
}
