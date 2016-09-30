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
    
    public partial class reciboEntrada
    {
        public reciboEntrada()
        {
            this.entradaTarima = new HashSet<entradaTarima>();
            this.reciboentradasacos = new HashSet<reciboentradasacos>();
        }
    
        public int idreciboentrada { get; set; }
        public int idinventario { get; set; }
        public System.DateTime fecha { get; set; }
        public string calidad { get; set; }
        public Nullable<int> cantidadsacos { get; set; }
        public string cliente { get; set; }
        public Nullable<double> pesototalsacos { get; set; }
        public string contrato { get; set; }
        public string guia { get; set; }
        public string placa { get; set; }
        public Nullable<int> ubicacion { get; set; }
        public Nullable<double> pesotarimasvacias { get; set; }
        public Nullable<double> pesobruto { get; set; }
        public Nullable<double> pesoneto { get; set; }
        public string observaciones { get; set; }
        public Nullable<double> pesototaltarimas { get; set; }
    
        public virtual ICollection<entradaTarima> entradaTarima { get; set; }
        public virtual inventario inventario { get; set; }
        public virtual ICollection<reciboentradasacos> reciboentradasacos { get; set; }
    }
}
