using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    //Subclase de Exception (superclase)
    public class ApiException : Exception
    {
        //Constructor (método inicializador)
        //Anulando el constructor predeterminado vacío => public Clase() {}
        //base(message)
        public ApiException(string message) : base(message) { }
    }
}
