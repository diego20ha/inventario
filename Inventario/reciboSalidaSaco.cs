//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventario
{
    using System;
    using System.Collections.Generic;
    
    public partial class reciboSalidaSaco
    {
        public int idrecibosalidasacos { get; set; }
        public int idrecibosalida { get; set; }
        public int cantidad { get; set; }
        public string tipo { get; set; }
        public double tara { get; set; }
    
        public virtual reciboSalida reciboSalida { get; set; }
    }
}