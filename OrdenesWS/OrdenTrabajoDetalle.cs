//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrdenesWS
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrdenTrabajoDetalle
    {
        public int IdOrdenTrabajo { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public int Id { get; set; }
        public Nullable<int> IdArticulo { get; set; }
    
        public virtual Articulo Articulo { get; set; }
        public virtual OrdenTrabajo OrdenTrabajo { get; set; }
    }
}
