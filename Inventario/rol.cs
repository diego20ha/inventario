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
    
    public partial class rol
    {
        public rol()
        {
            this.usuarios = new HashSet<usuario>();
        }
    
        public int idrol { get; set; }
        public string nombre { get; set; }
    
        public virtual ICollection<usuario> usuarios { get; set; }
    }
}
