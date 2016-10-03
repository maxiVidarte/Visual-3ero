using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cuenta
    {
        protected string _nroCuenta;
        protected string _titular;

        public string NroCuenta
        {
            get
            {
                return _nroCuenta;
            }

            set
            {
                _nroCuenta = value;
            }
        }

        public string Titular
        {
            get
            {
                return _titular;
            }

            set
            {
                _titular = value;
            }
        }


        public Cuenta(string nroCuenta,string titular)
        {
            this._nroCuenta = nroCuenta;
            this._titular = titular;
        }

        public override string ToString()
        {
            return this._titular.ToString() + "   " + this._nroCuenta;

        }



    }

}
