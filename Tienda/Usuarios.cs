//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tienda
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuarios()
        {
            this.HistorialAcceso = new HashSet<HistorialAcceso>();
        }
    
        public int id { get; set; }
        public Nullable<int> id_cliente { get; set; }
        public string username { get; set; }
        public string password_hash { get; set; }
        public string email { get; set; }
        public Nullable<int> id_rol { get; set; }
        public string estado { get; set; }
        public Nullable<System.DateTime> fecha_registro { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistorialAcceso> HistorialAcceso { get; set; }
        public virtual Roles Roles { get; set; }
    }
}
