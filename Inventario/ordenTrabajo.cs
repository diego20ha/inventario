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
    
    public partial class ordenTrabajo
    {
        public ordenTrabajo()
        {
            this.ordenOrigens = new HashSet<ordenOrigen>();
            this.ordenResultadoes = new HashSet<ordenResultado>();
        }
    
        public int idordentrabajo { get; set; }
        public int idinventario { get; set; }
        public string cliente { get; set; }
        public System.DateTime fecha { get; set; }
        public Nullable<int> cantidadsacos { get; set; }
        public Nullable<double> pesototal { get; set; }
        public string observaciones { get; set; }
    
        public virtual inventario inventario { get; set; }
        public virtual ICollection<ordenOrigen> ordenOrigens { get; set; }
        public virtual ICollection<ordenResultado> ordenResultadoes { get; set; }
    }
}
