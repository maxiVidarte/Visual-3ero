using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
     public class CuentaOffShore : Cuenta
    {

        private eParaisoFiscal _paraisoFiscal;

        public eParaisoFiscal ParaisoFiscal
        {
            get
            {
                return _paraisoFiscal;
            }

            set
            {
                _paraisoFiscal = value;
            }
        }

        public CuentaOffShore(string nroCuenta,string titular,eParaisoFiscal paraiso):base(nroCuenta,titular)
        {
            this._paraisoFiscal = paraiso;

        }



        public override string ToString()
        {
            return base.ToString() + " " + this._paraisoFiscal.ToString();
        }

        public static int OrdenarPorNumeroCuenta(CuentaOffShore c1, CuentaOffShore c2)
        {
            return String.Compare(c1._nroCuenta, c2._nroCuenta);
        }

        public static int OrdenarPorParaiso(CuentaOffShore c1, CuentaOffShore c2)
        {
            return String.Compare(c1._paraisoFiscal.ToString(), c2._paraisoFiscal.ToString());
        }
        public static int OrdenarPorTitular(CuentaOffShore c1, CuentaOffShore c2)
        {
            return String.Compare(c1._titular, c2._titular);
        }



    }
}
