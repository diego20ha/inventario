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
    
    public partial class inventario
    {
        public inventario()
        {
            this.reciboEntradas = new HashSet<reciboEntrada>();
            this.ordenTrabajoes = new HashSet<ordenTrabajo>();
            this.reciboSalidas = new HashSet<reciboSalida>();
        }
    
        public int idinventario { get; set; }
        public int idcliente { get; set; }
        public string nombreinventario { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual ICollection<reciboEntrada> reciboEntradas { get; set; }
        public virtual ICollection<ordenTrabajo> ordenTrabajoes { get; set; }
        public virtual ICollection<reciboSalida> reciboSalidas { get; set; }
    }
}
