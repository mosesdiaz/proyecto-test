//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proyecto_test
{
    using System;
    using System.Collections.Generic;
    
    public partial class tipo_ingreso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tipo_ingreso()
        {
            this.empleado_ingreso = new HashSet<empleado_ingreso>();
        }
    
        public int id_ingreso { get; set; }
        public string nombre { get; set; }
        public Nullable<bool> estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<empleado_ingreso> empleado_ingreso { get; set; }
    }
}
